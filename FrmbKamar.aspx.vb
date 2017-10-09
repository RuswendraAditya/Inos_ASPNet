Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class FrmbKamar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            With Me.DDLRUANG
                .DataSource = MasterLib.SetDataSourceRuang()
                .DataTextField = "vc_n_ruang"
                .DataValueField = "vc_k_ruang"
                .DataBind()
            End With
        End If
        datainap()
    End Sub

    Private Sub datainap()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsPasien.ConnectionString = connectionString

        SdsPasien.DataSourceMode = SqlDataSourceMode.DataSet
        SdsPasien.ProviderName = "System.Data.SqlClient"


        Dim strsql As String = ""

        strsql = "SELECT RMKamar.vc_no_bed, RMKamar.vc_nama, RMKelas.vc_n_kelas, ISNULL(RMKamar.vc_no_reg,'') AS VC_NO_REG, RMpasien.vc_no_rm, RMPasien.vc_nama_p, " & _
                 "RMPasien.vc_alamat, RMPasien.vc_kelurahan, RMPasien.vc_kecamatan, RMPasien.vc_kota,RMP_inap.dt_tgl_msk, RMP_inap.vc_jam_msk, RMSTATUSKAMAR.VC_N_STATUS, ISNULL(RMKAMAR.VC_k_STATUS,'')AS K_STATUS, ISNULL(RMP_inap.dt_tgl_pul,'') AS TGL_PUL " & _
                 ", RMP_inap.VC_ALERGI " & _
                 ", CASE WHEn ISNULL(IN_UMURTH,'') > 0 THEN ltrim(str(IN_UMURTH)) + ' Th ' + ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' ELSE " & _
                 " CASE WHEn ISNULL(IN_UMURTH,'')<= 0 and ISNULL(IN_UMURbl,'') > 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' else " & _
                 " CASE WHEn ISNULL(IN_UMURTH,'') <= 0 and ISNULL(IN_UMURbl,'') <= 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURhr)) + ' hr' else Str(0) end END end as umur, dbo.BPJS_RefDiagnosis_inasis.Description " & _
                 "FROM RMKamar INNER JOIN RMP_inap ON RMKamar.vc_no_reg = RMP_inap.vc_no_reg LEFT JOIN " & _
                 "RMPasien ON RMP_inap.vc_no_rm = RMPasien.vc_no_rm " & _
                 "INNER JOIN RMKelas on rmkamar.vc_k_kelas = rmkelas.vc_k_kelas " & _
                 "left JOIN RMStatusKamar on rmkamar.vc_k_status = RMStatusKamar.vc_k_Status " & _
                 "LEFT JOIN dbo.BPJS_RefDiagnosis_inasis ON dbo.RMP_inap.vc_alergi = dbo.BPJS_RefDiagnosis_inasis.Code " & _
                 "where RMKamar.vc_k_gugus = '" & Me.DDLRUANG.SelectedValue & "' " & _
                 "ORDER BY rmkamar.vc_nama "


        SdsPasien.SelectCommand = strsql
        GridView1.DataSourceID = SdsPasien.ID
    End Sub

    Protected Sub DDLRUANG_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLRUANG.SelectedIndexChanged
        datainap()
    End Sub
End Class
