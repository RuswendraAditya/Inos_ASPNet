Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration


Public Class ArRekapSurveilans 
    Inherits DataDynamics.ActiveReports.ActiveReport3

    Private param As String
    Private WithEvents label9 As DataDynamics.ActiveReports.Label
    Private WithEvents TxtNoRM As DataDynamics.ActiveReports.TextBox
    Private WithEvents line1 As DataDynamics.ActiveReports.Line
    Private WithEvents line2 As DataDynamics.ActiveReports.Line
    Private WithEvents line3 As DataDynamics.ActiveReports.Line
    Dim datareader As SqlClient.SqlDataReader

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region " ActiveReports Designer generated code "
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents TXTTANGGAL As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTNAMARS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTALAMATRS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTKOTARS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTYAYASAN As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTTELPON As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TXTTGLCETAK As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents TxtNamaKlinik As DataDynamics.ActiveReports.TextBox
    Private WithEvents label2 As DataDynamics.ActiveReports.Label
    Private WithEvents label5 As DataDynamics.ActiveReports.Label
    Private WithEvents label6 As DataDynamics.ActiveReports.Label
    Private WithEvents label7 As DataDynamics.ActiveReports.Label
    Private WithEvents label8 As DataDynamics.ActiveReports.Label
    Private WithEvents groupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents groupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TxtTglMsk As DataDynamics.ActiveReports.TextBox
    Private WithEvents TxtKamar As DataDynamics.ActiveReports.TextBox
    Private WithEvents TxtNamaPasien As DataDynamics.ActiveReports.TextBox
    Private WithEvents TxtUmur As DataDynamics.ActiveReports.TextBox
    Private WithEvents TxtJK As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "ArRekapSurveilans.resx"
        Dim resources As System.Resources.ResourceManager = GetResourceManager()
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.TXTTANGGAL = New DataDynamics.ActiveReports.TextBox
        Me.TXTNAMARS = New DataDynamics.ActiveReports.TextBox
        Me.TXTALAMATRS = New DataDynamics.ActiveReports.TextBox
        Me.TXTKOTARS = New DataDynamics.ActiveReports.TextBox
        Me.TXTYAYASAN = New DataDynamics.ActiveReports.TextBox
        Me.TXTTELPON = New DataDynamics.ActiveReports.TextBox
        Me.TXTTGLCETAK = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.TxtNamaKlinik = New DataDynamics.ActiveReports.TextBox
        Me.label2 = New DataDynamics.ActiveReports.Label
        Me.label5 = New DataDynamics.ActiveReports.Label
        Me.label6 = New DataDynamics.ActiveReports.Label
        Me.label7 = New DataDynamics.ActiveReports.Label
        Me.label8 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TxtTglMsk = New DataDynamics.ActiveReports.TextBox
        Me.TxtKamar = New DataDynamics.ActiveReports.TextBox
        Me.TxtNamaPasien = New DataDynamics.ActiveReports.TextBox
        Me.TxtUmur = New DataDynamics.ActiveReports.TextBox
        Me.TxtJK = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.groupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.groupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.label9 = New DataDynamics.ActiveReports.Label
        Me.TxtNoRM = New DataDynamics.ActiveReports.TextBox
        Me.line1 = New DataDynamics.ActiveReports.Line
        Me.line2 = New DataDynamics.ActiveReports.Line
        Me.line3 = New DataDynamics.ActiveReports.Line
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTTANGGAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTNAMARS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTALAMATRS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTKOTARS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTYAYASAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTTELPON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTTGLCETAK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNamaKlinik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglMsk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNamaPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUmur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtJK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.TXTTANGGAL, Me.TXTNAMARS, Me.TXTALAMATRS, Me.TXTKOTARS, Me.TXTYAYASAN, Me.TXTTELPON, Me.TXTTGLCETAK, Me.ReportInfo1, Me.Label3, Me.Label4, Me.TxtNamaKlinik, Me.label2, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.line1, Me.line2})
        Me.PageHeader1.Height = 1.885417!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.6875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-align: right; font-weight: bold; font-size: 12pt; "
        Me.Label1.Text = "FORMULIR REKAPAN SURVEILANS HARIAN INFEKSI RUMAH SAKIT"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 6.6875!
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTTANGGAL.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTANGGAL.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTTANGGAL.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTANGGAL.Border.RightColor = System.Drawing.Color.Black
        Me.TXTTANGGAL.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTANGGAL.Border.TopColor = System.Drawing.Color.Black
        Me.TXTTANGGAL.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTANGGAL.Height = 0.25!
        Me.TXTTANGGAL.Left = 5.0!
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Style = "text-align: right; font-weight: bold; font-size: 12pt; "
        Me.TXTTANGGAL.Text = "Tanggal :"
        Me.TXTTANGGAL.Top = 0.3125!
        Me.TXTTANGGAL.Width = 4.375!
        '
        'TXTNAMARS
        '
        Me.TXTNAMARS.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTNAMARS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTNAMARS.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTNAMARS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTNAMARS.Border.RightColor = System.Drawing.Color.Black
        Me.TXTNAMARS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTNAMARS.Border.TopColor = System.Drawing.Color.Black
        Me.TXTNAMARS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTNAMARS.Height = 0.25!
        Me.TXTNAMARS.Left = 0.0!
        Me.TXTNAMARS.MultiLine = False
        Me.TXTNAMARS.Name = "TXTNAMARS"
        Me.TXTNAMARS.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9pt; "
        Me.TXTNAMARS.Text = Nothing
        Me.TXTNAMARS.Top = 0.1875!
        Me.TXTNAMARS.Width = 3.6875!
        '
        'TXTALAMATRS
        '
        Me.TXTALAMATRS.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTALAMATRS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTALAMATRS.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTALAMATRS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTALAMATRS.Border.RightColor = System.Drawing.Color.Black
        Me.TXTALAMATRS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTALAMATRS.Border.TopColor = System.Drawing.Color.Black
        Me.TXTALAMATRS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTALAMATRS.Height = 0.25!
        Me.TXTALAMATRS.Left = 0.0!
        Me.TXTALAMATRS.MultiLine = False
        Me.TXTALAMATRS.Name = "TXTALAMATRS"
        Me.TXTALAMATRS.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; "
        Me.TXTALAMATRS.Text = Nothing
        Me.TXTALAMATRS.Top = 0.375!
        Me.TXTALAMATRS.Width = 3.6875!
        '
        'TXTKOTARS
        '
        Me.TXTKOTARS.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTKOTARS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTKOTARS.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTKOTARS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTKOTARS.Border.RightColor = System.Drawing.Color.Black
        Me.TXTKOTARS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTKOTARS.Border.TopColor = System.Drawing.Color.Black
        Me.TXTKOTARS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTKOTARS.Height = 0.25!
        Me.TXTKOTARS.Left = 0.0!
        Me.TXTKOTARS.MultiLine = False
        Me.TXTKOTARS.Name = "TXTKOTARS"
        Me.TXTKOTARS.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; "
        Me.TXTKOTARS.Text = Nothing
        Me.TXTKOTARS.Top = 0.5625!
        Me.TXTKOTARS.Width = 3.6875!
        '
        'TXTYAYASAN
        '
        Me.TXTYAYASAN.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTYAYASAN.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTYAYASAN.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTYAYASAN.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTYAYASAN.Border.RightColor = System.Drawing.Color.Black
        Me.TXTYAYASAN.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTYAYASAN.Border.TopColor = System.Drawing.Color.Black
        Me.TXTYAYASAN.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTYAYASAN.Height = 0.25!
        Me.TXTYAYASAN.Left = 0.0!
        Me.TXTYAYASAN.MultiLine = False
        Me.TXTYAYASAN.Name = "TXTYAYASAN"
        Me.TXTYAYASAN.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9pt; "
        Me.TXTYAYASAN.Text = Nothing
        Me.TXTYAYASAN.Top = 0.0!
        Me.TXTYAYASAN.Width = 3.6875!
        '
        'TXTTELPON
        '
        Me.TXTTELPON.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTTELPON.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTELPON.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTTELPON.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTELPON.Border.RightColor = System.Drawing.Color.Black
        Me.TXTTELPON.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTELPON.Border.TopColor = System.Drawing.Color.Black
        Me.TXTTELPON.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTELPON.Height = 0.25!
        Me.TXTTELPON.Left = 0.0!
        Me.TXTTELPON.MultiLine = False
        Me.TXTTELPON.Name = "TXTTELPON"
        Me.TXTTELPON.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; "
        Me.TXTTELPON.Text = Nothing
        Me.TXTTELPON.Top = 0.75!
        Me.TXTTELPON.Width = 3.6875!
        '
        'TXTTGLCETAK
        '
        Me.TXTTGLCETAK.Border.BottomColor = System.Drawing.Color.Black
        Me.TXTTGLCETAK.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTGLCETAK.Border.LeftColor = System.Drawing.Color.Black
        Me.TXTTGLCETAK.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTGLCETAK.Border.RightColor = System.Drawing.Color.Black
        Me.TXTTGLCETAK.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTGLCETAK.Border.TopColor = System.Drawing.Color.Black
        Me.TXTTGLCETAK.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TXTTGLCETAK.Height = 0.1875!
        Me.TXTTGLCETAK.Left = 7.875!
        Me.TXTTGLCETAK.MultiLine = False
        Me.TXTTGLCETAK.Name = "TXTTGLCETAK"
        Me.TXTTGLCETAK.Style = "ddo-char-set: 0; text-align: right; font-style: normal; font-size: 9pt; "
        Me.TXTTGLCETAK.Text = "Tanggal :"
        Me.TXTTGLCETAK.Top = 0.75!
        Me.TXTTGLCETAK.Width = 1.5!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "{PageNumber} dari {PageCount}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 8.5!
        Me.ReportInfo1.MultiLine = False
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; "
        Me.ReportInfo1.Top = 0.5625!
        Me.ReportInfo1.Width = 0.875!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 7.4375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = ""
        Me.Label3.Text = "Tgl.Cetak  :"
        Me.Label3.Top = 0.75!
        Me.Label3.Width = 1.0!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 7.4375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "Halaman   :"
        Me.Label4.Top = 0.5625!
        Me.Label4.Width = 1.0!
        '
        'TxtNamaKlinik
        '
        Me.TxtNamaKlinik.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtNamaKlinik.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaKlinik.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtNamaKlinik.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaKlinik.Border.RightColor = System.Drawing.Color.Black
        Me.TxtNamaKlinik.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaKlinik.Border.TopColor = System.Drawing.Color.Black
        Me.TxtNamaKlinik.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaKlinik.Height = 0.25!
        Me.TxtNamaKlinik.Left = 0.0!
        Me.TxtNamaKlinik.MultiLine = False
        Me.TxtNamaKlinik.Name = "TxtNamaKlinik"
        Me.TxtNamaKlinik.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Times New Roman; "
        Me.TxtNamaKlinik.Text = Nothing
        Me.TxtNamaKlinik.Top = 1.0!
        Me.TxtNamaKlinik.Width = 3.6875!
        '
        'label2
        '
        Me.label2.Border.BottomColor = System.Drawing.Color.Black
        Me.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label2.Border.LeftColor = System.Drawing.Color.Black
        Me.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label2.Border.RightColor = System.Drawing.Color.Black
        Me.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label2.Border.TopColor = System.Drawing.Color.Black
        Me.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label2.Height = 0.1875!
        Me.label2.HyperLink = Nothing
        Me.label2.Left = 0.125!
        Me.label2.Name = "label2"
        Me.label2.Style = ""
        Me.label2.Text = "Tanggal"
        Me.label2.Top = 1.625!
        Me.label2.Width = 0.5625!
        '
        'label5
        '
        Me.label5.Border.BottomColor = System.Drawing.Color.Black
        Me.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label5.Border.LeftColor = System.Drawing.Color.Black
        Me.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label5.Border.RightColor = System.Drawing.Color.Black
        Me.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label5.Border.TopColor = System.Drawing.Color.Black
        Me.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label5.Height = 0.1875!
        Me.label5.HyperLink = Nothing
        Me.label5.Left = 0.8125!
        Me.label5.Name = "label5"
        Me.label5.Style = ""
        Me.label5.Text = "Kamar"
        Me.label5.Top = 1.625!
        Me.label5.Width = 0.5625!
        '
        'label6
        '
        Me.label6.Border.BottomColor = System.Drawing.Color.Black
        Me.label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label6.Border.LeftColor = System.Drawing.Color.Black
        Me.label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label6.Border.RightColor = System.Drawing.Color.Black
        Me.label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label6.Border.TopColor = System.Drawing.Color.Black
        Me.label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label6.Height = 0.1875!
        Me.label6.HyperLink = Nothing
        Me.label6.Left = 2.6875!
        Me.label6.Name = "label6"
        Me.label6.Style = ""
        Me.label6.Text = "Nama Pasien"
        Me.label6.Top = 1.625!
        Me.label6.Width = 1.0625!
        '
        'label7
        '
        Me.label7.Border.BottomColor = System.Drawing.Color.Black
        Me.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label7.Border.LeftColor = System.Drawing.Color.Black
        Me.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label7.Border.RightColor = System.Drawing.Color.Black
        Me.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label7.Border.TopColor = System.Drawing.Color.Black
        Me.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label7.Height = 0.1875!
        Me.label7.HyperLink = Nothing
        Me.label7.Left = 4.0!
        Me.label7.Name = "label7"
        Me.label7.Style = ""
        Me.label7.Text = "Umur"
        Me.label7.Top = 1.625!
        Me.label7.Width = 0.375!
        '
        'label8
        '
        Me.label8.Border.BottomColor = System.Drawing.Color.Black
        Me.label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label8.Border.LeftColor = System.Drawing.Color.Black
        Me.label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label8.Border.RightColor = System.Drawing.Color.Black
        Me.label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label8.Border.TopColor = System.Drawing.Color.Black
        Me.label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label8.Height = 0.1875!
        Me.label8.HyperLink = Nothing
        Me.label8.Left = 4.5625!
        Me.label8.Name = "label8"
        Me.label8.Style = ""
        Me.label8.Text = "JK"
        Me.label8.Top = 1.625!
        Me.label8.Width = 0.375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TxtTglMsk, Me.TxtKamar, Me.TxtNamaPasien, Me.TxtUmur, Me.TxtJK, Me.TxtNoRM, Me.line3})
        Me.Detail1.Height = 0.2708333!
        Me.Detail1.Name = "Detail1"
        '
        'TxtTglMsk
        '
        Me.TxtTglMsk.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtTglMsk.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtTglMsk.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtTglMsk.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtTglMsk.Border.RightColor = System.Drawing.Color.Black
        Me.TxtTglMsk.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtTglMsk.Border.TopColor = System.Drawing.Color.Black
        Me.TxtTglMsk.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtTglMsk.Height = 0.1875!
        Me.TxtTglMsk.Left = 0.125!
        Me.TxtTglMsk.Name = "TxtTglMsk"
        Me.TxtTglMsk.Style = ""
        Me.TxtTglMsk.Text = Nothing
        Me.TxtTglMsk.Top = 0.0!
        Me.TxtTglMsk.Width = 0.625!
        '
        'TxtKamar
        '
        Me.TxtKamar.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtKamar.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtKamar.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtKamar.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtKamar.Border.RightColor = System.Drawing.Color.Black
        Me.TxtKamar.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtKamar.Border.TopColor = System.Drawing.Color.Black
        Me.TxtKamar.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtKamar.Height = 0.1875!
        Me.TxtKamar.Left = 0.8125!
        Me.TxtKamar.Name = "TxtKamar"
        Me.TxtKamar.Style = ""
        Me.TxtKamar.Text = Nothing
        Me.TxtKamar.Top = 0.0!
        Me.TxtKamar.Width = 0.9375!
        '
        'TxtNamaPasien
        '
        Me.TxtNamaPasien.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtNamaPasien.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaPasien.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtNamaPasien.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaPasien.Border.RightColor = System.Drawing.Color.Black
        Me.TxtNamaPasien.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaPasien.Border.TopColor = System.Drawing.Color.Black
        Me.TxtNamaPasien.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNamaPasien.Height = 0.1875!
        Me.TxtNamaPasien.Left = 2.6875!
        Me.TxtNamaPasien.Name = "TxtNamaPasien"
        Me.TxtNamaPasien.Style = ""
        Me.TxtNamaPasien.Text = Nothing
        Me.TxtNamaPasien.Top = 0.0!
        Me.TxtNamaPasien.Width = 1.25!
        '
        'TxtUmur
        '
        Me.TxtUmur.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtUmur.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtUmur.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtUmur.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtUmur.Border.RightColor = System.Drawing.Color.Black
        Me.TxtUmur.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtUmur.Border.TopColor = System.Drawing.Color.Black
        Me.TxtUmur.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtUmur.Height = 0.1875!
        Me.TxtUmur.Left = 4.0!
        Me.TxtUmur.Name = "TxtUmur"
        Me.TxtUmur.Style = ""
        Me.TxtUmur.Text = Nothing
        Me.TxtUmur.Top = 0.0!
        Me.TxtUmur.Width = 0.5!
        '
        'TxtJK
        '
        Me.TxtJK.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtJK.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtJK.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtJK.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtJK.Border.RightColor = System.Drawing.Color.Black
        Me.TxtJK.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtJK.Border.TopColor = System.Drawing.Color.Black
        Me.TxtJK.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtJK.Height = 0.1875!
        Me.TxtJK.Left = 4.5625!
        Me.TxtJK.Name = "TxtJK"
        Me.TxtJK.Style = ""
        Me.TxtJK.Text = Nothing
        Me.TxtJK.Top = 0.0!
        Me.TxtJK.Width = 0.5!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'groupHeader1
        '
        Me.groupHeader1.Height = 0.0!
        Me.groupHeader1.Name = "groupHeader1"
        '
        'groupFooter1
        '
        Me.groupFooter1.Height = 0.0!
        Me.groupFooter1.Name = "groupFooter1"
        '
        'label9
        '
        Me.label9.Border.BottomColor = System.Drawing.Color.Black
        Me.label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label9.Border.LeftColor = System.Drawing.Color.Black
        Me.label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label9.Border.RightColor = System.Drawing.Color.Black
        Me.label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label9.Border.TopColor = System.Drawing.Color.Black
        Me.label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.label9.Height = 0.1875!
        Me.label9.HyperLink = Nothing
        Me.label9.Left = 1.875!
        Me.label9.Name = "label9"
        Me.label9.Style = ""
        Me.label9.Text = "No.RM"
        Me.label9.Top = 1.625!
        Me.label9.Width = 0.5625!
        '
        'TxtNoRM
        '
        Me.TxtNoRM.Border.BottomColor = System.Drawing.Color.Black
        Me.TxtNoRM.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNoRM.Border.LeftColor = System.Drawing.Color.Black
        Me.TxtNoRM.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNoRM.Border.RightColor = System.Drawing.Color.Black
        Me.TxtNoRM.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNoRM.Border.TopColor = System.Drawing.Color.Black
        Me.TxtNoRM.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TxtNoRM.Height = 0.1875!
        Me.TxtNoRM.Left = 1.8125!
        Me.TxtNoRM.Name = "TxtNoRM"
        Me.TxtNoRM.Style = "color: Blue; "
        Me.TxtNoRM.Text = Nothing
        Me.TxtNoRM.Top = 0.0!
        Me.TxtNoRM.Width = 0.8125!
        '
        'line1
        '
        Me.line1.Border.BottomColor = System.Drawing.Color.Black
        Me.line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line1.Border.LeftColor = System.Drawing.Color.Black
        Me.line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line1.Border.RightColor = System.Drawing.Color.Black
        Me.line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line1.Border.TopColor = System.Drawing.Color.Black
        Me.line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line1.Height = 0.0!
        Me.line1.Left = 0.125!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.5625!
        Me.line1.Width = 6.25!
        Me.line1.X1 = 0.125!
        Me.line1.X2 = 6.375!
        Me.line1.Y1 = 1.5625!
        Me.line1.Y2 = 1.5625!
        '
        'line2
        '
        Me.line2.Border.BottomColor = System.Drawing.Color.Black
        Me.line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line2.Border.LeftColor = System.Drawing.Color.Black
        Me.line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line2.Border.RightColor = System.Drawing.Color.Black
        Me.line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line2.Border.TopColor = System.Drawing.Color.Black
        Me.line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line2.Height = 0.0!
        Me.line2.Left = 0.125!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.875!
        Me.line2.Width = 6.25!
        Me.line2.X1 = 0.125!
        Me.line2.X2 = 6.375!
        Me.line2.Y1 = 1.875!
        Me.line2.Y2 = 1.875!
        '
        'line3
        '
        Me.line3.Border.BottomColor = System.Drawing.Color.Black
        Me.line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line3.Border.LeftColor = System.Drawing.Color.Black
        Me.line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line3.Border.RightColor = System.Drawing.Color.Black
        Me.line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line3.Border.TopColor = System.Drawing.Color.Black
        Me.line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.line3.Height = 0.0!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.25!
        Me.line3.Width = 6.25!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 6.25!
        Me.line3.Y1 = 0.25!
        Me.line3.Y2 = 0.25!
        '
        'ArRekapSurveilans
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 9.40625!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.groupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.groupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTTANGGAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTNAMARS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTALAMATRS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTKOTARS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTYAYASAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTTELPON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTTGLCETAK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNamaKlinik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglMsk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNamaPasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUmur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtJK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

    Private Function GetResourceManager() As System.Resources.ResourceManager
        Return Resources.ArRekapSurveilans.ResourceManager

    End Function

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub ArRekapSurveilans_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Fields.Add("dt_tgl_trans")
        Fields.Add("vc_no_rm")
        Fields.Add("vc_nama_p")
        Fields.Add("vc_alamat")

        Me.TxtNoRM.DataField = "VC_NO_RM"
        Me.TxtNamaPasien.DataField = "VC_NAMA_P"

    End Sub

    Private Sub ArRekapSurveilans_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        'jika menggunakan table database
        'dengan terlebih dahulu menginisialisai dulu field nya di rptUnboundGrp_DataInitialize
        'Me.label4.Text = "paguyuban"

        Try
            datareader.Read()
            Me.Fields("vc_no_rm").Value = datareader("vc_no_rm")
            Me.Fields("vc_nama_p").Value = datareader("vc_nama_p")
            Me.Fields("vc_alamat").Value = datareader("vc_alamat")
            eArgs.EOF = False
        Catch ex As Exception
            'System.Windows.Forms.MessageBox.Show(ex.ToString())
            eArgs.EOF = True
        End Try

        'jika mau pakai datatable atau perulangan yg kita tentukan
        'batasan data di tentukan disini
        'dan untuk mengisi di textboxnya di definisikan di detil_format

        'If i >= 10 Then
        '    eArgs.EOF = True
        'Else
        '    eArgs.EOF = False
        '    i = i + 1
        'End If

    End Sub

    Private Sub ArRekapSurveilans_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim rpt As New ArRekapSurveilans
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("koneksi").ConnectionString
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim strsql As String = "select aa.dt_tgl_trans, bb.vc_no_rm,  bb.vc_nama_p, bb.vc_alamat " & _
                               "from Inos_Surveilans aa inner join rmpasien bb " & _
                               "on aa.vc_no_rm = bb.vc_no_rm "



        Dim sqlCommand As New SqlClient.SqlCommand(strsql)
        sqlCommand.Connection = connection
        connection.Open()

        datareader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection)

    End Sub
End Class
