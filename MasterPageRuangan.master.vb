Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class MasterPageRuangan

    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Sub mnuHome_click(ByVal sender As Object, ByVal e As EventArgs)
        'Response.Redirect("~/menu.aspx")
        Dim baseUrl As String = Request.Url.GetLeftPart(UriPartial.Authority)
        Response.Redirect(baseUrl + "/menu")
    End Sub
    Sub HtmlAnchor_Click(ByVal sender As Object, ByVal e As EventArgs)
        'MsgBox("Buka laporan ")
        'Exit Sub
        'Response.Redirect("~/FrmBdaftarpaguyuban.aspx")
    End Sub
    Sub mnu010101010000_click(ByVal sender As Object, ByVal e As EventArgs)
        GetAccess("010101010000")
        'Response.Redirect("~/Searching.aspx")
    End Sub
    Sub mnu010101020000_click(ByVal sender As Object, ByVal e As EventArgs)
        'Response.Redirect("~/Frmbkamar.aspx")
        GetAccess("010101020000")
    End Sub

    Sub mnu010102010000_click(ByVal sender As Object, ByVal e As EventArgs)
        'Response.Redirect("~/Frmbtarget.aspx")
        GetAccess("010102010000")
    End Sub

    Sub mnu010102020000_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/Form_Surveilans_hasil.aspx")
        'GetAccess("010102020000")
    End Sub
 
    Sub mnu010102030000_click(ByVal sender As Object, ByVal e As EventArgs)
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormSearchingInputSurveilans.aspx")
        'GetAccess("010102030000")
    End Sub

    Sub mnu010103010000_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("menu_laporan.aspx")
        'GetAccess("010103010000")
    End Sub

    Sub mnu010103020000_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("Triwulan.aspx")
        'GetAccess("010103020000")
    End Sub

    Sub mnu010103040000_click(ByVal sender As Object, ByVal e As EventArgs)
        Session("urlback") = Request.Url.ToString
        Response.Redirect("FormSearchRekapSurveilans.aspx")
        'GetAccess("010103040000")
    End Sub
    Sub mnu010103050000_click(ByVal sender As Object, ByVal e As EventArgs)
        Session("urlback") = Request.Url.ToString
        Response.Redirect("FormSearchLaporanInfeksiSummary.aspx")
        'GetAccess("010103050000")
    End Sub

    Sub mnu010104010000_click(ByVal sender As Object, ByVal e As EventArgs)
        'edit password
        GetAccess("010104010000")
    End Sub
    Sub mnu0402_click(ByVal sender As Object, ByVal e As EventArgs)
        'GETAKSES("mnu0402")
    End Sub

    Sub mnu0403_click(ByVal sender As Object, ByVal e As EventArgs)
        'GETAKSES("mnu0403")
    End Sub

    Sub mnu0404_click(ByVal sender As Object, ByVal e As EventArgs)
        'Response.Redirect("~/frmpilihpaguyuban.aspx")
    End Sub

    Sub mnu0500_click(ByVal sender As Object, ByVal e As EventArgs)

        Session.Clear()

        Response.Redirect("~/default.aspx")
    End Sub

    Sub mnu0600_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(Request.RawUrl)
    End Sub


    Private Sub GetAccess(ByVal ckodemenu As String)
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim strsql As String = ""


        Dim lAdaUser As Boolean = False
        Dim cIdModul As String = "6302"
        Dim cIDApps As String = "0101"

        strsql = "SELECT     dbo.pde_user_apps.vc_id, dbo.pde_user_apps.vc_owner, dbo.pde_user_apps.vc_apps_code, dbo.pde_user_apps.vc_userid, dbo.pde_user_apps.in_userlevel, " & _
                 "dbo.pde_user_apps_akses.vc_id_parent, dbo.pde_user_apps_akses.vc_codemenu, dbo.pde_user_apps_akses.bt_enable, dbo.pde_user_apps_akses.bt_visible, " & _
                 "dbo.pde_user_apps_akses.bt_access " & _
                 "FROM  dbo.pde_user_apps INNER JOIN " & _
                 "dbo.pde_user_apps_akses ON dbo.pde_user_apps.vc_id = dbo.pde_user_apps_akses.vc_id_parent " & _
                 "where dbo.pde_user_apps.vc_owner='" & cIdModul & "' and dbo.pde_user_apps.vc_userid = '" & Session("cIdUser") & "' " & _
                 "and dbo.pde_user_apps.vc_apps_code = '" & cIDApps & "' and dbo.pde_user_apps_akses.bt_visible = 1 " & _
                 "and pde_user_apps_akses.vc_codemenu = '" & ckodemenu & "' "


        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim objdatareader As SqlClient.SqlDataReader
        objdatareader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Dim i As Integer = 0
        While objdatareader.Read()
            lAdaUser = True

            If objdatareader("VC_codemenu").ToString = "010101010000" Then
                'informasi pasien
                Response.Redirect("~/Searching.aspx")
            End If

            'info pasien inap per ruang
            If objdatareader("VC_codemenu").ToString = "010101020000" Then
                Response.Redirect("~/frmbkamar.aspx")
            End If

            'Transaksi -> target surveilans
            If objdatareader("VC_codemenu").ToString = "010102010000" Then
                Response.Redirect("~/Frmbtarget.aspx")
            End If


            'Transaksi -> input surveilans hasil
            If objdatareader("VC_codemenu").ToString = "010102020000" Then
                Response.Redirect("~/Form_Surveilans_hasil.aspx")
            End If

            'Transaksi -> input surveilans_infeksi
            If objdatareader("VC_codemenu").ToString = "010102030000" Then
                Session("urlback") = Request.Url.ToString
                Response.Redirect("~/FormSearchingInputSurveilans.aspx")
            End If

            'LAPORAN -> BULANAN
            If objdatareader("VC_codemenu").ToString = "010103010000" Then
                Response.Redirect("menu_laporan.aspx")
            End If

            'LAPORAN -> TRI BULANAN
            If objdatareader("VC_codemenu").ToString = "010103020000" Then
                Response.Redirect("TRIWULAN.aspx")
            End If

            'LAPORAN -> TRI BULANAN
            If objdatareader("VC_codemenu").ToString = "010103020000" Then
                Response.Redirect("TRIWULAN.aspx")
            End If

            'LAPORAN -> OPERASI
            If objdatareader("VC_codemenu").ToString = "010103030000" Then
                Response.Redirect("laporan_operasi.aspx")
            End If

            ''LAPORAN -> Rekap Surveilans
            'If objdatareader("VC_codemenu").ToString = "010103040000" Then
            '    Response.Redirect("~/FormSearchRekapSurveilans.aspx")
            'End If
            ''LAPORAN ->  Summary Surveilans
            'If objdatareader("VC_codemenu").ToString = "010103050000" Then
            '    Response.Redirect("~/FormSearchLaporanInfeksiSummary.aspx")
            'End If

            'BANTUAN -> EDIT PASSWORD
            If objdatareader("VC_codemenu").ToString = "010104010000" Then
                Response.Redirect("FrmEditPassword.aspx")
            End If

        End While
        objdatareader.Close()

        If lAdaUser = False Then
            Dim someScript As String = ""
            someScript = "<script language='javascript'>alert('Anda tidak berhak mengakses menu ini!...');</script>"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
            'Response.Redirect("default.aspx")
        End If
    End Sub

End Class

