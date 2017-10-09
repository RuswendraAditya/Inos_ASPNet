Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class Searching
    Inherits System.Web.UI.Page

    Protected Sub CmdCari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdCari.Click

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsPasien.ConnectionString = connectionString

        SdsPasien.DataSourceMode = SqlDataSourceMode.DataSet
        SdsPasien.ProviderName = "System.Data.SqlClient"

        'If Me.TxtCariNama.Text = "" And Me.TxtCariKelurahan.Text = "" And Me.TxtCariKecamatan.Text = "" And Me.TxtCariKota.Text = "" And Me.TxtCariNoRM.Text = "" Then
        '    Dim someScript As String = ""
        '    someScript = "<script language='javascript'>alert('Isikan salah satu parameter pencarian!...');</script>"
        '    Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        '    Exit Sub
        'End If

        Dim strsql As String = ""

        strsql = "SELECT RMPasien.vc_no_rm, RMPasien.vc_nama_p, RMPasien.vc_kelurahan, RMPasien.vc_kecamatan, RMPasien.vc_kota, RMP_inap.vc_no_reg, rmkamar.vc_nama as kamar, RMP_inap.VC_ALERGI " & _
                 ", CASE WHEn ISNULL(IN_UMURTH,'') > 0 THEN ltrim(str(IN_UMURTH)) + ' Th ' + ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' ELSE " & _
                 " CASE WHEn ISNULL(IN_UMURTH,'')<= 0 and ISNULL(IN_UMURbl,'') > 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' else " & _
                 " CASE WHEn ISNULL(IN_UMURTH,'') <= 0 and ISNULL(IN_UMURbl,'') <= 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURhr)) + ' hr' else Str(0) end END end as umur " & _
                 "FROM RMPasien INNER JOIN " & _
                 "RMP_inap ON RMPasien.vc_no_rm = RMP_inap.vc_no_rm INNER JOIN " & _
                 "RMTaraKarip ON CASE WHEN (RMP_inap.vc_KLAS_MUT is null or RMP_inap.vc_KLAS_MUT ='') " & _
                 "THEN RMP_inap.vc_K_KLAS_M " & _
                 "ELSE RMP_inap.vc_KLAS_MUT End = RMTaraKarip.vc_kd_Gsklco INNER JOIN  " & _
                 "RMKamar ON RMTaraKarip.VC_No_Bed = RMKamar.vc_no_bed " & _
                 "WHERE RMPasien.vc_no_rm <> ''" & _
                 "and rmp_inap.dt_tgl_PUL is null "

        'Metode pencarian diawali kata
        If Me.TxtCariNama.Text <> "" Then
            strsql = strsql + "AND ([VC_nama_P])like '%" & UCase(TxtCariNama.Text) & "%' "
        End If

        If Me.TxtCariKelurahan.Text <> "" Then
            strsql = strsql & "AND ([VC_KELURAHAN])like '%" & UCase(TxtCariKelurahan.Text) & "%' "
        End If

        If Me.TxtCariKecamatan.Text <> "" Then
            strsql = strsql & "AND ([VC_KECAMATAN])like '%" & UCase(Me.TxtCariKecamatan.Text) & "%' "
        End If

        If Me.TxtCariKota.Text <> "" Then
            strsql = strsql & "AND ([VC_KOTA])like '%" & UCase(Me.TxtCariKota.Text) & "%' "
        End If

        If Me.TxtCariNoRM.Text <> "" Then
            strsql = strsql & "AND ([VC_no_rm])like '%" & UCase(Me.TxtCariNoRM.Text) & "%' "
        End If

        strsql = strsql + " ORDER BY RMPasien.VC_NAMA_P"

        SdsPasien.SelectCommand = strsql
        GridView1.DataSourceID = SdsPasien.ID
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
