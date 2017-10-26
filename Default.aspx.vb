Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        Session.Clear()

        If MasterLib.CheckUser(Me.txtUserName.Text, Me.txtPwd.Text, "") Then
            Session("ssusername") = UCase(txtUserName.Text.ToString().Trim())
            Session("source") = "PPI"
            Session("cIdUser") = MasterLib.ShowData("vc_username", "vc_id", "pde_user", UCase(Me.txtUserName.Text), "")
            Response.Redirect("BERANDA.aspx")
        Else
            Me.txtUserName.Focus()
        End If


    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session.Clear()
        'Response.Redirect("~/default.aspx")
        'Session("ssotorisasipassword") = txtUserName.Text.ToString().Trim()
        'Session("sshakaksespilih") = "OK"
        'Response.Redirect("~/frmpilihpaguyuban.aspx")


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
