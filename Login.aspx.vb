Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration

Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        Session.Clear()

        'If MasterLib.CheckUser(Me.txtUserName.Text, Me.txtPwd.Text, "") Then
        '    Session("ssusername") = UCase(txtUserName.Text.ToString().Trim())
        '    Session("cIdUser") = MasterLib.ShowData("vc_username", "vc_id", "pde_user", UCase(Me.txtUserName.Text), "")
        '    Response.Redirect("BERANDA.aspx")
        'Else
        '    Me.txtUserName.Focus()
        'End If

        If Me.txtUserName.Text = "user" And Me.txtPwd.Text = "user" Then
            Session("source") = "USER"
            Session("ssusername") = UCase(txtUserName.Text.ToString().Trim())
            Response.Redirect("menu_laporan_ruangan.aspx")
        End If
    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session.Clear()
        Dim baseUrl As String = Request.Url.GetLeftPart(UriPartial.Authority)
        Response.Redirect(baseUrl + "/menu")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
