Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormInputSurveilansInfeksi
    'Ruswendra 20 sep2017
    Inherits System.Web.UI.Page
    Dim Pesan_gagal As String
    Dim trans_id As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            loadDataPasien()
            ChkBoxMDROTidak.Checked = True
            dropDownSpesimen.Enabled = False
            dropDownSpesimen.SelectedValue = "0"
            controlCheckBoxBateri(False)
            If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))) Then
                bindDataExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))
            End If
            If (String.IsNullOrEmpty(Request.QueryString("transactionId"))) Then
                LinkButtonHAP.Visible = False
                LinkButtonVAP.Visible = False
                LinkButtonIADP.Visible = False
                LinkButtonISK.Visible = False
                LinkButtonPLE.Visible = False
                LinkButtonIDO.Visible = False
                LinkButtonDekubitus.Visible = False
            End If
        End If
     

    End Sub
    Private Sub disabledForm()
        Me.DDLRUANG.Enabled = False
        Me.DDLKamar.Enabled = False
        Me.ddlbulan.Enabled = False
        Me.TxtTahun.Enabled = False
        Me.dateVENAPasang.Enabled = False
        Me.dateVENAAff.Enabled = False
        Me.TextLamaHari1.Enabled = False
        Me.dateCVPPasang.Enabled = False
        Me.dateCVPAff.Enabled = False
        Me.TextLamaHari2.Enabled = False
        Me.dateUrinePasang.Enabled = False
        Me.dateUrineAFF.Enabled = False
        Me.TextLamaHari3.Enabled = False
        Me.dateETPasang.Enabled = False
        Me.dateETAff.Enabled = False
        Me.TextLamaHari4.Enabled = False
        Me.dateTTPasang.Enabled = False
        Me.dateTTAff.Enabled = False
        Me.TextLamaHari5.Enabled = False
        Me.dateVentilatorPasang.Enabled = False
        Me.dateVentilatorAff.Enabled = False
        Me.TextLamaHari6.Enabled = False
        Me.dateTirahPasang.Enabled = False
        Me.dateTirahAff.Enabled = False
        Me.TextLamaHari7.Enabled = False
        'Me.TxtHasilThorax.Enabled = False
        'Me.TxtHBSag.Enabled = False
        'Me.TxtAntiHCV.Enabled = False
        'Me.TxtAntiHiv.Enabled = False
        'Me.TxtLekosit.Enabled = False
        'Me.TxtGDS.Enabled = False
        'Me.TxtHasilThorax.Enabled = False
        Me.dateKejIDO.Enabled = False
        Me.dateKejISK.Enabled = False
        Me.dateKejPlebitis.Enabled = False
        Me.dateKejVAP.Enabled = False
        Me.dateKejHAP.Enabled = False
        Me.dateKejIADP.Enabled = False
        Me.dateKejDekubitus.Enabled = False
        Me.txtAntibiotika.Enabled = False
        Me.txtKulturPlebitis.Enabled = False
        Me.txtKulturISK.Enabled = False
        Me.txtKulturIDO.Enabled = False
        Me.txtKulturIADP.Enabled = False
        Me.txtKulturHAP.Enabled = False
        Me.txtKulturDekubitus.Enabled = False
        Me.txtKulturVAP.Enabled = False
        controlCheckBoxBateri(False)
        dropDownSpesimen.Enabled = False

    End Sub

    Private Sub enabledForm()
        Me.DDLRUANG.Enabled = True
        Me.DDLKamar.Enabled = True
        Me.ddlbulan.Enabled = True
        Me.TxtTahun.Enabled = True
        Me.dateVENAPasang.Enabled = True
        Me.dateVENAAff.Enabled = True
        Me.TextLamaHari1.Enabled = True
        Me.dateCVPPasang.Enabled = True
        Me.dateCVPAff.Enabled = True
        Me.TextLamaHari2.Enabled = True
        Me.dateUrinePasang.Enabled = True
        Me.dateUrineAFF.Enabled = True
        Me.TextLamaHari3.Enabled = True
        Me.dateETPasang.Enabled = True
        Me.dateETAff.Enabled = True
        Me.TextLamaHari4.Enabled = True
        Me.dateTTPasang.Enabled = True
        Me.dateTTAff.Enabled = True
        Me.TextLamaHari5.Enabled = True
        Me.dateVentilatorPasang.Enabled = True
        Me.dateVentilatorAff.Enabled = True
        Me.TextLamaHari6.Enabled = True
        Me.dateTirahPasang.Enabled = True
        Me.dateTirahAff.Enabled = True
        Me.TextLamaHari7.Enabled = True
 
        Me.dateKejIDO.Enabled = True
        Me.dateKejISK.Enabled = True
        Me.dateKejPlebitis.Enabled = True
        Me.dateKejVAP.Enabled = True
        Me.dateKejHAP.Enabled = True
        Me.dateKejIADP.Enabled = True
        Me.dateKejDekubitus.Enabled = True
        Me.txtAntibiotika.Enabled = True
        Me.txtKulturPlebitis.Enabled = True
        Me.txtKulturISK.Enabled = True
        Me.txtKulturIDO.Enabled = True
        Me.txtKulturIADP.Enabled = True
        Me.txtKulturHAP.Enabled = True
        Me.txtKulturDekubitus.Enabled = True
        Me.txtKulturVAP.Enabled = True
        controlCheckBoxBateri(True)
        dropDownSpesimen.Enabled = True

    End Sub

    ' load data pasien un
    Private Sub loadDataPasien()
        Dim strsql As String = ""

        strsql = "SELECT RMPasien.vc_no_rm, RMPasien.vc_nama_p,RMPasien.vc_jenis_k,RMPasien.vc_alamat, RMP_inap.vc_no_reg, RMP_inap.dt_tgl_msk,RMKAMAR.VC_NAMA as kamar,RMKamar.vc_k_gugus ,RMP_inap.VC_ALERGI , CASE WHEn ISNULL(IN_UMURTH,'') > 0 THEN ltrim(str(IN_UMURTH)) + ' Th ' + ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' ELSE " & _
                 "CASE WHEn ISNULL(IN_UMURTH,'')<= 0 and ISNULL(IN_UMURbl,'') > 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' else " & _
                 "CASE WHEn ISNULL(IN_UMURTH,'') <= 0 and ISNULL(IN_UMURbl,'') <= 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURhr)) + ' hr' else Str(0) end END end as umur, dbo.BPJS_RefDiagnosis_inasis.Description  FROM RMPasien INNER JOIN " & _
                 "RMP_inap ON RMPasien.vc_no_rm = RMP_inap.vc_no_rm INNER JOIN " & _
                 "rmkamar ON CASE WHEN (RMP_inap.vc_KLAS_MUT is null or RMP_inap.vc_KLAS_MUT ='') " & _
                 "THEN RMP_inap.vc_Kd_kamar_Masuk " & _
                 "ELSE RMP_inap.vc_kd_kamar_MUTasi End = rmkamar.vc_no_bed " & _
                 "LEFT JOIN dbo.BPJS_RefDiagnosis_inasis ON dbo.RMP_inap.vc_alergi = dbo.BPJS_RefDiagnosis_inasis.Code " & _
                 "LEFT JOIN RMRuang ruang ON vc_k_gugus = ruang.vc_k_ruang " & _
                 "WHERE  RMPasien.vc_no_rm = '" & Request.QueryString("noRM") & "' and RMP_inap.vc_no_reg ='" & Request.QueryString("noReg") & "'  "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Me.TxtNoRM.Text = ""
        Me.TxtNama.Text = ""
        Me.TxtAlamat.Text = ""
        Me.TxtNoREG.Text = ""
        Me.TxtUmur.Text = ""
        Me.TxtKelamin.Text = ""
        Me.TxtDiagnosa.Text = ""

        While dr.Read
            Me.TxtNoRM.Text = dr("vc_no_rm")
            Me.TxtNama.Text = dr("vc_nama_p")
            Me.TxtAlamat.Text = dr("vc_alamat")
            Me.TxtNoREG.Text = dr("vc_no_reg")
            Me.TxtUmur.Text = dr("umur")
            Me.TxtKelamin.Text = dr("vc_jenis_k")
            'Me.txtKamar.Text = dr("kamar")
            Me.TxtDiagnosa.Text = dr("vc_alergi")

        End While
        dr.Close()
        If TxtDiagnosa.Text.Length > 0 Then
            Me.TxtDiagnosa.Enabled = False
        End If

        With Me.DDLRUANG
            .DataSource = MasterLib.SetDataSourceRuang()
            .DataTextField = "vc_n_ruang"
            .DataValueField = "vc_k_ruang"
            .DataBind()
        End With
        DDLRUANG.Items.Insert(0, New ListItem("---", "---"))
        Me.ddlbulan.Text = Month(MasterLib.GetCurrentDate)
        Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)
        Me.DDLRUANG.Items.Remove(DDLRUANG.Items.FindByText("SEMUA"))

    End Sub

    'untuk menbinding data lama
    Private Sub bindDataExists(ByVal transactionId As Integer, ByVal noRm As String, ByVal noReg As String)

        Dim strsql As String = ""
        strsql = "SELECT SUBSTRING(vc_period,0,CHARINDEX('-',vc_period,0)) month,SUBSTRING(vc_period,CHARINDEX('-',vc_period)+1,LEN(vc_period)) year, vc_ruang,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena " & _
           ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp " & _
           ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine " & _
           ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett " & _
           ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT " & _
           ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator " & _
           ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah " & _
           ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK " & _
           ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP " & _
           ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis " & _
            ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika,bt_antibiotika_ya,bt_antibiotika_tidak,bt_covid_ya,bt_covid_tidak " & _
            ",bt_tbc_ya,bt_tbc_tidak,bt_hepa_ya,bt_hepa_tidak,bt_hiv_ya,bt_hiv_tidak ,[bt_mdro],[vc_spesimen],[bt_bakteri_mrsa],[bt_bakteri_mrse],[bt_bakteri_klebisella],[bt_bakteri_coli],[bt_bakteri_psedomonas],[bt_bakteri_MDR],[bt_bakteri_VRE],cast(NULLIF([dt_tgl_operasi],'') AS DATETIME) dt_tgl_operasi,bt_operasi_b,bt_operasi_bt,bt_operasi_k " & _
            ",[bt_bakteri_CRE],[bt_bakteri_MDRTB] " & _
            " FROM Inos_Surveilans_Infeksi where transaction_id = '" & transactionId & "' and vc_no_rm = '" & noRm & "' and vc_no_reg = '" & noReg & "'"

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            If Not IsDBNull(dr("month")) Then
                ddlbulan.SelectedValue = dr("month")
            End If
            If Not IsDBNull(dr("year")) Then
                TxtTahun.Text = dr("year")
            End If
            If Not IsDBNull(dr("vc_diagnosa")) Then
                Me.TxtDiagnosa.Text = dr("vc_diagnosa")
            End If
            If Not IsDBNull(dr("vc_diagnosa")) Then
                Me.TxtDiagnosa.Text = dr("vc_diagnosa")
            End If
            If Not IsDBNull(dr("dt_vena_pasang")) Then
                Me.dateVENAPasang.Text = Format(dr("dt_vena_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_vena_aff")) Then
                Me.dateVENAAff.Text = Format(dr("dt_vena_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari1.Text = dr("in_hari_vena")
            If Not IsDBNull(dr("dt_cvp_pasang")) Then
                Me.dateCVPPasang.Text = Format(dr("dt_cvp_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_cvp_aff")) Then
                Me.dateCVPAff.Text = Format(dr("dt_cvp_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari2.Text = dr("in_hari_cvp")
            If Not IsDBNull(dr("dt_urine_pasang")) Then
                Me.dateUrinePasang.Text = Format(dr("dt_urine_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_urine_aff")) Then
                Me.dateUrineAFF.Text = Format(dr("dt_urine_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari3.Text = dr("in_hari_urine")
            If Not IsDBNull(dr("dt_ett_pasang")) Then
                Me.dateETPasang.Text = Format(dr("dt_ett_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_ett_aff")) Then
                Me.dateETAff.Text = Format(dr("dt_ett_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari4.Text = dr("in_hari_ett")
            If Not IsDBNull(dr("dt_TT_pasang")) Then
                Me.dateTTPasang.Text = Format(dr("dt_TT_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_TT_aff")) Then
                Me.dateTTAff.Text = Format(dr("dt_TT_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari5.Text = dr("in_hari_tt")
            If Not IsDBNull(dr("dt_ventilator_pasang")) Then
                Me.dateVentilatorPasang.Text = Format(dr("dt_ventilator_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_ventilator_aff")) Then
                Me.dateVentilatorAff.Text = Format(dr("dt_ventilator_aff"), "dd/MM/yyyy")
            End If
            Me.TextLamaHari6.Text = dr("in_hari_ventilator")
            If Not IsDBNull(dr("dt_tirah_pasang")) Then
                Me.dateTirahPasang.Text = Format(dr("dt_tirah_pasang"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("dt_tirah_aff")) Then
                Me.dateTirahAff.Text = Format(dr("dt_tirah_aff"), "dd/MM/yyyy")
            End If
            If Not IsDBNull(dr("bt_antibiotika_ya")) Then
                Me.ChkBoxAntiYa.Checked = dr("bt_antibiotika_ya")
            Else
                Me.ChkBoxAntiYa.Checked = False
            End If
            If Not IsDBNull(dr("bt_antibiotika_tidak")) Then
                Me.ChkBoxAntiTidak.Checked = dr("bt_antibiotika_tidak")
            Else
                Me.ChkBoxAntiTidak.Checked = False
            End If
            'add 11 nov TBC
            If Not IsDBNull(dr("bt_tbc_ya")) Then
                Me.ChkBoxYaTBC.Checked = dr("bt_tbc_ya")
            Else
                Me.ChkBoxYaTBC.Checked = False
            End If
            If Not IsDBNull(dr("bt_tbc_tidak")) Then
                Me.ChkBoxTidakTBC.Checked = dr("bt_tbc_tidak")
            Else
                Me.ChkBoxTidakTBC.Checked = False
            End If
            'add 11 nov Hepa
            If Not IsDBNull(dr("bt_hepa_ya")) Then
                Me.ChkBoxYaHepatitis.Checked = dr("bt_hepa_ya")
            Else
                Me.ChkBoxYaHepatitis.Checked = False
            End If
            If Not IsDBNull(dr("bt_hepa_tidak")) Then
                Me.ChkBoxTidakHepatitis.Checked = dr("bt_hepa_tidak")
            Else
                Me.ChkBoxTidakHepatitis.Checked = False
            End If


            'add 11 nov Hiv
            If Not IsDBNull(dr("bt_hiv_ya")) Then
                Me.ChkBoxYaHIV.Checked = dr("bt_hiv_ya")
            Else
                Me.ChkBoxYaHIV.Checked = False
            End If
            If Not IsDBNull(dr("bt_hiv_tidak")) Then
                Me.ChkBoxTidakHIV.Checked = dr("bt_hiv_tidak")
            Else
                Me.ChkBoxTidakHIV.Checked = False
            End If

            If Not IsDBNull(dr("bt_covid_ya")) Then
                Me.chckBoxCovidYa.Checked = dr("bt_covid_ya")
            Else
                Me.chckBoxCovidYa.Checked = False
            End If
            If Not IsDBNull(dr("bt_covid_tidak")) Then
                Me.chckBoxCovidTidak.Checked = dr("bt_covid_tidak")
            Else
                Me.chckBoxCovidTidak.Checked = False
            End If
            'untuk MDRO
            If Not IsDBNull(dr("bt_mdro")) Then
                If (dr("bt_mdro")) = True Then
                    Me.ChkBoxMDROYa.Checked = True
                    Me.ChkBoxMDROTidak.Checked = False

                Else
                    Me.ChkBoxMDROYa.Checked = False
                    Me.ChkBoxMDROTidak.Checked = True
                   
                End If
            Else
                Me.ChkBoxMDROYa.Checked = False
                Me.ChkBoxMDROTidak.Checked = True
            End If

            'spesimen
            If Not IsDBNull(dr("vc_spesimen")) Then
                Me.dropDownSpesimen.SelectedValue = dr("vc_spesimen")
            Else
                Me.dropDownSpesimen.SelectedValue = "0"
            End If


            'bakteri MRSA
            If Not IsDBNull(dr("bt_bakteri_mrsa")) Then
                If (dr("bt_bakteri_mrsa")) = True Then
                    Me.chckBoxMRSA.Checked = True
                Else
                    Me.chckBoxMRSA.Checked = False
                End If
            Else
               Me.chckBoxMRSA.Checked = False
            End If
            'bakteri MRSE
            If Not IsDBNull(dr("bt_bakteri_mrse")) Then
                If (dr("bt_bakteri_mrse")) = True Then
                    Me.chckBoxMRSE.Checked = True
                Else
                    Me.chckBoxMRSE.Checked = False
                End If
            Else
                Me.chckBoxMRSE.Checked = False
            End If

            'bakteri klebisella
            If Not IsDBNull(dr("bt_bakteri_klebisella")) Then
                If (dr("bt_bakteri_klebisella")) = True Then
                    Me.chckBoxKlebsiella.Checked = True
                Else
                    Me.chckBoxKlebsiella.Checked = False
                End If
            Else
                Me.chckBoxKlebsiella.Checked = False
            End If

            'bakteri Coli
            If Not IsDBNull(dr("bt_bakteri_coli")) Then
                If (dr("bt_bakteri_coli")) = True Then
                    Me.chckBoxColi.Checked = True
                Else
                    Me.chckBoxColi.Checked = False
                End If
            Else
                Me.chckBoxColi.Checked = False
            End If
            'bakteri psedomonas
            If Not IsDBNull(dr("bt_bakteri_psedomonas")) Then
                If (dr("bt_bakteri_psedomonas")) = True Then
                    Me.chckBoxPsedomonas.Checked = True
                Else
                    Me.chckBoxPsedomonas.Checked = False
                End If
            Else
                Me.chckBoxPsedomonas.Checked = False
            End If
            'bakteri MDR
            If Not IsDBNull(dr("bt_bakteri_MDR")) Then
                If (dr("bt_bakteri_MDR")) = True Then
                    Me.chckBoxMDR.Checked = True
                Else
                    Me.chckBoxMDR.Checked = False
                End If
            Else
                Me.chckBoxMDR.Checked = False
            End If

            'bakteri VRE
            If Not IsDBNull(dr("bt_bakteri_VRE")) Then
                If (dr("bt_bakteri_VRE")) = True Then
                    Me.chckBoxVRE.Checked = True
                Else
                    Me.chckBoxVRE.Checked = False
                End If
            Else
                Me.chckBoxVRE.Checked = False
            End If

            'bakteri CRE
            If Not IsDBNull(dr("bt_bakteri_CRE")) Then
                If (dr("bt_bakteri_CRE")) = True Then
                    Me.chckBoxCRE.Checked = True
                Else
                    Me.chckBoxCRE.Checked = False
                End If
            Else
                Me.chckBoxCRE.Checked = False
            End If


            'bakteri MDRTB
            If Not IsDBNull(dr("bt_bakteri_MDRTB")) Then
                If (dr("bt_bakteri_MDRTB")) = True Then
                    Me.chckBoxMDRTB.Checked = True
                Else
                    Me.chckBoxMDRTB.Checked = False
                End If
            Else
                Me.chckBoxMDRTB.Checked = False
            End If
            'tanggal operasi
            If Not IsDBNull(dr("dt_tgl_operasi")) Then
                Me.dateOperasi.Text = Format(dr("dt_tgl_operasi"), "dd/MM/yyyy")
            End If
            'opreasi B
            If Not IsDBNull(dr("bt_operasi_b")) Then
                If (dr("bt_operasi_b")) = True Then
                    Me.chckBoxBOperasi.Checked = True
                Else
                    Me.chckBoxBOperasi.Checked = False
                End If
            Else
                Me.chckBoxBOperasi.Checked = False
            End If
            'operasi BT
            If Not IsDBNull(dr("bt_operasi_bt")) Then
                If (dr("bt_operasi_bt")) = True Then
                    Me.chckBoxBTOperasi.Checked = True
                Else
                    Me.chckBoxBTOperasi.Checked = False
                End If
            Else
                Me.chckBoxBTOperasi.Checked = False
            End If
            'operasi Kbt_operasi_k
            If Not IsDBNull(dr("bt_operasi_k")) Then
                If (dr("bt_operasi_k")) = True Then
                    Me.chckBoxKOperasi.Checked = True
                Else
                    Me.chckBoxKOperasi.Checked = False
                End If
            Else
                Me.chckBoxKOperasi.Checked = False
            End If
            Me.DDLRUANG.SelectedValue = Me.DDLRUANG.Items.FindByText(Me.getNamaRuang(dr("vc_ruang"))).Value
            getNamaKamarFromRuang()
            Try
                Me.DDLKamar.SelectedValue = Me.DDLKamar.Items.FindByText(dr("vc_nama_kamar")).Value
            Catch ex As Exception
                Me.DDLKamar.SelectedValue = ""
            End Try

            ' PESAN(Me.getKodeKamar(dr("vc_nama_kamar")))
            Me.TextLamaHari7.Text = dr("in_hari_tirah")
            'Me.TxtHBSag.Text = dr("vc_HBSag")
            'Me.TxtAntiHCV.Text = dr("vc_antiHCV")
            'Me.TxtAntiHiv.Text = dr("vc_antiHIV")
            'Me.TxtLekosit.Text = dr("vc_lekosit")
            'Me.TxtGDS.Text = dr("vc_GDS")
            'Me.TxtHasilThorax.Text = dr("vc_hasillThorax")

            If Not IsDBNull(dr("dt_infeksi_IDO")) Then
                Me.dateKejIDO.Text = Format(dr("dt_infeksi_IDO"), "dd/MM/yyyy")
            End If
            Me.txtKulturIDO.Text = dr("vc_kultur_IDO")

            If Not IsDBNull(dr("dt_infeksi_ISK")) Then
                Me.dateKejISK.Text = Format(dr("dt_infeksi_ISK"), "dd/MM/yyyy")
            End If
            Me.txtKulturISK.Text = dr("vc_kultur_ISK")

            If Not IsDBNull(dr("dt_infeksi_VAP")) Then
                Me.dateKejVAP.Text = Format(dr("dt_infeksi_VAP"), "dd/MM/yyyy")
            End If
            Me.txtKulturVAP.Text = dr("vc_kultur_VAP")

            If Not IsDBNull(dr("dt_infeksi_HAP")) Then
                Me.dateKejHAP.Text = Format(dr("dt_infeksi_HAP"), "dd/MM/yyyy")
            End If
            Me.txtKulturHAP.Text = dr("vc_kultur_HAP")

            If Not IsDBNull(dr("dt_infeksi_IADP")) Then
                Me.dateKejIADP.Text = Format(dr("dt_infeksi_IADP"), "dd/MM/yyyy")
            End If
            Me.txtKulturIADP.Text = dr("vc_kultur_IADP")

            If Not IsDBNull(dr("dt_infeksi_plebitis")) Then
                Me.dateKejPlebitis.Text = Format(dr("dt_infeksi_plebitis"), "dd/MM/yyyy")
            End If
            Me.txtKulturPlebitis.Text = dr("vc_kultur_plebitis")

            If Not IsDBNull(dr("dt_infeksi_dekubitus")) Then
                Me.dateKejDekubitus.Text = Format(dr("dt_infeksi_dekubitus"), "dd/MM/yyyy")
            End If
            Me.txtKulturDekubitus.Text = dr("vc_kultur_dekubitus")

            Me.txtAntibiotika.Text = dr("vc_antibiotika")
        End While
        dr.Close()
        disabledForm()

        Me.BtnSaveInfeksi.Enabled = False
    End Sub

    Protected Sub dateVENAPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVENAPasang.TextChanged
        If (Me.dateVENAPasang.Text.Length > 0 And Me.dateVENAAff.Text.Length > 0) Then
            Me.TextLamaHari1.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVENAPasang.Text)), CDate(MasterLib.xDate(dateVENAAff.Text))) + 1
        Else
            Me.TextLamaHari1.Text = 0
        End If
    End Sub

    Protected Sub dateVENAAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVENAAff.TextChanged
        If (Me.dateVENAPasang.Text.Length > 0 And Me.dateVENAAff.Text.Length > 0) Then
            Me.TextLamaHari1.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVENAPasang.Text)), CDate(MasterLib.xDate(dateVENAAff.Text))) + 1
        Else
            Me.TextLamaHari1.Text = 0
        End If
    End Sub

    Protected Sub DateCVPPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateCVPPasang.TextChanged
        If (Me.dateCVPPasang.Text.Length > 0 And Me.dateCVPAff.Text.Length > 0) Then
            Me.TextLamaHari2.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateCVPPasang.Text)), CDate(MasterLib.xDate(dateCVPAff.Text))) + 1
        Else
            Me.TextLamaHari2.Text = 0
        End If
    End Sub

    Protected Sub DateCVPAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateCVPAff.TextChanged
        If (Me.dateCVPPasang.Text.Length > 0 And Me.dateCVPAff.Text.Length > 0) Then
            Me.TextLamaHari2.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateCVPPasang.Text)), CDate(MasterLib.xDate(dateCVPAff.Text))) + 1
        Else
            Me.TextLamaHari2.Text = 0
        End If
    End Sub

    Protected Sub dateUrinePasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateUrinePasang.TextChanged
        If (Me.dateUrinePasang.Text.Length > 0 And Me.dateUrineAFF.Text.Length > 0) Then
            Me.TextLamaHari3.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateUrinePasang.Text)), CDate(MasterLib.xDate(dateUrineAFF.Text))) + 1
        Else
            Me.TextLamaHari3.Text = 0
        End If
    End Sub

    Protected Sub dateUrineAFF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateUrineAFF.TextChanged
        If (Me.dateUrinePasang.Text.Length > 0 And Me.dateUrineAFF.Text.Length > 0) Then
            Me.TextLamaHari3.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateUrinePasang.Text)), CDate(MasterLib.xDate(dateUrineAFF.Text))) + 1
        Else
            Me.TextLamaHari3.Text = 0
        End If
    End Sub

    Protected Sub dateETPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateETPasang.TextChanged
        If (Me.dateETPasang.Text.Length > 0 And Me.dateETAff.Text.Length > 0) Then
            Me.TextLamaHari4.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateETPasang.Text)), CDate(MasterLib.xDate(dateETAff.Text))) + 1
        Else
            Me.TextLamaHari4.Text = 0
        End If
    End Sub

    Protected Sub dateETAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateETAff.TextChanged
        If (Me.dateETPasang.Text.Length > 0 And Me.dateETAff.Text.Length > 0) Then
            Me.TextLamaHari4.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateETPasang.Text)), CDate(MasterLib.xDate(dateETAff.Text))) + 1
        Else
            Me.TextLamaHari4.Text = 0
        End If
    End Sub

    Protected Sub dateTTPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTTPasang.TextChanged
        If (Me.dateTTPasang.Text.Length > 0 And Me.dateTTAff.Text.Length > 0) Then
            Me.TextLamaHari5.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTTPasang.Text)), CDate(MasterLib.xDate(dateTTAff.Text))) + 1
        Else
            Me.TextLamaHari5.Text = 0
        End If
    End Sub

    Protected Sub dateTTAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTTAff.TextChanged
        If (Me.dateTTPasang.Text.Length > 0 And Me.dateTTAff.Text.Length > 0) Then
            Me.TextLamaHari5.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTTPasang.Text)), CDate(MasterLib.xDate(dateTTAff.Text))) + 1
        Else
            Me.TextLamaHari5.Text = 0
        End If
    End Sub

    Protected Sub dateVentilatorPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVentilatorPasang.TextChanged
        If (Me.dateVentilatorPasang.Text.Length > 0 And Me.dateVentilatorAff.Text.Length > 0) Then
            Me.TextLamaHari6.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVentilatorPasang.Text)), CDate(MasterLib.xDate(dateVentilatorAff.Text))) + 1
        Else
            Me.TextLamaHari6.Text = 0
        End If
    End Sub

    Protected Sub dateVentilatorAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVentilatorAff.TextChanged
        If (Me.dateVentilatorPasang.Text.Length > 0 And Me.dateVentilatorAff.Text.Length > 0) Then
            Me.TextLamaHari6.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVentilatorPasang.Text)), CDate(MasterLib.xDate(dateVentilatorAff.Text))) + 1
        Else
            Me.TextLamaHari6.Text = 0
        End If
    End Sub

    Protected Sub dateTirahPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTirahPasang.TextChanged
        If (Me.dateTirahPasang.Text.Length > 0 And Me.dateTirahAff.Text.Length > 0) Then
            Me.TextLamaHari7.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTirahPasang.Text)), CDate(MasterLib.xDate(dateTirahAff.Text))) + 1
        Else
            Me.TextLamaHari7.Text = 0
        End If
    End Sub

    Protected Sub dateTirahAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTirahAff.TextChanged
        If (Me.dateTirahPasang.Text.Length > 0 And Me.dateTirahAff.Text.Length > 0) Then
            Me.TextLamaHari7.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTirahPasang.Text)), CDate(MasterLib.xDate(dateTirahAff.Text))) + 1
        Else
            Me.TextLamaHari7.Text = 0
        End If
    End Sub
    'check data surveilans infeksi sudah ada belum
    Function checkSurInfeksiExists(ByVal Transaction_id As Integer, ByVal noRm As String, ByVal noReg As String) As Boolean

        Dim strsql As String = ""
        Dim dataExists As Boolean = False
        strsql = "SELECT vc_no_rm,vc_no_reg FROM  Inos_Surveilans_Infeksi where  transaction_id = '" & Transaction_id & "' and vc_no_rm = '" & noRm & "' and vc_no_reg = '" & noReg & "'"

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            dataExists = True
            Exit While
        End While
        dr.Close()
        Return dataExists
    End Function

    'untuk menyimpan data survelians 
    Function simpanData() As Boolean

        Dim strsql As String = ""
        Dim Period As String = Me.ddlbulan.Text & "-" & Me.TxtTahun.Text
        Dim hasilMDRO As Boolean
        If (ChkBoxMDROYa.Checked) Then
            hasilMDRO = True
        End If
        If (ChkBoxMDROTidak.Checked) Then
            hasilMDRO = False
        End If
        simpanData = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans
        Try
            If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg")) = True) Then
                strsql = "update Inos_Surveilans_Infeksi set " & _
                                    "  vc_ruang = '" & Me.DDLRUANG.SelectedValue & "' " & _
                                    ", vc_nama_kamar = '" & Me.DDLKamar.SelectedItem.Text & "' " & _
                                    ", vc_period = '" & Period & "' " & _
                                    ", vc_diagnosa = '" & Me.TxtDiagnosa.Text & "' " & _
                                    ", dt_vena_pasang = '" & convertDateInput(Me.dateVENAPasang.Text) & "' " & _
                                    ", dt_vena_aff = '" & convertDateInput(Me.dateVENAAff.Text) & "' " & _
                                    ", in_hari_vena = '" & (Me.TextLamaHari1.Text) & "' " & _
                                    ", dt_cvp_pasang = '" & convertDateInput(Me.dateCVPPasang.Text) & "' " & _
                                    ", dt_cvp_aff = '" & convertDateInput(Me.dateCVPAff.Text) & "' " & _
                                    ", in_hari_cvp = '" & Me.TextLamaHari2.Text & "' " & _
                                    ", dt_urine_pasang = '" & convertDateInput(Me.dateUrinePasang.Text) & "' " & _
                                    ", dt_urine_aff = '" & convertDateInput(Me.dateUrineAFF.Text) & "' " & _
                                    ", in_hari_urine = '" & Me.TextLamaHari3.Text & "' " & _
                                    ", dt_ett_pasang = '" & convertDateInput(Me.dateETPasang.Text) & "' " & _
                                    ", dt_ett_aff = '" & convertDateInput(Me.dateETAff.Text) & "' " & _
                                    ", in_hari_ett = '" & Me.TextLamaHari4.Text & "' " & _
                                    ", dt_TT_pasang = '" & convertDateInput(Me.dateTTPasang.Text) & "' " & _
                                    ", dt_TT_aff = '" & convertDateInput(Me.dateTTAff.Text) & "' " & _
                                    ", in_hari_TT = '" & Me.TextLamaHari5.Text & "' " & _
                                    ", dt_ventilator_pasang = '" & convertDateInput(Me.dateVentilatorPasang.Text) & "' " & _
                                    ", dt_ventilator_aff = '" & convertDateInput(Me.dateVentilatorAff.Text) & "' " & _
                                    ", in_hari_ventilator = '" & Me.TextLamaHari6.Text & "' " & _
                                    ", dt_tirah_pasang = '" & convertDateInput(Me.dateTirahPasang.Text) & "' " & _
                                    ", dt_tirah_aff = '" & convertDateInput(Me.dateTirahAff.Text) & "' " & _
                                    ", in_hari_tirah = '" & Me.TextLamaHari7.Text & "' " & _
                                    ", dt_infeksi_IDO = '" & convertDateInput(Me.dateKejIDO.Text) & "' " & _
                                    ", vc_kultur_IDO = '" & Me.txtKulturIDO.Text & "' " & _
                                    ", dt_infeksi_ISK = '" & convertDateInput(Me.dateKejISK.Text) & "' " & _
                                    ", vc_kultur_ISK = '" & Me.txtKulturISK.Text & "' " & _
                                    ", dt_infeksi_VAP = '" & convertDateInput(Me.dateKejVAP.Text) & "' " & _
                                    ", vc_kultur_VAP = '" & Me.txtKulturVAP.Text & "' " & _
                                    ", dt_infeksi_HAP = '" & convertDateInput(Me.dateKejHAP.Text) & "' " & _
                                    ", vc_kultur_HAP = '" & Me.txtKulturHAP.Text & "' " & _
                                    ", dt_infeksi_IADP = '" & convertDateInput(Me.dateKejIADP.Text) & "' " & _
                                    ", vc_kultur_IADP = '" & Me.txtKulturIADP.Text & "' " & _
                                    ", dt_infeksi_plebitis = '" & convertDateInput(Me.dateKejPlebitis.Text) & "' " & _
                                    ", vc_kultur_plebitis = '" & Me.txtKulturPlebitis.Text & "' " & _
                                    ", dt_infeksi_dekubitus = '" & convertDateInput(Me.dateKejDekubitus.Text) & "' " & _
                                    ", vc_kultur_dekubitus = '" & Me.txtKulturDekubitus.Text & "' " & _
                                    ", vc_antibiotika = '" & Me.txtAntibiotika.Text & "' " & _
                                    ", bt_antibiotika_ya = '" & Me.ChkBoxAntiYa.Checked & "' " & _
                                    ", bt_antibiotika_tidak = '" & Me.ChkBoxAntiTidak.Checked & "' " & _
                                    ", bt_tbc_ya = '" & Me.ChkBoxYaTBC.Checked & "' " & _
                                    ", bt_tbc_tidak = '" & Me.ChkBoxTidakTBC.Checked & "' " & _
                                    ", bt_hepa_ya = '" & Me.ChkBoxYaHepatitis.Checked & "' " & _
                                    ", bt_hepa_tidak = '" & Me.ChkBoxTidakHepatitis.Checked & "' " & _
                                    ", bt_hiv_ya = '" & Me.ChkBoxYaHIV.Checked & "' " & _
                                    ", bt_hiv_tidak = '" & Me.ChkBoxTidakHIV.Checked & "' " & _
                                    ", bt_covid_ya = '" & Me.chckBoxCovidYa.Checked & "' " & _
                                    ", bt_covid_tidak = '" & Me.chckBoxCovidTidak.Checked & "' " & _
                                    ", bt_mdro = '" & hasilMDRO & "' " & _
                                    ", vc_spesimen = '" & Me.dropDownSpesimen.SelectedValue & "' " & _
                                    ", bt_bakteri_mrsa = '" & Me.chckBoxMRSA.Checked & "' " & _
                                    ", bt_bakteri_mrse = '" & Me.chckBoxMRSE.Checked & "' " & _
                                    ", bt_bakteri_klebisella = '" & Me.chckBoxKlebsiella.Checked & "' " & _
                                    ", bt_bakteri_coli = '" & Me.chckBoxColi.Checked & "' " & _
                                    ", bt_bakteri_psedomonas = '" & Me.chckBoxPsedomonas.Checked & "' " & _
                                    ", bt_bakteri_MDR = '" & Me.chckBoxMDR.Checked & "' " & _
                                    ", bt_bakteri_VRE = '" & Me.chckBoxVRE.Checked & "' " & _
                                    ", bt_bakteri_CRE = '" & Me.chckBoxCRE.Checked & "' " & _
                                    ", bt_bakteri_MDRTB = '" & Me.chckBoxMDRTB.Checked & "' " & _
                                    ", dt_tgl_operasi = '" & convertDateInput(Me.dateOperasi.Text) & "' " & _
                                    ", bt_operasi_b = '" & Me.chckBoxBOperasi.Checked & "' " & _
                                    ", bt_operasi_bt ='" & Me.chckBoxBTOperasi.Checked & "' " & _
                                    ", bt_operasi_k ='" & Me.chckBoxKOperasi.Checked & "' " & _
                                    ", vc_last_updated_by = '" & Session("ssUserName") & "' " & _
                                    ", dt_last_update_date = '" & MasterLib.GetCurrentDate & "' " & _
                                    " where transaction_id =  '" & Request.QueryString("transactionId") & "' and vc_no_rm = '" & Request.QueryString("noRM") & "' and vc_no_reg = '" & Request.QueryString("noReg") & "'; "
            End If
            If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg")) = False) Then
                strsql = "insert into Inos_Surveilans_Infeksi (vc_no_rm ,vc_no_reg,vc_period,vc_ruang,vc_nama_kamar,vc_diagnosa,dt_vena_pasang,dt_vena_aff,in_hari_vena, " & _
                                    "dt_cvp_pasang,dt_cvp_aff,in_hari_cvp,dt_urine_pasang,dt_urine_aff,in_hari_urine,dt_ett_pasang,dt_ett_aff,in_hari_ett,dt_TT_pasang,dt_TT_aff,in_hari_TT, " & _
                                    "dt_ventilator_pasang,dt_ventilator_aff ,in_hari_ventilator, " & _
                                    "dt_tirah_pasang ,dt_tirah_aff,in_hari_tirah, " & _
                                    "dt_infeksi_IDO ,vc_kultur_IDO,dt_infeksi_ISK,vc_kultur_ISK,dt_infeksi_VAP,vc_kultur_VAP, " & _
                                    "dt_infeksi_HAP,vc_kultur_HAP,dt_infeksi_IADP,vc_kultur_IADP,dt_infeksi_plebitis,vc_kultur_plebitis,dt_infeksi_dekubitus,vc_kultur_dekubitus, " & _
                                    "bt_tbc_ya,bt_tbc_tidak,bt_hepa_ya,bt_hepa_tidak,bt_hiv_ya,bt_hiv_tidak,bt_covid_ya,bt_covid_tidak, " & _
                                    "vc_antibiotika,bt_antibiotika_ya,bt_antibiotika_tidak,vc_create_by,dt_create_date,vc_last_updated_by,dt_last_update_date," & _
                                    "[bt_mdro],[vc_spesimen],[bt_bakteri_mrsa],[bt_bakteri_mrse],[bt_bakteri_klebisella],[bt_bakteri_coli],[bt_bakteri_psedomonas],  " & _
                                    "[bt_bakteri_MDR],[bt_bakteri_VRE],[bt_bakteri_CRE],[bt_bakteri_MDRTB],[dt_tgl_operasi],[bt_operasi_b],[bt_operasi_bt],[bt_operasi_k]) " & _
                                                        " values " & _
                                   "('" & Request.QueryString("noRM") & "','" & Request.QueryString("noReg") & "','" & Period & "','" & (Me.DDLRUANG.SelectedValue) & "','" & Me.DDLKamar.SelectedItem.Text & "','" & Me.TxtDiagnosa.Text & "' " & _
                                   ",'" & convertDateInput(dateVENAPasang.Text) & "','" & convertDateInput(dateVENAAff.Text) & "','" & Me.TextLamaHari1.Text & "' " & _
                                   ",'" & convertDateInput(dateCVPPasang.Text) & "','" & convertDateInput(dateCVPAff.Text) & "','" & Me.TextLamaHari2.Text & "' " & _
                                   ",'" & convertDateInput(dateUrinePasang.Text) & "','" & convertDateInput(dateUrineAFF.Text) & "','" & Me.TextLamaHari3.Text & "' " & _
                                   ",'" & convertDateInput(dateETPasang.Text) & "','" & convertDateInput(dateETAff.Text) & "','" & Me.TextLamaHari4.Text & "' " & _
                                   ",'" & convertDateInput(dateTTPasang.Text) & "','" & convertDateInput(dateTTAff.Text) & "','" & Me.TextLamaHari5.Text & "' " & _
                                   ",'" & convertDateInput(dateVentilatorPasang.Text) & "','" & convertDateInput(dateVentilatorAff.Text) & "','" & Me.TextLamaHari6.Text & "' " & _
                                    ",'" & convertDateInput(dateTirahPasang.Text) & "','" & convertDateInput(dateTirahAff.Text) & "','" & Me.TextLamaHari7.Text & "' " & _
                                    ",'" & convertDateInput(Me.dateKejIDO.Text) & "','" & Me.txtKulturIDO.Text & "','" & convertDateInput(Me.dateKejISK.Text) & "','" & Me.txtKulturISK.Text & "','" & convertDateInput(Me.dateKejVAP.Text) & "','" & Me.txtKulturVAP.Text & "' " & _
                                    ",'" & convertDateInput(Me.dateKejHAP.Text) & "','" & Me.txtKulturHAP.Text & "','" & convertDateInput(Me.dateKejIADP.Text) & "','" & Me.txtKulturIADP.Text & "','" & convertDateInput(Me.dateKejPlebitis.Text) & "','" & Me.txtKulturPlebitis.Text & "','" & convertDateInput(Me.dateKejDekubitus.Text) & "','" & Me.txtKulturDekubitus.Text & "' " & _
                                    ",'" & Me.ChkBoxYaTBC.Checked & "','" & Me.ChkBoxTidakTBC.Checked & "','" & Me.ChkBoxYaHepatitis.Checked & "','" & Me.ChkBoxTidakHepatitis.Checked & "','" & Me.ChkBoxYaHIV.Checked & "','" & Me.ChkBoxTidakHIV.Checked & "','" & Me.chckBoxCovidYa.Checked & "','" & Me.chckBoxCovidTidak.Checked & "' " & _
                                    ",'" & Me.txtAntibiotika.Text & "','" & Me.ChkBoxAntiYa.Checked & "','" & Me.ChkBoxAntiTidak.Checked & "','" & Session("ssUserName") & "','" & MasterLib.GetCurrentDate & "','" & Session("ssUserName") & "','" & MasterLib.GetCurrentDate & "'" & _
                                     ",'" & hasilMDRO & "','" & Me.dropDownSpesimen.SelectedValue & "','" & Me.chckBoxMRSA.Checked & "','" & Me.chckBoxMRSE.Checked & "','" & Me.chckBoxKlebsiella.Checked & "','" & Me.chckBoxColi.Checked & "','" & Me.chckBoxPsedomonas.Checked & "'" & _
                                    ",'" & Me.chckBoxMDR.Checked & "','" & Me.chckBoxVRE.Checked & "','" & Me.chckBoxCRE.Checked & "','" & Me.chckBoxMDRTB.Checked & "','" & convertDateInput(Me.dateOperasi.Text) & "','" & Me.chckBoxBOperasi.Checked & "','" & Me.chckBoxBTOperasi.Checked & "','" & Me.chckBoxKOperasi.Checked & "');Select SCOPE_IDENTITY() "



            End If

            command.CommandText = strsql
            command.CommandType = CommandType.Text
            trans_id = command.ExecuteScalar()
            MyTrans.Commit()
            simpanData = True

        Catch ex As Exception
            MyTrans.Rollback()
            simpanData = False
            Throw New Exception("Error: ", ex)
        End Try


    End Function
    Private Function controlCheckBoxBateri(ByVal condition As Boolean)
        Me.chckBoxMRSA.Enabled = condition
        Me.chckBoxMRSE.Enabled = condition
        Me.chckBoxKlebsiella.Enabled = condition
        Me.chckBoxColi.Enabled = condition
        Me.chckBoxPsedomonas.Enabled = condition
        Me.chckBoxMDR.Enabled = condition
        Me.chckBoxVRE.Enabled = condition
        Me.chckBoxCRE.Enabled = condition
        Me.chckBoxMDRTB.Enabled = condition
      
    End Function
    Private Function convertDateInput(ByVal tanggal As String) As Date
        Dim tanggal_return As Date
        If (tanggal.Length > 0) Then
            tanggal_return = CDate(MasterLib.xDate(tanggal))
        Else
            tanggal_return = Nothing
        End If
        Return tanggal_return
    End Function
    Protected Sub BtnSaveInfeksi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveInfeksi.Click
        If (Me.DDLRUANG.SelectedItem.Value = "---") Then
            PESAN("Mohon Pilih Ruangan")
        ElseIf (Me.DDLKamar.SelectedItem.Value.Length = 0 Or Me.DDLKamar.SelectedItem.Value = "---") Then
            PESAN("Mohon Pilih Kamar")
        Else
            Dim saveData As Boolean
            saveData = simpanData()
            If (saveData) Then
                PESAN("Data Berhasil Disimpan")
                If (trans_id > 0) Then
                    Response.Redirect("~/FormInputSurveilansInfeksi.aspx?transactionId=" & trans_id & "&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))
                Else
                    bindDataExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))
                End If
            Else
                PESAN(Pesan_gagal)
            End If
        End If

    End Sub

    Private Function getKodeRuang(ByVal ruang As String) As String
        Dim ruang_return As String = ""
        Dim strsql As String = ""
        strsql = "SELECT vc_k_ruang " & _
                 " FROM RMRuang where upper(vc_n_ruang) = UPPER('" & ruang & "') "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            ruang_return = dr("vc_k_ruang")
        End While
        dr.Close()

        Return ruang_return
    End Function


    Private Function getNamaRuang(ByVal ruang As String) As String
        Dim ruang_return As String = ""
        Dim strsql As String = ""
        strsql = "SELECT vc_n_ruang " & _
                 " FROM RMRuang where upper(vc_k_ruang) = UPPER('" & ruang & "') "

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

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

   

    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg")) = True) Then
            enabledForm()
            Me.BtnSaveInfeksi.Enabled = True
        Else
            PESAN("Tidak bisa edit data, karena blm ada data tersimpan!!")
        End If


    End Sub

    Protected Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormSearchingInputSurveilans.aspx")
    End Sub

    Protected Sub DDLRUANG_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLRUANG.SelectedIndexChanged
      getNamaKamarFromRuang()
    End Sub

    Protected Sub getNamaKamarFromRuang()
        Dim kode_ruang As String = DDLRUANG.SelectedValue.ToString()
        With Me.DDLKamar
            .DataSource = FillKamar(kode_ruang)
            .DataValueField = "vc_no_bed"
            .DataTextField = "vc_nama"
            .DataBind()
        End With
        DDLKamar.Items.Insert(0, New ListItem("---", "---"))
    End Sub


    Private Function FillKamar(ByVal kode_ruang As String) As DataSet
        Dim strSQL As String = ""
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        strSQL = "SELECT vc_no_bed ,vc_nama FROM RMKamar where vc_k_gugus = '" & kode_ruang & "'"


        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim conn As New SqlConnection(connectionString)
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand(strSQL, conn)
        da.SelectCommand = comm
        da.Fill(ds)
        conn.Close()
        Return ds
    End Function


    Private Function getKodeKamar(ByVal kamar As String) As String
        Dim kamar_return As String = ""
        Dim strsql As String = ""
        strsql = "SELECT vc_no_bed " & _
                 " FROM RMKamar where upper(vc_nama) = UPPER('" & kamar & "') "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            kamar_return = dr("vc_no_bed")
        End While
        dr.Close()

        Return kamar_return
    End Function

    Protected Sub LinkButtonIADP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonIADP.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringIADP.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub LinkButtonISK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonISK.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringISK.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub LinkButtonVAP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonVAP.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringVAP.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub LinkButtonHAP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonHAP.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringHAP.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub LinkButtonPLE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonPLE.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringPlebitis.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))

    End Sub

    Protected Sub LinkButtonIDO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonIDO.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringIDO.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub LinkButtonDekubitus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonDekubitus.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormMonitoringDekubitus.aspx?transactionId=" + Request.QueryString("transactionId") + "&noRM=" + Request.QueryString("noRM") + "&noReg=" + Request.QueryString("noReg"))
    End Sub

    Protected Sub BtnHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If String.IsNullOrEmpty(Request.QueryString("transactionId")) Then
            PESAN("Tidak Ada Data yang dihapus!...")
        Else
            Dim strsql As String = ""
            Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim command As SqlCommand = New SqlCommand()
            Dim MyTrans As SqlTransaction
            connection.Open()
            command.Connection = connection
            MyTrans = connection.BeginTransaction()
            command.Transaction = MyTrans
            Try
                If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg")) = True) Then
                    strsql = "update Inos_Surveilans_Infeksi set " & _
                                        " bt_hapus = 1 " & _
                                        " where transaction_id =  '" & Request.QueryString("transactionId") & "' and vc_no_rm = '" & Request.QueryString("noRM") & "' and vc_no_reg = '" & Request.QueryString("noReg") & "'; "

                End If

                command.CommandText = strsql
                command.CommandType = CommandType.Text
                trans_id = command.ExecuteScalar()
                MyTrans.Commit()
                PESAN("Data Berhasil dihapus!...")
                Session("urlback") = Request.Url.ToString
                Response.Redirect("~/FormSearchingInputSurveilans.aspx")
            Catch ex As Exception
                MyTrans.Rollback()
                Throw New Exception("Error: ", ex)
            End Try
        End If

        

    End Sub

    Private Sub DeleteAllData()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim strsql As String = ""
        Try
            strsql = "delete from IBSLaporanOperasi where vc_no_trans = '" & Request.QueryString("pNoTrans") & "'"

            connection.Open()
            command.Connection = connection
            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()
            PESAN("Data Berhasil dihapus!...")

            Response.Redirect("~/Datapasien.aspx")

        Catch ex As Exception
            'MyTrans.Rollback()
            PESAN("Data Gagal dihapus!...")
        End Try
    End Sub

    Protected Sub ChkBoxYaHIV_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxYaHIV.CheckedChanged
        If (ChkBoxYaHIV.Checked = True) Then
            ChkBoxTidakHIV.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxTidakHIV_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxTidakHIV.CheckedChanged
        If (ChkBoxTidakHIV.Checked = True) Then
            ChkBoxYaHIV.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxYaTBC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxYaTBC.CheckedChanged
        If (ChkBoxYaTBC.Checked = True) Then
            ChkBoxTidakTBC.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxTidakTBC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxTidakTBC.CheckedChanged
        If (ChkBoxTidakTBC.Checked = True) Then
            ChkBoxYaTBC.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxYaHepatitis_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxYaHepatitis.CheckedChanged
        If (ChkBoxYaHepatitis.Checked = True) Then
            ChkBoxTidakHepatitis.Checked = False
        End If
    End Sub
    Protected Sub ChkBoxTidakHepatitis_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxTidakHepatitis.CheckedChanged
        If (ChkBoxTidakHepatitis.Checked = True) Then
            ChkBoxYaHepatitis.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxAntiTidak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxAntiTidak.CheckedChanged
        If (ChkBoxAntiTidak.Checked = True) Then
            ChkBoxAntiYa.Checked = False
        End If
    End Sub


    Protected Sub ChkBoxAntiYa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxAntiYa.CheckedChanged
        If (ChkBoxAntiYa.Checked = True) Then
            ChkBoxAntiTidak.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxMDROYa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxMDROYa.CheckedChanged
        If (ChkBoxMDROYa.Checked = True) Then
            ChkBoxMDROTidak.Checked = False
            dropDownSpesimen.Enabled = True
            controlCheckBoxBateri(True)
        Else
            ChkBoxMDROTidak.Checked = True
            dropDownSpesimen.Enabled = False
            dropDownSpesimen.SelectedValue = "0"
            controlCheckBoxBateri(False)
            Me.ChkBoxMDROYa.Checked = False
            Me.ChkBoxMDROTidak.Checked = True
            Me.chckBoxMRSA.Checked = False
            Me.chckBoxMRSE.Checked = False
            Me.chckBoxKlebsiella.Checked = False
            Me.chckBoxColi.Checked = False
            Me.chckBoxPsedomonas.Checked = False
            Me.chckBoxMDR.Checked = False
            Me.chckBoxVRE.Checked = False
            Me.chckBoxCRE.Checked = False
            Me.chckBoxMDRTB.Checked = False
        End If
    End Sub

    Protected Sub ChkBoxMDROTidak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBoxMDROTidak.CheckedChanged
        If (ChkBoxMDROTidak.Checked = True) Then
            ChkBoxMDROYa.Checked = False
            dropDownSpesimen.Enabled = False
            dropDownSpesimen.SelectedValue = "0"
            controlCheckBoxBateri(False)
            Me.ChkBoxMDROYa.Checked = False
            Me.ChkBoxMDROTidak.Checked = True
            Me.chckBoxMRSA.Checked = False
            Me.chckBoxMRSE.Checked = False
            Me.chckBoxKlebsiella.Checked = False
            Me.chckBoxColi.Checked = False
            Me.chckBoxPsedomonas.Checked = False
            Me.chckBoxMDR.Checked = False
            Me.chckBoxVRE.Checked = False
            Me.chckBoxCRE.Checked = False
            Me.chckBoxMDRTB.Checked = False
        Else
            dropDownSpesimen.Enabled = True
            ChkBoxMDROYa.Checked = True
            controlCheckBoxBateri(True)
        End If
    End Sub

    Protected Sub chckBoxCovidYa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If (chckBoxCovidYa.Checked = True) Then
            chckBoxCovidTidak.Checked = False
        End If
    End Sub

    Protected Sub chckBoxCovidTidak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If (chckBoxCovidTidak.Checked = True) Then
            chckBoxCovidYa.Checked = False
        End If
    End Sub
End Class
