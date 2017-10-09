Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Compilation
Partial Class TestingData
    Inherits System.Web.UI.Page

    Dim lerror As Boolean = False
    Protected Sub cmdkeuangan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdkeuangan.Click
        'cek tabel keurincian
        '          pubno_bukti
        'select * from rmp_inap where vc_no_rm = '00155377'
        'select * from rmpasien where vc_no_rm = '00155377'

        'select * from keurincian where vc_no_bukti = '09031107010007'

        'tabel keurincian
        lerror = False
        Me.LblKeuangan.Text = "KEUANGAN"
        Dim cPesanKeuangan As String = "Keurincian bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "keurincian", "09031107010007", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanKeuangan = "Tabel Keurincian GAGAL dibuka"
            lerror = True
        End Try
        Me.LblKeuangan.Text = cPesanKeuangan

        'tabel keurinciRJ
        Dim cPesanKeuangan2 As String = " KeurincianRJ bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "keurincianRJ", "09031102170002", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanKeuangan = " Tabel KeurincianRJ GAGAL dibuka"
            lerror = True
        End Try
        Me.LblKeuangan.Text = Me.LblKeuangan.Text + cPesanKeuangan2

        'tabel PubNoBukti
        Dim cPesanKeuangan3 As String = " PubNo_Bukti bisa dibuka"
        Try
            If MasterLib.ShowData("vc_k_gugus", "vc_k_gugus", "PubNo_Bukti", "0602", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanKeuangan = " Tabel PubNo_Bukti GAGAL dibuka"
            lerror = True
        End Try
        Me.LblKeuangan.Text = Me.LblKeuangan.Text + cPesanKeuangan3

        'tabel KeuTarip
        Dim cPesanKeuangan4 As String = " KeuTarip bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_gsklco", "vc_kd_gsklco", "Keutarip", "031311120", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanKeuangan = " Tabel KeuTarip GAGAL dibuka"
            lerror = True
        End Try
        Me.LblKeuangan.Text = Me.LblKeuangan.Text + cPesanKeuangan4
        If lerror Then
            Me.LblKeuangan.ForeColor = Drawing.Color.Red
        End If


    End Sub

    Protected Sub cmdrekammedis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdrekammedis.Click
        Me.LblRekamMedis.Text = ""
        Dim cPesanRekamMedis As String = "RMPasien bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_no_rm", "vc_no_rm", "rmpasien", "00155377", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRekamMedis = "Tabel RMPasien GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRekamMedis.Text = cPesanRekamMedis

        'tabel RMKunjung
        Dim cPesanRekamMedis2 As String = " RMKunjung bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_regj", "vc_no_regj", "rmkunjung", "1305181801029", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRekamMedis2 = " Tabel RMKunjung GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRekamMedis.Text = Me.LblRekamMedis.Text + cPesanRekamMedis2

        'tabel RMP_Inap
        Dim cPesanRekamMedis3 As String = " RMP_inap bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_reg", "vc_no_reg", "RMP_inap", "081227019", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRekamMedis3 = " Tabel RMP_inap GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRekamMedis.Text = Me.LblRekamMedis.Text + cPesanRekamMedis3
        If lerror = True Then
            Me.LblRekamMedis.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub cmdrawatjalan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdrawatjalan.Click
        Me.LblRawatJalan.Text = ""
        Dim cPesanRawatJalan As String = "RJNota bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_no_rm", "vc_no_rm", "RJNota", "00155377", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRawatJalan = "Tabel RJNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRawatJalan.Text = cPesanRawatJalan

        'tabel RJSubNota
        Dim cPesanRawatJalan2 As String = " RJSubNota bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "RJSubNota", "09031102170002", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRawatJalan2 = " Tabel RJSubNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRawatJalan.Text = Me.LblRawatJalan.Text + cPesanRawatJalan2
        If lerror = True Then
            Me.LblRawatJalan.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub cmdrawatinap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdrawatinap.Click
        Me.LblRawatInap.Text = ""
        Dim cPesanRawatInap As String = "RIHBiayaInap bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "RIHBiayaInap", "09031103230001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRawatInap = "Tabel RIHBiayaInap GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRawatInap.Text = cPesanRawatInap

        'tabel dbo.RIDBiayaInap
        Dim cPesanRawatinap2 As String = " dbo.RIDBiayaInap bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "RJSubNota", "09031103230001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRawatinap2 = " Tabel RIDBiayaInap GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRawatInap.Text = Me.LblRawatInap.Text + cPesanRawatinap2
        If lerror = True Then
            Me.LblRawatInap.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub cmdfarmasi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdfarmasi.Click
        Me.LblFarmasi.Text = ""
        Dim cPesanFarmasi As String = " FA_No_bukti bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_k_gugus", "vc_k_gugus", "fa_no_bukti", "0601", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi = "Tabel Fa_no_bukti GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = cPesanFarmasi

        'tabel fa_nomor_trans
        Dim cPesanFarmasi2 As String = " fa_nomor_trans bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_trans", "vc_kd_trans", "fa_nomor_trans", "KS09110306020002", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi2 = " Tabel RIDBiayaInap GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi2

        'tabel fa_nomor_transisi
        Dim cPesanFarmasi3 As String = " fa_nomor_transisi bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_transisi", "vc_kd_transisi", "fa_nomor_transisi", "09110106010001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi3 = " Tabel fa_nomor_transisi GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi3

        'tabel fa_nomor_transisi
        Dim cPesanFarmasi4 As String = " fa_obat bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kodeobat", "vc_kodeobat", "fa_obat", "000001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi4 = " Tabel fa_obat GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi4

        'tabel fa_resep_in_h
        Dim cPesanFarmasi5 As String = " fa_resep_in_h bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_resep", "vc_kd_resep", "fa_resep_in_h", "RS09031106020003", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi5 = " Tabel fa_resep_in_h GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi5


        'tabel fa_resep_in_d
        Dim cPesanFarmasi6 As String = " fa_resep_in_d bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_resep", "vc_kd_resep", "fa_resep_in_d", "RS09031106020081", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi6 = " Tabel fa_resep_in_d GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi6


        'tabel dbo.fa_resep_ranap_h
        Dim cPesanFarmasi7 As String = " dbo.fa_resep_ranap_h bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_resep", "vc_kd_resep", "fa_resep_ranap_h", "RP09020106010003", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi7 = " Tabel dbo.fa_resep_ranap_h GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi7


        'tabel dbo.fa_resep_ranap_d
        Dim cPesanFarmasi8 As String = " dbo.fa_resep_ranap_d bisa dibuka"
        Try
            If MasterLib.ShowData("vc_kd_resep", "vc_kd_resep", "fa_resep_ranap_d", "RP09020106010003", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanFarmasi8 = " Tabel dbo.fa_resep_ranap_d GAGAL dibuka"
            lerror = True
        End Try
        Me.LblFarmasi.Text = Me.LblFarmasi.Text + cPesanFarmasi8
        If lerror = True Then
            Me.LblFarmasi.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub cmdlaborat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdlaborat.Click
        Me.LblLaborat.Text = ""
        Dim cPesanLaborat As String = "LabNota bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "LabNota", "09020107010003", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanLaborat = "Tabel LabNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblLaborat.Text = cPesanLaborat

        'tabel dbo.LabNotaRalan
        Dim cPesanLaborat2 As String = " dbo.LabNotaRalan bisa dibuka"
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "LabNotaRalan", "09031107010027", "") <> "" Then
            End If
        Catch ex As Exception
            lerror = True
            cPesanLaborat2 = " Tabel LabNotaRalan GAGAL dibuka"
        End Try
        Me.LblLaborat.Text = Me.LblLaborat.Text + cPesanLaborat2

        'tabel dbo.LabSubNota
        Dim cPesanLaborat3 As String = " dbo.LabSubNota bisa dibuka"
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "LabSubNota", "09031107010007", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanLaborat3 = " Tabel LabSubNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblLaborat.Text = Me.LblLaborat.Text + cPesanLaborat3

        If lerror = True Then
            Me.LblLaborat.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub cmdradiologi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdradiologi.Click
        Me.LblRadiologi.Text = ""
        Dim cPesanRadilogi As String = "RadNota bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "RadNota", "09020108010001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRadilogi = "Tabel RadNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRadiologi.Text = cPesanRadilogi

        'tabel dbo.RadNotaRalan
        Dim cPesanRadilogi2 As String = " dbo.RadNotaRalan bisa dibuka"
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "RadNotaRalan", "09031108010007", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRadilogi2 = " Tabel RadNotaRalan GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRadiologi.Text = Me.LblRadiologi.Text + cPesanRadilogi2

        'tabel dbo.RadSubNota
        Dim cPesanRadilogi3 As String = " dbo.RadSubNota bisa dibuka"
        Try
            If MasterLib.ShowData("vc_nobukti", "vc_nobukti", "RadSubNota", "09031108010002", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRadilogi3 = " Tabel RADSubNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRadiologi.Text = Me.LblRadiologi.Text + cPesanRadilogi3

        If lerror = True Then
            Me.LblLaborat.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub cmdrehabmedik_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdrehabmedik.Click
        Me.LblRehabMedik.Text = ""
        Dim cPesanRehabMedik As String = "dbo.RHBnota bisa dibuka"
        lerror = False
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "RHBnota", "09031109010001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRehabMedik = "Tabel RHBnota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRehabMedik.Text = cPesanRehabMedik

        'tabel dbo.RHBSubNota
        Dim cPesanRehabMedik2 As String = " dbo.RHBSubNota bisa dibuka"
        Try
            If MasterLib.ShowData("vc_no_bukti", "vc_no_bukti", "RHBSubNota", "09031109010001", "") <> "" Then
            End If
        Catch ex As Exception
            cPesanRehabMedik2 = " Tabel RHBSubNota GAGAL dibuka"
            lerror = True
        End Try
        Me.LblRehabMedik.Text = Me.LblRehabMedik.Text + cPesanRehabMedik2
        If lerror = True Then
            Me.LblRehabMedik.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmdkeuangan_Click(sender, e)
        cmdrekammedis_Click(sender, e)
        cmdrawatjalan_Click(sender, e)
        cmdrawatinap_Click(sender, e)
        cmdfarmasi_Click(sender, e)
        cmdlaborat_Click(sender, e)
        cmdradiologi_Click(sender, e)
        cmdrehabmedik_Click(sender, e)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.LblKeuangan.Text = ""
        Me.LblFarmasi.Text = ""
        Me.LblLaborat.Text = ""
        Me.LblRadiologi.Text = ""
        Me.LblRawatInap.Text = ""
        Me.LblRawatJalan.Text = ""
        Me.LblRehabMedik.Text = ""
        Me.LblRekamMedis.Text = ""
        Me.TxtJalur.Text = ""
    End Sub


    Protected Sub LinkButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton8.Click
        Me.TxtJalur.Text = "Untuk Tabel KeurincianRJ : Cabut Jalur jarungan yg di Menuju RM1, RM2, Klinik2, Farmasi (karena Box yang di tangga terhubung lewat farmasi Timur " + Chr(13) & _
                           "Untuk Tabel Keurincian : Cabut Jalur Rehab.Medik, AKPN"
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Me.TxtJalur.Text = "Untuk Tabel RMPasien : Cabut RM1 dan RM2, Jika tetap tidak bisa matikan switch hub yang ada di IT " & _
                           "Untuk Tabel RMKunjung : Cabut RM1, RM2, Farmasi Timur,Klinik2, Klinik1"
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Me.TxtJalur.Text = "Untuk Tabel RJNota dan RJSubNota : Cabut Klinik1, Klinik2, RM2 "
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton3.Click
        Me.TxtJalur.Text = "Untuk Tabel RIHBiayaInap dan RIDBiayaInap : Cabut AKPN, IBS/Gizi"
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton4.Click
        Me.TxtJalur.Text = "Untuk Tabel Farmasi : Cabut Farmasi Timur dan Farmasi Pusat"
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton5.Click
        Me.TxtJalur.Text = "Untuk Tabel Laborat : Cabut Laborat"
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton6.Click
        Me.TxtJalur.Text = "Untuk Tabel Radiologi : Cabut AKPN, IBS/Gizi"
    End Sub

    Protected Sub LinkButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton7.Click
        Me.TxtJalur.Text = "Untuk Tabel Rehab Medik : Cabut Rehab. Medik"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TxtJalur_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtJalur.TextChanged
    End Sub
End Class
