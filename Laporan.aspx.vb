
Partial Class Laporan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then

            'subds.ConnectionString = connectionString
            'subds.SQL = "select * from setup_paguyuban"

            ' it's not a postback, so populate that combo
            Me.cboViewerType.Items.Clear()
            Me.cboViewerType.Items.Add("HtmlViewer")
            Me.cboViewerType.Items.Add("ActiveXViewer")
            Me.cboViewerType.Items.Add("PDF Reader")
            Me.cboViewerType.Items.Add("RawHtml")
            Me.cboViewerType.SelectedIndex = 0 ' the default is HTML.

            'With rpt
            '.DataSource = subds

            '    '    .Run(False)
            'End With

        End If
    End Sub

    Protected Sub cboViewerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboViewerType.SelectedIndexChanged
        Dim selection As String = Me.cboViewerType.Items(Me.cboViewerType.SelectedIndex).Text
        Select Case selection
            Case "PDF Reader" 'Acrobat Reader was chosen as the viewer type
                Me.arvWebMain.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.AcrobatReader
            Case "ActiveXViewer" 'ActiveX was chosen as the viewer type
                Me.arvWebMain.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.ActiveXViewer
            Case "HtmlViewer" 'HTML Viewer was chosen as the viewer type
                Me.arvWebMain.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.HtmlViewer
            Case "RawHtml" 'Raw HTML was chosen as the viewer type
                Me.arvWebMain.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.RawHtml
        End Select

    End Sub
End Class
