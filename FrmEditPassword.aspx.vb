Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration

Partial Class FrmEditPassword
    Inherits System.Web.UI.Page

    Protected Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        'cek password lama
        'Dim cpasswordlama As String = MasterLib.cekusername("vc_username", "vc_Password", "skrjabatan", Session("ssusername"), Me.ddljabatan.SelectedValue, "")

        If MasterLib.CheckUser(Session("ssusername"), Me.txtPasswordLama.Text, "") = False Then
            PESAN("Password Lama anda salah!...")
            Me.txtPasswordLama.Focus()
            Exit Sub
        End If

        If Me.TxtPassBaru.Text = "" Then
            PESAN("Password harus diisi!...")
            Exit Sub
        End If

        If Me.TxtPassBaru.Text <> Me.TxtUlangiPasswordBaru.Text Then
            PESAN("Pengulangan password dengan password baru tidak sama!...")
            Exit Sub
        End If

        Dim strsql As String = ""
        Dim lFound As Boolean = False
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()

        Try
            'update
            strsql = "update pde_user set vc_password = '" & MasterLib.ConvertPass(Me.TxtUlangiPasswordBaru.Text, "E") & _
                     "' where vc_username = '" & Session("ssusername") & "'"

            connection.Open()
            command.Connection = connection
            command.CommandText = strsql
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()

            PESAN("Password Berhasil diperbaharui...")

        Catch ex As Exception
            PESAN("Password gagal diperbaharui...")
        End Try

    End Sub

    Private Sub PESAN(ByVal cpesan As String)
        ClientScript.RegisterStartupScript(Me.GetType, "ClientSideScript", "<script type='text/javascript'>window.alert('" & cpesan & "')</script>")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("~/beranda.aspx")
    End Sub

End Class
