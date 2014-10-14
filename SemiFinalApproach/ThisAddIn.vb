Imports SemiFinalApproach.rightpanel
Public Class ThisAddIn
    Private Sub Application_NewPresentation(Pres As PowerPoint.Presentation) Handles Application.NewPresentation
        Dim ctp As Microsoft.Office.Tools.CustomTaskPane
        ctp = Me.CustomTaskPanes.Add(New rightpanel, "RightSide Add-In")
        ctp.Width = 370
        ctp.Visible = True
        Globals.Ribbons.Ribbon1.ToggleButton1.Checked = True
    End Sub
End Class
