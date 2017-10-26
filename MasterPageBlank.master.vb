
Partial Class MasterPageBlank
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Session("ssUserName") = "" Then
        '    Session.Clear()
        '    Response.Redirect("~/default.aspx")
        'End If

    End Sub

    Sub mnuhome_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("http://e-bethesda.or.id/menu")
        'Response.Redirect("Surat Masuk")
    End Sub

    Sub mnu0101_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("~/EntriJPManual.aspx?status=" + "1" + "&pKode=" + Request.QueryString("pKode"))
        'Response.Redirect("Entri-Edit-JP-Manual.aspx?status=" + "1" + "&pKode=" + Request.QueryString("pKode"))
        'Response.Redirect("~/FrmDataPasien.aspx?" + "pNoRM=" + "" + "&pNoRegj=" + "" + "&pKlinik=" + Me.ddlKlinikAktif.SelectedValue + "&pDokter=" + Me.ddldokter.SelectedValue)
        'Response.Redirect("Surat Masuk")
        'Response.Redirect("~/Frmbtarget.aspx")
    End Sub

    Sub mnu0102_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("Import-Data-Excell.aspx?status=" + "2" + "&pKode=" + Request.QueryString("pKode"))
        'Response.Redirect("~/Form_Surveilans_hasil.aspx")
    End Sub

    Sub mnu0103_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim someScript As String = ""
        'someScript = "<script language='javascript'>alert('Anda Tidak berhak mengakses menu ini!...');</script>"
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        'Response.Redirect("menu_laporan.aspx")

    End Sub

    Sub mnu0100_click(ByVal sender As Object, ByVal e As EventArgs)
        'KELUAR
        'Response.Redirect(Session("urlback"))
        Response.Redirect(Session("urlback"))
    End Sub


    Sub mnu0200_click(ByVal sender As Object, ByVal e As EventArgs)
        'Response.Redirect("Edit-Password.aspx")
        'Response.Redirect("Edit-Password.aspx?status=" + "1" + "&pKode=" + Request.QueryString("pKode"))
    End Sub

    Sub mnu0300_click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(Request.RawUrl)
    End Sub

    Sub mnu0400_click(ByVal sender As Object, ByVal e As EventArgs)
        'Session("sshakaksespilih") = "OK"
        'Session("ssNidLogin") = MasterLib.ShowData("vc_username", "vc_nid", "pde_user", Session("ssusername"), "")
        'If Session("ssNidLogin") = "NULL" Then
        '    Session("ssNidLogin") = ""
        'End If
        'Session("cIdUser") = MasterLib.ShowData("vc_username", "vc_id", "pde_user", Session("ssusername"), "")
        'Session("kodejp") = ""
        Session("sshakaksespilih") = ""
        Response.Redirect("Menu-Pilihan-JP.aspx")
    End Sub

End Class

