Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class Pilihan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("ssUserName") = "" Then
            Session.Clear()
            Response.Redirect("~/default.aspx")
        End If

        If Not Page.IsPostBack Then
            isigrid()
            GridView1.DataSourceID = SdsData.ID
            If GridView1.Rows.Count <= 0 Then
                PESAN("Password Anda tidak mempunyai otorisasi untuk menjalankan modul JP...")
                'Session.Clear()
                'Response.Redirect("~/default.aspx")
            End If
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

            'JIKA TIDAK DIATUR MELLALU USER TOOL, AKTIFKAN
            'strsql = "SELECT vc_kd_kel, vc_nama_kel from sdm_kelompok " & _
            '         "where substring(vc_kd_kel,1,1)='2' " & _
            '         "order by vc_kd_kel"


            Dim lAdaUser As Boolean = False
            Dim cIdModul As String = "1302"
            Dim cIDApps As String = "0101"

            'DATA MUNCUL HANYA SESUAI DENGAN OTORITAS PASSWORD YG DIATUR MELALU USERTOOL
            strsql = "SELECT SDM_KELOMPOK.VC_KD_KEL, VC_NAMA_KEL, SDM_KELOMPOK.VC_KD_MENU " & _
                     "FROM  dbo.pde_user_apps INNER JOIN " & _
                     "dbo.pde_user_apps_akses ON dbo.pde_user_apps.vc_id = dbo.pde_user_apps_akses.vc_id_parent INNER JOIN SDM_KELOMPOK " & _
                     "ON SDM_KELOMPOK.VC_KD_MENU = dbo.pde_user_apps_akses.vc_codemenu " & _
                     "where dbo.pde_user_apps.vc_owner='" & cIdModul & "' and dbo.pde_user_apps.vc_userid = '" & Session("cIdUser") & "' " & _
                     "and dbo.pde_user_apps.vc_apps_code = '" & cIDApps & "' and dbo.pde_user_apps_akses.bt_visible = 1 " & _
                     "ORDER BY SDM_KELOMPOK.VC_KD_KEL "

            SdsData.SelectCommand = strsql
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        Try

            'warna cursor
            'warna cursor
            Dim onmouseoverStyle As String = "this.style.backgroundColor='cyan'"

            Dim onmouseoutStyle As String = "this.style.backgroundColor='#@BackColor'"
            'Dim onmouseoutStyle As String = ""

            'Dim rowBackColor As String = String.Empty
            Dim rowBackColor As String = "this.style.backgroundColor='blue'"



            If e.Row.RowType = DataControlRowType.DataRow Then
                e.Row.Attributes.Add("onmouseover", "this.style.cursor='pointer'")

                rowBackColor = GridView1.RowStyle.BackColor.Name.Remove(0, 2)
                e.Row.Attributes.Add("onmouseover", onmouseoverStyle)

                e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))
                'tambahan jika row diklik maka data sudah terpilih (tanpa harus mengklik tombol select
                e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
                e.Row.ToolTip = "Silahkan Klik baris data yang akan dipilih..."
                e.Row.Attributes("style") = "cursor:pointer"
                '-------------------------------------------------------
                Dim ckode As String = DirectCast(DataBinder.Eval(e.Row.DataItem, "vc_kd_kel"), String)
                Select Case ckode
                    Case Request.QueryString("pKode")
                        e.Row.BackColor = Drawing.Color.Blue
                        e.Row.ForeColor = Drawing.Color.Yellow
                        onmouseoutStyle = "this.style.backgroundColor='blue'"
                        e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))
                End Select

                'e.Row.BackColor = Drawing.Color.Blue
                'e.Row.ForeColor = Drawing.Color.Yellow
                'onmouseoutStyle = "this.style.backgroundColor='blue'"
                'e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))

                'onmouseoutStyle = "this.style.backgroundColor='blue'"

                'rowBackColor = GridView1.RowStyle.BackColor.Name.Remove(0, 2)
                'e.Row.Attributes.Add("onmouseover", onmouseoverStyle)

                'e.Row.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", rowBackColor))



            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim cKode As String = CType(GridView1.SelectedRow.FindControl("lblkode"), Label).Text
        'Response.Redirect("~/pilihan.aspx?" + "pKode=" + cKode)
        'Response.Redirect("~/entrijpmanual.aspx?" + "pKode=" + cKode)
        'MsgBox(Session("ssusername"))
        'Session("sshakaksespilih") = "OK"
        Session("kodejp") = cKode
        Response.Redirect("~/Entri-Edit-JP-Manual.aspx?status=" + "1" + "&pKode=" + cKode)
    End Sub

    Protected Sub cmdkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Session.Clear()
        Response.Redirect("~/default.aspx")
    End Sub

    Private Sub SetMenuAccess()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim strsql As String = ""


        Dim lAdaUser As Boolean = False
        Dim cIdModul As String = "1302"
        Dim cIDApps As String = "0101"

        strsql = "SELECT dbo.pde_user_apps.vc_id, dbo.pde_user_apps.vc_owner, dbo.pde_user_apps.vc_apps_code, dbo.pde_user_apps.vc_userid, dbo.pde_user_apps.in_userlevel, " & _
                 "dbo.pde_user_apps_akses.vc_id_parent, dbo.pde_user_apps_akses.vc_codemenu, dbo.pde_user_apps_akses.bt_enable, dbo.pde_user_apps_akses.bt_visible, " & _
                 "dbo.pde_user_apps_akses.bt_access " & _
                 "FROM  dbo.pde_user_apps INNER JOIN " & _
                 "dbo.pde_user_apps_akses ON dbo.pde_user_apps.vc_id = dbo.pde_user_apps_akses.vc_id_parent " & _
                 "where dbo.pde_user_apps.vc_owner='" & cIdModul & "' and dbo.pde_user_apps.vc_userid = '" & Session("cIdUser") & "' " & _
                 "and dbo.pde_user_apps.vc_apps_code = '" & cIDApps & "' and dbo.pde_user_apps_akses.bt_visible = 1 "


        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim objdatareader As SqlClient.SqlDataReader
        objdatareader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Dim i As Integer = 0
        While objdatareader.Read()
            lAdaUser = True

            'If objdatareader("VC_codemenu").ToString = "050101000000" Then
            '    Me.mnu050101000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Anamnese
            'If objdatareader("VC_codemenu").ToString = "050102000000" Then
            '    Me.mnu050102000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Rekam Medis
            'If objdatareader("VC_codemenu").ToString = "050103000000" Then
            '    Me.mnu050103000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Radiologi
            'If objdatareader("VC_codemenu").ToString = "050104000000" Then
            '    Me.mnu050104000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Laborat
            'If objdatareader("VC_codemenu").ToString = "050105000000" Then
            '    Me.mnu050105000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Epres
            'If objdatareader("VC_codemenu").ToString = "050106000000" Then
            '    Me.mnu050106000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data Catatan
            'If objdatareader("VC_codemenu").ToString = "050107000000" Then
            '    Me.mnu050107000000.Visible = objdatareader("bt_visible")
            'End If

            ''tombol data IMage
            'If objdatareader("VC_codemenu").ToString = "050108000000" Then
            '    Me.mnu050108000000.Visible = objdatareader("bt_visible")
            'End If
        End While
        objdatareader.Close()


        'If Request.QueryString("pNoRegj") = "ViewRM" Then
        '    mnu050102000000.Visible = False
        '    mnu050101000000.Visible = False
        '    Me.cmdKunjungan.Visible = True
        'End If

        If lAdaUser = False Then
            Dim someScript As String = ""
            someScript = "<script language='javascript'>alert('Tidak ada menu yang bisa anda akses!...');</script>"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
            Response.Redirect("default.aspx")
        End If
    End Sub

End Class
