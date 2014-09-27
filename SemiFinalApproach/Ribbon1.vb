Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Private Sub ToggleButton1_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles ToggleButton1.Click
        If ToggleButton1.Checked = True Then
            Globals.ThisAddIn.ctp.Visible = True
        Else
            Globals.ThisAddIn.ctp.Visible = False
        End If
    End Sub
End Class
