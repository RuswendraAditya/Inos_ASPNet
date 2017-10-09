Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class HAIs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cNamaRuang As String = ""

        If Request.QueryString("kRuang") <> "000X" Then
            cNamaRuang = MasterLib.ShowData("vc_k_ruang", "vc_n_ruang", "rmruang", Request.QueryString("kRuang"), "")
            Me.LblJudul.Text = Me.LblJudul.Text + " BULAN : " & Request.QueryString("pBulan") & " TAHUN : " & Request.QueryString("pTahun") & " Ruang : " & cNamaRuang
        Else
            Me.LblJudul.Text = Me.LblJudul.Text + " BULAN : " & Request.QueryString("pBulan") & " TAHUN : " & Request.QueryString("pTahun")
        End If
        LapHais()
    End Sub

    Private Sub LapHais()
        Dim strsql As String = ""
        Dim DTGL As Date = DateTime.Now
        Dim nTotalTerima As Integer = 0
        Dim nTotalKeluar As Integer = 0
        Dim nTotal As Integer = 0

        'Buat Tabel Hasil sementara untuk menampung hasil yang akan dimunculkan dilaporan
        Dim dsHasil As New DataSet
        Dim dthasil As DataTable = dsHasil.Tables.Add("Hasil")
        dthasil.Columns.Add("No")                           'Buat Nomor
        dthasil.Columns.Add("kode")                         'Ambil KODE
        dthasil.Columns.Add("lama")                         'Ambil lama
        dthasil.Columns.Add("HAIS")                         'Ambil NAMA
        dthasil.Columns.Add("JUMLAH")                       'Ambil Hasil
        dthasil.Columns.Add("HASIL")                        'Ambil (Hasil * LAMA)/1000
        dthasil.Columns.Add("TARGET")                       'Ambil TARGET


        'Lihat daftar Mitra yang ada
        'If Session("lapkodepaguyuban") = "" Then
        'Me.Label2.Text = "REKAP. PENDAPATAN MITRA PAGUYUBAN : " & Session("namepaguyuban") & "<br> DARI TANGGAL : " & Date.Parse(Session("dtgldari")).ToString("dd/MM/yyyy") & " Sampai : " & Date.Parse(Session("dtglsampai")).ToString("dd/MM/yyyy") & "<br> Tanggal Cetak : " & Date.Now.ToString("dd/MM/yyyy hh:mm:dd")
        strsql = "SELECT INOS_Master_Hais.vc_kode, Inos_Master_Target.vc_nama_surveilans, Inos_Master_Target.dc_target " & _
                 "from INOS_Master_Hais inner join Inos_Master_Target " & _
                 "on INOS_Master_Hais.vc_kode = Inos_Master_Target.vc_kode " & _
                 "order by vc_kode"

        'End If

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim objdatareader As SqlClient.SqlDataReader
        objdatareader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Dim i As Integer = 0
        While objdatareader.Read
            i = i + 1
            dthasil.Rows.Add(i, objdatareader("vc_kode"), 0, objdatareader("vc_nama_surveilans"), 0, 0, objdatareader("dc_target"))
        End While
        objdatareader.Close()


        'buka data yang ada di tabel sementara
        Dim j As Integer = 0


        If Request.QueryString("kRuang") = "000X" Then
            strsql = "SELECT isnull(dc_IADP_hasil,0) as dc_IADP_hasil, isnull(in_lama_IADP,0) as in_lama_IADP, " & _
                     "isnull(dc_plebitis_hasil,0) as dc_plebitis_hasil, isnull(in_Lama_PLEbitis,0) as in_lama_plebitis, " & _
                     "isnull(dc_ca_uti_hasil,0) as dc_ca_uti_hasil, isnull(in_lama_ca_uti,0) as in_lama_ca_uti, " & _
                     "isnull(dc_operasi_bersih_hasil,0) as dc_operasi_bersih_hasil, isnull(in_lama_bersih,0) as in_lama_bersih, " & _
                     "isnull(dc_operasi_bt_hasil,0) as dc_operasi_bt_hasil, isnull(in_lama_bt,0) as in_lama_bt, " & _
                     "isnull(dc_operasi_kotor_hasil,0)as dc_operasi_kotor_hasil, isnull(in_lama_kotor,0) as in_lama_kotor, " & _
                     "isnull(dc_HAP_hasil,0)as dc_HAP_hasil, isnull(in_lama_hap,0) as in_lama_hap, " & _
                     "isnull(dc_vap_hasil,0)as dc_vap_hasil, isnull(in_lama_vap,0) as in_lama_vap, " & _
                     "isnull(dc_dekubitus_hasil,0) as dc_dekubitus_hasil, isnull(in_lama_dekubitus,0) as in_lama_dekubitus " & _
                     "FROM Inos_Surveilans_hasil " & _
                     "where in_bulan = " & Request.QueryString("pBulan") & " and in_tahun = " & Request.QueryString("pTahun") & "  " & _
                     "and vc_k_ruang <> '000X' "
        Else
            strsql = "SELECT isnull(dc_IADP_hasil,0) as dc_IADP_hasil, isnull(in_lama_IADP,0) as in_lama_IADP, " & _
                     "isnull(dc_plebitis_hasil,0) as dc_plebitis_hasil, isnull(in_Lama_PLEbitis,0) as in_lama_plebitis, " & _
                     "isnull(dc_ca_uti_hasil,0) as dc_ca_uti_hasil, isnull(in_lama_ca_uti,0) as in_lama_ca_uti, " & _
                     "isnull(dc_operasi_bersih_hasil,0) as dc_operasi_bersih_hasil, isnull(in_lama_bersih,0) as in_lama_bersih, " & _
                     "isnull(dc_operasi_bt_hasil,0) as dc_operasi_bt_hasil, isnull(in_lama_bt,0) as in_lama_bt, " & _
                     "isnull(dc_operasi_kotor_hasil,0)as dc_operasi_kotor_hasil, isnull(in_lama_kotor,0) as in_lama_kotor, " & _
                     "isnull(dc_HAP_hasil,0)as dc_HAP_hasil, isnull(in_lama_hap,0) as in_lama_hap, " & _
                     "isnull(dc_vap_hasil,0)as dc_vap_hasil, isnull(in_lama_vap,0) as in_lama_vap, " & _
                     "isnull(dc_dekubitus_hasil,0) as dc_dekubitus_hasil, isnull(in_lama_dekubitus,0) as in_lama_dekubitus " & _
                     "FROM Inos_Surveilans_hasil " & _
                     "where in_bulan = " & Request.QueryString("pBulan") & " and in_tahun = " & Request.QueryString("pTahun") & "  " & _
                     "and vc_k_ruang = '" & Request.QueryString("kRuang") & "' "
        End If

        Dim sqlCommand1 As New SqlClient.SqlCommand(strsql)
        sqlCommand1.Connection = connection
        connection.Open()

        objdatareader = sqlCommand1.ExecuteReader(CommandBehavior.CloseConnection)

        While objdatareader.Read
            For j = 0 To dthasil.Rows.Count - 1
                If dthasil.Rows(j).Item("kode") = "0001" Then    'IADP
                    If objdatareader("in_lama_IADP") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_IADP")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_iadp_hasil")
                End If
                If dthasil.Rows(j).Item("kode") = "0002" Then    'Plebitis
                    If objdatareader("in_lama_plebitis") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_plebitis")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_plebitis_hasil")
                End If

                If dthasil.Rows(j).Item("kode") = "0003" Then    'ca_uti
                    If objdatareader("in_lama_ca_uti") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_ca_uti")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_ca_uti_hasil")
                End If

                If dthasil.Rows(j).Item("kode") = "0007" Then    'HAP
                    If objdatareader("in_lama_hap") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_hap")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_hap_hasil")
                End If

                If dthasil.Rows(j).Item("kode") = "0008" Then    'VAP
                    If objdatareader("in_lama_vap") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_vap")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_vap_hasil")
                End If

                If dthasil.Rows(j).Item("kode") = "0009" Then    'Dekubitus
                    If objdatareader("in_lama_dekubitus") > 0 Then
                        dthasil.Rows(j).Item("lama") = objdatareader("in_lama_dekubitus")
                    End If
                    dthasil.Rows(j).Item("JUMLAH") = Val(dthasil.Rows(j).Item("JUMLAH")) + objdatareader("dc_dekubitus_hasil")
                End If
            Next

        End While
        objdatareader.Close()

        j = 0
        'UNTUK MENGHITUNG HASIL
        For j = 0 To dthasil.Rows.Count - 1
            If dthasil.Rows(j).Item("JUMLAH") <> 0 Then
                dthasil.Rows(j).Item("HASIL") = Format((Val(dthasil.Rows(j).Item("JUMLAH")) / Val(dthasil.Rows(j).Item("LAMA"))) * 1000, "standard")
            End If
        Next

        Me.GridView1.DataSource = dthasil
        GridView1.DataBind()

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        MasterLib.Export2excel(GridView1, LblJudul, "Laporan Bulanan HAIs")
    End Sub
End Class
