Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Configuration
Imports System.Web.Configuration
Partial Class ImporJP
    Inherits System.Web.UI.Page
    Dim nTotal As Double = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myContext As HttpContext = HttpContext.Current
        If Session("urlimport") = "" Then
            Session("urlimport") = Request.RawUrl
        End If
        myContext.RewritePath(Session("urlimport"))

        If Not Page.IsPostBack Then
            'With DDLGUGUS
            '    .DataSource = MasterLib.SetDataSourceGugusSDM
            '    .DataTextField = "vc_n_gugus"
            '    .DataValueField = "vc_k_gugus"
            '    .DataBind()
            'End With
            Me.lblinfo.Text = "NOTE : Transfer data ke SDM tidak boleh lebih dari tanggal : " & MasterLib.BatasTgl & " setiap bulannya"
            Me.lblnamakel.Text = Me.lblnamakel.Text + "  (" + MasterLib.ShowData("vc_kd_kel", "vc_nama_kel", "sdm_kelompok", Request.QueryString("pKode"), "") + ")"
        End If
        Me.TxtBulan.Text = Month(MasterLib.GetCurrentDate)
        Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)

    End Sub
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Try
            Me.TxtCatatan.Visible = True
            Dim nTgl As Integer = MasterLib.BatasTgl
            If Day(MasterLib.GetCurrentDate) > nTgl Then
                PESAN("Import Data tidak diperbolehkan melebihi tgl..." & nTgl)
                Exit Sub
            End If

            If FileUpload1.HasFile Then
                Dim FileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
                Dim Extension As String = Path.GetExtension(FileUpload1.PostedFile.FileName)
                Dim FolderPath As String = ConfigurationManager.AppSettings("FolderPath")

                Dim FilePath As String = Server.MapPath(FolderPath + FileName)
                FileUpload1.SaveAs(FilePath)
                Import_To_Grid(FilePath, Extension, 1)
                cekDataPraImport()
            Else
                PESAN("File yang mau diupload tidak ada!...silahkan browse file yang mau diupload")
            End If
        Catch ex As Exception
            PESAN("File tidak bisa diimport, silahkan cek filenya (Hanya untuk file excell (xls atau xlsx) saja")
        End Try
    End Sub
    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Private Sub Import_To_Grid(ByVal FilePath As String, ByVal Extension As String, ByVal isHDR As String)
        Dim conStr As String = ""
        Select Case Extension
            Case ".xls"
                'Excel 97-03 
                conStr = ConfigurationManager.ConnectionStrings("Excel03ConString").ConnectionString
                Exit Select
            Case ".xlsx"
                'Excel 07 
                conStr = ConfigurationManager.ConnectionStrings("Excel07ConString").ConnectionString
                Exit Select
        End Select
        conStr = String.Format(conStr, FilePath, isHDR)

        Dim connExcel As New OleDbConnection(conStr)
        Dim cmdExcel As New OleDbCommand()
        Dim oda As New OleDbDataAdapter()
        Dim dt As New DataTable()

        cmdExcel.Connection = connExcel

        'Get the name of First Sheet 
        connExcel.Open()
        Dim dtExcelSchema As DataTable
        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim SheetName As String = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
        connExcel.Close()

        'Read Data from First Sheet 
        connExcel.Open()
        cmdExcel.CommandText = "SELECT * From [" & SheetName & "]"
        oda.SelectCommand = cmdExcel
        oda.Fill(dt)
        connExcel.Close()

        'Bind Data to GridView 

        GridView1.Caption = Path.GetFileName(FilePath)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
        Dim FolderPath As String = ConfigurationManager.AppSettings("FolderPath")
        Dim FileName As String = GridView1.Caption
        Dim Extension As String = Path.GetExtension(FileName)
        Dim FilePath As String = Server.MapPath(FolderPath + FileName)

        Import_To_Grid(FilePath, Extension, 1)
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim i As Integer = 0
        'Dim cNik As String = ""
        'Dim nRupiah As Double = 0

        'For i = 0 To GridView1.Rows.Count - 1
        '    cNik = Me.GridView1.Rows(i).Cells(0).Text
        '    nRupiah = Me.GridView1.Rows(i).Cells(2).Text
        'Next

        'System.Threading.Thread.Sleep(5000)
        'PESAN("Proses selesai...")
        If Me.TxtCatatan.Text <> "" Then
            PESAN("Masih ada data Missing!, Silahkan data diperbaiki dulu...")
            Exit Sub
        End If
        If GridView1.Rows.Count > 0 Then
            If simpanData() = True Then
                PESAN("Data berhasil ditransfer ke SDM")
            End If
        Else
            PESAN("Tidak ada data yang bisa ditransfer ke SDM!...")
        End If
    End Sub

    Function simpanData() As Boolean
        Dim strsql As String = ""
        simpanData = False
        Dim lFound As Boolean = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim command2 As SqlCommand = New SqlCommand()
        Dim i As Integer = 0
        Dim cNik As String = ""
        Dim nRupiah As Double = 0

        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        command2.Connection = connection


        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans

        Me.TxtCatatan.Text = ""

        Try

            'HAPUS SEMUA DATA YG SUDAH MASUK KLU MAU UPDATE/DIEDIT
            strsql = "DELETE FROM sdm_temp " & _
                     "where in_bulan = " & Me.TxtBulan.Text & " and in_tahun = " & Me.TxtTahun.Text & " AND vc_kd_kel = '" & Request.QueryString("pKode") & "' "
            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()

            For i = 0 To GridView1.Rows.Count - 1
                cNik = Me.GridView1.Rows(i).Cells(0).Text
                'If MasterLib.lGetNik(cNik, command) = True Then
                nRupiah = Convert.ToDouble(Me.GridView1.Rows(i).Cells(2).Text)
                'If MasterLib.lCekNikJP2(cNik, Request.QueryString("pKode"), Me.TxtBulan.Text, Me.TxtTahun.Text, command) = True Then
                'lFound = True
                'update
                'strsql = "update sdm_temp set " & _
                '            " dc_rupiah= " & (nRupiah) & " " & _
                '            ", dt_tgl_transaksi = '" & MasterLib.GetCurrentDate & "' " & _
                '            ", vc_user = '" & Session("ssUserName") & "' " & _
                '            ", vc_kd_gugus_sdm = '" & Session("sskodegugus") & "' " & _
                '            "where vc_nik = '" & cNik & "' and vc_kd_kel = '" & Request.QueryString("pKode") & "' and in_bulan = " & Me.TxtBulan.Text & " and in_tahun = " & Me.TxtTahun.Text & " "

                'Else

                'masukkan data baru
                strsql = "insert into sdm_temp(vc_nik, dc_rupiah, in_bulan, in_tahun, dt_tgl_transaksi, vc_kd_kel, vc_user, vc_kd_gugus_sdm) " & _
                                             "values " & _
                                             "('" & UCase(cNik) & "', " & nRupiah & ", " & Me.TxtBulan.Text & ", " & Me.TxtTahun.Text & ", '" & MasterLib.GetCurrentDate & "', '" & Request.QueryString("pKode") & "', '" & Session("ssUserName") & "', '" & Session("sskodegugus") & "')"
                'End If
                command.CommandText = strsql
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                'Else
                'If Len(cNik) = 4 Then
                'Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + "<li>"
                'End If
                'End If
            Next
            simpanData = True
            MyTrans.Commit()
        Catch ex As Exception
            simpanData = False
            MyTrans.Rollback()
        End Try


    End Function

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        'If e.Row.RowType = DataControlRowType.DataRow Then

        '    nTotal += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "column2"))

        'ElseIf e.Row.RowType = DataControlRowType.Footer Then
        '    e.Row.Cells(0).Text = "TOTAL :"

        '    e.Row.Cells(2).Text = Format(nTotal.ToString, "Standard")

        '    e.Row.Cells(2).HorizontalAlign = HorizontalAlign.Right
        '    e.Row.Font.Bold = True

        'End If

        Try

            'warna cursor
            Dim onmouseoverStyle As String = "this.style.backgroundColor='cyan'"

            Dim onmouseoutStyle As String = "this.style.backgroundColor='#@BackColor'"
            'Dim onmouseoutStyle As String = ""

            Dim rowBackColor As String = "this.style.backgroundColor='blue'"



            If e.Row.RowType = DataControlRowType.DataRow Then
                'tambahan jika row diklik maka data sudah terpilih (tanpa harus mengklik tombol select
                e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
                e.Row.ToolTip = "Silahkan Klik baris data yang akan ditampilkan..."
                e.Row.Attributes("style") = "cursor:pointer"
                '-------------------------------------------------------
                onmouseoutStyle = "this.style.backgroundColor='blue'"

                'rowBackColor = GridView1.RowStyle.BackColor.Name.Remove(0, 2)
                'e.Row.Attributes.Add("onmouseover", onmouseoverStyle)

                'e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))



            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
    Private Sub cekDataPraImport()
        Dim nRupiah As Integer = 0
        Dim nTotal As Integer = 0
        Dim i As Integer = 0
        Dim cNik As String = ""
        Me.TxtCatatan.Text = ""
        Me.TxtTotal.Text = 0
        For i = 0 To GridView1.Rows.Count - 1
            cNik = Trim(Me.GridView1.Rows(i).Cells(0).Text)
            If MasterLib.lGetNikNonCom(cNik) = False Then
                If Len(cNik) = 4 Then
                    Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + " -> Nik tidak ditemukan" + "<li>"
                End If
                'JIKA NIK KOSONG TAPI NAMA ADA
                'If Not IsNumeric(Me.GridView1.Rows(i).Cells(0).Text) And Len(Trim(Me.GridView1.Rows(i).Cells(0).Text)) >= 0 Then
                'End If
                'MsgBox(cNik & "  " & Len(cNik))
                If Len(cNik) > 4 And IsNumeric(cNik) Then
                    Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + " -> NIK 5 digit(Harusnya 4 digit..)" + "<li>"
                End If

                If (Len(cNik) < 4 Or Not IsNumeric(cNik)) And Me.GridView1.Rows(i).Cells(1).Text <> "" Then
                    Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + " -> NIK kosong" + "<li>"
                End If
            Else    'JIKA KETEMU
                Try
                    If Me.GridView1.Rows(i).Cells(2).Text <= 0 Then
                        Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + " -> Rupiah 0 " + "<li>"
                    End If
                Catch ex As Exception
                    Me.TxtCatatan.Text = Me.TxtCatatan.Text + Trim(Me.GridView1.Rows(i).Cells(0).Text) + " : " + Trim(Me.GridView1.Rows(i).Cells(1).Text) + "<li>"
                End Try
            End If
            Try
                nRupiah = Me.GridView1.Rows(i).Cells(2).Text
            Catch ex As Exception
                nRupiah = 0
            End Try
            nTotal = nTotal + nRupiah
        Next
        Me.TxtTotal.Text = Format(nTotal, "Standard")
    End Sub

End Class
