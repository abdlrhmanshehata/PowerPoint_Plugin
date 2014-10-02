Imports Microsoft.Office.Interop.PowerPoint
Imports Microsoft.Office.Core
Imports System.Windows.Forms
Imports System.Drawing

Public Class rightpanel
    Dim objapp As PowerPoint.Application = Globals.ThisAddIn.Application
    Dim i As Integer
    Dim notesshape As PowerPoint.Shape
    Dim shapename As String
    Dim selectedshape As PowerPoint.Shape
    Dim l As Integer
#Region "Notes"

#Region "Subs"
    Sub getnoteshape()
        getcurrentindex()
        For Each shape As PowerPoint.Shape In objapp.ActivePresentation.Slides(i).NotesPage.Shapes
            If shape.HasTextFrame Then
                If shape.Width > 300 Then
                    shapename = shape.Name
                    notesshape = objapp.ActivePresentation.Slides(i).NotesPage.Shapes(shapename)
                End If
            End If
        Next
    End Sub
    Sub getcurrentindex()
        i = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
        txtSlideId.Text = "Current SlideId: " & i
    End Sub
    Sub getalignment()
        Dim alignment As Integer
        alignment = notesshape.TextFrame.TextRange.ParagraphFormat.Alignment
        Select Case alignment
            Case 1
                txtNotes.SelectionAlignment = HorizontalAlignment.Left
            Case 2
                txtNotes.SelectionAlignment = HorizontalAlignment.Center
            Case 3
                txtNotes.SelectionAlignment = HorizontalAlignment.Right
        End Select
    End Sub
    Sub getfont()
        txtNotes.Text = notesshape.TextFrame.TextRange.Text
        txtNotes.Font = New Drawing.Font(notesshape.TextFrame.TextRange.Font.Name, notesshape.TextFrame.TextRange.Font.Size)
        Try
            cboxFontFamily.SelectedIndex = cboxFontFamily.Items.IndexOf(notesshape.TextFrame.TextRange.Font.Name)
            cboxFontSize.SelectedIndex = cboxFontSize.Items.IndexOf(CStr(notesshape.TextFrame.TextRange.Font.Size))
        Catch ex As Exception
        End Try
    End Sub


    Sub setfont()
        notesshape.TextFrame.TextRange.Text = txtNotes.Text
        notesshape.TextFrame.TextRange.Font.Name = cboxFontFamily.SelectedItem.ToString
        notesshape.TextFrame.TextRange.Font.Size = CInt(cboxFontSize.SelectedItem.ToString)
    End Sub
    Sub setalignment()
        Dim alignment As Integer
        alignment = txtNotes.SelectionAlignment
        Select Case alignment
            Case 0
                notesshape.TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignLeft
            Case 2
                notesshape.TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignCenter
            Case 1
                notesshape.TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignRight
        End Select
    End Sub
    Sub setfontstyle()

    End Sub

    Sub importnotes()
        Try
            getcurrentindex()
            getnoteshape()
            getfont()
            getalignment()
        Catch ex As Exception
        End Try
    End Sub
    Sub exportnotes()
        Try
            getcurrentindex()
            getnoteshape()
            setfont()
            setalignment()
            setfontstyle()
        Catch ex As Exception
        End Try
    End Sub
    Sub disablecontrols()
        btnAlignCenter.Enabled = False
        btnAlignLeft.Enabled = False
        btnAlignRight.Enabled = False
        btnCopy.Enabled = False
        btnCut.Enabled = False
        btnPaste.Enabled = False
        btnSave.Enabled = False
        btnBold.Enabled = False
        btnUnderline.Enabled = False
        btnItalic.Enabled = False
    End Sub
    Sub enablecontrol()
        btnAlignCenter.Enabled = True
        btnAlignLeft.Enabled = True
        btnAlignRight.Enabled = True
        btnCopy.Enabled = True
        btnCut.Enabled = True
        btnPaste.Enabled = True
        btnSave.Enabled = True
        btnBold.Enabled = True
        btnUnderline.Enabled = True
        btnItalic.Enabled = True
    End Sub



    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        getnoteshape()
        getcurrentindex()
        notesshape.TextFrame.TextRange.Text = txtNotes.Text
    End Sub
#End Region

#Region "Control_Buttons"
    Private Sub cboxFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontSize.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, CInt(cboxFontSize.SelectedItem.ToString))
    End Sub
    Private Sub cboxFontFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontFamily.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, CInt(cboxFontSize.SelectedItem.ToString))
    End Sub
    Private Sub btnAlignLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignLeft.Click
        getnoteshape()
        txtNotes.SelectionAlignment = HorizontalAlignment.Left
    End Sub
    Private Sub btnAlignCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignCenter.Click
        getnoteshape()
        txtNotes.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub btnAlignRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignRight.Click
        getnoteshape()
        txtNotes.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

    End Sub
    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click

    End Sub
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click

    End Sub
    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click

    End Sub
    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click

    End Sub
    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click

    End Sub
#End Region

#End Region

#Region "Format Shape"
    Sub showpage(ByVal page As TableLayoutPanel)
        page.Visible = True
        page.Dock = DockStyle.Fill
    End Sub
    Sub hidepage(ByVal page As TableLayoutPanel)
        page.Visible = False
        page.Dock = DockStyle.None
    End Sub
    Sub hideall()
        hidepage(TextBoxPage)
        hidepage(FillPage)
        hidepage(LineColorPage)
        hidepage(LineStylePage)
        hidepage(ShadowPage)
        hidepage(SizePage)
    End Sub
    Private Sub cboxFormatShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFormatShape.SelectedIndexChanged
        Select Case (cboxFormatShape.SelectedIndex)
            Case 0
                hideall()
                showpage(TextBoxPage)
                Fixedtimer.Enabled = True
            Case 1
                hideall()
                showpage(FillPage)
            Case 2
                hideall()
                showpage(LineColorPage)
            Case 3
                hideall()
                showpage(LineStylePage)
            Case 4
                hideall()
                showpage(ShadowPage)
            Case 5
                hideall()
                showpage(SizePage)
        End Select
    End Sub
    Sub selectshape()
        Try
            Dim k, g As Object
            k = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
            g = objapp.ActiveWindow.Selection.ShapeRange.Name
            selectedshape = objapp.ActivePresentation.Slides(k).Shapes(g)
        Catch ex As Exception

        End Try
    
    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Fixedtimer.Enabled = True
    End Sub
    '======================================TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ===================================================='
    '======================================TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ===================================================='
    Sub gettextpage()
        selectshape()
        Try
            If selectedshape.HasTextFrame Then
                '========================================TEXT DIRECTION============================'
                With cboxtextdirection
                    Select Case selectedshape.TextFrame.Orientation
                        Case MsoTextOrientation.msoTextOrientationHorizontal
                            .SelectedIndex = 0
                        Case MsoTextOrientation.msoTextOrientationDownward
                            .SelectedIndex = 1
                        Case MsoTextOrientation.msoTextOrientationUpward
                            .SelectedIndex = 2
                    End Select
                End With
                '========================================TEXT ALIGNMENT============================'
                With cboxtextalignment
                    Select Case selectedshape.TextFrame.VerticalAnchor
                        Case MsoVerticalAnchor.msoAnchorTop
                            .SelectedIndex = 0
                        Case MsoVerticalAnchor.msoAnchorMiddle
                            .SelectedIndex = 1
                        Case MsoVerticalAnchor.msoAnchorBottom
                            .SelectedIndex = 2
                    End Select
                End With
                '========================================AutoFit=================================='
                Select Case selectedshape.TextFrame2.AutoSize
                    Case MsoAutoSize.msoAutoSizeShapeToFitText
                        ResizeShape.Checked = True
                    Case MsoAutoSize.msoAutoSizeTextToFitShape
                        Shrinktext.Checked = True
                    Case MsoAutoSize.msoAutoSizeNone
                        Donnotautofit.Checked = True
                End Select
                '========================================Margin=================================='
                txtleftmargin.Text = selectedshape.TextFrame.MarginLeft / 72
                txtrightmargin.Text = selectedshape.TextFrame.MarginRight / 72
                txttopmargin.Text = selectedshape.TextFrame.MarginTop / 72
                txtbottommargin.Text = selectedshape.TextFrame.MarginBottom / 72
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub settextPage()
        selectshape()
        Try
            If selectedshape.HasTextFrame Then
                '============================================TEXT DIRECTION================================================================='
                With selectedshape.TextFrame
                    Select Case (cboxtextdirection.SelectedIndex)
                        Case 0
                            .Orientation = MsoTextOrientation.msoTextOrientationHorizontal
                        Case 1
                            .Orientation = MsoTextOrientation.msoTextOrientationDownward
                        Case 2
                            .Orientation = MsoTextOrientation.msoTextOrientationUpward
                            'Case 3
                            '    selectedshape.TextEffect.KernedPairs = MsoTriState.msoTrue

                    End Select
                End With
                '======================================================TEXT ALIGNMENT==========================================================='
                With selectedshape.TextFrame
                    Select Case cboxtextalignment.SelectedIndex
                        Case 0
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorTop
                        Case 1
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle
                        Case 2
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorBottom
                    End Select
                End With
                '================================================== AUTOFIT================================================================='
                If Donnotautofit.Checked Then
                    selectedshape.TextFrame.AutoSize = PpAutoSize.ppAutoSizeNone
                ElseIf ResizeShape.Checked Then
                    selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeShapeToFitText
                ElseIf Shrinktext.Checked Then
                    selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeTextToFitShape
                End If
            End If
        Catch

        End Try
    End Sub

    Private Sub Fixedtimer_Tick(sender As Object, e As EventArgs) Handles Fixedtimer.Tick
        Dim location As System.Drawing.Point
        Dim critical As System.Drawing.Point
        critical.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        location.X = MousePosition.X
        location.Y = MousePosition.Y
        If location.X > critical.X Then
            settextPage()
            exportnotes()
        Else
            gettextpage()
            importnotes()
        End If
    End Sub
    Private Sub chkboxWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxWrap.CheckedChanged
        If chkboxWrap.Checked Then
            selectedshape.TextFrame.WordWrap = MsoTriState.msoCTrue
        Else
            selectedshape.TextFrame.WordWrap = MsoTriState.msoFalse
        End If
    End Sub
    Private Sub plsLM_Click(sender As Object, e As EventArgs) Handles plsLM.Click
        selectedshape.TextFrame.MarginLeft += 0.1 * 72
        gettextpage()
    End Sub
    Private Sub mnsLM_Click(sender As Object, e As EventArgs) Handles mnsLM.Click
        Try
            selectedshape.TextFrame.MarginLeft -= 0.1 * 72
            gettextpage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub plsBM_Click(sender As Object, e As EventArgs) Handles plsBM.Click
        selectedshape.TextFrame.MarginBottom += 0.1 * 72
        gettextpage()
    End Sub
    Sub mnsBM_click() Handles mnsBM.Click
        Try
            selectedshape.TextFrame.MarginBottom -= 0.1 * 72
            gettextpage()
        Catch ex As Exception
        End Try

    End Sub
    Sub plsRM_click() Handles plsRM.Click
        selectedshape.TextFrame.MarginRight += 0.1 * 72
        gettextpage()
    End Sub
    Sub msnRM_click() Handles mnsRM.Click
        Try
            selectedshape.TextFrame.MarginRight -= 0.1 * 72
            gettextpage()
        Catch ex As Exception
        End Try

    End Sub
    Sub plsTM_click() Handles plsTM.Click
        selectedshape.TextFrame.MarginTop += 0.1 * 72
        gettextpage()
    End Sub
    Sub mnsTM_click() Handles mnsTM.Click
        Try
            selectedshape.TextFrame.MarginTop -= 0.1 * 72
            gettextpage()
        Catch ex As Exception
        End Try

    End Sub
#End Region
 
End Class
