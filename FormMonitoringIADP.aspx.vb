Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FormMonitoringIADP
    Inherits System.Web.UI.Page
    Private Sub getDataHdr()
        Dim strsql As String = ""
        'Monitoring_hdr_id()
        strsql = "SELECT * from Inos_Monitoring_IADP " & _
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

            If IsDBNull(dr("bt_subclavia")) Then
                chkBoxSubClavia.Checked = False
            Else
                If (dr("bt_subclavia") = True) Then
                    chkBoxSubClavia.Checked = True
                Else
                    chkBoxSubClavia.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_jugolaris")) Then
                chkBoxJugolaris.Checked = False
            Else
                If (dr("bt_jugolaris") = True) Then
                    chkBoxJugolaris.Checked = True
                Else
                    chkBoxJugolaris.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_femoralis")) Then
                chkBoxFemoralis.Checked = False
            Else
                If (dr("bt_femoralis") = True) Then
                    chkBoxFemoralis.Checked = True
                Else
                    chkBoxFemoralis.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cvc_12")) Then
                chkBoxCVC12.Checked = False
            Else
                If (dr("bt_cvc_12") = True) Then
                    chkBoxCVC12.Checked = True
                Else
                    chkBoxCVC12.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cvc_7")) Then
                chkBoxCVC7.Checked = False
            Else
                If (dr("bt_cvc_7") = True) Then
                    chkBoxCVC7.Checked = True
                Else
                    chkBoxCVC7.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_cvc_5")) Then
                chkBoxCVC7.Checked = False
            Else
                If (dr("bt_cvc_5") = True) Then
                    chkBoxCVC5.Checked = True
                Else
                    chkBoxCVC5.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_jenis_cvc_4")) Then
                chkBox4Lumen.Checked = False
            Else
                If (dr("bt_jenis_cvc_4") = True) Then
                    chkBox4Lumen.Checked = True
                Else
                    chkBox4Lumen.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_jenis_cvc_3")) Then
                chkBox3Lumen.Checked = False
            Else
                If (dr("bt_jenis_cvc_3") = True) Then
                    chkBox3Lumen.Checked = True
                Else
                    chkBox3Lumen.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_jenis_cvc_2")) Then
                chkBox2Lumen.Checked = False
            Else
                If (dr("bt_jenis_cvc_2") = True) Then
                    chkBox2Lumen.Checked = True
                Else
                    chkBox2Lumen.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_jenis_cvc_1")) Then
                chkBox2Lumen.Checked = False
            Else
                If (dr("bt_jenis_cvc_1") = True) Then
                    chkBox2Lumen.Checked = True
                Else
                    chkBox2Lumen.Checked = False
                End If
            End If
            If IsDBNull(dr("bt_infeksi_iadp")) Then
                ChkBoxInfeksiIadpTidak.Checked = True
            Else
                If (dr("bt_infeksi_iadp") = True) Then
                    ChkBoxInfeksiIadpYa.Checked = True
                Else
                    ChkBoxInfeksiIadpTidak.Checked = True
                End If
            End If
        End While


    End Sub
    Private Function getMonitoringHdrId() As Integer
        Dim strsql As String = ""
        Dim monitoring_hdr_id As Integer = 0
        strsql = "SELECT * from Inos_Monitoring_IADP " & _
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

    Private Sub getDataPencegahanIADP()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  iadp.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_IADP iadp LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = iadp.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                             "and item.vc_source = trans.vc_source " & _
                             "and iadp.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'IADP' " & _
                             "and vc_type = 'Pencegahan' " & _
                             "order by item.in_sequence asc"
        Else
            strsql = "SELECT iadp.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                     "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'IADP' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_IADP iadp " & _
                     "on iadp.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Pencegahan'  " & _
                     "and item.vc_source = 'IADP' " & _
                     "order by item.in_sequence asc "
        End If


        SdsData.SelectCommand = strsql
        GridView1.DataSourceID = SdsData.ID
        GridView1.DataBind()
    End Sub


    Private Sub getDataDiagnosaIADP()
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData2.ConnectionString = connectionString
        Dim strsql As String = ""
        SdsData2.DataSourceMode = SqlDataSourceMode.DataSet
        If (getMonitoringHdrId() <> 0) Then
            strsql = "SELECT  iadp.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                             "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                             ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20," & _
                             "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 FROM Inos_Monitoring_IADP iadp LEFT JOIN  Inos_Monitoring_Trans trans " & _
                             "on trans.in_monitoring_hdr_id = iadp.in_monitoring_id " & _
                             "RIGHT JOIN Inos_monitoring_Item item " & _
                             "ON item.vc_kode = trans.vc_kode " & _
                             "and item.vc_source = trans.vc_source " & _
                             "and iadp.in_monitoring_id= '" & getMonitoringHdrId() & "' " & _
                             "where item.vc_source = 'IADP' " & _
                             "and vc_type = 'Diagnosa' " & _
                             "order by item.in_sequence asc"
        Else
            strsql = "SELECT iadp.*, item.vc_nama,in_monitoring_hdr_id,item.vc_kode, vc_tgl_1,vc_tgl_2,vc_tgl_3, " & _
                     "vc_tgl_4,vc_tgl_5,vc_tgl_6,vc_tgl_7,vc_tgl_8,vc_tgl_9,vc_tgl_10 " & _
                     ",vc_tgl_11,vc_tgl_12,vc_tgl_13,vc_tgl_14,vc_tgl_15,vc_tgl_16,vc_tgl_17,vc_tgl_18,vc_tgl_19,vc_tgl_20, " & _
                     "vc_tgl_21,vc_tgl_22,vc_tgl_23,vc_tgl_24,vc_tgl_25,vc_tgl_26,vc_tgl_27,vc_tgl_28,vc_tgl_29,vc_tgl_30,vc_tgl_31 " & _
                     "FROM Inos_monitoring_Item item LEFT JOIN Inos_Monitoring_Trans trans " & _
                     "ON item.vc_kode = trans.vc_kode " & _
                     "and item.vc_source = trans.vc_source " & _
                     "and item.vc_source = 'IADP' " & _
                     "and trans.in_monitoring_hdr_id = 0 " & _
                     "LEFT JOIN Inos_Monitoring_IADP iadp " & _
                     "on iadp.in_monitoring_id = trans.in_monitoring_hdr_id " & _
                     "where vc_type = 'Diagnosa'  " & _
                     "and item.vc_source = 'IADP' " & _
                 "order by item.in_sequence asc"
        End If

        SdsData2.SelectCommand = strsql
        GridView2.DataSourceID = SdsData2.ID
        GridView2.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

       
        If (Not Page.IsPostBack) Then
            getDataHdr()
            getDataPencegahanIADP()
            getDataDiagnosaIADP()
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

    Protected Sub BtnSaveMonitoringIADP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveMonitoringIADP.Click
        SaveHdr()
        DeleteOldData()
        saveDataPencegahanIADP()
        saveDataDiagnosaIADP()
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
        myCommand.Parameters("@source_id").Value = "IADP"
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
        If (Me.ChkBoxInfeksiIadpYa.Checked) Then
            infeksi = True
        End If

        Try
            If (getMonitoringHdrId() <> 0) Then
                PESAN(Me.chkBoxSubClavia.Checked)
                strsql = "update Inos_Monitoring_IADP set " & _
                         " bt_subclavia = '" & Me.chkBoxSubClavia.Checked & "' " & _
                         ",bt_jugolaris = '" & Me.chkBoxJugolaris.Checked & "' " & _
                         ",bt_femoralis = '" & Me.chkBoxFemoralis.Checked & "' " & _
                         ",bt_cvc_12 =    '" & Me.chkBoxCVC12.Checked & "' " & _
                         ",bt_cvc_7 =    '" & Me.chkBoxCVC7.Checked & "' " & _
                         ",bt_cvc_5 =    '" & Me.chkBoxCVC5.Checked & "' " & _
                         ",  bt_jenis_cvc_4 =    '" & Me.chkBox4Lumen.Checked & "' " & _
                         ",  bt_jenis_cvc_3 =    '" & Me.chkBox3Lumen.Checked & "' " & _
                         ",  bt_jenis_cvc_2 =    '" & Me.chkBox2Lumen.Checked & "' " & _
                         ",  bt_jenis_cvc_1 =    '" & Me.chkBox1Lumen.Checked & "' " & _
                         ",  bt_infeksi_iadp =  '" & infeksi & "' " & _
                         " where in_transaction_id =  '" & Request.QueryString("transactionId") & "' "
            Else
                strsql = "insert into Inos_Monitoring_IADP (in_transaction_id, bt_subclavia,bt_jugolaris,bt_femoralis, " & _
                                                      "bt_cvc_12, bt_cvc_7, bt_cvc_5, " & _
                                                      "bt_jenis_cvc_4,bt_jenis_cvc_3, bt_jenis_cvc_2, bt_jenis_cvc_1, bt_infeksi_iadp )  " & _
                                                                          " values " & _
                                                     "('" & Request.QueryString("transactionId") & "','" & Me.chkBoxSubClavia.Checked & "','" & Me.chkBoxJugolaris.Checked & "','" & Me.chkBoxFemoralis.Checked & "' " & _
                                                     ",'" & Me.chkBoxCVC12.Checked & "','" & Me.chkBoxCVC7.Checked & "','" & Me.chkBoxCVC5.Checked & "'" & _
                                                     ",'" & Me.chkBox4Lumen.Checked & "','" & Me.chkBox3Lumen.Checked & "','" & Me.chkBox2Lumen.Checked & "','" & Me.chkBox1Lumen.Checked & "','" & infeksi & "')"



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
    Private Sub saveDataPencegahanIADP()
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
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','IADP','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
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

    Private Sub saveDataDiagnosaIADP()
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
                                                      "('" & getMonitoringHdrId() & "','" & vc_kode & "','IADP','" & tgl_1 & "','" & tgl_2 & "','" & tgl_3 & "','" & tgl_4 & "','" & tgl_5 & "','" & tgl_6 & "' " & _
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
