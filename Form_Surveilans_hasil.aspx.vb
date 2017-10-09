Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class Form_Surveilans_hasil
    Inherits System.Web.UI.Page

    Private lFlag As String = "Generate"

    Protected Sub CmdSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Dim lLengkap As Boolean = True


        Select Case CmdSimpan.Text
            Case "Input"
                Me.Enableds(True)
                CmdSimpan.Text = "Simpan"
                CmdBatal.Text = "Batal"
                InputData()
                gethasil()
            Case "Simpan"
                'validasi data
                lLengkap = True

                If Me.ddlbulan.Text = "" Then
                    PESAN("Bulan harus diisi!...")
                    lLengkap = False
                    Me.ddlbulan.Focus()
                    Exit Sub
                End If


                If Me.TxtTahun.Text = "" Then
                    PESAN("Tahun harus diisi!...")
                    lLengkap = False
                    Me.TxtTahun.Focus()
                    Exit Sub
                End If

                If lLengkap Then

                    'data save
                    If simpanData() = True Then
                        Me.Enableds(False)
                        CmdSimpan.Text = "Input"
                        CmdBatal.Text = "Keluar"
                        'ShowGrid()
                        PESAN("Data Berhasil disimpan...")
                        isigrid()
                        GridView1.DataSourceID = SdsData.ID
                    Else
                        PESAN("Data Gagal disimpan!...")
                    End If
                Else
                    PESAN("Data Harus dilengkapi!...")
                    Me.ddlruang.Focus()
                End If
        End Select
    End Sub

    Protected Sub CmdBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        If Me.CmdBatal.Text = "Keluar" Then
            'Response.Redirect("~/frmmenu.aspx")
        End If

        If Me.CmdBatal.Text = "Batal" Then
            Enableds(False)
            InputData()
            Me.CmdSimpan.Text = "Input"
            Me.CmdSimpan.Text = "Input"
            Me.CmdBatal.Text = "Keluar"
        End If
    End Sub

    Private Sub Enableds(ByVal lStatus As Boolean)
        'Me.ddlbulan.Enabled = lStatus
        'Me.TxtTahun.Enabled = lStatus
        Me.TxtVenaSentral.Enabled = lStatus
        Me.TxtVenaPerifer.Enabled = lStatus
        Me.TxtCatheter.Enabled = lStatus
        Me.TxtOperasiBersih.Enabled = lStatus
        Me.TxtOperasiBT.Enabled = lStatus
        Me.TxtOperasiKotor.Enabled = lStatus
        Me.TxtTirahBaring.Enabled = lStatus
        Me.TxtVen.Enabled = lStatus
        Me.TxtTB.Enabled = lStatus
        Me.TxtLamaIADP.Enabled = lStatus
        Me.TxtLamaPlebitis.Enabled = lStatus
        Me.TxtLamaCa_uti.Enabled = lStatus
        Me.TxtLamaBT.Enabled = lStatus
        Me.TxtLamaBersih.Enabled = lStatus
        Me.TxtLamaKotor.Enabled = lStatus
        Me.TxtLamaHAP.Enabled = lStatus
        Me.TxtLamaVAP.Enabled = lStatus
        Me.TxtLamaDekubitus.Enabled = lStatus
    End Sub

    Private Sub InputData()
        Me.TxtVenaSentral.Text = 0
        Me.TxtVenaPerifer.Text = 0
        Me.TxtCatheter.Text = 0
        Me.TxtOperasiBersih.Text = 0
        Me.TxtOperasiBT.Text = 0
        Me.TxtOperasiKotor.Text = 0
        Me.TxtTirahBaring.Text = 0
        Me.TxtVen.Text = 0
        Me.TxtTB.Text = 0
        Me.TxtLamaIADP.Text = 0
        Me.TxtLamaPlebitis.Text = 0
        Me.TxtLamaCa_uti.Text = 0
        Me.TxtLamaBT.Text = 0
        Me.TxtLamaBersih.Text = 0
        Me.TxtLamaKotor.Text = 0
        Me.TxtLamaHAP.Text = 0
        Me.TxtLamaVAP.Text = 0
        Me.TxtLamaDekubitus.Text = 0

    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Function simpanData() As Boolean
        Dim strsql As String = ""

        simpanData = False
        Dim lFound As Boolean = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim cKode As String = ""

        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans

        Try
            If MasterLib.lCekSurveilans(Me.ddlbulan.SelectedValue, Me.TxtTahun.Text, Me.ddlruang.SelectedValue, command) = False Then
                'Buat Kode
                strsql = "insert into Inos_Surveilans_hasil(vc_k_ruang, in_bulan, in_tahun, dc_IADP_hasil, in_lama_iadp " & _
                                                            ", dc_Plebitis_hasil, in_lama_plebitis " & _
                                                            ", dc_ca_uti_hasil, in_lama_ca_uti " & _
                                                            ", dc_operasi_bersih_hasil, in_lama_bersih " & _
                                                            ", dc_operasi_bt_hasil, in_lama_bt " & _
                                                            ", dc_operasi_kotor_hasil, in_lama_kotor " & _
                                                            ", dc_HAP_hasil, in_lama_hap " & _
                                                            ", dc_VAP_hasil, in_lama_vap " & _
                                                            ", dc_dekubitus_hasil, in_lama_dekubitus, vc_operator) " & _
                                                    "values " & _
                                                            "('" & Me.ddlruang.SelectedValue & "', " & Me.ddlbulan.SelectedValue & ", " & Me.TxtTahun.Text & " " & _
                                                            ", " & Me.TxtVenaSentral.Text & ", " & Me.TxtLamaIADP.Text & " " & _
                                                            ", " & Me.TxtVenaPerifer.Text & ", " & Me.TxtLamaPlebitis.Text & " " & _
                                                            ", " & Me.TxtCatheter.Text & ", " & Me.TxtLamaCa_uti.Text & " " & _
                                                            ", " & Me.TxtOperasiBersih.Text & ", " & Me.TxtLamaBersih.Text & " " & _
                                                            ", " & Me.TxtOperasiBT.Text & ", " & Me.TxtLamaBT.Text & " " & _
                                                            ", " & Me.TxtOperasiKotor.Text & ", " & Me.TxtLamaKotor.Text & " " & _
                                                            ", " & Me.TxtTirahBaring.Text & ", " & Me.TxtLamaHAP.Text & " " & _
                                                            ", " & Me.TxtVen.Text & ", " & Me.TxtLamaVAP.Text & " " & _
                                                            ", " & Me.TxtTB.Text & ", " & Me.TxtLamaDekubitus.Text & " " & _
                                                            ", '" & Session("ssUserName") & "')"
            Else
                strsql = "update Inos_Surveilans_hasil set " & _
                                " dc_IADP_hasil= '" & Me.TxtVenaSentral.Text & "' " & _
                                ", in_lama_IADP = " & Me.TxtLamaIADP.Text & " " & _
                                ", dc_plebitis_hasil= '" & Me.TxtVenaPerifer.Text & "' " & _
                                ", in_lama_PLEbitis = " & Me.TxtLamaPlebitis.Text & " " & _
                                ", dc_ca_uti_hasil= '" & Me.TxtCatheter.Text & "' " & _
                                ", in_lama_ca_uti= " & Me.TxtLamaCa_uti.Text & " " & _
                                ", dc_operasi_bersih_hasil= '" & Me.TxtOperasiBersih.Text & "' " & _
                                ", in_lama_bersih = " & Me.TxtLamaBersih.Text & " " & _
                                ", dc_operasi_bt_hasil= '" & Me.TxtOperasiBT.Text & "' " & _
                                ", in_lama_bt = " & Me.TxtLamaBT.Text & " " & _
                                ", dc_operasi_kotor_hasil= '" & Me.TxtOperasiKotor.Text & "' " & _
                                ", in_lama_kotor = " & Me.TxtLamaKotor.Text & " " & _
                                ", dc_HAP_hasil= '" & Me.TxtTirahBaring.Text & "' " & _
                                ", in_lama_hap = " & Me.TxtLamaHAP.Text & " " & _
                                ", dc_VAP_hasil= '" & Me.TxtVen.Text & "' " & _
                                ", in_lama_vap = " & Me.TxtLamaVAP.Text & " " & _
                                ", dc_dekubitus_hasil= '" & Me.TxtTB.Text & "' " & _
                                ", in_lama_dekubitus = " & Me.TxtLamaDekubitus.Text & " " & _
                                "where vc_k_ruang = '" & Me.ddlruang.SelectedValue & "' " & _
                                "and in_bulan = " & Me.ddlbulan.SelectedValue & " and in_tahun = " & Me.TxtTahun.Text & ""
            End If

            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            MyTrans.Commit()

            simpanData = True
        Catch ex As Exception
            simpanData = False
            MyTrans.Rollback()
        End Try


    End Function

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        'Dim Param As Parameter
        'Dim strsql As String = ""

        'Dim ntahun As Integer = Year(MasterLib.GetCurrentDate)
        'Dim nBulan As Integer = Month(MasterLib.GetCurrentDate)
        '' pegaturan untuk grid pasien

        'Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        'Dim connection As SqlConnection = New SqlConnection(connectionString)

        'SdsData.ConnectionString = connectionString

        'SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        'SdsData.ProviderName = "System.Data.SqlClient"

        'strsql = "SELECT vc_kd_infeksi, vc_nm_infeksi from inos_master_infeksi order by vc_kd_infeksi"
        'SdsData.SelectCommand = strsql

        'SdsData.DeleteCommand = "DELETE FROM inos_master_infeksi " _
        '    & "WHERE vc_kd_infeksi= @vckode "

        '' parameter delete
        'Param = New Parameter("vckode", TypeCode.String)
        'SdsData.DeleteParameters.Add(Param)


        'GridView1.DataSourceID = SdsData.ID
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            With ddlruang
                .DataSource = MasterLib.SetDataSourceRuang()
                .DataTextField = "vc_n_ruang"
                .DataValueField = "vc_k_ruang"
                .DataBind()
            End With

            Me.ddlbulan.SelectedValue = Month(MasterLib.GetCurrentDate)
            Me.TxtTahun.Text = Year(MasterLib.GetCurrentDate)

        End If

        isigrid()
        GridView1.DataSourceID = SdsData.ID

    End Sub

    Private Sub isigrid()
        Dim strsql As String = ""

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        Try

            strsql = "select rmruang.vc_K_ruang, rmruang.vc_n_ruang, dc_IADP_hasil, in_lama_iadp " & _
                     ", dc_Plebitis_hasil, in_lama_plebitis, dc_ca_uti_hasil, in_lama_ca_uti " & _
                     ", dc_operasi_bersih_hasil, in_lama_bersih, dc_operasi_bt_hasil, in_lama_bt " & _
                     ", dc_operasi_kotor_hasil, in_lama_kotor, dc_HAP_hasil, in_lama_hap " & _
                     ", dc_VAP_hasil, in_lama_vap, dc_dekubitus_hasil, in_lama_dekubitus FROM RMRUANG " & _
                     "LEFT JOIN (SELECT * FROM Inos_Surveilans_hasil where in_bulan = " & Me.ddlbulan.SelectedValue & " and in_tahun = " & Me.TxtTahun.Text & "  )BB ON rmruang.vc_K_ruang = BB.VC_K_RUANG " & _
                     "ORDER BY RMRUANG.VC_K_RUANG"


            SdsData.SelectCommand = strsql

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        'If (e.CommandName.Equals("Update")) Then
        'ElseIf (e.CommandName.Equals("Delete")) Then
        '    If e.CommandArgument <> "00000" Then
        '        SdsData.DeleteParameters("vckode").DefaultValue = e.CommandArgument
        '        SdsData.Delete()
        '    Else
        '        PESAN("Data ini tidak bisa dihapus!...")
        '        Exit Sub
        '    End If
        'ElseIf (e.CommandName.Equals("Edit")) Then
        '    If e.CommandArgument <> "00000" Then
        '        Me.TxtKode.Text = e.CommandArgument
        '        GetData()
        '        Me.CmdSimpan.Text = "Simpan"
        '        Me.CmdBatal.Text = "Batal"
        '        Me.TxtKode.Focus()
        '    Else
        '        PESAN("Data ini tidak bisa diedit!...")
        '        Exit Sub
        '    End If

        'End If
    End Sub

    Function GetData() As Boolean
        'Dim strsql As String = ""
        'Dim cKodeGugus As String = ""

        'GetData = False

        'strsql = "SELECT VC_KD_INfeksi, VC_NM_INfeksi from inos_master_infeksi where vc_kd_infeksi = '" & Me.TxtKode.Text & "' "

        'Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        'Dim connection As SqlConnection = New SqlConnection(connectionString)
        'Dim command As SqlCommand = New SqlCommand()

        'Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        'sqlCommand.Connection = connection
        'connection.Open()

        'Dim dr As SqlClient.SqlDataReader
        'dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        'While dr.Read
        '    GetData = True
        '    Me.TxtNama.Text = dr("vc_nm_infeksi")
        '    'Me.TxtRupiah.Text = Double.Parse(dr("dc_rupiah"))
        '    Exit While
        'End While
        'dr.Close()
    End Function

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub ddlruang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlruang.SelectedIndexChanged
        gethasil()
    End Sub

    Private Sub gethasil()
        Dim strsql As String = ""
        strsql = "SELECT isnull(dc_IADP_hasil,0) as dc_IADP_hasil, isnull(in_lama_IADP,0) as in_lama_IADP, " & _
                 "isnull(dc_plebitis_hasil,0) as dc_plebitis_hasil, isnull(in_Lama_PLEbitis,0) as in_lama_plebitis, " & _
                 "isnull(dc_ca_uti_hasil,0) as dc_ca_uti_hasil, isnull(in_lama_ca_uti,0) as in_lama_ca_uti, " & _
                 "isnull(dc_operasi_bersih_hasil,0) as dc_operasi_bersih_hasil, isnull(in_lama_bersih,0) as in_lama_bersih, " & _
                 "isnull(dc_operasi_bt_hasil,0) as dc_operasi_bt_hasil, isnull(in_lama_bt,0) as in_lama_bt, " & _
                 "isnull(dc_operasi_kotor_hasil,0)as dc_operasi_kotor_hasil, isnull(in_lama_kotor,0) as in_lama_kotor, " & _
                 "isnull(dc_HAP_hasil,0)as dc_HAP_hasil, isnull(in_lama_hap,0) as in_lama_hap, " & _
                 "isnull(dc_vap_hasil,0)as dc_vap_hasil, isnull(in_lama_vap,0) as in_lama_vap, " & _
                 "isnull(dc_dekubitus_hasil,0) as dc_dekubitus_hasil, isnull(in_lama_dekubitus,0) as in_lama_dekubitus " & _
                 "FROM Inos_Surveilans_hasil where in_bulan = " & Me.ddlbulan.SelectedValue & " and in_tahun = " & Me.TxtTahun.Text & " and vc_k_ruang = '" & Me.ddlruang.SelectedValue & "' "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        InputData()

        While dr.Read
            Me.TxtVenaSentral.Text = dr("dc_IADP_hasil")
            Me.TxtLamaIADP.Text = dr("in_lama_IADP")
            Me.TxtVenaPerifer.Text = dr("dc_plebitis_hasil")
            Me.TxtLamaPlebitis.Text = dr("in_lama_PLEBITIS")
            Me.TxtCatheter.Text = dr("dc_ca_uti_hasil")
            Me.TxtLamaCa_uti.Text = dr("in_lama_CA_UTI")
            Me.TxtOperasiBersih.Text = dr("dc_operasi_bersih_hasil")
            Me.TxtLamaBersih.Text = dr("in_lama_BERSIH")
            Me.TxtOperasiBT.Text = dr("dc_operasi_bt_hasil")
            Me.TxtLamaBT.Text = dr("in_lama_BT")
            Me.TxtOperasiKotor.Text = dr("dc_operasi_kotor_hasil")
            Me.TxtLamaKotor.Text = dr("in_lama_KOTOR")
            Me.TxtTirahBaring.Text = dr("dc_HAP_hasil")
            Me.TxtLamaHAP.Text = dr("in_lama_HAP")
            Me.TxtVen.Text = dr("dc_vap_hasil")
            Me.TxtLamaVAP.Text = dr("in_lama_VAP")
            Me.TxtTB.Text = dr("dc_dekubitus_hasil")
            Me.TxtLamaDekubitus.Text = dr("in_lama_DEKUBITUS")
            Exit While
        End While
        dr.Close()

    End Sub

End Class

