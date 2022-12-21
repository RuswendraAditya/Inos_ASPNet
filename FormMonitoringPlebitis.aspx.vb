Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormMonitoringPlebitis
    Inherits System.Web.UI.Page
    Private Sub getDataHdr()
        Dim strsql As String = ""
        'Monitoring_hdr_id()
        strsql = "SELECT * from Inos_Monitoring_plebitis " & _
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

            If IsDBNull(dr("bt_abocath")) Then
                chkBoxAbocath.Checked = False
            Else
                If (dr("bt_abocath") = True) Then
                    chkBoxAbocath.Checked = True
                Else
                    chkBoxAbocath.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_venflon")) Then
                chkBoxVenflon.Checked = False
            Else
                If (dr("bt_venflon") = True) Then
                    chkBoxVenflon.Checked = True
                Else
                    chkBoxVenflon.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_metacarpal")) Then
                ChkBoxMetacarpal.Checked = False
            Else
                If (dr("bt_metacarpal") = True) Then
                    ChkBoxMetacarpal.Checked = True
                Else
                    ChkBoxMetacarpal.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_sefalika")) Then
                ChkBoxSefalika.Checked = False
            Else
                If (dr("bt_sefalika") = True) Then
                    ChkBoxSefalika.Checked = True
                Else
                    ChkBoxSefalika.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_basalika")) Then
                ChkBoxBasalika.Checked = False
            Else
                If (dr("bt_basalika") = True) Then
                    ChkBoxBasalika.Checked = True
                Else
                    ChkBoxBasalika.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_medialis")) Then
                ChkBoxMedialis.Checked = False
            Else
                If (dr("bt_medialis") = True) Then
                    ChkBoxMedialis.Checked = True
                Else
                    ChkBoxMedialis.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cateter_16")) Then
                chkBoxCateter16.Checked = False
            Else
                If (dr("bt_cateter_16") = True) Then
                    chkBoxCateter16.Checked = True
                Else
                    chkBoxCateter16.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cateter_18")) Then
                chkBoxCateter18.Checked = False
            Else
                If (dr("bt_cateter_18") = True) Then
                    chkBoxCateter18.Checked = True
                Else
                    chkBoxCateter18.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cateter_20")) Then
                chkBoxCateter20.Checked = False
            Else
                If (dr("bt_cateter_20") = True) Then
                    chkBoxCateter20.Checked = True
                Else
                    chkBoxCateter20.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cateter_22")) Then
                chkBoxCateter22.Checked = False
            Else
                If (dr("bt_cateter_22") = True) Then
                    chkBoxCateter22.Checked = True
                Else
                    chkBoxCateter22.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cateter_24")) Then
                chkBoxCateter24.Checked = False
            Else
                If (dr("bt_cateter_24") = True) Then
                    chkBoxCateter24.Checked = True
                Else
                    chkBoxCateter24.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_infeksi_plebitis")) Then
                ChkBoxInfeksiplebitisTidak.Checked = True
            Else
                If (dr("bt_infeksi_plebitis") = True) Then
                    ChkBoxInfeksiplebitisYa.Checked = True
                Else
                    ChkBoxInfeksiplebitisTidak.Checked = True
                End If
            End If
            If IsDBNull(dr("vc_lokasi")) = False Then
                txtLokasiPleb.Text = dr("vc_lokasi")
            End If
            If IsDBNull(dr("vc_obat")) = False Then
                txtObatPleb.Text = dr("vc_obat")
            End If
        End While


    End Sub
    Private Function getMonitoringHdrId() As Integer
        Dim strsql As String = ""
        Dim monitoring_hdr_id As Integer = 0
        strsql = "SELECT * from Inos_Monitoring_plebitis " & _
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

    Private Sub getDataPencegahanplebitis()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  plebitis.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_plebitis plebitis LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = plebitis.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                              "and item.vc_source = trans.vc_source " & _
                             "and plebitis.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'PLEBITIS' " & _
                             "and vc_type = 'Pencegahan' " & _
                             "order by item.in_sequence asc"
        Else
            strsql = "SELECT plebitis.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                      "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'PLEBITIS' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_plebitis plebitis " & _
                     "on plebitis.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Pencegahan'  " & _
                     "and item.vc_source = 'PLEBITIS' " & _
                     "order by item.in_sequence asc "
        End If


        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
        GridView1.DataBind()
    End Sub


    Private Sub getDataDiagnosaplebitis()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData2.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData2.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  plebitis.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_plebitis plebitis LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = plebitis.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                             "and item.vc_source = trans.vc_source " & _
                             "and plebitis.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'PLEBITIS' " & _
                             "and item.vc_type = 'Diagnosa' " & _
                               "order by item.in_sequence asc"
        Else
            strsql = "SELECT plebitis.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                     "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'PLEBITIS' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_plebitis plebitis " & _
                     "on plebitis.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Diagnosa'  " & _
                     "and item.vc_source = 'PLEBITIS' " & _
                 "order by item.in_sequence asc"
        End If

        SdsData2.SelectCommand = strsql
        GridView2.DataSourceID = SdsData2.ID
        GridView2.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If (Not Page.IsPostBack) Then
            getDataHdr()
            getDataPencegahanplebitis()
            getDataDiagnosaplebitis()
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

    Protected Sub BtnSaveMonitoringplebitis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveMonitoringplebitis.Click
        SaveHdr()
        DeleteOldData()
        saveDataPencegahanplebitis()
        saveDataDiagnosaplebitis()
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?&transactionId=" & Request.QueryString("transactionId") & "&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))

    End Sub

    Private Sub DeleteOldData()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim deleteSql As String = "DELETE FROM  Inos_Monitoring_trans WHERE  in_monitoring_hdr_id = @monitoring_id and vc_source = @source_id;"
        Dim myCommand As SqlCommand = New SqlCommand(deleteSql, _
           connection)
        myCommand.Parameters.Add(New SqlParameter("@monitoring_id", SqlDbType.Int))
        myCommand.Parameters.Add(New SqlParameter("@source_id", SqlDbType.VarChar))
        myCommand.Parameters("@monitoring_id").Value = getMonitoringHdrId()
        myCommand.Parameters("@source_id").Value = "PLEBITIS"
        myCommand.Connection.Open()
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException
        End Try
        myCommand.Connection.Close()
    End Sub

    Private Sub SaveHdr()
        Dim strsql As String = ""
        Dim infeksi As Boolean = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        Dim MyTrans As SqlTransaction
        connection.Open()
        command.Connection = connection
        MyTrans = connection.BeginTransaction()
        command.Transaction = MyTrans
        If (Me.ChkBoxInfeksiplebitisYa.Checked) Then
            infeksi = True
        End If

        Try
            If (getMonitoringHdrId() <> 0) Then
                strsql = "update Inos_Monitoring_plebitis set " & _
                         " bt_abocath = '" & Me.chkBoxAbocath.Checked & "' " & _
                         ",bt_venflon = '" & Me.chkBoxVenflon.Checked & "' " & _
                         ",bt_metacarpal =    '" & Me.ChkBoxMetacarpal.Checked & "' " & _
                         ",bt_sefalika =    '" & Me.ChkBoxSefalika.Checked & "' " & _
                         ",bt_basalika =    '" & Me.ChkBoxBasalika.Checked & "' " & _
                         ",bt_medialis =    '" & Me.ChkBoxMedialis.Checked & "' " & _
                         ",bt_cateter_16 =    '" & Me.chkBoxCateter16.Checked & "' " & _
                         ",bt_cateter_18 =    '" & Me.chkBoxCateter18.Checked & "' " & _
                         ",  bt_cateter_20 =    '" & Me.chkBoxCateter20.Checked & "' " & _
                         ",  bt_cateter_22 =    '" & Me.chkBoxCateter22.Checked & "' " & _
                         ",  bt_cateter_24 =    '" & Me.chkBoxCateter24.Checked & "' " & _
                         ",  bt_infeksi_plebitis =  '" & infeksi & "' " & _
                         ",  vc_lokasi =  '" & txtLokasiPleb.Text & "' " & _
                         ",  vc_obat =  '" & txtObatPleb.Text & "' " & _
                         " where in_transaction_id =  '" & Request.QueryString("transactionId") & "' "
            Else
                strsql = "insert into Inos_Monitoring_plebitis (in_transaction_id, bt_abocath,bt_venflon,bt_cateter_16, " & _
                                                       "bt_metacarpal,bt_sefalika,bt_basalika,bt_medialis, " & _
                                                       "bt_cateter_18,bt_cateter_20, bt_cateter_22, bt_cateter_24,bt_infeksi_plebitis,vc_lokasi, vc_obat )  " & _
                                                                          " values " & _
                                                     "('" & Request.QueryString("transactionId") & "','" & Me.chkBoxAbocath.Checked & "','" & Me.chkBoxVenflon.Checked & "','" & Me.chkBoxCateter16.Checked & "' " & _
                                                     ",'" & Me.ChkBoxMetacarpal.Checked & "','" & Me.ChkBoxSefalika.Checked & "','" & Me.ChkBoxBasalika.Checked & "','" & Me.ChkBoxMedialis.Checked & "' " & _
                                                     ",'" & Me.chkBoxCateter18.Checked & "','" & Me.chkBoxCateter20.Checked & "','" & Me.chkBoxCateter22.Checked & "','" & Me.chkBoxCateter24.Checked & "','" & infeksi & "','" & txtLokasiPleb.Text & "','" & txtObatPleb.Text & "')"



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
    Private Sub saveDataPencegahanplebitis()
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
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','PLEBITIS','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
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

    Private Sub saveDataDiagnosaplebitis()
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
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','PLEBITIS','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
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




    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Session("urlback") = Request.Url.ToString
        Response.Redirect("~/FormInputSurveilansInfeksi.aspx?&transactionId=" & Request.QueryString("transactionId") & "&noRM=" & Request.QueryString("noRM") & "&noReg=" & Request.QueryString("noReg"))
    End Sub
End Class
