Public Class ThisAddIn
    Public ctp As Microsoft.Office.Tools.CustomTaskPane
    Private Sub ThisAddIn_Startup() Handles Me.Startup

        ctp = Me.CustomTaskPanes.Add(New rightpanel, "RightSide Add-In")
        ctp.Visible = True
        ctp.Width = 360

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
