Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormSearchingInputSurveilans
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not Page.IsPostBack Then
        '    With Me.DDLRUANG
        '        .DataSource = MasterLib.SetDataSourceRuang()
        '        .DataTextField = "vc_n_ruang"
        '        .DataValueField = "vc_k_ruang"
        '        .DataBind()
        '    End With
        'End If
    End Sub
    Protected Sub CmdCariPasien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdCariPasien.Click
        If Me.ValidationCariPasien = True Then
            getDataInap()
        Else
            Response.Write("<script language=""javascript"">alert('Anda Harus Mengisi Salah Satu Filter Pencarian');</script>")
        End If


    End Sub

    Function ValidationCariPasien() As Boolean
        If Me.TxtCariNama.Text.Length = 0 And Me.TxtCariKelurahan.Text.Length = 0 And Me.TxtCariKecamatan.Text.Length = 0 And Me.TxtCariKota.Text.Length = 0 And Me.TxtCariNoRM.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub getDataInap()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsPasien.ConnectionString = connectionString

        SdsPasien.DataSourceMode = SqlDataSourceMode.DataSet
        SdsPasien.ProviderName = "System.Data.SqlClient"

        'If Me.TxtCariNama.Text = "" And Me.TxtCariKelurahan.Text = "" And Me.TxtCariKecamatan.Text = "" And Me.TxtCariKota.Text = "" And Me.TxtCariNoRM.Text = "" Then
        '    Dim someScript As String = ""
        '    someScript = "<script language='javascript'>alert('Isikan salah satu parameter pencarian!...');</script>"
        '    Page.ClientScript.RegisterStartupScript(Me.GetType(), "onload", someScript)
        '    Exit Sub
        'End If

        Dim strsql As String = ""

        strsql = "SELECT RMPasien.vc_no_rm, RMPasien.vc_nama_p, ruang.VC_n_ruang,vc_kelurahan, RMPasien.vc_kecamatan, RMPasien.vc_kota, RMP_inap.vc_no_reg, RMP_inap.dt_tgl_msk,RMKAMAR.VC_NAMA as kamar,RMKamar.vc_k_gugus ,RMP_inap.VC_ALERGI , CASE WHEn ISNULL(IN_UMURTH,'') > 0 THEN ltrim(str(IN_UMURTH)) + ' Th ' + ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' ELSE  " & _
                "CASE WHEn ISNULL(IN_UMURTH,'')<= 0 and ISNULL(IN_UMURbl,'') > 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURbl)) + ' bl ' + ltrim(str(IN_UMURhr)) + ' hr' else " & _
                "CASE WHEn ISNULL(IN_UMURTH,'') <= 0 and ISNULL(IN_UMURbl,'') <= 0 and ISNULL(IN_UMURhr,'') > 0 THEN ltrim(str(IN_UMURhr)) + ' hr' else Str(0) end END end as umur, dbo.BPJS_RefDiagnosis_inasis.Description  FROM RMPasien INNER JOIN " & _
                 "RMP_inap ON RMPasien.vc_no_rm = RMP_inap.vc_no_rm INNER JOIN " & _
                 "rmkamar ON CASE WHEN (RMP_inap.vc_KLAS_MUT is null or RMP_inap.vc_KLAS_MUT ='') " & _
                 "THEN RMP_inap.vc_Kd_kamar_Masuk " & _
                 "ELSE RMP_inap.vc_kd_kamar_MUTasi End = rmkamar.vc_no_bed " & _
         "LEFT JOIN dbo.BPJS_RefDiagnosis_inasis ON dbo.RMP_inap.vc_alergi = dbo.BPJS_RefDiagnosis_inasis.Code " & _
   "LEFT JOIN RMRuang ruang ON vc_k_gugus = ruang.vc_k_ruang " & _
         "WHERE RMPasien.vc_no_rm <> '' "

        'Metode pencarian diawali kata
        If Me.TxtCariNama.Text <> "" Then
            strsql = strsql + "AND ([VC_nama_P])like '%" & UCase(TxtCariNama.Text) & "%' "
        End If

        If Me.TxtCariKelurahan.Text <> "" Then
            strsql = strsql & "AND ([VC_KELURAHAN])like '%" & UCase(TxtCariKelurahan.Text) & "%' "
        End If

        If Me.TxtCariKecamatan.Text <> "" Then
            strsql = strsql & "AND ([VC_KECAMATAN])like '%" & UCase(Me.TxtCariKecamatan.Text) & "%' "
        End If

        If Me.TxtCariKota.Text <> "" Then
            strsql = strsql & "AND ([VC_KOTA])like '%" & UCase(Me.TxtCariKota.Text) & "%' "
        End If

        If Me.TxtCariNoRM.Text <> "" Then
            strsql = strsql & "AND (RMPasien.[VC_no_rm])like '%" & UCase(Me.TxtCariNoRM.Text) & "%' "
        End If

        strsql = strsql + " ORDER BY RMPasien.VC_NAMA_P"

        SdsPasien.SelectCommand = strsql
        GridView1.DataSourceID = SdsPasien.ID
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            'e.Row.Attributes.Add("onmouseover", "ToolTip('Display some message');")
            e.Row.Attributes.Add("onMouseOver", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='cyan';this.style.cursor='pointer';")
            e.Row.Attributes.Add("OnMouseOut", "this.style.backgroundColor=this.originalstyle;")
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
            e.Row.ToolTip = "Klik untuk Menginput data"
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim index As Integer = GridView1.SelectedIndex
        Session("urlback") = Request.Url.ToString
        If (checkSurInfeksiExists(GridView1.DataKeys(index).Values(0).ToString(), GridView1.DataKeys(index).Values(1).ToString())) Then
            Response.Redirect("~/FormSearchingDataSurveilans.aspx?noRM=" & GridView1.DataKeys(index).Values(0).ToString() & "&noReg=" & GridView1.DataKeys(index).Values(1).ToString())
        Else
            Response.Redirect("~/FormInputSurveilansInfeksi.aspx?noRM=" & GridView1.DataKeys(index).Values(0).ToString() & "&noReg=" & GridView1.DataKeys(index).Values(1).ToString())
        End If
    End Sub

    Protected Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If (Session("source") = "USER") Then
            Response.Redirect("menu_laporan_ruangan.aspx")
        End If
        If (Session("source") = "PPI") Then
            Response.Redirect("beranda.aspx")
        End If
    End Sub

    'check data surveilans infeksi sudah ada belum
    Function checkSurInfeksiExists(ByVal noRm As String, ByVal noReg As String) As Boolean

        Dim strsql As String = ""
        Dim dataExists As Boolean = False
        strsql = "SELECT vc_no_rm,vc_no_reg FROM  Inos_Surveilans_Infeksi where vc_no_rm = '" & noRm & "' and vc_no_reg = '" & noReg & "'"

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
End Class
