Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class EntriJPManual
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myContext As HttpContext = HttpContext.Current
        If Session("url") = "" Then
            Session("url") = Request.RawUrl
        End If
        myContext.RewritePath(Session("URL"))

        If Not Page.IsPostBack Then


            'With DDLGUGUS
            '    .DataSource = MasterLib.SetDataSourceGugusSDM
            '    .DataTextField = "vc_n_gugus"
            '    .DataValueField = "vc_k_gugus"
            '    .DataBind()
            'End With
            Me.lblinfo.Text = "NOTE : Transfer data ke SDM tidak boleh lebih dari tanggal : " & MasterLib.BatasTgl & " setiap bulannya"
            Me.TxtBulan.Text = Month(MasterLib.GetCurrentDate)
            Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)
            Session("sskodegugus") = MasterLib.ShowData("vc_kd_kel", "vc_kd_gugus", "sdm_kelompok", Request.QueryString("pKode"), "")


            If Me.chkData.Checked = True Then
                Me.GridView1.Visible = True
                'isigrid()
                'GridView1.DataSourceID = SdsData.ID
            Else
                Me.GridView1.Visible = False
            End If
            Me.Lblnamakel.Text = Me.Lblnamakel.Text + "  (" + MasterLib.ShowData("vc_kd_kel", "vc_nama_kel", "sdm_kelompok", Request.QueryString("pKode"), "") + ")"
        End If

        Dim nTgl As Integer = MasterLib.BatasTgl
        If Day(MasterLib.GetCurrentDate) > nTgl Then
            'PESAN("Import Data tidak diperbolehkan melebihi tgl..." & nTgl)
            Me.GridView1.Enabled = False
            Exit Sub
        Else
            Me.GridView1.Enabled = True
        End If

    End Sub

    Protected Sub cmdInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdInput.Click
        Dim nTgl As Integer = MasterLib.BatasTgl
        If Day(MasterLib.GetCurrentDate) > nTgl Then
            PESAN("Entri Data tidak diperbolehkan melebihi tgl..." & nTgl)
            Exit Sub
        End If

        Select Case Me.cmdInput.Text
            Case "Input"
                enableds(True)
                Me.TxtNik.Focus()
                Me.TxtNik.Text = ""
                inputdata()
                Me.cmdInput.Text = "Simpan"
            Case "Simpan"
                Try
                    If Me.TxtNik.Text = "" Then
                        PESAN("NIK harus diisi!...")
                        Me.TxtNik.Focus()
                        Exit Sub
                    End If

                    If Me.TxtNama.Text = "" Then
                        PESAN("Identitas tidak lengkap!...")
                        Exit Sub
                    End If

                    If Me.TxtRupiah.Text = "" Then
                        Me.TxtRupiah.Text = 0
                    End If

                    If Me.TxtRupiah.Text = 0 Then
                        PESAN("Rupiah harus diisi!...")
                        Exit Sub
                    End If

                    If Me.TxtNik.Text <> "" And Me.TxtNama.Text <> "" And Me.TxtRupiah.Text > 0 Then
                        If simpanData() Then
                            PESAN("Data berhasil disimpan!...")
                            If Me.chkData.Checked = True Then
                                Me.GridView1.Visible = True
                                isigrid()
                                GridView1.DataSourceID = SdsData.ID
                            Else
                                Me.GridView1.Visible = False
                            End If
                            Me.cmdInput.Text = "Input"
                            enableds(False)
                        Else
                            PESAN("Data Gagal disimpan!...")
                        End If
                    End If
                Catch ex As Exception
                    PESAN("Data Gagal disimpan!...")
                End Try

        End Select

    End Sub

    Private Sub inputdata()
        Me.TxtNama.Text = ""
        Me.TxtRupiah.Text = ""
    End Sub
    Private Sub enableds(ByVal lstatus As Boolean)
        Me.TxtNik.Enabled = lstatus
        Me.TxtRupiah.Enabled = lstatus
    End Sub


    Protected Sub chkData_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkData.CheckedChanged

        If Me.chkData.Checked = True Then
            Me.GridView1.Visible = True
            'isigrid()
            'GridView1.DataSourceID = SdsData.ID
        Else
            Me.GridView1.Visible = False
        End If
    End Sub

    Private Sub isigrid()
        Dim strsql As String = ""

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        Try

            strsql = "SELECT SDM_Temp.in_bulan, SDM_Temp.in_tahun, SDM_Temp.vc_nik, SDMKaryawan.vc_nama_kry, SDM_Temp.dc_rupiah, pubgugussdm.vc_n_gugus " & _
                     "FROM SDM_Temp inner join SDMKaryawan ON SDM_Temp.vc_nik = SDMKaryawan.vc_nik inner join " & _
                     "pubgugussdm on pubgugussdm.vc_k_gugus = sdmkaryawan.vc_kd_pubgugussdm " & _
                     "where in_bulan = " & Me.TxtBulan.Text & " and in_tahun = " & Me.TxtTahun.Text & " " & _
                     "and vc_kd_kel = '" & Request.QueryString("pKode") & "' order by vc_nama_kry "

            SdsData.SelectCommand = strsql
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub Cmdbatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmdbatal.Click
        Select Case Me.Cmdbatal.Text
            Case "Batal"
                Me.TxtNik.Text = ""
                inputdata()
                Me.cmdInput.Text = "Input"
                enableds(False)
            Case "Edit"
                Me.cmdInput.Text = "Simpan"
                enableds(True)
                Me.Cmdbatal.Text = "Batal"
        End Select
    End Sub

    Protected Sub TxtNik_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNik.TextChanged
        If Len(Me.TxtNik.Text) = 4 Then
            If GetData() = False Then
                PESAN("Nik tidak ditemukan!...")
                Me.TxtNik.Text = ""
                Me.TxtNama.Text = ""
                Me.TxtRupiah.Text = ""
            End If
        Else
            PESAN("Panjang Nik harus 4 digit!...")
            Me.TxtNik.Text = ""
            Me.TxtNama.Text = ""
            Me.TxtRupiah.Text = ""
        End If
    End Sub

    Function GetData() As Boolean
        Dim strsql As String = ""
        Dim cKodeGugus As String = ""

        GetData = False

        'LANGKAH 1 CEK DATA KARYAWAN
        strsql = "SELECT SDM_Temp.in_bulan, SDM_Temp.in_tahun, SDM_Temp.vc_nik, SDMKaryawan.vc_nama_kry, isnull(SDM_Temp.dc_rupiah,0) as dc_rupiah, SDM_Temp.vc_kd_gugus_sdm " & _
                     "FROM SDMKaryawan left join SDM_Temp on SDM_Temp.vc_nik = SDMKaryawan.vc_nik " & _
                     "where sdmkaryawan.vc_nik = '" & Me.TxtNik.Text & "' and sdmkaryawan.bt_aktif = 1 "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            GetData = True
            Me.TxtNama.Text = dr("vc_nama_kry")
            'Me.TxtRupiah.Text = Double.Parse(dr("dc_rupiah"))
            Exit While
        End While
        dr.Close()

        'LANGKAH 2 CEK DATA APAKAH SUDAH PERNAH ENTRI JP
        strsql = "SELECT SDM_Temp.in_bulan, SDM_Temp.in_tahun, SDM_Temp.vc_nik, SDMKaryawan.vc_nama_kry, isnull(SDM_Temp.dc_rupiah,0) as dc_rupiah, SDM_Temp.vc_kd_gugus_sdm " & _
                     "FROM SDMKaryawan left join SDM_Temp on SDM_Temp.vc_nik = SDMKaryawan.vc_nik " & _
                     "where sdmkaryawan.vc_nik = '" & Me.TxtNik.Text & "' AND vc_kd_kel = '" & Request.QueryString("pKode") & "' AND SDM_Temp.in_bulan = " & Me.TxtBulan.Text & " AND SDM_Temp.in_tahun = " & Me.TxtTahun.Text & ""

        Dim sqlCommand1 As New SqlClient.SqlCommand(strsql)
        sqlCommand1.Connection = connection
        connection.Open()

        Dim dr1 As SqlClient.SqlDataReader
        dr1 = sqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

        While dr1.Read
            GetData = True
            'Me.TxtNama.Text = dr("vc_nama_kry")
            Me.TxtRupiah.Text = Double.Parse(dr1("dc_rupiah"))
            Exit While
        End While
        dr1.Close()

    End Function


    Function simpanData() As Boolean
        'Dim MyTrans As SqlTransaction
        Dim strsql As String = ""

        simpanData = False
        Dim lFound As Boolean = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()


        Dim cNik As String = ""
        Dim nRupiah As Double = 0
        If MasterLib.lCekNikJP(Me.TxtNik.Text, Request.QueryString("pKode"), Me.TxtBulan.Text, Me.TxtTahun.Text) = True Then
            lFound = True
        End If

        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans

        Try

            If Len(Me.TxtNik.Text) = 4 Then
                cNik = Me.TxtNik.Text
                nRupiah = Me.TxtRupiah.Text

                If lFound Then
                    'update
                    strsql = "update sdm_temp set " & _
                                    " dc_rupiah= " & (nRupiah) & " " & _
                                    ", dt_tgl_transaksi = '" & MasterLib.GetCurrentDate & "' " & _
                                    ", vc_user = '" & Session("ssUserName") & "' " & _
                                    "where vc_nik = '" & cNik & "' and vc_kd_kel = '" & Request.QueryString("pKode") & "' and in_bulan = " & Me.TxtBulan.Text & " and in_tahun = " & Me.TxtTahun.Text & " AND vc_kd_gugus_sdm = '" & Session("sskodegugus") & "' "
                Else
                    strsql = "insert into sdm_temp(vc_nik, dc_rupiah, in_bulan, in_tahun, dt_tgl_transaksi, vc_kd_kel, vc_user, vc_kd_gugus_sdm) " & _
                                                 "values " & _
                                                 "('" & UCase(cNik) & "', " & nRupiah & ", " & Me.TxtBulan.Text & ", " & Me.TxtTahun.Text & ", '" & MasterLib.GetCurrentDate & "', '" & Request.QueryString("pKode") & "', '" & Session("ssUserName") & "', '" & Session("sskodegugus") & "')"
                End If

                command.CommandText = strsql
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                MyTrans.Commit()
            End If

            simpanData = True
        Catch ex As Exception
            simpanData = False
            MyTrans.Rollback()
        End Try


    End Function
    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub GridView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Init
        Dim Param As Parameter
        Dim strsql As String = ""

        Dim ntahun As Integer = Year(MasterLib.GetCurrentDate)
        Dim nBulan As Integer = Month(MasterLib.GetCurrentDate)
        ' pegaturan untuk grid pasien

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        strsql = "SELECT SDM_Temp.in_bulan, SDM_Temp.in_tahun, SDM_Temp.vc_nik, SDMKaryawan.vc_nama_kry, SDM_Temp.dc_rupiah, pubgugussdm.vc_n_gugus " & _
                 "FROM SDM_Temp inner join SDMKaryawan ON SDM_Temp.vc_nik = SDMKaryawan.vc_nik inner join " & _
                 "pubgugussdm on pubgugussdm.vc_k_gugus = sdmkaryawan.vc_kd_pubgugussdm " & _
                 "where vc_kd_kel ='" & Request.QueryString("pKode") & "' and in_bulan = " & nBulan & " order by vc_nama_kry "

        SdsData.SelectCommand = strsql

        SdsData.DeleteCommand = "DELETE FROM sdm_temp " _
            & "WHERE vc_nik= @vcnik and in_bulan=@inbulan and in_tahun=@intahun and vc_kd_kel=@vckdkel"

        ' parameter delete
        Param = New Parameter("vcnik", TypeCode.String)
        SdsData.DeleteParameters.Add(Param)

        Param = New Parameter("inbulan", TypeCode.String)
        SdsData.DeleteParameters.Add(Param)

        Param = New Parameter("inTahun", TypeCode.String)
        SdsData.DeleteParameters.Add(Param)

        Param = New Parameter("vckdkel", TypeCode.String)
        SdsData.DeleteParameters.Add(Param)

        GridView1.DataSourceID = SdsData.ID
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName.Equals("Update")) Then
            'Dim nText As String = ""
            'Dim tBox As TextBox
            'tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtkode"), TextBox)
            'SdsData.UpdateParameters("vckode").DefaultValue = tBox.Text
            'tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtnama"), TextBox)
            'SdsData.UpdateParameters("vcnamamitra").DefaultValue = tBox.Text
            'tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtalamat"), TextBox)
            'SdsData.UpdateParameters("vcalamat").DefaultValue = tBox.Text
            'tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtphone"), TextBox)
            'SdsData.UpdateParameters("vcphone").DefaultValue = tBox.Text
            'SdsData.Update()
        ElseIf (e.CommandName.Equals("Delete")) Then
            SdsData.DeleteParameters("vcnik").DefaultValue = e.CommandArgument
            SdsData.DeleteParameters("inBulan").DefaultValue = Me.TxtBulan.Text
            SdsData.DeleteParameters("inTahun").DefaultValue = Me.TxtTahun.Text
            SdsData.DeleteParameters("vckdkel").DefaultValue = Request.QueryString("pKode")
            SdsData.Delete()
        ElseIf (e.CommandName.Equals("Edit")) Then
            'PESAN(e.CommandArgument.ToString)
            Me.TxtNik.Text = e.CommandArgument
            GetData()
            Me.TxtNik.Enabled = True
            Me.TxtRupiah.Enabled = True
            Me.cmdInput.Text = "Simpan"
            Me.TxtNik.Focus()
        End If

    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        'Try

        '    'warna(cursor)
        '    Dim onmouseoverStyle As String = "this.style.backgroundColor='cyan'"

        '    Dim onmouseoutStyle As String = "this.style.backgroundColor='#@BackColor'"
        '    'Dim onmouseoutStyle As String = ""

        '    Dim rowBackColor As String = "this.style.backgroundColor='blue'"



        '    If e.Row.RowType = DataControlRowType.DataRow Then
        '        'tambahan jika row diklik maka data sudah terpilih (tanpa harus mengklik tombol select
        '        e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
        '        e.Row.ToolTip = "Silahkan Klik baris data yang akan diedit..."
        '        e.Row.Attributes("style") = "cursor:pointer"
        '        '-------------------------------------------------------
        '        'onmouseoutStyle = "this.style.backgroundColor='blue'"

        '        'rowBackColor = GridView1.RowStyle.BackColor.Name.Remove(0, 2)
        '        'e.Row.Attributes.Add("onmouseover", onmouseoverStyle)

        '        'e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))



        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
