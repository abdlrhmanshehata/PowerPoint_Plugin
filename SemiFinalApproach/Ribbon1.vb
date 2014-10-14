Imports Microsoft.Office.Tools.Ribbon
Public Class Ribbon1
    Dim index As Integer

    Sub getindex()
        Try
            Dim name As String = Globals.ThisAddIn.Application.ActivePresentation.Name

            If name.Length = 13 Then
                index = CInt(name(12).ToString)
            ElseIf name.Length > 13 Then
                index = CInt(name(12).ToString) & CInt(name(13).ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ToggleButton1_Click() Handles ToggleButton1.Click
        getindex()
        If ToggleButton1.Checked = True Then
            Globals.ThisAddIn.CustomTaskPanes.Item(index - 1).Visible = True
        Else
            Globals.ThisAddIn.CustomTaskPanes.Item(index - 1).Visible = False
        End If
    End Sub
End Class
