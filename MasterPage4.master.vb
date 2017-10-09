Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class MasterPage4
    Inherits System.Web.UI.MasterPage

    Dim cInfo As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("lapkodepaguyuban") = ""
        'Session("lapkodeanggota") = ""
        'Session("lapkodeputaran") = ""
        'Session("laptgldari") = ""
        'Session("laptglsampai") = ""
        'Session("lapkodekota") = ""
        'Session("lapkodemitra") = ""
        'Session("sshakakses") = ""
        'Session("ssusername") = "operator"
        'If Session("ssusername") = "" Then
        ' Response.Redirect("~/default.aspx")
        ' End If


        If Not Page.IsPostBack Then
            'Dim cStatus As String = Request.QueryString("status")


        End If


    End Sub
    Sub mnuhome_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim baseUrl As String = Request.Url.GetLeftPart(UriPartial.Authority)
        Response.Redirect(baseUrl + "/menu")
    End Sub

    Sub mnu0101_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("~/testingdata.aspx?status=" + "1")
        'Response.Redirect("Surat Masuk")
    End Sub

    Sub mnu0102_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("~/DaftarIP.aspx?status=" + "2")

    End Sub

    Sub mnu0103_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("~/frmmaintenaceData.aspx?status=" + "3")

    End Sub

    Sub mnu0100_click(ByVal sender As Object, ByVal e As EventArgs)

        Session.Clear()

        Response.Redirect("~/default.aspx")
    End Sub


    Sub mnu0200_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/Edit-Password.aspx")
    End Sub

    Sub mnu0300_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(Request.RawUrl)
    End Sub

End Class

