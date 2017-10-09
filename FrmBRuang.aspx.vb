Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class FrmBRuang
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        datainap()

    End Sub

    Private Sub datainap()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsPasien.ConnectionString = connectionString

        SdsPasien.DataSourceMode = SqlDataSourceMode.DataSet
        SdsPasien.ProviderName = "System.Data.SqlClient"


        Dim strsql As String = ""

        strsql = "SELECT vc_k_ruang, vc_n_ruang from rmruang order by vc_k_ruang "

        SdsPasien.SelectCommand = strsql
        GridView1.DataSourceID = SdsPasien.ID

    End Sub
End Class
