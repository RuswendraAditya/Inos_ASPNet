<%@ Application Language="VB" %>

<script runat="server">
    
    Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

        Dim myContext As HttpContext = HttpContext.Current
       
        Dim rewrite_regex As Regex = New Regex("(.+)\/((.+)\.*)", RegexOptions.IgnoreCase)
        
        Try

            'see if we need to rewrite the URL
            Dim match_rewrite As Match = rewrite_regex.Match(myContext.Request.Path.ToString())
           
                    
            If match_rewrite.Groups(2).Captures(0).ToString() = "Menu-Pilihan-JP.aspx" Then
                myContext.RewritePath("pilihan.aspx")
            ElseIf match_rewrite.Groups(2).Captures(0).ToString() = "Entri-Edit-JP-Manual.aspx" Then
                myContext.RewritePath("EntriJPManual.aspx")
            ElseIf match_rewrite.Groups(2).Captures(0).ToString() = "Import-Data-Excell.aspx" Then
                myContext.RewritePath("ImporJP.aspx")
            ElseIf match_rewrite.Groups(2).Captures(0).ToString() = "Preview-Data.aspx" Then
                myContext.RewritePath("PreviewJP.aspx")
            ElseIf match_rewrite.Groups(2).Captures(0).ToString() = "Edit-Password.aspx" Then
                myContext.RewritePath("FrmEditPassword.aspx")
            ElseIf match_rewrite.Groups(2).Captures(0).ToString() = "" Then
                myContext.RewritePath("default.aspx")
            End If
        Catch ex As Exception
            Response.Write("ERR in Global.asax :" & ex.Message + Constants.vbLf + Constants.vbLf + ex.StackTrace.ToString() & Constants.vbLf + Constants.vbLf)

        End Try

    End Sub
    
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
       
</script>