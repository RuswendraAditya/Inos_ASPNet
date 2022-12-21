Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormSearchingDataSurveilans
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            getDataInfeksiSurveilans(Request.QueryString("noRM"), Request.QueryString("noReg"))


        End If
    End Sub

    Private Sub getDataInfeksiSurveilans(ByVal noRM As String, ByVal noReg As String)
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsPasien.ConnectionString = connectionString

        SdsPasien.DataSourceMode = SqlDataSourceMode.DataSet
        SdsPasien.ProviderName = "System.Data.SqlClient"
        Dim strsql As String = ""
        strsql = "SELECT transaction_id,isi.vc_no_rm,isi.vc_no_reg,pasien.vc_nama_p, " & _
        "ruang.VC_n_ruang,vc_nama_kamar,(SELECT CASE " & _
        "WHEN SUBSTRING(vc_period,3,1) = '-' THEN (SELECT CONCAT((select DateName(mm,DATEADD(mm, Substring(vc_period,1,2) - 1,0)) ), '-',right(rtrim(vc_period),4))) " & _
        "ELSE (SELECT CONCAT((select DateName(mm,DATEADD(mm, Substring(vc_period,1,1) - 1,0)) ), '-',right(rtrim(vc_period),4))) " & _
        "END) as period FROM Inos_Surveilans_Infeksi isi " & _
        "LEFT JOIN RMPasien pasien " & _
        "ON isi.vc_no_rm = pasien.vc_no_rm LEFT JOIN RMRuang ruang " & _
        "ON isi.vc_ruang = ruang.VC_k_ruang " & _
        " WHERE isi.vc_no_rm ='" & noRM & "'  and isi.vc_no_reg='" & noReg & "' and ISNULL(bt_hapus, 0 ) = 0 "


        SdsPasien.SelectCommand = strsql
        GridView1.DataSourceID = SdsPasien.ID
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            'e.Row.Attributes.Add("onmouseover", "ToolTip('Display some message');")
            e.Row.Attributes.Add("onMouseOver", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='cyan';this.style.cursor='pointer';")
            e.Row.Attributes.Add("OnMouseOut", "this.style.backgroundColor=this.originalstyle;")
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
            e.Row.ToolTip = "Klik untuk Menginput data"
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim index As Integer = GridView1.SelectedIndex
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?transactionId=" & GridView1.DataKeys(index).Values(0).ToString() & "&noRM=" & GridView1.DataKeys(index).Values(1).ToString() & "&noReg=" & GridView1.DataKeys(index).Values(2).ToString())
    End Sub

    Protected Sub BtnNewInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewInput.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("FormSearchingInputSurveilans.aspx")
    End Sub
End Class
