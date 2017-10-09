Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Web.Configuration


Partial Class Daftar_operasi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strsql As String = ""

        Me.LblJudul.Text = "DAFTAR TINDAKAN DAN PEMBEDAHAN Dari Tanggal : " & Request.QueryString("dTglDari") & " s/d " & Request.QueryString("dTglSampai")

        strsql = "SELECT  aa.vc_no_trans, convert(varchar(10),dt_tgl_operasi,101) as dt_tgl_operasi, convert(varchar(5),dt_tgl_operasi,108) as dt_jam_operasi, aa.vc_no_rm,aa.vc_no_reg, vc_nama_p, " & _
                 "vc_tindakan, rtrim(vc_n_ruang)+'/'+vc_n_kelas as vc_n_ruang, cc.vc_jenis_k, in_umurth, vc_no_ok, " & _
                 "vc_asal, vc_nama_kry, case when isnull(vc_derajat,'') ='' then vc_ket_lain else vc_derajat end as vc_ket_lain,1, case when isnull(bt_jkn,0)=0 then 'NON JKN' else 'JKN' end as JKN2, " & _
                 "vc_asal_daftar, case when ISNULL(bb.VC_K_PNG,'')='4YE' THEN 'JKN' ELSE 'NON JKN' END AS JKN, aa.bt_operasi FROM IBSJdwlOps aa " & _
                 "inner join RMP_Inap bb on aa.vc_no_reg = bb.vc_no_reg " & _
                 "inner join RMPasien cc on bb.vc_no_rm = cc.vc_no_rm " & _
                 "inner join RMTaraKarip ee ON CASE WHEN (bb.vc_KLAS_MUT IS NULL OR bb.vc_KLAS_MUT = '') THEN bb.vc_K_KLAS_M ELSE bb.vc_KLAS_MUT END = ee.vc_kd_Gsklco " & _
                 "inner join RMKamar ff ON ee.VC_No_Bed = ff.vc_no_bed " & _
                 "inner join RMRuang gg ON ff.vc_k_gugus = gg.VC_k_ruang " & _
                 "inner join IBSDokterOps hh on aa.vc_no_trans = hh.vc_no_trans " & _
                 "inner join SDMDokter ii on hh.vc_nid = ii.vc_nid " & _
                 "INNER JOIN rmkelas jj on ff.vc_k_kelas = jj.vc_k_kelas " & _
                 "WHERE	convert(varchar(10),dt_tgl_operasi,120) Between CONVERT(DATETIME,'" & MasterLib.xDate(Request.QueryString("dTglDari")) & "') and CONVERT(DATETIME,'" & MasterLib.xDate(Request.QueryString("dTglSampai")) & "')  AND    aa.vc_status = '2'  " & _
                 "UNION  Select	aa.vc_no_trans,convert(varchar(10),dt_tgl_operasi,101) as dt_tgl_operasi, convert(varchar(5),dt_tgl_operasi,108) as dt_jam_operasi,  " & _
                 "aa.vc_no_rm,aa.vc_no_reg, vc_nama_p, " & _
                 "vc_tindakan, '' as vc_n_ruang,cc.vc_jenis_k,in_umurth, " & _
                 "vc_no_ok, vc_asal, vc_nama_kry,case when isnull(vc_derajat,'') ='' then vc_ket_lain else vc_derajat end as vc_ket_lain,2, case when isnull(bt_jkn,0)=0 then 'NON JKN' else 'JKN' end as JKN2, " & _
                 "vc_asal_daftar, case when isnull(bt_jkn,0)=0 then 'NON JKN' else 'JKN' end as JKN, aa.bt_operasi FROM	IBSJdwlOps aa " & _
                 "inner join RMKunjung bb on aa.vc_no_reg = bb.vc_no_regj " & _
                 "inner join RMPasien cc on bb.vc_no_rm = cc.vc_no_rm " & _
                 "inner join IBSDokterOps ff on aa.vc_no_trans = ff.vc_no_trans " & _
                 "inner join SDMDokter gg on ff.vc_nid = gg.vc_nid " & _
                 "WHERE	convert(varchar(10),dt_tgl_operasi,120) Between CONVERT(DATETIME,'" & MasterLib.xDate(Request.QueryString("dTglDari")) & "') and CONVERT(DATETIME,'" & MasterLib.xDate(Request.QueryString("dTglSampai")) & "')  AND    aa.vc_status = '2'  " & _
                 "AND BT_OPERASI = 1 " & _
                 "ORDER BY vc_no_trans, vc_nama_kry "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        MasterLib.Export2excel(GridView1, LblJudul, "Laporan Operasi")
    End Sub
End Class
