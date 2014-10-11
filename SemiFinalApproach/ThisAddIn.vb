Imports SemiFinalApproach.rightpanel
Public Class ThisAddIn
    Public ctp As Microsoft.Office.Tools.CustomTaskPane
    Public mytimer As New System.Windows.Forms.Timer


    Private Sub ThisAddIn_Startup() Handles Me.Startup
        ctp = Me.CustomTaskPanes.Add(New rightpanel, "RightSide Add-In")
        ctp.Visible = False
        ctp.Width = 370
        Globals.Ribbons.Ribbon1.ToggleButton1.Checked = True
        Globals.Ribbons.Ribbon1.ToggleButton1_Click()

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub
End Class
