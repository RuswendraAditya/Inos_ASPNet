
Partial Class Laporan_Operasi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.DateTglDari.Text = Format(MasterLib.GetCurrentDate, "dd/MM/yyyy")
            Me.DateTglSampai.Text = Format(MasterLib.GetCurrentDate, "dd/MM/yyyy")

        End If
    End Sub

    Protected Sub CmdPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdPreview.Click

        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/daftar_operasi.aspx?dTglDari=" & Me.DateTglDari.Text & "&dTglSampai=" & Me.DateTglSampai.Text)
    End Sub

    Protected Sub DateTglDari_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTglDari.TextChanged
        If Not IsDate(MasterLib.xDate(Me.DateTglDari.Text)) Then
            PESAN("Pengisian Tanggal dari salah!...")
            Me.DateTglDari.Focus()
        End If
    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub DateTglSampai_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTglSampai.TextChanged
        If Not IsDate(MasterLib.xDate(Me.DateTglSampai.Text)) Then
            PESAN("Pengisian Tanggal sampai salah!...")
            Me.DateTglSampai.Focus()
        End If

    End Sub
End Class
