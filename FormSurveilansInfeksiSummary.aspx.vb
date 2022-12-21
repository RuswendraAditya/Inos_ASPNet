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
        Dim Period As String = Request.QueryString("bulan") & "-" & Request.QueryString("tahun")
        SdsData.ConnectionString = connectionString
        Dim first_day As Date = DateSerial(Request.QueryString("tahun"), Request.QueryString("bulan"), 1)
        Dim last_day As Date = DateSerial(Request.QueryString("tahun"), Request.QueryString("bulan") + 1, 0)
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet

        Dim strsql As String = ""


        'strsql = "SELECT ruang.VC_n_ruang,vc_ruang,SUM(in_hari_cvp) vena_sentral_n,count(dt_infeksi_IADP) iadp,SUM(in_hari_vena) vena_perifier_n,count(dt_infeksi_plebitis) plebitis, " & _
        '   "SUM(in_hari_urine) urine_n,count(dt_infeksi_ISK) ISK,SUM(in_hari_tirah) tirah_n,count(dt_infeksi_HAP) HAP, " & _
        '   "SUM(in_hari_ventilator) ventilator_n,count(dt_infeksi_VAP) VAP,count(dt_infeksi_dekubitus) dekubitus " & _
        '   "FROM (SELECT  isi.vc_period,isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena   " & _
        '   ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp   " & _
        '   ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine   " & _
        '   ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett   " & _
        '   ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT   " & _
        '   ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator   " & _
        '   ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah  " & _
        '   ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax   " & _
        '   ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK   " & _
        '   ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP   " & _
        '   ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
        '   ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika  " & _
        '   "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm  " & _
        '   "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and isi.vc_period ='" & Period & "'  " & _
        '  " ) rekap " & _
        '   "LEFT JOIN RMRuang ruang ON rekap.vc_ruang = ruang.VC_k_ruang " & _
        '   "group by VC_n_ruang,vc_ruang "
        '   strsql = "SELECT ruang.VC_n_ruang,vc_ruang,SUM(in_hari_cvp) vena_sentral_n,count(dt_infeksi_IADP) iadp,SUM(in_hari_vena) vena_perifier_n,count(dt_infeksi_plebitis) plebitis,  " & _
        '      "SUM(in_hari_urine) urine_n,count(dt_infeksi_ISK) ISK,SUM(in_hari_tirah) tirah_n,count(dt_infeksi_HAP) HAP,   " & _
        '      "SUM(in_hari_ventilator) ventilator_n,count(dt_infeksi_VAP) VAP,count(dt_infeksi_dekubitus) dekubitus,COUNT(bt_tbc_ya) bt_tbc_ya,COUNT(bt_tbc_tidak) bt_tbc_tidak, " & _
        '"COUNT(bt_hiv_ya) bt_hiv_ya,COUNT(bt_hiv_tidak) bt_hiv_tidak,COUNT(bt_hepa_ya) bt_hepa_ya,COUNT(bt_hepa_tidak) bt_hepa_tidak,COUNT(bt_covid_ya) bt_covid_ya,COUNT(bt_covid_tidak) bt_covid_tidak, " & _
        '"COUNT(bt_antibiotika_ya) bt_antibiotika_ya ,COUNT(bt_antibiotika_tidak) bt_antibiotika_tidak,COUNT(tran_id) as tran_id ,  " & _
        '"ROUND(CAST(COUNT(bt_antibiotika_ya) AS float)/CAST(COUNT(tran_id) AS float) * 100,2) as persen_ya,  " & _
        '"ROUND( CAST ( COUNT (  bt_mdro_ya ) AS FLOAT ) / CAST ( COUNT ( tran_id ) AS FLOAT ) * 100, 2 ) AS persen_ya_mdro " & _
        '      "FROM (SELECT  isi.vc_period,isi.vc_no_rm,pasien.vc_nama_p,isi.vc_ruang,isi.vc_no_reg,pasien.vc_jenis_k,inap.dt_tgl_pul as tgl_trans,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena    " & _
        '      ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp   " & _
        '      ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine   " & _
        '      ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett   " & _
        '      ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT   " & _
        '      ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator  " & _
        '      ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah " & _
        '      ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax   " & _
        '      ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK   " & _
        '      ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP  " & _
        '      ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
        '      ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus, CASE WHEN bt_tbc_ya = 1 THEN '1' end  bt_tbc_ya,  CASE WHEN bt_tbc_tidak = 1 THEN '1' end bt_tbc_tidak, " & _
        '      "CASE WHEN bt_hiv_ya = 1 THEN '1' end  bt_hiv_ya,  CASE WHEN bt_hiv_tidak = 1 THEN '1' end bt_hiv_tidak, " & _
        '      "CASE WHEN bt_hepa_ya = 1 THEN '1' end  bt_hepa_ya,  CASE WHEN bt_hepa_tidak = 1 THEN '1' end bt_hepa_tidak, " & _
        '      "CASE WHEN bt_covid_ya = 1 THEN '1' end  bt_covid_ya,  CASE WHEN bt_covid_tidak = 1 THEN '1' end bt_covid_tidak, " & _
        '      "CASE WHEN bt_antibiotika_ya = 1 THEN '1' end  bt_antibiotika_ya,  CASE WHEN bt_antibiotika_tidak = 1 THEN '1' end bt_antibiotika_tidak,vc_antibiotika, CASE WHEN bt_mdro = 1 THEN '1' END bt_mdro_ya,  isi.transaction_id as tran_id   " & _
        '      "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm  " & _
        '      "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg WHERE isi.vc_no_rm <> '' and ISNULL(bt_hapus, 0 ) = 0 and isi.vc_period ='" & Period & "'  " & _
        '      ") rekap  " & _
        '      "LEFT JOIN RMRuang ruang ON rekap.vc_ruang = ruang.VC_k_ruang  " & _
        '      "group by VC_n_ruang,vc_ruang "
        strsql = "SELECT " & _
                    "	ruang.VC_n_ruang, " & _
                    "	vc_ruang, " & _
                    "	SUM ( in_hari_cvp ) vena_sentral_n, " & _
                    "	COUNT ( dt_infeksi_IADP ) iadp, " & _
                    "	SUM ( in_hari_vena ) vena_perifier_n, " & _
                    "	COUNT ( dt_infeksi_plebitis ) plebitis, " & _
                    "	SUM ( in_hari_urine ) urine_n, " & _
                    "	COUNT ( dt_infeksi_ISK ) ISK, " & _
                    "	SUM ( in_hari_tirah ) tirah_n, " & _
                    "	COUNT ( dt_tgl_operasi ) operasi, " & _
                    "	SUM ( " & _
                    "	CAST ( bt_operasi_b AS INT )) bt_operasi_b, " & _
                    "	SUM ( " & _
                    "	CAST ( bt_operasi_k AS INT )) bt_operasi_k, " & _
                    "	SUM ( " & _
                    "	CAST ( bt_operasi_bt AS INT )) bt_operasi_bt, " & _
                    "	COUNT ( dt_infeksi_HAP ) HAP, " & _
                    "	SUM ( in_hari_ventilator ) ventilator_n, " & _
                    "	COUNT ( dt_infeksi_VAP ) VAP, " & _
                    "	COUNT ( dt_infeksi_dekubitus ) dekubitus, " & _
                    "	COUNT ( bt_tbc_ya ) bt_tbc_ya, " & _
                    "	COUNT ( bt_tbc_tidak ) bt_tbc_tidak, " & _
                    "	COUNT ( bt_hiv_ya ) bt_hiv_ya, " & _
                    "	COUNT ( bt_hiv_tidak ) bt_hiv_tidak, " & _
                    "	COUNT ( bt_hepa_ya ) bt_hepa_ya, " & _
                    "	COUNT ( bt_hepa_tidak ) bt_hepa_tidak, " & _
                    "	COUNT ( bt_covid_ya ) bt_covid_ya, " & _
                    "	COUNT ( bt_covid_tidak ) bt_covid_tidak, " & _
                    "	COUNT ( bt_antibiotika_ya ) bt_antibiotika_ya, " & _
                    "	COUNT ( bt_antibiotika_tidak ) bt_antibiotika_tidak, " & _
                    "	COUNT ( tran_id ) AS tran_id, " & _
                    "	ROUND( " & _
                    "	CAST ( COUNT ( bt_antibiotika_ya ) AS FLOAT ) / CAST ( COUNT ( tran_id ) AS FLOAT ) * 100, " & _
                    "	2  " & _
                    "	) AS persen_ya, " & _
                    "	ROUND( " & _
                    "	CAST ( COUNT ( bt_mdro_ya ) AS FLOAT ) / CAST ( COUNT ( tran_id ) AS FLOAT ) * 100, " & _
                    "	2  " & _
                    "	) AS persen_ya_mdro  " & _
                    "FROM " & _
                    "	( " & _
                    "SELECT " & _
                    "	isi.vc_period, " & _
                    "	isi.vc_no_rm, " & _
                    "	pasien.vc_nama_p, " & _
                    "	isi.vc_ruang, " & _
                    "	isi.vc_no_reg, " & _
                    "	pasien.vc_jenis_k, " & _
                    "	inap.dt_tgl_pul AS tgl_trans, " & _
                    "	in_umurth, " & _
                    "	vc_nama_kamar, " & _
                    "	vc_diagnosa, " & _
                    "	CAST ( NULLIF ( [dt_vena_pasang], '' ) AS DATETIME ) dt_vena_pasang, " & _
                    "	CAST ( NULLIF ( [dt_vena_aff], '' ) AS DATETIME ) dt_vena_aff, " & _
                    "	in_hari_vena, " & _
                    "	CAST ( NULLIF ( [dt_cvp_pasang], '' ) AS DATETIME ) dt_cvp_pasang, " & _
                    "	CAST ( NULLIF ( [dt_cvp_aff], '' ) AS DATETIME ) dt_cvp_aff, " & _
                    "	in_hari_cvp, " & _
                    "	CAST ( NULLIF ( [dt_urine_pasang], '' ) AS DATETIME ) dt_urine_pasang, " & _
                    "	CAST ( NULLIF ( [dt_urine_aff], '' ) AS DATETIME ) dt_urine_aff, " & _
                    "	in_hari_urine, " & _
                    "	CAST ( NULLIF ( [dt_ett_pasang], '' ) AS DATETIME ) dt_ett_pasang, " & _
                    "	CAST ( NULLIF ( [dt_ett_aff], '' ) AS DATETIME ) dt_ett_aff, " & _
                    "	in_hari_ett, " & _
                    "	CAST ( NULLIF ( [dt_TT_pasang], '' ) AS DATETIME ) dt_TT_pasang, " & _
                    "	CAST ( NULLIF ( [dt_TT_aff], '' ) AS DATETIME ) dt_TT_aff, " & _
                    "	in_hari_TT, " & _
                    "	CAST ( NULLIF ( [dt_ventilator_pasang], '' ) AS DATETIME ) dt_ventilator_pasang, " & _
                    "	CAST ( NULLIF ( [dt_ventilator_aff], '' ) AS DATETIME ) dt_ventilator_aff, " & _
                    "	in_hari_ventilator, " & _
                    "	CAST ( NULLIF ( [dt_tirah_pasang], '' ) AS DATETIME ) dt_tirah_pasang, " & _
                    "	CAST ( NULLIF ( [dt_tirah_aff], '' ) AS DATETIME ) dt_tirah_aff, " & _
                    "	in_hari_tirah, " & _
                    "	CAST ( NULLIF ( [dt_tgl_operasi], '' ) AS DATETIME ) dt_tgl_operasi, " & _
                    "	ISNULL( bt_operasi_b, 0 ) bt_operasi_b, " & _
                    "	ISNULL( bt_operasi_k, 0 ) bt_operasi_k, " & _
                    "	ISNULL( bt_operasi_bt, 0 ) bt_operasi_bt, " & _
                    "	vc_HBSag, " & _
                    "	vc_antiHCV, " & _
                    "	vc_antiHIV, " & _
                    "	vc_lekosit, " & _
                    "	vc_GDS, " & _
                    "	vc_hasillThorax, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_IDO], '' ) AS DATETIME ) dt_infeksi_IDO, " & _
                    "	vc_kultur_IDO, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_ISK], '' ) AS DATETIME ) dt_infeksi_ISK, " & _
                    "	vc_kultur_ISK, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_VAP], '' ) AS DATETIME ) dt_infeksi_VAP, " & _
                    "	vc_kultur_VAP, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_HAP], '' ) AS DATETIME ) dt_infeksi_HAP, " & _
                    "	vc_kultur_HAP, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_IADP], '' ) AS DATETIME ) dt_infeksi_IADP, " & _
                    "	vc_kultur_IADP, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_plebitis], '' ) AS DATETIME ) dt_infeksi_plebitis, " & _
                    "	vc_kultur_plebitis, " & _
                    "	CAST ( NULLIF ( [dt_infeksi_dekubitus], '' ) AS DATETIME ) dt_infeksi_dekubitus, " & _
                    "	vc_kultur_dekubitus, " & _
                    "CASE " & _
                    "	 " & _
                    "	WHEN bt_tbc_ya = 1 THEN " & _
                    "	'1'  " & _
                    "	END bt_tbc_ya, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_tbc_tidak = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_tbc_tidak, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_hiv_ya = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_hiv_ya, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_hiv_tidak = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_hiv_tidak, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_hepa_ya = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_hepa_ya, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_hepa_tidak = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_hepa_tidak, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_covid_ya = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_covid_ya, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_covid_tidak = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_covid_tidak, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_antibiotika_ya = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_antibiotika_ya, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_antibiotika_tidak = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_antibiotika_tidak, " & _
                    "	vc_antibiotika, " & _
                    "CASE " & _
                    "		 " & _
                    "		WHEN bt_mdro = 1 THEN " & _
                    "		'1'  " & _
                    "	END bt_mdro_ya, " & _
                    "	isi.transaction_id AS tran_id  " & _
                    "FROM " & _
                    "	Inos_Surveilans_Infeksi ISI " & _
                    "	LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm " & _
                    "	LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm  " & _
                    "	AND isi.vc_no_reg = inap.vc_no_reg  " & _
                    "WHERE " & _
                    "	isi.vc_no_rm <> ''  " & _
                    "	AND ISNULL( bt_hapus, 0 ) = 0  " & _
                    "	AND isi.vc_period = '" & Period & "'   " & _
                    "	) rekap " & _
                    "	LEFT JOIN RMRuang ruang ON rekap.vc_ruang = ruang.VC_k_ruang  " & _
                    "GROUP BY " & _
                    "	VC_n_ruang, " & _
                    "vc_ruang"
        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub
End Class
