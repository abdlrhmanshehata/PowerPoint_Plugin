Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Tools
Public Class Ribbon1
    Dim ctp As CustomTaskPane
    Sub addtaskpane()
        ctp = Globals.ThisAddIn.CustomTaskPanes.Add(New rightpanel, " PowerPlug")
        ctp.Width = 310
        ctp.Visible = True
    End Sub
    Sub removetaskpane()
        Globals.ThisAddIn.CustomTaskPanes.Remove(ctp)
    End Sub
    Public Sub ShowPlug_Click() Handles ShowPlug.Click
        If Globals.ThisAddIn.Application.Presentations.Count <> 0 Then
            If ShowPlug.Checked Then
                addtaskpane()
            Else
                removetaskpane()
            End If
        Else
            MsgBox(" Please Open at least one presentation ")
        End If

    End Sub
    
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Try
            If ctp.Visible = False Then
                ShowPlug.Checked = False
                removetaskpane()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
