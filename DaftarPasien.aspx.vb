Imports System.Data
Imports System.Web
Imports System.Web.Configuration
Imports System.Data.SqlClient
Partial Class DaftarPasien
    Inherits System.Web.UI.Page
    Protected Sub BtnCari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim strsql As String = ""
        Dim is_first_statement As Boolean = True

        'Me.LblJudul.Text = "DAFTAR TINDAKAN DAN PEMBEDAHAN Dari Tanggal : " & Request.QueryString("dTglDari") & " s/d " & Request.QueryString("dTglSampai")
        strsql = "SELECT vc_no_rm,vc_nama_p,convert(varchar(10),dt_tgl_lhr,101) as dt_tgl_lhr,vc_alamat,agama.vc_agama,in_umurth,vc_jenis_k,vc_kecamatan,vc_kelurahan,vc_kota,vc_propinsi,vc_no_peserta_bpjs,vc_pekerjaan FROM RMPASIEN pasien LEFT JOIN PubKerja kerja " & _
                " ON kerja.vc_kode = pasien.vc_k_pek " & _
                " LEFT JOIN PubAgama agama ON agama.vc_kode = vc_k_agm "
        If (Me.txtBoxNama.Text.Length > 0 Or Me.txtNoRM.Text.Length > 0 Or Me.DateTglLahir.Text.Length > 0) Then
            strsql = strsql & " WHERE "
            ' strsql = strsql & ("WHERE UPPER(vc_nama_p) like '%RUSWENDRA%'")
        End If

    
        If (Me.txtNoRM.Text.Length > 0) Then
            strsql = strsql & ("UPPER(vc_no_rm) like '%" & Me.txtNoRM.Text.ToUpper & "%' ")
            is_first_statement = False
            ' strsql = strsql & ("WHERE UPPER(vc_nama_p) like '%RUSWENDRA%'")
        End If
        If (Me.txtBoxNama.Text.Length > 0) Then
            If is_first_statement = True Then
                strsql = strsql & ("UPPER(vc_nama_p) like '%" & Me.txtBoxNama.Text.ToUpper & "%' ")
                is_first_statement = False
            Else
                strsql = strsql & ("AND UPPER(vc_nama_p) like '%" & Me.txtBoxNama.Text.ToUpper & "%' ")
            End If
        End If
        If (Me.DateTglLahir.Text.Length > 0) Then
            If is_first_statement = True Then
                strsql = strsql & ("convert(varchar(10),dt_tgl_lhr,101) like '%" & MasterLib.xDate(Me.DateTglLahir.Text) & "%' ")
                is_first_statement = False
            Else
                strsql = strsql & ("AND convert(varchar(10),dt_tgl_lhr,101) like '%" & MasterLib.xDate(Me.DateTglLahir.Text) & "%' ")
            End If
        End If

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID

    End Sub
    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim labelRM As Label = New Label()
            labelRM = e.Row.FindControl("lblNoRM")

            Dim hl As HyperLink = New HyperLink()
            hl = e.Row.FindControl("HlRJ")

            hl.NavigateUrl = "~/daftarRajal.aspx?noRM=" & labelRM.Text & ""
            hl.Text = "Click Here"


            Dim hl2 As HyperLink = New HyperLink()
            hl2 = e.Row.FindControl("HlRinap")

            hl2.NavigateUrl = "~/DaftarRawatinap.aspx?noRM=" & labelRM.Text & ""
            hl2.Text = "Click Here"

        End If
    End Sub


End Class
