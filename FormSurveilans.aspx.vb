Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class FormSurveilans
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            enableds(False)
        End If
        With Me.ddlInfeksiRS
            .DataSource = MasterLib.SetDataSourceInfeksi
            .DataTextField = "vc_nm_infeksi"
            .DataValueField = "vc_kd_infeksi"
            .DataBind()
        End With
    End Sub

    Protected Sub cmdInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdInput.Click
        Dim dTgl As Date = MasterLib.GetCurrentDate
        'If Day(MasterLib.GetCurrentDate) > nTgl Then
        '    PESAN("Entri Data tidak diperbolehkan melebihi tgl..." & nTgl)
        '    Exit Sub
        'End If

        Select Case Me.cmdInput.Text
            Case "Input"
                enableds(True)
                Me.TxtNoRM.Focus()
                inputdata()
                Me.cmdInput.Text = "Simpan"
            Case "Simpan"
                Try
                    If Me.TxtNoRM.Text = "" Then
                        PESAN("No.RM harus diisi!...")
                        Me.TxtNoRM.Focus()
                        Exit Sub
                    End If

                    If Me.TxtNoREG.Text = "" Then
                        PESAN("No.RM Harus diisi!...")
                        Me.TxtNoREG.Focus()
                        Exit Sub
                    End If


                    If Me.TxtNoREG.Text <> "" Then
                        If simpanData() Then
                            PESAN("Data berhasil disimpan!...")
                            Me.cmdInput.Text = "Input"
                            enableds(False)
                        Else
                            PESAN("Data Gagal disimpan!...")
                        End If
                    End If

                    If Me.DateIVLPasang.Text <> "" Then
                        If Me.DateIVLAff.Text = "" Then
                            PESAN("Tgl IVL Aff tidak boleh kosong, dan harus >= tgl. IVL Pasang")
                            Exit Sub
                        End If
                    End If

                    If Me.DateCVLPasang.Text <> "" Then
                        If Me.DateCVLAff.Text = "" Then
                            PESAN("Tgl CVL Aff tidak boleh kosong, dan harus >= tgl. CVL Pasang")
                            Exit Sub
                        End If
                    End If

                    If Me.DateDCPasang.Text <> "" Then
                        If Me.DateDCAff.Text = "" Then
                            PESAN("Tgl DC Aff tidak boleh kosong, dan harus >= tgl. DC Pasang")
                            Exit Sub
                        End If
                    End If

                    If Me.DateETTPasang.Text <> "" Then
                        If Me.DateETTAff.Text = "" Then
                            PESAN("Tgl ETT/TT Aff tidak boleh kosong, dan harus >= tgl. ETT/TT Pasang")
                            Exit Sub
                        End If
                    End If

                    If Me.DateVentiPasang.Text <> "" Then
                        If Me.DateVentiPasang.Text = "" Then
                            PESAN("Tgl VENTI Aff tidak boleh kosong, dan harus >= tgl. VENTI Pasang")
                            Exit Sub
                        End If
                    End If

                Catch ex As Exception
                    PESAN("Data Gagal disimpan!...")
                End Try

        End Select

    End Sub

    Private Sub enableds(ByVal lstatus As Boolean)
        Me.TxtNoRM.Enabled = lstatus
        Me.TxtNoREG.Enabled = lstatus
        'Me.DateIVLPasang.Enabled = lstatus
        'Me.DateIVLAff.Enabled = lstatus
        'Me.DateCVLPasang.Enabled = lstatus
        'Me.DateCVLAff.Enabled = lstatus
        'Me.DateDCPasang.Enabled = lstatus
        'Me.DateDCAff.Enabled = lstatus
        'Me.DateETTPasang.Enabled = lstatus
        'Me.DateETTAff.Enabled = lstatus
        'Me.DateVentiPasang.Enabled = lstatus
        'Me.DateVentiAff.Enabled = lstatus
        'Me.DateTirahDari.Enabled = lstatus
        'Me.DateTirahSampai.Enabled = lstatus
        Me.TxtAntiBiotik.Enabled = lstatus
        Me.TxtCatatan.Enabled = lstatus
        Me.TxtDiagnosaICDX.Enabled = lstatus
        Me.ddlInfeksiRS.Enabled = lstatus
    End Sub

    Private Sub InputData()
        Me.DateTglEntri.Text = Format(MasterLib.GetCurrentDate, "dd/MM/yyyy")
        Me.TxtNoRM.Text = ""
        Me.TxtNoREG.Text = ""
        Me.TxtNama.Text = ""
        Me.TxtAlamat.Text = ""
        Me.TxtUmurTh.Text = ""
        Me.TxtUmurbl.Text = ""
        Me.TxtUmurhr.Text = ""
        Me.TxtKelamin.Text = ""
        Me.TxtKamar.Text = ""
        Me.DateIVLPasang.Text = ""
        Me.DateIVLAff.Text = ""
        Me.DateCVLPasang.Text = ""
        Me.DateCVLAff.Text = ""
        Me.DateDCPasang.Text = ""
        Me.DateDCAff.Text = ""
        Me.DateETTPasang.Text = ""
        Me.DateETTAff.Text = ""
        Me.DateVentiPasang.Text = ""
        Me.DateVentiAff.Text = ""
        Me.DateTirahDari.Text = ""
        Me.DateTirahSampai.Text = ""
        Me.TxtAntiBiotik.Text = ""
        Me.TxtCatatan.Text = ""
        Me.TxtDiagnosaICDX.Text = ""
        Me.ddlInfeksiRS.SelectedValue = "00000"
        Me.dateTglPulang.Text = ""
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


        If MasterLib.ShowData("vc_no_reg", "vc_no_reg", "Inos_Surveilans", Me.TxtNoREG.Text, "") <> "" Then
            lFound = True
        End If

        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans

        Try

            If Me.TxtNoREG.Text <> "" Then
                If lFound Then
                    'update
                    strsql = "update Inos_Surveilans set " & _
                                    " vc_ivl_pasang= '" & Me.DateIVLPasang.Text & "' " & _
                                    ", vc_ivl_Aff= '" & Me.DateIVLAff.Text & "' " & _
                                    ", vc_CVL_Pasang= '" & Me.DateCVLPasang.Text & "' " & _
                                    ", vc_CVL_Aff= '" & Me.DateCVLAff.Text & "' " & _
                                    ", vc_DC_pasang= '" & Me.DateDCPasang.Text & "' " & _
                                    ", vc_DC_Aff= '" & Me.DateCVLAff.Text & "' " & _
                                    ", vc_ETT_pasang= '" & Me.DateETTPasang.Text & "' " & _
                                    ", vc_ETT_Aff= '" & Me.DateETTAff.Text & "' " & _
                                    ", vc_Venti_Pasang= '" & Me.DateVentiPasang.Text & "' " & _
                                    ", vc_Venti_Aff= '" & Me.DateVentiAff.Text & "' " & _
                                    ", vc_Tirah_Baring_dari= '" & Me.DateTirahDari.Text & "' " & _
                                    ", vc_Tirah_Baring_sampai= '" & Me.DateTirahSampai.Text & "' " & _
                                    ", vc_antibiotik= '" & Me.TxtAntiBiotik.Text & "' " & _
                                    ", vc_catatan= '" & Me.TxtCatatan.Text & "' " & _
                                    ", vc_diagnosa_10= '" & Me.TxtDiagnosaICDX.Text & "' " & _
                                    ", vc_kode_infeksi= '" & Me.ddlInfeksiRS.SelectedValue & "' " & _
                                    ", vc_operator = '" & Session("ssUserName") & "' " & _
                                    "where vc_no_reg = '" & Me.TxtNoREG.Text & "' "
                Else
                    strsql = "insert into Inos_Surveilans(vc_no_rm, vc_no_reg, dt_tgl_trans, vc_kd_ruang, vc_nama_kamar, vc_ivl_pasang, vc_ivl_aff " & _
                                                        ", vc_CVL_Pasang, vc_CVL_aff, vc_DC_pasang, vc_DC_Aff, vc_ETT_pasang, vc_ETT_Aff " & _
                                                        ", vc_Venti_Pasang, vc_Venti_Aff, vc_Tirah_Baring_dari, vc_Tirah_Baring_sampai " & _
                                                        ", vc_antibiotik, vc_catatan, vc_diagnosa_10, vc_kode_infeksi, dt_tgl_pul, vc_operator) " & _
                                                 "values " & _
                                                        "('" & Me.TxtNoRM.Text & "', '" & Me.TxtNoREG.Text & "', '" & MasterLib.GetCurrentDate & "', '" & Me.TxtKodeRuang.Text & "', '" & Me.TxtKamar.Text & "', '" & Me.DateIVLPasang.Text & "', '" & Me.DateIVLAff.Text & "' " & _
                                                        ", '" & Me.DateCVLPasang.Text & "', '" & Me.DateCVLAff.Text & "', '" & Me.DateDCPasang.Text & "', '" & Me.DateDCAff.Text & "', '" & Me.DateETTPasang.Text & "', '" & Me.DateETTAff.Text & "' " & _
                                                        ", '" & Me.DateVentiPasang.Text & "', '" & Me.DateVentiAff.Text & "', '" & Me.DateTirahDari.Text & "', '" & Me.DateTirahSampai.Text & "' " & _
                                                        ", '" & Me.TxtAntiBiotik.Text & "', '" & Me.TxtCatatan.Text & "', '" & Me.TxtDiagnosaICDX.Text & "', '" & Me.ddlInfeksiRS.SelectedValue & "', CONVERT(DATETIME,'" & MasterLib.xDate(Me.dateTglPulang.Text) & "'), '" & Session("ssUserName") & "')"
                End If

                command.CommandText = strsql
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                MyTrans.Commit()
            End If

            simpanData = True
        Catch ex As Exception
            simpanData = False
            MyTrans.Rollback()
        End Try


    End Function

    Protected Sub Cmdbatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmdbatal.Click
        Select Case Me.Cmdbatal.Text
            Case "Batal"
                Me.TxtNoRM.Text = ""
                InputData()
                Me.cmdInput.Text = "Input"
                enableds(False)
            Case "Edit"
                Me.cmdInput.Text = "Simpan"
                enableds(True)
                Me.Cmdbatal.Text = "Batal"
        End Select

    End Sub

    Protected Sub TxtNoREG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNoREG.TextChanged
        GetNoreg()
    End Sub

    Private Sub GetNoreg()
        Dim strsql As String = ""

        strsql = "SELECT RMPasien.vc_no_rm, RMPasien.vc_nama_p, RMPasien.vc_kelurahan, RMPasien.vc_kecamatan, RMPasien.vc_kota, RMP_inap.vc_no_reg, RMP_inap.dt_tgl_msk,RMKAMAR.VC_NAMA as kamar,RMKamar.vc_k_gugus ,RMP_inap.VC_ALERGI , CASE WHEn ISNULL(IN_UMURTH,'') > 0 THEN ltrim(str(IN_UMURTH)) + ' Th ' + ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' ELSE " & _
                  "CASE WHEn ISNULL(IN_UMURTH,'')<= 0 and ISNULL(IN_UMURbl,'') > 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' else " & _
                  "CASE WHEn ISNULL(IN_UMURTH,'') <= 0 and ISNULL(IN_UMURbl,'') <= 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURhr)) + ' hr' else Str(0) end END end as umur, dbo.BPJS_RefDiagnosis_inasis.Description  FROM RMPasien INNER JOIN " & _
                   "RMP_inap ON RMPasien.vc_no_rm = RMP_inap.vc_no_rm INNER JOIN " & _
                   "rmkamar ON CASE WHEN (RMP_inap.vc_KLAS_MUT is null or RMP_inap.vc_KLAS_MUT ='') " & _
                   "THEN RMP_inap.vc_Kd_kamar_Masuk " & _
                   "ELSE RMP_inap.vc_kd_kamar_MUTasi End = rmkamar.vc_no_bed " & _
           "LEFT JOIN dbo.BPJS_RefDiagnosis_inasis ON dbo.RMP_inap.vc_alergi = dbo.BPJS_RefDiagnosis_inasis.Code " & _
                  "WHERE RMPasien.vc_no_rm = '' "


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
        Me.TxtUmurTh.Text = ""
        Me.TxtUmurbl.Text = ""
        Me.TxtUmurhr.Text = ""
        Me.TxtKelamin.Text = ""
        Me.TxtKamar.Text = ""
        Me.dateTglPulang.Text = ""
        Me.TxtKodeRuang.Text = ""

        While dr.Read
            Me.TxtNoRM.Text = dr("vc_no_rm")
            Me.TxtNama.Text = dr("vc_nama_p")
            Me.TxtAlamat.Text = dr("vc_alamat")
            Me.TxtUmurTh.Text = dr("in_umurth")
            Me.TxtUmurbl.Text = dr("in_umurbl")
            Me.TxtUmurhr.Text = dr("in_umurhr")
            Me.TxtKelamin.Text = dr("vc_jenis_k")
            Me.TxtKamar.Text = dr("vc_nama")
            Me.dateTglPulang.Text = Format(dr("dt_tgl_pul"), "dd/MM/yyyy")
            Me.TxtKodeRuang.Text = dr("vc_k_gugus")
        End While
        dr.Close()

        ShowSurveiland()

    End Sub

    Function lGetNoRM() As Boolean
        Dim strsql As String = ""
        lGetNoRM = False

        strsql = "SELECT dbo.RMP_inap.vc_no_reg, dbo.RMPasien.vc_no_rm, dbo.RMPasien.vc_nama_p, dbo.RMPasien.vc_jenis_k, dbo.RMPasien.in_umurth, dbo.RMPasien.in_umurbl, " & _
                 "dbo.RMPasien.in_umurhr, dbo.RMPasien.vc_alamat, dbo.RMTaraKarip.VC_No_Bed, dbo.RMKamar.vc_nama, dbo.RMKelas.vc_n_kelas, dbo.RMP_inap.dt_tgl_pul " & _
                 "FROM dbo.RMP_inap INNER JOIN " & _
                 "dbo.RMPasien ON dbo.RMP_inap.vc_no_rm = dbo.RMPasien.vc_no_rm INNER JOIN " & _
                 "dbo.RMTaraKarip ON case when isnull(dbo.RMP_inap.vc_klas_mut,'')='' then dbo.RMP_inap.vc_k_klas_m else dbo.RMP_inap.vc_klas_mut end = dbo.RMTaraKarip.vc_kd_Gsklco INNER JOIN " & _
                 "dbo.RMKamar ON dbo.RMTaraKarip.VC_No_Bed = dbo.RMKamar.vc_no_bed INNER JOIN " & _
                 "dbo.RMKelas ON dbo.RMKamar.vc_k_kelas = dbo.RMKelas.vc_k_kelas " & _
                 "where rmp_inap.vc_no_rm = '" & Me.TxtNoRM.Text & " '"

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Me.TxtNoREG.Text = ""
        Me.TxtNama.Text = ""
        Me.TxtAlamat.Text = ""
        Me.TxtUmurTh.Text = ""
        Me.TxtUmurbl.Text = ""
        Me.TxtUmurhr.Text = ""
        Me.TxtKelamin.Text = ""
        Me.TxtKamar.Text = ""
        Me.dateTglPulang.Text = ""

        While dr.Read
            lGetNoRM = True
            Me.TxtNama.Text = dr("vc_nama_p")
            Me.TxtAlamat.Text = dr("vc_alamat")
            Me.TxtUmurTh.Text = dr("in_umurth")
            Me.TxtUmurbl.Text = dr("in_umurbl")
            Me.TxtUmurhr.Text = dr("in_umurhr")
            Me.TxtKelamin.Text = dr("vc_jenis_k")
        End While
        dr.Close()

    End Function
    Protected Sub LinkButton10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton10.Click

    End Sub

    Protected Sub TxtNoRM_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNoRM.TextChanged
        If lGetNoRM() = False Then
            PESAN("Pasien ini belum pernah rawat inap!...")
            InputData()
            Exit Sub
        Else
            RiwayatInap()
            GridView1.DataSourceID = SdsData.ID
        End If
    End Sub

    Private Sub RiwayatInap()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        Dim strsql As String = ""


        Try

            strsql = "SELECT dbo.RMP_inap.vc_no_reg, dbo.RMP_inap.dt_tgl_msk, dbo.RMP_inap.dt_tgl_pul, " & _
                     "dbo.RMKamar.vc_nama, dbo.RMKelas.vc_n_kelas " & _
                     "FROM dbo.RMP_inap INNER JOIN " & _
                     "dbo.RMPasien ON dbo.RMP_inap.vc_no_rm = dbo.RMPasien.vc_no_rm INNER JOIN " & _
                     "dbo.RMTaraKarip ON case when isnull(dbo.RMP_inap.vc_klas_mut,'')='' then dbo.RMP_inap.vc_k_klas_m else dbo.RMP_inap.vc_klas_mut end = dbo.RMTaraKarip.vc_kd_Gsklco INNER JOIN " & _
                     "dbo.RMKamar ON dbo.RMTaraKarip.VC_No_Bed = dbo.RMKamar.vc_no_bed INNER JOIN " & _
                     "dbo.RMKelas ON dbo.RMKamar.vc_k_kelas = dbo.RMKelas.vc_k_kelas " & _
                     "where rmp_inap.vc_no_rm = '" & Me.TxtNoRM.Text & " '"

            SdsData.SelectCommand = strsql

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ShowSurveiland()

        Dim strsql As String = ""
        strsql = "select * from Inos_Surveilans " & _
                     "where vc_no_reg = '" & Me.TxtNoREG.Text & " '"

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Me.DateIVLPasang.Text = ""
        Me.DateIVLAff.Text = ""
        Me.DateCVLPasang.Text = ""
        Me.DateCVLAff.Text = ""
        Me.DateDCPasang.Text = ""
        Me.DateDCAff.Text = ""
        Me.DateETTPasang.Text = ""
        Me.DateETTAff.Text = ""
        Me.DateVentiPasang.Text = ""
        Me.DateVentiAff.Text = ""
        Me.DateTirahDari.Text = ""
        Me.DateTirahSampai.Text = ""
        Me.TxtAntiBiotik.Text = ""
        Me.TxtCatatan.Text = ""
        Me.TxtDiagnosaICDX.Text = ""
        Me.ddlInfeksiRS.SelectedValue = "00000"

        While dr.Read
            Me.DateIVLPasang.Text = dr("vc_IVL_pasang")
            Me.DateIVLAff.Text = dr("vc_IVL_Aff")
            Me.DateCVLPasang.Text = dr("vc_CVL_Pasang")
            Me.DateCVLAff.Text = dr("vc_CVL_Aff")
            Me.DateDCPasang.Text = dr("vc_DC_pasang")
            Me.DateDCAff.Text = dr("vc_DC_Aff")
            Me.DateETTPasang.Text = dr("vc_ETT_pasang")
            Me.DateETTAff.Text = dr("vc_ETT_Aff")
            Me.DateVentiPasang.Text = dr("vc_Venti_Pasang")
            Me.DateVentiAff.Text = dr("vc_Venti_Aff")
            Me.DateTirahDari.Text = dr("vc_Tirah_Baring_dari")
            Me.DateTirahSampai.Text = dr("vc_Tirah_Baring_Sampai")
            Me.TxtAntiBiotik.Text = dr("vc_AntiBiotik")
            Me.TxtCatatan.Text = dr("vc_catatan")
            Me.TxtDiagnosaICDX.Text = dr("vc_Diagnosa_10")
            Me.ddlInfeksiRS.SelectedValue = dr("vc_kode_Infeksi")
        End While
        dr.Close()
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
        e.Row.ToolTip = "Silahkan Klik baris data untuk dipilih..."
        e.Row.Attributes("style") = "cursor:pointer"

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim cNoReg As String = CType(GridView1.SelectedRow.FindControl("lblNoReg"), Label).Text
        Me.TxtNoREG.Text = cNoReg
        GetNoreg()
    End Sub

    Protected Sub DateIVLPasang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateIVLPasang.TextChanged
        'If Not IsDate(Me.DateIVLPasang.Text) Then
        '    PESAN("Format Tanggal salah!...")
        '    Me.DateIVLPasang.Text = ""
        '    Me.DateIVLPasang.Focus()
        '    Exit Sub
        'End If
    End Sub
End Class
