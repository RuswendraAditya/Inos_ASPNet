
Partial Class FormSearchLaporanInfeksiSummary
    Inherits System.Web.UI.Page

    Protected Sub BtnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormSurveilansInfeksiSummary.aspx?bulan=" & ddlbulan.Text & "&tahun=" & TxtTahun.Text)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.ddlbulan.Text = Month(MasterLib.GetCurrentDate)
            Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)
        End If
    End Sub
End Class
