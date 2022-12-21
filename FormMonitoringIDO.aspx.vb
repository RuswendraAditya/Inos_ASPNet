Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormMonitoringHAP
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            GetNamaRuangOp()
            GetTindakanOp()
            getDataHdr()
            getDataPencegahanIDO()
            getDataDiagnosaIDO()
        End If

        'disabledChecklistDay()
    End Sub

    Private Sub disabledChecklistDay()
        Dim day As String = Format(MasterLib.GetCurrentDate(), "dd")
        For i As Integer = 0 To GridView1.Rows.Count - 1
            Dim row As GridViewRow = GridView1.Rows(i)
            If row.RowType = DataControlRowType.DataRow Then
                If (day = "01") Then
                    DirectCast(row.FindControl("chk_tgl_1"), CheckBox).Enabled = True
                End If
                If (day = "02") Then
                    DirectCast(row.FindControl("chk_tgl_2"), CheckBox).Enabled = True
                End If
                If (day = "03") Then
                    DirectCast(row.FindControl("chk_tgl_3"), CheckBox).Enabled = True
                End If
                If (day = "04") Then
                    DirectCast(row.FindControl("chk_tgl_4"), CheckBox).Enabled = True
                End If
                If (day = "05") Then
                    DirectCast(row.FindControl("chk_tgl_5"), CheckBox).Enabled = True
                End If
                If (day = "06") Then
                    DirectCast(row.FindControl("chk_tgl_6"), CheckBox).Enabled = True
                End If
                If (day = "07") Then
                    DirectCast(row.FindControl("chk_tgl_7"), CheckBox).Enabled = True
                End If
                If (day = "08") Then
                    DirectCast(row.FindControl("chk_tgl_8"), CheckBox).Enabled = True
                End If
                If (day = "09") Then
                    DirectCast(row.FindControl("chk_tgl_9"), CheckBox).Enabled = True
                End If
                If (day = "10") Then
                    DirectCast(row.FindControl("chk_tgl_10"), CheckBox).Enabled = True
                End If
                If (day = "11") Then
                    DirectCast(row.FindControl("chk_tgl_11"), CheckBox).Enabled = True
                End If
                If (day = "12") Then
                    DirectCast(row.FindControl("chk_tgl_12"), CheckBox).Enabled = True
                End If
                If (day = "13") Then
                    DirectCast(row.FindControl("chk_tgl_13"), CheckBox).Enabled = True
                End If
                If (day = "14") Then
                    DirectCast(row.FindControl("chk_tgl_14"), CheckBox).Enabled = True
                End If
                If (day = "15") Then
                    DirectCast(row.FindControl("chk_tgl_15"), CheckBox).Enabled = True
                End If
                If (day = "16") Then
                    DirectCast(row.FindControl("chk_tgl_16"), CheckBox).Enabled = True
                End If
                If (day = "17") Then
                    DirectCast(row.FindControl("chk_tgl_17"), CheckBox).Enabled = True
                End If
                If (day = "18") Then
                    DirectCast(row.FindControl("chk_tgl_18"), CheckBox).Enabled = True
                End If
                If (day = "19") Then
                    DirectCast(row.FindControl("chk_tgl_19"), CheckBox).Enabled = True
                End If
                If (day = "20") Then
                    DirectCast(row.FindControl("chk_tgl_20"), CheckBox).Enabled = True
                End If
                If (day = "21") Then
                    DirectCast(row.FindControl("chk_tgl_21"), CheckBox).Enabled = True
                End If
                If (day = "22") Then
                    DirectCast(row.FindControl("chk_tgl_22"), CheckBox).Enabled = True
                End If
                If (day = "23") Then
                    DirectCast(row.FindControl("chk_tgl_23"), CheckBox).Enabled = True
                End If
                If (day = "24") Then
                    DirectCast(row.FindControl("chk_tgl_24"), CheckBox).Enabled = True
                End If
                If (day = "25") Then
                    DirectCast(row.FindControl("chk_tgl_25"), CheckBox).Enabled = True
                End If
                If (day = "26") Then
                    DirectCast(row.FindControl("chk_tgl_26"), CheckBox).Enabled = True
                End If
                If (day = "27") Then
                    DirectCast(row.FindControl("chk_tgl_27"), CheckBox).Enabled = True
                End If
                If (day = "28") Then
                    DirectCast(row.FindControl("chk_tgl_28"), CheckBox).Enabled = True
                End If
                If (day = "29") Then
                    DirectCast(row.FindControl("chk_tgl_29"), CheckBox).Enabled = True
                End If
                If (day = "30") Then
                    DirectCast(row.FindControl("chk_tgl_30"), CheckBox).Enabled = True
                End If
                If (day = "31") Then
                    DirectCast(row.FindControl("chk_tgl_31"), CheckBox).Enabled = True
                End If
            End If
        Next
        For i As Integer = 0 To GridView2.Rows.Count - 1
            Dim row As GridViewRow = GridView2.Rows(i)
            If row.RowType = DataControlRowType.DataRow Then
                If (day = "01") Then
                    DirectCast(row.FindControl("chk_tgl_1_diag"), CheckBox).Enabled = True
                End If
                If (day = "02") Then
                    DirectCast(row.FindControl("chk_tgl_2_diag"), CheckBox).Enabled = True
                End If
                If (day = "03") Then
                    DirectCast(row.FindControl("chk_tgl_3_diag"), CheckBox).Enabled = True
                End If
                If (day = "04") Then
                    DirectCast(row.FindControl("chk_tgl_4_diag"), CheckBox).Enabled = True
                End If
                If (day = "05") Then
                    DirectCast(row.FindControl("chk_tgl_5_diag"), CheckBox).Enabled = True
                End If
                If (day = "06") Then
                    DirectCast(row.FindControl("chk_tgl_6_diag"), CheckBox).Enabled = True
                End If
                If (day = "07") Then
                    DirectCast(row.FindControl("chk_tgl_7_diag"), CheckBox).Enabled = True
                End If
                If (day = "08") Then
                    DirectCast(row.FindControl("chk_tgl_8_diag"), CheckBox).Enabled = True
                End If
                If (day = "09") Then
                    DirectCast(row.FindControl("chk_tgl_9_diag"), CheckBox).Enabled = True
                End If
                If (day = "10") Then
                    DirectCast(row.FindControl("chk_tgl_10_diag"), CheckBox).Enabled = True
                End If
                If (day = "11") Then
                    DirectCast(row.FindControl("chk_tgl_11_diag"), CheckBox).Enabled = True
                End If
                If (day = "12") Then
                    DirectCast(row.FindControl("chk_tgl_12_diag"), CheckBox).Enabled = True
                End If
                If (day = "13") Then
                    DirectCast(row.FindControl("chk_tgl_13_diag"), CheckBox).Enabled = True
                End If
                If (day = "14") Then
                    DirectCast(row.FindControl("chk_tgl_14_diag"), CheckBox).Enabled = True
                End If
                If (day = "15") Then
                    DirectCast(row.FindControl("chk_tgl_15_diag"), CheckBox).Enabled = True
                End If
                If (day = "16") Then
                    DirectCast(row.FindControl("chk_tgl_16_diag"), CheckBox).Enabled = True
                End If
                If (day = "17") Then
                    DirectCast(row.FindControl("chk_tgl_17_diag"), CheckBox).Enabled = True
                End If
                If (day = "18") Then
                    DirectCast(row.FindControl("chk_tgl_18_diag"), CheckBox).Enabled = True
                End If
                If (day = "19") Then
                    DirectCast(row.FindControl("chk_tgl_19_diag"), CheckBox).Enabled = True
                End If
                If (day = "20") Then
                    DirectCast(row.FindControl("chk_tgl_20_diag"), CheckBox).Enabled = True
                End If
                If (day = "21") Then
                    DirectCast(row.FindControl("chk_tgl_21_diag"), CheckBox).Enabled = True
                End If
                If (day = "22") Then
                    DirectCast(row.FindControl("chk_tgl_22_diag"), CheckBox).Enabled = True
                End If
                If (day = "23") Then
                    DirectCast(row.FindControl("chk_tgl_23_diag"), CheckBox).Enabled = True
                End If
                If (day = "24") Then
                    DirectCast(row.FindControl("chk_tgl_24_diag"), CheckBox).Enabled = True
                End If
                If (day = "25") Then
                    DirectCast(row.FindControl("chk_tgl_25_diag"), CheckBox).Enabled = True
                End If
                If (day = "26") Then
                    DirectCast(row.FindControl("chk_tgl_26_diag"), CheckBox).Enabled = True
                End If
                If (day = "27") Then
                    DirectCast(row.FindControl("chk_tgl_27_diag"), CheckBox).Enabled = True
                End If
                If (day = "28") Then
                    DirectCast(row.FindControl("chk_tgl_28_diag"), CheckBox).Enabled = True
                End If
                If (day = "29") Then
                    DirectCast(row.FindControl("chk_tgl_29_diag"), CheckBox).Enabled = True
                End If
                If (day = "30") Then
                    DirectCast(row.FindControl("chk_tgl_30_diag"), CheckBox).Enabled = True
                End If
                If (day = "31") Then
                    DirectCast(row.FindControl("chk_tgl_31_diag"), CheckBox).Enabled = True
                End If
            End If
        Next
    End Sub


    Private Sub getDataHdr()
        Dim strsql As String = ""
        'Monitoring_hdr_id()
        strsql = "SELECT * from Inos_Monitoring_IDO " & _
                 "WHERE  in_transaction_id = '" & Request.QueryString("transactionId") & "'  "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            If IsDBNull(dr("dt_tgl_operasi")) = False Then
                If (Format(dr("dt_tgl_operasi"), "dd/MM/yyyy") = "01/01/1900") Then
                Else
                    txtTglOperasi.Text = Format(dr("dt_tgl_operasi"), "dd/MM/yyyy")
                End If


            End If
            If IsDBNull(dr("in_lama_jam_operasi")) = False Then
                TxtLamaOperasiJam.Text = dr("in_lama_jam_operasi")
            End If
            If IsDBNull(dr("in_lama_menit_operasi")) = False Then
                TxtLamaOperasiMenit.Text = dr("in_lama_menit_operasi")
            End If
            If IsDBNull(dr("bt_elektif")) Then
                ChkBoxElektif.Checked = True
            Else
                If (dr("bt_elektif") = True) Then
                    ChkBoxElektif.Checked = True
                Else
                    ChkBoxElektif.Checked = True
                End If
            End If
            If IsDBNull(dr("bt_cito")) Then
                ChkBoxCito.Checked = True
            Else
                If (dr("bt_cito") = True) Then
                    ChkBoxCito.Checked = True
                Else
                    ChkBoxCito.Checked = True
                End If
            End If
            If IsDBNull(dr("vc_kamar_operasi")) = False Then
                DdRuangOp.SelectedValue = dr("vc_kamar_operasi")
            End If
            If IsDBNull(dr("vc_tindakan")) = False Then
                DdTindakan.SelectedValue = dr("vc_tindakan")
            End If
            If IsDBNull(dr("in_asa_score")) = False Then
                DDAsaScore.SelectedValue = dr("in_asa_score")
            End If
            If IsDBNull(dr("vc_klasifikasi_op")) = False Then
                DDKlasifikasiOp.SelectedValue = dr("vc_klasifikasi_op")
            End If
            If IsDBNull(dr("in_suhu_tubuh")) = False Then
                DDSuhuTubuh.SelectedValue = dr("in_suhu_tubuh")
            End If
            If IsDBNull(dr("vc_albumin")) = False Then
                TxtAlbumin.Text = dr("vc_albumin")
            End If
            If IsDBNull(dr("vc_gula_darah")) = False Then
                TxtGulaDarah.Text = dr("vc_gula_darah")
            End If
            If IsDBNull(dr("bt_merokok")) Then
                DDMerokok.SelectedValue = "Tidak"
            Else
                If (dr("bt_merokok") = True) Then
                    DDMerokok.SelectedValue = "Ya"
                Else
                    DDMerokok.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("bt_peny_lain")) Then
                DDPenyInfeksi.SelectedValue = "Tidak"
            Else
                If (dr("bt_peny_lain") = True) Then
                    DDPenyInfeksi.SelectedValue = "Ya"
                Else
                    DDPenyInfeksi.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("bt_mrsa")) Then
                DDScreeningMRSA.SelectedValue = "Tidak"
            Else
                If (dr("bt_mrsa") = True) Then
                    DDScreeningMRSA.SelectedValue = "Ya"
                Else
                    DDScreeningMRSA.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("vc_pencukuran")) = False Then
                DDPencukuran.SelectedValue = dr("vc_pencukuran")
            End If
            If IsDBNull(dr("vc_waktu_pencukuran")) = False Then
                txtWaktuPencukuran.Text = dr("vc_waktu_pencukuran")
            End If
            If IsDBNull(dr("vc_mandi")) = False Then
                DDMandi.SelectedValue = dr("vc_mandi")
            End If
            If IsDBNull(dr("bt_profilaksis")) Then
                DDProfilaksis.SelectedValue = "Tidak"
            Else
                If (dr("bt_profilaksis") = True) Then
                    DDProfilaksis.SelectedValue = "Ya"
                Else
                    DDProfilaksis.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("vc_sirkulasi_udara")) = False Then
                TxtSirkulasi.Text = dr("vc_sirkulasi_udara")
            End If
            If IsDBNull(dr("vc_kelembapan_udara")) = False Then
                TxtUdara.Text = dr("vc_kelembapan_udara")
            End If
            If IsDBNull(dr("vc_tekanan_udara")) = False Then
                TxtTekanan.Text = dr("vc_tekanan_udara")
            End If
            If IsDBNull(dr("vc_suhu_ruang")) = False Then
                TxtSuhuRuang.Text = dr("vc_suhu_ruang")
            End If
            If IsDBNull(dr("bt_drain")) Then
                DDDrain.SelectedValue = "Tidak"
            Else
                If (dr("bt_drain") = True) Then
                    DDDrain.SelectedValue = "Ya"
                Else
                    DDDrain.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("vc_disinfeksi_kulit")) = False Then
                DDDisinfeksi.SelectedValue = dr("vc_disinfeksi_kulit")
            End If
            If IsDBNull(dr("bt_implant")) Then
                DDImplant.SelectedValue = "Tidak"
            Else
                If (dr("bt_implant") = True) Then
                    DDImplant.SelectedValue = "Ya"
                Else
                    DDImplant.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("in_jumlah_staff")) = False Then
                TxtJumlahStaff.Text = dr("in_jumlah_staff")
            End If
            If IsDBNull(dr("bt_indikator_steril")) Then
                DDIndikator.SelectedValue = "Tidak"
            Else
                If (dr("bt_indikator_steril") = True) Then
                    DDIndikator.SelectedValue = "Ya"
                Else
                    DDIndikator.SelectedValue = "Tidak"
                End If
            End If
            If IsDBNull(dr("bt_superfisal")) Then
                ChkBoxSuperfisal.Checked = False
            Else
                If (dr("bt_superfisal") = True) Then
                    ChkBoxSuperfisal.Checked = True
                Else
                    ChkBoxSuperfisal.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_fascia")) Then
                ChkBoxFascia.Checked = False
            Else
                If (dr("bt_fascia") = True) Then
                    ChkBoxFascia.Checked = True
                Else
                    ChkBoxFascia.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_rongga")) Then
                ChkBoxRongga.Checked = False
            Else
                If (dr("bt_rongga") = True) Then
                    ChkBoxRongga.Checked = True
                Else
                    ChkBoxRongga.Checked = False
                End If
            End If
        End While


    End Sub

    Private Sub getDataPencegahanIDO()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  IDO.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_IDO IDO LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = IDO.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                             "and item.vc_source = trans.vc_source " & _
                             "and IDO.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'IDO' " & _
                             "and vc_type = 'Pencegahan' " & _
                             "order by item.in_sequence asc"
        Else
            strsql = "SELECT IDO.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                     "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'IDO' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_IDO IDO " & _
                     "on IDO.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Pencegahan'  " & _
                     "and item.vc_source = 'IDO' " & _
                     "order by item.in_sequence asc "
        End If


        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
        GridView1.DataBind()
    End Sub


    Private Sub getDataDiagnosaIDO()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData2.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData2.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  IDO.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_IDO IDO LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = IDO.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                             "and item.vc_source = trans.vc_source " & _
                             "and IDO.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'IDO' " & _
                             "and vc_type = 'Diagnosa' " & _
                             "order by item.in_sequence asc"
        Else
            strsql = "SELECT IDO.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                     "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'IDO' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_IDO IDO " & _
                     "on IDO.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Diagnosa'  " & _
                     "and item.vc_source = 'IDO' " & _
                 "order by item.in_sequence asc"
        End If

        SdsData2.SelectCommand = strsql
        GridView2.DataSourceID = SdsData2.ID
        GridView2.DataBind()
    End Sub
    Private Sub GetNamaRuangOp()
        Dim strSQL As String = ""
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)


        strSQL = "Select vc_kd_ruang,vc_nm_ruang FROM IBSRuangOK Order By vc_kd_ruang"

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim conn As New SqlConnection(connectionString)
        conn.Open()
        Dim comm As SqlCommand = New SqlCommand(strSQL, conn)
        da.SelectCommand = comm
        da.Fill(ds)
        conn.Close()

        With Me.DdRuangOp
            .DataSource = ds
            .DataTextField = "vc_nm_ruang"
            .DataValueField = "vc_kd_ruang"
            .DataBind()
        End With
        DdRuangOp.Items.Insert(0, New ListItem("---", "---"))
    End Sub

    Private Sub GetTindakanOp()
        With Me.DdTindakan
            Dim strSQL As String = ""
            Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter("Select vc_kd_jenisOp, vc_jenisOp FROM IBS_JENIS_OP order by vc_jenisOp", con)
            Dim links As DataTable = New DataTable()
            adapter.Fill(links)
            .DataTextField = "vc_jenisOp"
            .DataValueField = "vc_kd_jenisOp"
            .DataSource = links
            .DataBind()
        End With

    End Sub

    Private Function getMonitoringHdrId() As Integer
        Dim strsql As String = ""
        Dim monitoring_hdr_id As Integer = 0
        strsql = "SELECT * from Inos_Monitoring_IDO " & _
                 "WHERE  in_transaction_id = '" & Request.QueryString("transactionId") & "'  "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            monitoring_hdr_id = dr("in_monitoring_id")
        End While
        Return monitoring_hdr_id

    End Function
    Private Sub DeleteOldData()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim deleteSql As String = "DELETE FROM  Inos_Monitoring_trans WHERE  in_monitoring_hdr_id = @monitoring_id and vc_source = @source_id;"
        Dim myCommand As SqlCommand = New SqlCommand(deleteSql, _
           connection)
        myCommand.Parameters.Add(New SqlParameter("@monitoring_id", SqlDbType.Int))
        myCommand.Parameters.Add(New SqlParameter("@source_id", SqlDbType.VarChar))
        myCommand.Parameters("@monitoring_id").Value = getMonitoringHdrId()
        myCommand.Parameters("@source_id").Value = "IDO"
        myCommand.Connection.Open()
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException
        End Try
        myCommand.Connection.Close()
    End Sub


    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Private Sub saveDataPencegahanIDO()
        Dim strsql As String = ""
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans
        For i As Integer = 0 To GridView1.Rows.Count - 1
            Dim row As GridViewRow = GridView1.Rows(i)
            If row.RowType = DataControlRowType.DataRow Then
                Dim vc_kode As String = DirectCast(row.FindControl("lbl_kode"), Label).Text
                Dim tgl_1 As Boolean = DirectCast(row.FindControl("chk_tgl_1"), CheckBox).Checked
                Dim tgl_2 As Boolean = DirectCast(row.FindControl("chk_tgl_2"), CheckBox).Checked
                Dim tgl_3 As Boolean = DirectCast(row.FindControl("chk_tgl_3"), CheckBox).Checked
                Dim tgl_4 As Boolean = DirectCast(row.FindControl("chk_tgl_4"), CheckBox).Checked
                Dim tgl_5 As Boolean = DirectCast(row.FindControl("chk_tgl_5"), CheckBox).Checked
                Dim tgl_6 As Boolean = DirectCast(row.FindControl("chk_tgl_6"), CheckBox).Checked
                Dim tgl_7 As Boolean = DirectCast(row.FindControl("chk_tgl_7"), CheckBox).Checked
                Dim tgl_8 As Boolean = DirectCast(row.FindControl("chk_tgl_8"), CheckBox).Checked
                Dim tgl_9 As Boolean = DirectCast(row.FindControl("chk_tgl_9"), CheckBox).Checked
                Dim tgl_10 As Boolean = DirectCast(row.FindControl("chk_tgl_10"), CheckBox).Checked
                Dim tgl_11 As Boolean = DirectCast(row.FindControl("chk_tgl_11"), CheckBox).Checked
                Dim tgl_12 As Boolean = DirectCast(row.FindControl("chk_tgl_12"), CheckBox).Checked
                Dim tgl_13 As Boolean = DirectCast(row.FindControl("chk_tgl_13"), CheckBox).Checked
                Dim tgl_14 As Boolean = DirectCast(row.FindControl("chk_tgl_14"), CheckBox).Checked
                Dim tgl_15 As Boolean = DirectCast(row.FindControl("chk_tgl_15"), CheckBox).Checked
                Dim tgl_16 As Boolean = DirectCast(row.FindControl("chk_tgl_16"), CheckBox).Checked
                Dim tgl_17 As Boolean = DirectCast(row.FindControl("chk_tgl_17"), CheckBox).Checked
                Dim tgl_18 As Boolean = DirectCast(row.FindControl("chk_tgl_18"), CheckBox).Checked
                Dim tgl_19 As Boolean = DirectCast(row.FindControl("chk_tgl_19"), CheckBox).Checked
                Dim tgl_20 As Boolean = DirectCast(row.FindControl("chk_tgl_20"), CheckBox).Checked
                Dim tgl_21 As Boolean = DirectCast(row.FindControl("chk_tgl_21"), CheckBox).Checked
                Dim tgl_22 As Boolean = DirectCast(row.FindControl("chk_tgl_22"), CheckBox).Checked
                Dim tgl_23 As Boolean = DirectCast(row.FindControl("chk_tgl_23"), CheckBox).Checked
                Dim tgl_24 As Boolean = DirectCast(row.FindControl("chk_tgl_24"), CheckBox).Checked
                Dim tgl_25 As Boolean = DirectCast(row.FindControl("chk_tgl_25"), CheckBox).Checked
                Dim tgl_26 As Boolean = DirectCast(row.FindControl("chk_tgl_26"), CheckBox).Checked
                Dim tgl_27 As Boolean = DirectCast(row.FindControl("chk_tgl_27"), CheckBox).Checked
                Dim tgl_28 As Boolean = DirectCast(row.FindControl("chk_tgl_28"), CheckBox).Checked
                Dim tgl_29 As Boolean = DirectCast(row.FindControl("chk_tgl_29"), CheckBox).Checked
                Dim tgl_30 As Boolean = DirectCast(row.FindControl("chk_tgl_30"), CheckBox).Checked
                Dim tgl_31 As Boolean = DirectCast(row.FindControl("chk_tgl_31"), CheckBox).Checked
                Try
                    strsql = "insert into Inos_Monitoring_Trans (in_monitoring_hdr_id ,vc_kode,vc_source,vc_tgl_1,vc_tgl_2,vc_tgl_3,vc_tgl_4,vc_tgl_5,vc_tgl_6, " & _
                                                       "vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10,vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15, " & _
                                                       "vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20,vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25, " & _
                                                       "vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31) " & _
                                                                           " values " & _
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','IDO','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
                                                      ",'" & tgl_7 & "','" & tgl_8 & "','" & tgl_9 & "','" & tgl_10 & "','" & tgl_11 & "','" & tgl_12 & "','" & tgl_13 & "','" & tgl_14 & "','" & tgl_15 & "' " & _
                                                      ",'" & tgl_16 & "','" & tgl_17 & "','" & tgl_18 & "','" & tgl_19 & "','" & tgl_20 & "','" & tgl_21 & "','" & tgl_22 & "','" & tgl_23 & "','" & tgl_24 & "','" & tgl_25 & "'  " & _
                                                      ",'" & tgl_26 & "','" & tgl_27 & "','" & tgl_28 & "','" & tgl_29 & "','" & tgl_30 & "','" & tgl_31 & "')"



                    command.CommandText = strsql
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MyTrans.Rollback()
                End Try
            End If
        Next
        MyTrans.Commit()
    End Sub

    Private Sub saveDataDiagnosaIDO()
        Dim strsql As String = ""
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans
        Dim i = 0
        For i = 0 To GridView2.Rows.Count - 1
            Dim row As GridViewRow = GridView2.Rows(i)
            If row.RowType = DataControlRowType.DataRow Then
                Dim vc_kode As String = DirectCast(row.FindControl("lbl_kode_diag"), Label).Text
                Dim tgl_1 As Boolean = DirectCast(row.FindControl("chk_tgl_1_diag"), CheckBox).Checked
                Dim tgl_2 As Boolean = DirectCast(row.FindControl("chk_tgl_2_diag"), CheckBox).Checked
                Dim tgl_3 As Boolean = DirectCast(row.FindControl("chk_tgl_3_diag"), CheckBox).Checked
                Dim tgl_4 As Boolean = DirectCast(row.FindControl("chk_tgl_4_diag"), CheckBox).Checked
                Dim tgl_5 As Boolean = DirectCast(row.FindControl("chk_tgl_5_diag"), CheckBox).Checked
                Dim tgl_6 As Boolean = DirectCast(row.FindControl("chk_tgl_6_diag"), CheckBox).Checked
                Dim tgl_7 As Boolean = DirectCast(row.FindControl("chk_tgl_7_diag"), CheckBox).Checked
                Dim tgl_8 As Boolean = DirectCast(row.FindControl("chk_tgl_8_diag"), CheckBox).Checked
                Dim tgl_9 As Boolean = DirectCast(row.FindControl("chk_tgl_9_diag"), CheckBox).Checked
                Dim tgl_10 As Boolean = DirectCast(row.FindControl("chk_tgl_10_diag"), CheckBox).Checked
                Dim tgl_11 As Boolean = DirectCast(row.FindControl("chk_tgl_11_diag"), CheckBox).Checked
                Dim tgl_12 As Boolean = DirectCast(row.FindControl("chk_tgl_12_diag"), CheckBox).Checked
                Dim tgl_13 As Boolean = DirectCast(row.FindControl("chk_tgl_13_diag"), CheckBox).Checked
                Dim tgl_14 As Boolean = DirectCast(row.FindControl("chk_tgl_14_diag"), CheckBox).Checked
                Dim tgl_15 As Boolean = DirectCast(row.FindControl("chk_tgl_15_diag"), CheckBox).Checked
                Dim tgl_16 As Boolean = DirectCast(row.FindControl("chk_tgl_16_diag"), CheckBox).Checked
                Dim tgl_17 As Boolean = DirectCast(row.FindControl("chk_tgl_17_diag"), CheckBox).Checked
                Dim tgl_18 As Boolean = DirectCast(row.FindControl("chk_tgl_18_diag"), CheckBox).Checked
                Dim tgl_19 As Boolean = DirectCast(row.FindControl("chk_tgl_19_diag"), CheckBox).Checked
                Dim tgl_20 As Boolean = DirectCast(row.FindControl("chk_tgl_20_diag"), CheckBox).Checked
                Dim tgl_21 As Boolean = DirectCast(row.FindControl("chk_tgl_21_diag"), CheckBox).Checked
                Dim tgl_22 As Boolean = DirectCast(row.FindControl("chk_tgl_22_diag"), CheckBox).Checked
                Dim tgl_23 As Boolean = DirectCast(row.FindControl("chk_tgl_23_diag"), CheckBox).Checked
                Dim tgl_24 As Boolean = DirectCast(row.FindControl("chk_tgl_24_diag"), CheckBox).Checked
                Dim tgl_25 As Boolean = DirectCast(row.FindControl("chk_tgl_25_diag"), CheckBox).Checked
                Dim tgl_26 As Boolean = DirectCast(row.FindControl("chk_tgl_26_diag"), CheckBox).Checked
                Dim tgl_27 As Boolean = DirectCast(row.FindControl("chk_tgl_27_diag"), CheckBox).Checked
                Dim tgl_28 As Boolean = DirectCast(row.FindControl("chk_tgl_28_diag"), CheckBox).Checked
                Dim tgl_29 As Boolean = DirectCast(row.FindControl("chk_tgl_29_diag"), CheckBox).Checked
                Dim tgl_30 As Boolean = DirectCast(row.FindControl("chk_tgl_30_diag"), CheckBox).Checked
                Dim tgl_31 As Boolean = DirectCast(row.FindControl("chk_tgl_31_diag"), CheckBox).Checked
                Try
                    strsql = "insert into Inos_Monitoring_Trans (in_monitoring_hdr_id ,vc_kode,vc_source,vc_tgl_1,vc_tgl_2,vc_tgl_3,vc_tgl_4,vc_tgl_5,vc_tgl_6, " & _
                                                       "vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10,vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15, " & _
                                                       "vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20,vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25, " & _
                                                       "vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31) " & _
                                                                           " values " & _
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','IDO','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
                                                      ",'" & tgl_7 & "','" & tgl_8 & "','" & tgl_9 & "','" & tgl_10 & "','" & tgl_11 & "','" & tgl_12 & "','" & tgl_13 & "','" & tgl_14 & "','" & tgl_15 & "' " & _
                                                      ",'" & tgl_16 & "','" & tgl_17 & "','" & tgl_18 & "','" & tgl_19 & "','" & tgl_20 & "','" & tgl_21 & "','" & tgl_22 & "','" & tgl_23 & "','" & tgl_24 & "','" & tgl_25 & "'  " & _
                                                      ",'" & tgl_26 & "','" & tgl_27 & "','" & tgl_28 & "','" & tgl_29 & "','" & tgl_30 & "','" & tgl_31 & "')"



                    command.CommandText = strsql
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                Catch ex As Exception
                    ' PESAN(ex.Message.ToString.Substring(0, 30))
                    MyTrans.Rollback()
                End Try
            End If
        Next
        MyTrans.Commit()
    End Sub
    Private Sub SaveHdr()
        Dim strsql As String = ""
        Dim tglOperasi As Date
        Try
            tglOperasi = MasterLib.SqlDate(MasterLib.xDate(Me.txtTglOperasi.Text))
        Catch ex As Exception

        End Try
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans
        Dim merokok As Boolean = False
        Dim Profilaksis As Boolean = False
        Dim ScreeningMRSA As Boolean = False
        Dim PenyInfeksi As Boolean = False
        Dim Drain As Boolean = False
        Dim Implant As Boolean = False
        Dim Indikator As Boolean = False
        PESAN(DDIndikator.SelectedItem.Value.ToString)
        If (DDMerokok.SelectedItem.Value.ToString = "Ya") Then
            merokok = True
        End If
        If (DDProfilaksis.SelectedItem.Value.ToString = "Ya") Then
            Profilaksis = True
        End If
        If (DDScreeningMRSA.SelectedItem.Value.ToString = "Ya") Then
            ScreeningMRSA = True
        End If
        If (DDPenyInfeksi.SelectedItem.Value.ToString = "Ya") Then
            PenyInfeksi = True
        End If
        If (DDDrain.SelectedItem.Value.ToString = "Ya") Then
            Drain = True
        End If
        If (DDImplant.SelectedItem.Value.ToString = "Ya") Then
            Implant = True
        End If
        If (DDIndikator.SelectedItem.Value.ToString = "Ya") Then
            Indikator = True
        End If
        Try
            If (getMonitoringHdrId() <> 0) Then
                strsql = "update Inos_Monitoring_IDO set " & _
                         " dt_tgl_operasi = '" & tglOperasi & "' " & _
                         ",in_lama_jam_operasi = '" & Val(Me.TxtLamaOperasiJam.Text) & "' " & _
                         ",in_lama_menit_operasi = '" & Val(Me.TxtLamaOperasiMenit.Text) & "' " & _
                         ",bt_elektif =    '" & Me.ChkBoxElektif.Checked & "' " & _
                         ",bt_cito =    '" & Me.ChkBoxCito.Checked & "' " & _
                         ", vc_kamar_operasi=    '" & DdRuangOp.SelectedItem.Value.ToString & "' " & _
                         ",  vc_tindakan =    '" & DdTindakan.SelectedItem.Value.ToString & "' " & _
                         ",  in_asa_score =    '" & DDAsaScore.SelectedItem.Value.ToString & "' " & _
                         ",  vc_klasifikasi_op =    '" & DDKlasifikasiOp.SelectedItem.Value.ToString & "' " & _
                         ",  in_suhu_tubuh =    '" & Me.DDSuhuTubuh.SelectedItem.Value.ToString & "' " & _
                         ",  vc_albumin =  '" & TxtAlbumin.Text & "' " & _
                         ",  vc_gula_darah =  '" & TxtGulaDarah.Text & "' " & _
                         ",  bt_merokok =  '" & merokok & "' " & _
                         ",  bt_peny_lain =  '" & PenyInfeksi & "' " & _
                         ",  bt_mrsa =  '" & ScreeningMRSA & "' " & _
                         ",  vc_pencukuran =  '" & DDPencukuran.SelectedItem.Value.ToString & "' " & _
                         ",  vc_waktu_pencukuran =  '" & txtWaktuPencukuran.Text & "' " & _
                         ",  vc_mandi =  '" & DDMandi.SelectedItem.Value.ToString & "' " & _
                         ",  bt_profilaksis =  '" & Profilaksis & "' " & _
                         ",  vc_sirkulasi_udara =  '" & TxtSirkulasi.Text & "' " & _
                         ",  vc_kelembapan_udara =  '" & TxtTekanan.Text & "' " & _
                         ",  vc_tekanan_udara=  '" & TxtTekanan.Text & "' " & _
                         ",  vc_suhu_ruang =  '" & TxtSuhuRuang.Text & "' " & _
                         ",  bt_drain =  '" & Drain & "' " & _
                         ",  vc_disinfeksi_kulit =  '" & DDDisinfeksi.SelectedItem.Value.ToString & "' " & _
                         ",  bt_implant =  '" & Implant & "' " & _
                         ",  in_jumlah_staff =  '" & TxtJumlahStaff.Text & "' " & _
                         ",  bt_indikator_steril=  '" & Indikator & "' " & _
                         ",  bt_superfisal =  '" & ChkBoxSuperfisal.Checked & "' " & _
                         ",  bt_fascia =  '" & ChkBoxFascia.Checked & "' " & _
                         ",  bt_rongga =  '" & ChkBoxRongga.Checked & "' " & _
                         " where in_transaction_id =  '" & Request.QueryString("transactionId") & "' "
            Else
                strsql = "insert into Inos_Monitoring_IDO  (in_transaction_id, dt_tgl_operasi,in_lama_jam_operasi,in_lama_menit_operasi," & _
                                                    "bt_elektif, bt_cito, vc_kamar_operasi, " & _
                                                    "vc_tindakan, in_asa_score, vc_klasifikasi_op, " & _
                                                    "in_suhu_tubuh, vc_albumin, vc_gula_darah, " & _
                                                    "bt_merokok, bt_peny_lain,bt_mrsa, vc_pencukuran, " & _
                                                    "vc_waktu_pencukuran, vc_mandi, bt_profilaksis, " & _
                                                    "vc_sirkulasi_udara, vc_kelembapan_udara, vc_tekanan_udara, " & _
                                                    "vc_suhu_ruang, bt_drain, vc_disinfeksi_kulit, " & _
                                                    "bt_implant, in_jumlah_staff ,bt_indikator_steril, " & _
                                                    "bt_superfisal,  bt_fascia,bt_rongga )  " & _
                                                                        " values " & _
                                                   "('" & Request.QueryString("transactionId") & "','" & tglOperasi & "','" & Val(Me.TxtLamaOperasiJam.Text) & "','" & Val(Me.TxtLamaOperasiMenit.Text) & "' " & _
                                                   ",'" & Me.ChkBoxElektif.Checked & "','" & Me.ChkBoxCito.Checked & "','" & DdRuangOp.SelectedItem.Value.ToString & "'" & _
                                                   ",'" & DdTindakan.SelectedItem.Value.ToString & "','" & DDAsaScore.SelectedItem.Value.ToString & "','" & DDKlasifikasiOp.SelectedItem.Value.ToString & "'" & _
                                                   ",'" & Me.DDSuhuTubuh.SelectedItem.Value.ToString & "','" & TxtAlbumin.Text & "','" & TxtGulaDarah.Text & "'" & _
                                                   ",'" & merokok & "','" & PenyInfeksi & "','" & ScreeningMRSA & "','" & DDPencukuran.SelectedItem.Value.ToString & "'" & _
                                                   ",'" & txtWaktuPencukuran.Text & "','" & DDMandi.SelectedItem.Value.ToString & "','" & Profilaksis & "'" & _
                                                   ",'" & TxtSirkulasi.Text & "','" & TxtUdara.Text & "','" & TxtTekanan.Text & "'" & _
                                                   ",'" & TxtSuhuRuang.Text & "','" & Drain & "','" & DDDisinfeksi.SelectedItem.Value.ToString & "'" & _
                                                   ",'" & Implant & "','" & TxtJumlahStaff.Text & "','" & Indikator & "'" & _
                                                   ",'" & Me.ChkBoxSuperfisal.Checked & "','" & Me.ChkBoxFascia.Checked & "','" & Me.ChkBoxRongga.Checked & "')"


            End If
            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            MyTrans.Commit()
        Catch ex As Exception
            MyTrans.Rollback()
            Throw New Exception("Error: ", ex)
        End Try


    End Sub
    Protected Sub BtnSaveMonitoringIDO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveMonitoringIDO.Click
        SaveHdr()
        DeleteOldData()
        saveDataPencegahanIDO()
        saveDataDiagnosaIDO()
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?&transactionId=" & Request.QueryString("transactionId") & "&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))

    End Sub

    Protected Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?&transactionId=" & Request.QueryString("transactionId") & "&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))
    End Sub
End Class
