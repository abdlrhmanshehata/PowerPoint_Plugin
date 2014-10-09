Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Public Sub ToggleButton1_Click() Handles ToggleButton1.Click
        If ToggleButton1.Checked = True Then
            Globals.ThisAddIn.ctp.Visible = True
        Else
            Globals.ThisAddIn.ctp.Visible = False
        End If
    End Sub
End Class
