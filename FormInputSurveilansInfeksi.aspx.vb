Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormInputSurveilansInfeksi
    'Ruswendra 20 sep2017
    Inherits System.Web.UI.Page
    Dim Pesan_gagal As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            loadDataPasien()
            If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))) Then
                bindDataExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))
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
        Me.TxtHasilThorax.Enabled = False
        Me.TxtHBSag.Enabled = False
        Me.TxtAntiHCV.Enabled = False
        Me.TxtAntiHiv.Enabled = False
        Me.TxtLekosit.Enabled = False
        Me.TxtGDS.Enabled = False
        Me.TxtHasilThorax.Enabled = False
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
        Me.TxtHBSag.Enabled = True
        Me.TxtAntiHCV.Enabled = True
        Me.TxtAntiHiv.Enabled = True
        Me.TxtLekosit.Enabled = True
        Me.TxtGDS.Enabled = True
        Me.TxtHasilThorax.Enabled = True
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
        strsql = "SELECT vc_ruang,vc_nama_kamar,vc_diagnosa,cast(NULLIF([dt_vena_pasang],'') AS DATETIME) dt_vena_pasang,cast(NULLIF([dt_vena_aff],'') AS DATETIME) dt_vena_aff,in_hari_vena " & _
           ", cast(NULLIF([dt_cvp_pasang],'') AS DATETIME) dt_cvp_pasang,cast(NULLIF([dt_cvp_aff],'') AS DATETIME) dt_cvp_aff,in_hari_cvp " & _
           ",cast(NULLIF([dt_urine_pasang],'') AS DATETIME) dt_urine_pasang,cast(NULLIF([dt_urine_aff],'') AS DATETIME) dt_urine_aff,in_hari_urine " & _
           ",cast(NULLIF([dt_ett_pasang],'') AS DATETIME) dt_ett_pasang,cast(NULLIF([dt_ett_aff],'') AS DATETIME) dt_ett_aff,in_hari_ett " & _
           ",cast(NULLIF([dt_TT_pasang],'') AS DATETIME) dt_TT_pasang,cast(NULLIF([dt_TT_aff],'') AS DATETIME) dt_TT_aff,in_hari_TT " & _
           ",cast(NULLIF([dt_ventilator_pasang],'') AS DATETIME) dt_ventilator_pasang,cast(NULLIF([dt_ventilator_aff],'') AS DATETIME) dt_ventilator_aff,in_hari_ventilator " & _
           ",cast(NULLIF([dt_tirah_pasang],'') AS DATETIME) dt_tirah_pasang,cast(NULLIF([dt_tirah_aff],'') AS DATETIME) dt_tirah_aff,in_hari_tirah " & _
           ",vc_HBSag, vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax " & _
           ",cast(NULLIF([dt_infeksi_IDO],'') AS DATETIME) dt_infeksi_IDO, vc_kultur_IDO,cast(NULLIF([dt_infeksi_ISK],'') AS DATETIME) dt_infeksi_ISK,vc_kultur_ISK " & _
           ",cast(NULLIF([dt_infeksi_VAP],'') AS DATETIME) dt_infeksi_VAP, vc_kultur_VAP,cast(NULLIF([dt_infeksi_HAP],'') AS DATETIME)dt_infeksi_HAP,vc_kultur_HAP " & _
           ",cast(NULLIF([dt_infeksi_IADP],'') AS DATETIME) dt_infeksi_IADP, vc_kultur_IADP,cast(NULLIF([dt_infeksi_plebitis],'') AS DATETIME) dt_infeksi_plebitis,vc_kultur_plebitis " & _
            ",cast(NULLIF([dt_infeksi_dekubitus],'') AS DATETIME) dt_infeksi_dekubitus, vc_kultur_dekubitus,vc_antibiotika " & _
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
            Me.DDLRUANG.SelectedValue = Me.DDLRUANG.Items.FindByText(Me.getNamaRuang(dr("vc_ruang"))).Value
            getNamaKamarFromRuang()
            Try
                Me.DDLKamar.SelectedValue = Me.DDLKamar.Items.FindByText(dr("vc_nama_kamar")).Value
            Catch ex As Exception
                Me.DDLKamar.SelectedValue = ""
            End Try

            ' PESAN(Me.getKodeKamar(dr("vc_nama_kamar")))
            Me.TextLamaHari7.Text = dr("in_hari_tirah")
            Me.TxtHBSag.Text = dr("vc_HBSag")
            Me.TxtAntiHCV.Text = dr("vc_antiHCV")
            Me.TxtAntiHiv.Text = dr("vc_antiHIV")
            Me.TxtLekosit.Text = dr("vc_lekosit")
            Me.TxtGDS.Text = dr("vc_GDS")
            Me.TxtHasilThorax.Text = dr("vc_hasillThorax")

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
        End If
    End Sub

    Protected Sub dateVENAAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVENAAff.TextChanged
        If (Me.dateVENAPasang.Text.Length > 0 And Me.dateVENAAff.Text.Length > 0) Then
            Me.TextLamaHari1.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVENAPasang.Text)), CDate(MasterLib.xDate(dateVENAAff.Text))) + 1
        End If
    End Sub

    Protected Sub DateCVPPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateCVPPasang.TextChanged
        If (Me.dateCVPPasang.Text.Length > 0 And Me.dateCVPAff.Text.Length > 0) Then
            Me.TextLamaHari2.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateCVPPasang.Text)), CDate(MasterLib.xDate(dateCVPAff.Text))) + 1
        End If
    End Sub

    Protected Sub DateCVPAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateCVPAff.TextChanged
        If (Me.dateCVPPasang.Text.Length > 0 And Me.dateCVPAff.Text.Length > 0) Then
            Me.TextLamaHari2.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateCVPPasang.Text)), CDate(MasterLib.xDate(dateCVPAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateUrinePasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateUrinePasang.TextChanged
        If (Me.dateUrinePasang.Text.Length > 0 And Me.dateUrineAFF.Text.Length > 0) Then
            Me.TextLamaHari3.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateUrinePasang.Text)), CDate(MasterLib.xDate(dateUrineAFF.Text))) + 1
        End If
    End Sub

    Protected Sub dateUrineAFF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateUrineAFF.TextChanged
        If (Me.dateUrinePasang.Text.Length > 0 And Me.dateUrineAFF.Text.Length > 0) Then
            Me.TextLamaHari3.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateUrinePasang.Text)), CDate(MasterLib.xDate(dateUrineAFF.Text))) + 1
        End If
    End Sub

    Protected Sub dateETPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateETPasang.TextChanged
        If (Me.dateETPasang.Text.Length > 0 And Me.dateETAff.Text.Length > 0) Then
            Me.TextLamaHari4.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateETPasang.Text)), CDate(MasterLib.xDate(dateETAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateETAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateETAff.TextChanged
        If (Me.dateETPasang.Text.Length > 0 And Me.dateETAff.Text.Length > 0) Then
            Me.TextLamaHari4.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateETPasang.Text)), CDate(MasterLib.xDate(dateETAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateTTPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTTPasang.TextChanged
        If (Me.dateTTPasang.Text.Length > 0 And Me.dateTTAff.Text.Length > 0) Then
            Me.TextLamaHari5.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTTPasang.Text)), CDate(MasterLib.xDate(dateTTAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateTTAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTTAff.TextChanged
        If (Me.dateTTPasang.Text.Length > 0 And Me.dateTTAff.Text.Length > 0) Then
            Me.TextLamaHari5.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTTPasang.Text)), CDate(MasterLib.xDate(dateTTAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateVentilatorPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVentilatorPasang.TextChanged
        If (Me.dateVentilatorPasang.Text.Length > 0 And Me.dateVentilatorAff.Text.Length > 0) Then
            Me.TextLamaHari6.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVentilatorPasang.Text)), CDate(MasterLib.xDate(dateVentilatorAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateVentilatorAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateVentilatorAff.TextChanged
        If (Me.dateVentilatorPasang.Text.Length > 0 And Me.dateVentilatorAff.Text.Length > 0) Then
            Me.TextLamaHari6.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateVentilatorPasang.Text)), CDate(MasterLib.xDate(dateVentilatorAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateTirahPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTirahPasang.TextChanged
        If (Me.dateTirahPasang.Text.Length > 0 And Me.dateTirahAff.Text.Length > 0) Then
            Me.TextLamaHari7.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTirahPasang.Text)), CDate(MasterLib.xDate(dateTirahAff.Text))) + 1
        End If
    End Sub

    Protected Sub dateTirahAff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTirahAff.TextChanged
        If (Me.dateTirahPasang.Text.Length > 0 And Me.dateTirahAff.Text.Length > 0) Then
            Me.TextLamaHari7.Text = DateDiff(DateInterval.Day, CDate(MasterLib.xDate(dateTirahPasang.Text)), CDate(MasterLib.xDate(dateTirahAff.Text))) + 1
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
                                    ", vc_HBSag = '" & Me.TxtHBSag.Text & "' " & _
                                    ", vc_antiHCV = '" & Me.TxtAntiHCV.Text & "' " & _
                                    ", vc_antiHIV = '" & Me.TxtAntiHiv.Text & "' " & _
                                    ", vc_lekosit = '" & Me.TxtLekosit.Text & "' " & _
                                    ", vc_GDS = '" & Me.TxtGDS.Text & "' " & _
                                    ", vc_hasillThorax = '" & Me.TxtHasilThorax.Text & "' " & _
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
                                    ", vc_last_updated_by = '" & Session("ssUserName") & "' " & _
                                    ", dt_last_update_date = '" & MasterLib.GetCurrentDate & "' " & _
                                    " where transaction_id =  '" & Request.QueryString("transactionId") & "' and vc_no_rm = '" & Request.QueryString("noRM") & "' and vc_no_reg = '" & Request.QueryString("noReg") & "' "
            End If
            If (checkSurInfeksiExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg")) = False) Then
                strsql = "insert into Inos_Surveilans_Infeksi (vc_no_rm ,vc_no_reg,vc_period,vc_ruang,vc_nama_kamar,vc_diagnosa,dt_vena_pasang,dt_vena_aff,in_hari_vena, " & _
                                    "dt_cvp_pasang,dt_cvp_aff,in_hari_cvp,dt_urine_pasang,dt_urine_aff,in_hari_urine,dt_ett_pasang,dt_ett_aff,in_hari_ett,dt_TT_pasang,dt_TT_aff,in_hari_TT, " & _
                                    "dt_ventilator_pasang,dt_ventilator_aff ,in_hari_ventilator, " & _
                                    "dt_tirah_pasang ,dt_tirah_aff,in_hari_tirah, " & _
                                    "vc_HBSag ,vc_antiHCV,vc_antiHIV,vc_lekosit,vc_GDS,vc_hasillThorax, " & _
                                    "dt_infeksi_IDO ,vc_kultur_IDO,dt_infeksi_ISK,vc_kultur_ISK,dt_infeksi_VAP,vc_kultur_VAP, " & _
                                    "dt_infeksi_HAP,vc_kultur_HAP,dt_infeksi_IADP,vc_kultur_IADP,dt_infeksi_plebitis,vc_kultur_plebitis,dt_infeksi_dekubitus,vc_kultur_dekubitus, " & _
                                    "vc_antibiotika,vc_create_by,dt_create_date,vc_last_updated_by,dt_last_update_date) " & _
                                                        " values " & _
                                   "('" & Request.QueryString("noRM") & "','" & Request.QueryString("noReg") & "','" & Period & "','" & (Me.DDLRUANG.SelectedValue) & "','" & Me.DDLKamar.SelectedItem.Text & "','" & Me.TxtDiagnosa.Text & "' " & _
                                   ",'" & convertDateInput(dateVENAPasang.Text) & "','" & convertDateInput(dateVENAAff.Text) & "','" & Me.TextLamaHari1.Text & "' " & _
                                   ",'" & convertDateInput(dateCVPPasang.Text) & "','" & convertDateInput(dateCVPAff.Text) & "','" & Me.TextLamaHari2.Text & "' " & _
                                   ",'" & convertDateInput(dateUrinePasang.Text) & "','" & convertDateInput(dateUrineAFF.Text) & "','" & Me.TextLamaHari3.Text & "' " & _
                                   ",'" & convertDateInput(dateETPasang.Text) & "','" & convertDateInput(dateETAff.Text) & "','" & Me.TextLamaHari4.Text & "' " & _
                                   ",'" & convertDateInput(dateTTPasang.Text) & "','" & convertDateInput(dateTTAff.Text) & "','" & Me.TextLamaHari5.Text & "' " & _
                                   ",'" & convertDateInput(dateVentilatorPasang.Text) & "','" & convertDateInput(dateVentilatorAff.Text) & "','" & Me.TextLamaHari6.Text & "' " & _
                                    ",'" & convertDateInput(dateTirahPasang.Text) & "','" & convertDateInput(dateTirahAff.Text) & "','" & Me.TextLamaHari7.Text & "' " & _
                                    ",'" & Me.TxtHBSag.Text & "','" & Me.TxtAntiHCV.Text & "','" & Me.TxtAntiHiv.Text & "','" & Me.TxtLekosit.Text & "','" & Me.TxtGDS.Text & "','" & Me.TxtHasilThorax.Text & "' " & _
                                    ",'" & convertDateInput(Me.dateKejIDO.Text) & "','" & Me.txtKulturIDO.Text & "','" & convertDateInput(Me.dateKejISK.Text) & "','" & Me.txtKulturISK.Text & "','" & convertDateInput(Me.dateKejVAP.Text) & "','" & Me.txtKulturVAP.Text & "' " & _
                                    ",'" & convertDateInput(Me.dateKejHAP.Text) & "','" & Me.txtKulturHAP.Text & "','" & convertDateInput(Me.dateKejIADP.Text) & "','" & Me.txtKulturIADP.Text & "','" & convertDateInput(Me.dateKejPlebitis.Text) & "','" & Me.txtKulturPlebitis.Text & "','" & convertDateInput(Me.dateKejDekubitus.Text) & "','" & Me.txtKulturDekubitus.Text & "' " & _
                                    ",'" & Me.txtAntibiotika.Text & "','" & Session("ssUserName") & "','" & MasterLib.GetCurrentDate & "','" & Session("ssUserName") & "','" & MasterLib.GetCurrentDate & "')"



            End If

            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            MyTrans.Commit()
            simpanData = True
        Catch ex As Exception
            MyTrans.Rollback()
            simpanData = False
            Throw New Exception("Error: ", ex)
        End Try


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
                bindDataExists(Request.QueryString("transactionId"), Request.QueryString("noRM"), Request.QueryString("noReg"))
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
End Class
