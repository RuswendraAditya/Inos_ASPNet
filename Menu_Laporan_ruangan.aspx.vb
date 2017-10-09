
Partial Class Menu_Laporan_ruangan
    Inherits System.Web.UI.Page

    Protected Sub LBSSi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBSSi.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/SSI.aspx?pBulan=" & Me.ddlbulan.SelectedValue & "&pTahun=" & Me.TxtTahun.Text & "&kRuang=" & Me.DDLRUANG.SelectedValue)
    End Sub

    Protected Sub LBHAIs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBHAIs.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/HAIS.aspx?pBulan=" & Me.ddlbulan.SelectedValue & "&pTahun=" & Me.TxtTahun.Text & "&kRuang=" & Me.DDLRUANG.SelectedValue)

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.ddlbulan.Text = Month(MasterLib.GetCurrentDate)
            Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)

            With Me.DDLRUANG
                .DataSource = MasterLib.SetDataSourceRuang()
                .DataTextField = "vc_n_ruang"
                .DataValueField = "vc_k_ruang"
                .DataBind()
            End With
        End If
    End Sub
End Class
