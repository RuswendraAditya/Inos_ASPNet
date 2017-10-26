Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormRekapSurveilansInfeksi
    Inherits System.Web.UI.Page
    Private Sub getDatRekap()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString
        Dim Period As String = Request.QueryString("bulan") & "-" & Request.QueryString("tahun")
        Dim strsql As String = ""
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        If (Request.QueryString("bulan") < 10) Then
            strsql = "SELECT  (SELECT CONCAT((select DateName(mm,DATEADD(mm, Substring(vc_period,1,1) - 1,0)) ), '-',right(rtrim(vc_period),4))) as tgl_trans,isi.vc_no_rm,pasien.vc_nama_p,isi.vc_no_reg,pasien.vc_jenis_k,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena  " & _
              ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp  " & _
             ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine  " & _
              ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett  " & _
              ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT  " & _
              ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator  " & _
              ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah  " & _
              ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax  " & _
              ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK  " & _
              ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP  " & _
              ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
               ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika " & _
               "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm " & _
               "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg " & _
               " WHERE isi.vc_no_rm <> '' and isi.vc_period='" & Period & "'  "
        Else
            strsql = "SELECT  (SELECT CONCAT((select DateName(mm,DATEADD(mm, Substring(vc_period,1,2) - 1,0)) ), '-',right(rtrim(vc_period),4))) as tgl_trans,isi.vc_no_rm,pasien.vc_nama_p,isi.vc_no_reg,pasien.vc_jenis_k,in_umurth,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena  " & _
             ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp  " & _
            ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine  " & _
             ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett  " & _
             ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT  " & _
             ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator  " & _
             ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah  " & _
             ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax  " & _
             ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK  " & _
             ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP  " & _
             ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis  " & _
              ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika " & _
              "FROM Inos_Surveilans_Infeksi  ISI LEFT JOIN RMPasien pasien ON iSI.vc_no_rm = pasien.vc_no_rm " & _
              "LEFT JOIN RMP_inap inap ON isi.vc_no_rm = inap.vc_no_rm and isi.vc_no_reg = inap.vc_no_reg " & _
              " WHERE isi.vc_no_rm <> '' and isi.vc_period='" & Period & "'  "
        End If



        If Request.QueryString("ruang") <> "000X" Then
            strsql = strsql & " AND vc_ruang = '" & Request.QueryString("ruang") & "' "
        End If



        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
    End Sub
    Private Function getNamaRuang(ByVal kode_ruang As String) As String
        Dim ruang_return As String = ""
        Dim strsql As String = ""
        strsql = "SELECT vc_n_ruang " & _
                 " FROM RMRuang where upper(vc_k_ruang) = UPPER('" & kode_ruang & "') "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            ruang_return = dr("vc_n_ruang")
        End While
        dr.Close()

        Return ruang_return
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Ruang As String = getNamaRuang(Request.QueryString("ruang"))
        Dim month As String = MonthName(Request.QueryString("bulan"), True)
        Dim period As String = month & "-" & Request.QueryString("tahun")
        getDatRekap()
        LblJudul.Text = "Rekap Surveilans Infeksi Rumah Sakit (Ruang: " & getNamaRuang(Request.QueryString("ruang")) & ") Period :" & period & ""
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim month As String = MonthName(Request.QueryString("bulan"), True)
        Dim Ruang As String = getNamaRuang(Request.QueryString("ruang"))
        Dim period As String = month & "-" & Request.QueryString("tahun")
        Dim title As String = "Rekap Surveilans_" & period & "_" & Ruang & ""
        MasterLib.Export2excel(GridView1, LblJudul, title)
    End Sub
End Class
