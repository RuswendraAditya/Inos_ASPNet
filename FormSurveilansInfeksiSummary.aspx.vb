Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormSurveilansInfeksiSummary
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim month As String = MonthName(Request.QueryString("bulan"), True)
        Dim period As String = month & "-" & Request.QueryString("tahun")
        getDataSummary()
        LblJudul.Text = "Rekap Summary Surveilans Infeksi Rumah Sakit ( Period :" & period & ") "
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim month As String = MonthName(Request.QueryString("bulan"), True)
        Dim period As String = month & "-" & Request.QueryString("tahun")
        Dim title As String = "Rekap Summary Surveilans_" & period & ""
        MasterLib.Export2excel(GridView1, LblJudul, title)
    End Sub


    Private Sub getDataSummary()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString
        Dim first_day As Date = DateSerial(Request.QueryString("tahun"), Request.QueryString("bulan"), 1)
        Dim last_day As Date = DateSerial(Request.QueryString("tahun"), Request.QueryString("bulan") + 1, 0)
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet

        Dim strsql As String = ""
        'strsql = "SELECT ruang.VC_n_ruang,vc_ruang,SUM(in_hari_cvp) vena_sentral_n,count(dt_infeksi_IADP) iadp,SUM(in_hari_vena) vena_perifier_n,count(dt_infeksi_plebitis) plebitis, " & _
        '   "SUM(in_hari_urine) urine_n,count(dt_infeksi_ISK) ISK,SUM(in_hari_tirah) tirah_n,count(dt_infeksi_HAP) HAP, " & _
        '   "SUM(in_hari_ventilator) ventilator_n,count(dt_infeksi_VAP) VAP,count(dt_infeksi_dekubitus) dekubitus " & _
        '   "FROM (SELECT  isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATE) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATE) dt_vena_aff,in_hari_vena   " & _
        '   ", cast(NULLIF([dt_cvp_pasang],'') AS DATE) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATE) dt_cvp_aff,in_hari_cvp   " & _
        '   ",cast(NULLIF([dt_urine_pasang],'') AS DATE) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATE) dt_urine_aff,in_hari_urine   " & _
        '   ",cast(NULLIF([dt_ett_pasang],'') AS DATE) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATE) dt_ett_aff,in_hari_ett   " & _
        '   ",cast(NULLIF([dt_TT_pasang],'') AS DATE) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATE) dt_TT_aff,in_hari_TT   " & _
        '   ",cast(NULLIF([dt_ventilator_pasang],'') AS DATE) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATE) dt_ventilator_aff,in_hari_ventilator   " & _
        '   ",cast(NULLIF([dt_tirah_pasang],'') AS DATE) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATE) dt_tirah_aff,in_hari_tirah  " & _
        '   ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax   " & _
        '   ",cast(NULLIF([dt_infeksi_IDO],'') AS DATE) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATE) dt_infeksi_ISK,vc_kultur_ISK   " & _
        '   ",cast(NULLIF([dt_infeksi_VAP],'') AS DATE) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATE)dt_infeksi_HAP,vc_kultur_HAP   " & _
        '   ",cast(NULLIF([dt_infeksi_IADP],'') AS DATE) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATE) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
        '   ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATE) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika  " & _
        '   "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm  " & _
        '   "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and inap.dt_tgl_pul>='" & first_day & "' and  inap.dt_tgl_pul<='" & last_day & "' " & _
        '   "UNION " & _
        '   "SELECT  isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATE) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATE) dt_vena_aff,in_hari_vena  " & _
        '   ", cast(NULLIF([dt_cvp_pasang],'') AS DATE) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATE) dt_cvp_aff,in_hari_cvp   " & _
        '   ",cast(NULLIF([dt_urine_pasang],'') AS DATE) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATE) dt_urine_aff,in_hari_urine  " & _
        '   " cast(NULLIF([dt_ett_pasang],'') AS DATE) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATE) dt_ett_aff,in_hari_ett  " & _
        '   ",cast(NULLIF([dt_TT_pasang],'') AS DATE) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATE) dt_TT_aff,in_hari_TT  " & _
        '   ",cast(NULLIF([dt_ventilator_pasang],'') AS DATE) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATE) dt_ventilator_aff,in_hari_ventilator  " & _
        '   ",cast(NULLIF([dt_tirah_pasang],'') AS DATE) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATE) dt_tirah_aff,in_hari_tirah   " & _
        '   ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax " & _
        '   ",cast(NULLIF([dt_infeksi_IDO],'') AS DATE) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATE) dt_infeksi_ISK,vc_kultur_ISK   " & _
        '   ",cast(NULLIF([dt_infeksi_VAP],'') AS DATE) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATE)dt_infeksi_HAP,vc_kultur_HAP   " & _
        '   ",cast(NULLIF([dt_infeksi_IADP],'') AS DATE) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATE) dt_infeksi_plebitis,vc_kultur_plebitis   " & _
        '   ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATE) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika  " & _
        '   "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm " & _
        '   "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and inap.dt_tgl_msk>='" & first_day & "' and  inap.dt_tgl_msk<='" & last_day & "' and inap.dt_tgl_pul = ''  ) rekap " & _
        '   "LEFT JOIN RMRuang ruang ON rekap.vc_ruang = ruang.VC_k_ruang " & _
        '   "group by VC_n_ruang,vc_ruang " & _
        '   "ORDER BY VC_n_ruang"

        strsql = "SELECT ruang.VC_n_ruang,vc_ruang,SUM(in_hari_cvp) vena_sentral_n,count(dt_infeksi_IADP) iadp,SUM(in_hari_vena) vena_perifier_n,count(dt_infeksi_plebitis) plebitis, " & _
           "SUM(in_hari_urine) urine_n,count(dt_infeksi_ISK) ISK,SUM(in_hari_tirah) tirah_n,count(dt_infeksi_HAP) HAP, " & _
           "SUM(in_hari_ventilator) ventilator_n,count(dt_infeksi_VAP) VAP,count(dt_infeksi_dekubitus) dekubitus " & _
           "FROM (SELECT  isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena   " & _
           ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp   " & _
           ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine   " & _
           ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett   " & _
           ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT   " & _
           ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator   " & _
           ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah  " & _
           ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax   " & _
           ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK   " & _
           ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP   " & _
           ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
           ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika  " & _
           "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm  " & _
           "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and inap.dt_tgl_pul>='" & first_day & "' and  inap.dt_tgl_pul<='" & last_day & "' " & _
           "UNION " & _
           "SELECT  isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena   " & _
           ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp   " & _
           ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine   " & _
           ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett   " & _
           ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT   " & _
           ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator   " & _
           ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah  " & _
           ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax   " & _
           ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK   " & _
           ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP   " & _
           ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
           ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika  " & _
           "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm  " & _
           "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and inap.dt_tgl_msk>='" & first_day & "' and  inap.dt_tgl_msk<='" & last_day & "' and inap.dt_tgl_pul = '') rekap " & _
           "LEFT JOIN RMRuang ruang ON rekap.vc_ruang = ruang.VC_k_ruang " & _
           "group by VC_n_ruang,vc_ruang "
        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub
End Class
