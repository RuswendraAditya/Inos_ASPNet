
Partial Class Triwulan
    Inherits System.Web.UI.Page

    Protected Sub LBSSi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBSSi.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/SSI_Range.aspx?pTriwulan=" & Me.ddlTriwulan.SelectedValue & "&pTahun=" & Me.TxtTahun.Text & "&kRuang=" & Me.DDLRUANG.SelectedValue)
    End Sub

    Protected Sub LBHAIs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBHAIs.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/HAIS_Range.aspx?pTriwulan=" & Me.ddlTriwulan.SelectedValue & "&pTahun=" & Me.TxtTahun.Text & "&kRuang=" & Me.DDLRUANG.SelectedValue)

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim nTriwulan As Integer = Month(MasterLib.GetCurrentDate)

            'triwulan 1
            If nTriwulan >= 1 And nTriwulan <= 3 Then
                Me.ddlTriwulan.Text = 1
            End If

            'triwulan 2
            If nTriwulan >= 4 And nTriwulan <= 6 Then
                Me.ddlTriwulan.Text = 2
            End If

            'triwulan 3
            If nTriwulan >= 7 And nTriwulan <= 9 Then
                Me.ddlTriwulan.Text = 4
            End If

            'triwulan 4
            If nTriwulan >= 10 And nTriwulan <= 12 Then
                Me.ddlTriwulan.Text = 4
            End If

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
