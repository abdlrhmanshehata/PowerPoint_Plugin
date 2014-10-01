Imports SemiFinalApproach.rightpanel
Public Class ThisAddIn
    Public ctp As Microsoft.Office.Tools.CustomTaskPane
    Public mytimer As New System.Windows.Forms.Timer

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        ctp = Me.CustomTaskPanes.Add(New rightpanel, "RightSide Add-In")
        ctp.Visible = True
        ctp.Width = 370
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
