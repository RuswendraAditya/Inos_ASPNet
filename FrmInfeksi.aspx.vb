Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class FrmInfeksi
    Inherits System.Web.UI.Page

    Private lFlag As String = "Generate"

    Protected Sub CmdSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Dim lLengkap As Boolean = True


        Select Case CmdSimpan.Text
            Case "Input"
                Me.Enableds(True)
                CmdSimpan.Text = "Simpan"
                CmdBatal.Text = "Batal"
                Me.TxtKode.Text = lFlag
                InputData()
                TxtNama.Focus()
            Case "Simpan"
                'validasi data
                lLengkap = True

                If Me.TxtKode.Text = "" Then
                    PESAN("Kode harus diisi!...")
                    lLengkap = False
                    Me.TxtKode.Focus()
                    Exit Sub
                End If


                If Me.TxtNama.Text = "" Then
                    PESAN("Nama harus diisi!...")
                    lLengkap = False
                    Me.TxtNama.Focus()
                    Exit Sub
                End If

                If lLengkap Then
                    Try
                        'data save
                        If simpanData() = True Then
                            'MyTrans.Commit()
                            Me.Enableds(False)
                            CmdSimpan.Text = "Input"
                            CmdBatal.Text = "Keluar"
                            'ShowGrid()
                            PESAN("Data Berhasil disimpan...")
                            isigrid()
                            GridView1.DataSourceID = SdsData.ID
                        End If
                    Catch ex As Exception
                        'MyTrans.Rollback()
                        PESAN("Data Gagal disimpan!...")
                    End Try
                Else
                    PESAN("Data Harus dilengkapi!...")
                    Me.TxtNama.Focus()
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
        Me.TxtNama.Enabled = lStatus
    End Sub

    Private Sub InputData()
        Me.TxtNama.Text = ""
        Me.TxtKode.Text = lFlag
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
            If Me.TxtKode.Text = lFlag Then
                'Buat Kode
                cKode = MasterLib.GenCounterKode("IF", command)
                Me.TxtKode.Text = cKode
                strsql = "insert into Inos_MASTER_INFEKSI(vc_kd_infeksi, vc_nm_infeksi, vc_operator) " & _
                                             "values " & _
                                                    "('" & Me.TxtKode.Text & "', '" & Me.TxtNama.Text & "', '" & Session("ssUserName") & "')"
            Else
                strsql = "update Inos_MASTER_infeksi set " & _
                                " VC_NM_INFEKSI= '" & Me.TxtNama.Text & "' " & _
                                "where vc_kd_infeksi = '" & Me.TxtKode.Text & "' "
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
        Dim Param As Parameter
        Dim strsql As String = ""

        Dim ntahun As Integer = Year(MasterLib.GetCurrentDate)
        Dim nBulan As Integer = Month(MasterLib.GetCurrentDate)
        ' pegaturan untuk grid pasien

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        strsql = "SELECT vc_kd_infeksi, vc_nm_infeksi from inos_master_infeksi order by vc_kd_infeksi"
        SdsData.SelectCommand = strsql

        SdsData.DeleteCommand = "DELETE FROM inos_master_infeksi " _
            & "WHERE vc_kd_infeksi= @vckode "

        ' parameter delete
        Param = New Parameter("vckode", TypeCode.String)
        SdsData.DeleteParameters.Add(Param)


        GridView1.DataSourceID = SdsData.ID
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'isigrid()
    End Sub

    Private Sub isigrid()
        Dim strsql As String = ""

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        Try

            strsql = "SELECT VC_KD_infeksi, vc_nm_infeksi from inos_master_infeksi"

            SdsData.SelectCommand = strsql

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If (e.CommandName.Equals("Update")) Then
        ElseIf (e.CommandName.Equals("Delete")) Then
            If e.CommandArgument <> "00000" Then
                SdsData.DeleteParameters("vckode").DefaultValue = e.CommandArgument
                SdsData.Delete()
            Else
                PESAN("Data ini tidak bisa dihapus!...")
                Exit Sub
            End If
        ElseIf (e.CommandName.Equals("Edit")) Then
            If e.CommandArgument <> "00000" Then
                Me.TxtKode.Text = e.CommandArgument
                GetData()
                Me.CmdSimpan.Text = "Simpan"
                Me.CmdBatal.Text = "Batal"
                Me.TxtKode.Focus()
            Else
                PESAN("Data ini tidak bisa diedit!...")
                Exit Sub
            End If

            End If
    End Sub

    Function GetData() As Boolean
        Dim strsql As String = ""
        Dim cKodeGugus As String = ""

        GetData = False

        strsql = "SELECT VC_KD_INfeksi, VC_NM_INfeksi from inos_master_infeksi where vc_kd_infeksi = '" & Me.TxtKode.Text & "' "

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            GetData = True
            Me.TxtNama.Text = dr("vc_nm_infeksi")
            'Me.TxtRupiah.Text = Double.Parse(dr("dc_rupiah"))
            Exit While
        End While
        dr.Close()
    End Function

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
