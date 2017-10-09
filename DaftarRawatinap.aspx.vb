Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class DaftarRawatinap
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strsql As String = ""

        Me.LblJudul.Text = "DAFTAR RAWAT INAP PASIEN"
        strsql = "SELECT rmp_inap.vc_no_rm,dbo.RMP_inap.vc_no_reg, dbo.RMPasien.vc_nama_p,dbo.RMP_inap.dt_tgl_msk, dbo.RMP_inap.dt_tgl_pul, " & _
                 "dbo.RMKamar.vc_nama, dbo.RMKelas.vc_n_kelas, dokter.vc_nama_kry " & _
                 "FROM dbo.RMP_inap INNER JOIN " & _
                 "dbo.RMPasien ON dbo.RMP_inap.vc_no_rm = dbo.RMPasien.vc_no_rm INNER JOIN " & _
                 "dbo.RMTaraKarip ON case when isnull(dbo.RMP_inap.vc_klas_mut,'')='' then dbo.RMP_inap.vc_k_klas_m else dbo.RMP_inap.vc_klas_mut end = dbo.RMTaraKarip.vc_kd_Gsklco INNER JOIN " & _
                 "dbo.RMKamar ON dbo.RMTaraKarip.VC_No_Bed = dbo.RMKamar.vc_no_bed INNER JOIN " & _
                 "dbo.RMKelas ON dbo.RMKamar.vc_k_kelas = dbo.RMKelas.vc_k_kelas " & _
                 "LEFT JOIN SDMDOKTER dokter on dbo.RMP_inap.vc_nid = dokter.vc_nid " & _
                     "where rmp_inap.vc_no_rm = '" & Request.QueryString("noRM") & "' "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub
End Class
