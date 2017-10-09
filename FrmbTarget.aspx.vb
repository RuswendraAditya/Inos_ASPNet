Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html
Imports iTextSharp.text.html.simpleparser

Partial Class FrmbTarget
    Inherits System.Web.UI.Page
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim Param As Parameter

        ' pegaturan untuk grid pasien

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        SdsData.ConnectionString = connectionString

        SdsData.DataSourceMode = SqlDataSourceMode.DataSet
        SdsData.ProviderName = "System.Data.SqlClient"

        SdsData.SelectCommand = "SELECT vc_kode, " _
                                & "vc_nama_surveilans, dc_target FROM inos_master_target "

        'SdsData.SelectCommand = "SELECT vc_kode, " _
        '                        & "vc_nama_surveilans, dc_target FROM inos_master_target"


        'SdsData.DeleteCommand = "DELETE FROM pubmitrakerja " _
        '    & "WHERE vc_kode = @vckode"

        SdsData.UpdateCommand = "UPDATE inos_master_target SET " _
            & "vc_nama_surveilans = @vcnamasurveilans, dc_target = @dctarget " _
            & "WHERE vc_kode = @vckode "

        ' parameter select
        'Param = New Parameter("vckode", TypeCode.String)
        'SdsData.SelectParameters.Add(Param)

        ' parameter  update
        Param = New Parameter("vckode", TypeCode.String)
        SdsData.UpdateParameters.Add(Param)

        Param = New Parameter("vcnamasurveilans", TypeCode.String)
        SdsData.UpdateParameters.Add(Param)

        Param = New Parameter("dctarget", TypeCode.String)
        SdsData.UpdateParameters.Add(Param)

        ' parameter delete
        'Param = New Parameter("vckode", TypeCode.String)
        'SdsData.DeleteParameters.Add(Param)

        GridView1.DataSourceID = SdsData.ID
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'If (Session("ssotorisasipassword") = "" Or Session("sshakakses") <> "OK") Or Session("sshaksession") <> "sukses" Then
            '    Response.Redirect("~/default.aspx")
            'End If

            'SetDataSourceMitra()
            'GridView1.DataSourceID = SdsMitra.ID
        End If
    End Sub

    Private Sub SetDataSourcetARGET()
        'Dim Param As Parameter
        '' pegaturan untuk grid pasien

        'Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        'Dim connection As SqlConnection = New SqlConnection(connectionString)

        'SdsMitra.ConnectionString = connectionString

        'SdsMitra.DataSourceMode = SqlDataSourceMode.DataSet
        'SdsMitra.ProviderName = "System.Data.SqlClient"

        'SdsMitra.SelectCommand = "SELECT vc_kode, " _
        '    & "vc_nama_mitra, vc_alamat, vc_phone FROM pubmitrakerja where vc_kode_paguyuban = '" & Session("codepaguyuban") & "' order by vc_nama_mitra "


        'SdsMitra.SelectCommand = "SELECT vc_kode, " _
        '                       & "vc_nama_mitra, vc_alamat, vc_phone FROM pubmitrakerja where vc_kode_paguyuban = '" & Session("codepaguyuban") & "' order by vc_nama_mitra "

        'SdsMitra.DeleteCommand = "DELETE FROM pubmitrakerja " _
        '    & "WHERE vc_kode = @vckode"

        'SdsMitra.UpdateCommand = "UPDATE pubmitrakerja SET " _
        '    & "vc_nama_mitra = @vcnamamitra, vc_alamat = @vcalamat, vc_phone = @vcphone " _
        '    & "WHERE vc_kode = @vckode and vc_kode_paguyuban = '" & Session("codepaguyuban") & "' "

        '' parameter  update
        'Param = New Parameter("vckode", TypeCode.String)
        'SdsMitra.UpdateParameters.Add(Param)

        'Param = New Parameter("vcnamamitra", TypeCode.String)
        'SdsMitra.UpdateParameters.Add(Param)
        'Param = New Parameter("vcalamat", TypeCode.String)
        'SdsMitra.UpdateParameters.Add(Param)
        'Param = New Parameter("vcphone", TypeCode.String)
        'SdsMitra.UpdateParameters.Add(Param)

        '' parameter delete
        'Param = New Parameter("vckode", TypeCode.String)
        'SdsMitra.DeleteParameters.Add(Param)

    End Sub


    Protected Sub GridView1_RowCommand(ByVal sender As _
               Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) _
               Handles GridView1.RowCommand

        If (e.CommandName.Equals("Update")) Then
            Dim nText As String = ""
            Dim tBox As TextBox
            tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtkode"), TextBox)
            SdsData.UpdateParameters("vckode").DefaultValue = tBox.Text

            tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txtnamasurveilans"), TextBox)
            SdsData.UpdateParameters("vcnamasurveilans").DefaultValue = tBox.Text

            tBox = CType(GridView1.Rows(GridView1.EditIndex).FindControl("txttarget"), TextBox)
            SdsData.UpdateParameters("dctarget").DefaultValue = tBox.Text

            SdsData.Update()
        ElseIf (e.CommandName.Equals("Delete")) Then
            Dim cKodeMitra As String = Convert.ToString(e.CommandArgument).ToString
            'DelShowMitra(cKodeMitra)

            'SdsData.DeleteParameters("vckode").DefaultValue = e.CommandArgument
            'SdsData.Delete()

        End If

    End Sub
    Private Sub DelShowMitra(ByVal ckodemitra As String)
        Dim sqlConnectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim sqlConnection As SqlClient.SqlConnection = New SqlClient.SqlConnection(sqlConnectionString)
        Dim strsql As String = ""
        Dim cKodepaguyuban As String = ""
        Dim cKode As String = ""
        Dim cNama As String = ""
        Dim cAlamat As String = ""
        Dim cPhone As String = ""
        Dim cKodekota As String = ""
        Dim cOPerator As String = ""
        Dim cCreate_date As String = ""

        strsql = "SELECT vc_kode_paguyuban, vc_kode, vc_nama_mitra, vc_alamat, vc_phone, vc_kd_kota,  " & _
                 "vc_operator, dt_create_date FROM pubmitrakerja Where vc_kode = '" & ckodemitra & "' AND vc_kode_paguyuban = '" & Session("codepaguyuban") & "' "

        Dim sqlCommand As New SqlClient.SqlCommand(strsql)

        sqlCommand.Connection = sqlConnection
        sqlConnection.Open()

        Dim dr As SqlClient.SqlDataReader
        dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            cKodepaguyuban = dr("vc_kode_paguyuban").ToString
            cKode = dr("vc_kode").ToString
            cNama = dr("vc_nama_mitra").ToString
            cAlamat = dr("vc_alamat").ToString
            cPhone = dr("vc_phone").ToString
            cKodekota = dr("vc_kd_kota").ToString
            cOPerator = dr("vc_operator").ToString
            cCreate_date = dr("dt_create_date").ToString
        End While
        dr.Close()

        'simpan data
        strsql = "insert into xpubMitraKerja(vc_kode_paguyuban, VC_kode, VC_nama_Mitra, vc_alamat, vc_phone, vc_kd_kota, dt_create_date, vc_operator) " & _
             "values ('" & cKodepaguyuban & "', '" & cKode & "','" & Trim(cNama) & "', '" & Trim(cAlamat) & "', '" & cPhone & "', '" & cKodekota & "', '" & Date.Now.ToString("M/dd/yyyy") & "' , '" & Session("ssotorisasipassword") & "')"

        'strsql = "insert into xpubMitraKerja(VC_kode, VC_nama_Mitra)values ('" & cKode & "','" & Trim(cNama) & "')"

        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand()
        connection.Open()
        command.Connection = connection
        command.CommandText = strsql
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()

        command.Dispose()
        connection.Close()

    End Sub





End Class
