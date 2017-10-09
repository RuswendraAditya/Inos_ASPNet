Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class DaftarRajal
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strsql As String = ""

        Me.LblJudul.Text = "DAFTAR RAWAT JALAN PASIEN"

        strsql = "SELECT pasien.vc_no_rm,pasien.vc_nama_p ,kunjung.VC_NO_REGJ no_reg,kunjung.dt_tgl_proses_awal tgl_kunjungan,klinik.vc_N_KLINIK nama_klinik,dokter.vc_nama_kry dokter FROM  " & _
                 "RMPasien pasien, RMKUNJUNG kunjung,RMKLINIK klinik,SDMDOKTER dokter " & _
                    "where kunjung.vc_no_RM = '" & Request.QueryString("noRM") & "' " & _
                    "and kunjung.VC_NO_RM  = pasien.vc_no_rm " & _
                    "and klinik.vc_K_KLINIK = kunjung.VC_K_KLINIK " & _
                    "and dokter.vc_nid = kunjung.VC_K_DOKTER "
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub

End Class
