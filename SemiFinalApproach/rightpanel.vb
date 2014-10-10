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
#Region "General"
    Sub getnoteshape()
        Try
            getcurrentindex()
            For Each shape As PowerPoint.Shape In objapp.ActivePresentation.Slides(i).NotesPage.Shapes
                If shape.HasTextFrame Then
                    If shape.Width > 300 Then
                        shapename = shape.Name
                        notesshape = objapp.ActivePresentation.Slides(i).NotesPage.Shapes(shapename)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub getcurrentindex()
        Try
            i = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
            txtSlideId.Text = "Current SlideId: " & i
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Fixedtimer_Tick(sender As Object, e As EventArgs) Handles Fixedtimer.Tick
        getcurrentindex()
        getnoteshape()

        Dim location As System.Drawing.Point
        Dim critical As System.Drawing.Point
        critical.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        location.X = MousePosition.X
        location.Y = MousePosition.Y
        '===============================Mouse In=============================================
        If location.X > critical.X Then
            settextPage()
            setnotespage()
            '===============================Mouse Out=============================================
        Else
            gettextpage()
            getnotespage()
            Try
                btnRefresh_Click()
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

    '===============================NOTES NOTES NOTES NOTES NOTES NOTES NOTES ====================='
#Region "Notes"

#Region "Subs"
    Sub getalignment()

        Dim alignment As Integer = notesshape.TextFrame.TextRange.ParagraphFormat.Alignment
        Dim txtnotesalignment As Integer = txtNotes.SelectionAlignment

        If txtnotesalignment <> alignment Then
            Select Case alignment
                Case 1
                    txtNotes.SelectionAlignment = HorizontalAlignment.Left
                Case 2
                    txtNotes.SelectionAlignment = HorizontalAlignment.Center
                Case 3
                    txtNotes.SelectionAlignment = HorizontalAlignment.Right
            End Select
        End If

    End Sub
    Sub gettext()
        Try
            txtNotes.Text = notesshape.TextFrame.TextRange.Text
        Catch ex As Exception
        End Try
    End Sub
    Sub getfont()
        Dim notesfontname As String = notesshape.TextFrame.TextRange.Font.Name
        Dim notesfontsize As Integer = notesshape.TextFrame.TextRange.Font.Size
        Dim myfont As System.Drawing.Font = New Drawing.Font(notesfontname, notesfontsize)

        If txtNotes.Font.Name <> notesfontname Or txtNotes.Font.Size <> notesfontsize Then
            txtNotes.Font = myfont
            Try
                cboxFontFamily.SelectedIndex = cboxFontFamily.Items.IndexOf(notesfontname)
                cboxFontSize.SelectedIndex = cboxFontSize.Items.IndexOf(CStr(notesfontsize))
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub getfontstyle()
        Try
            For Each word As PowerPoint.TextRange In notesshape.TextFrame.TextRange.Words
                If word.Text <> " " Then
                    Dim length = word.Length
                    Dim index As Integer = word.Start
                    Dim theword As String = word.Text
                    txtNotes.DeselectAll()
                    txtNotes.Select(index - 1, length)

                    With txtNotes.SelectionFont
                        If .Bold <> word.Font.Bold And .Italic <> word.Font.Italic Then
                            newfontstyle(FontStyle.Bold Or FontStyle.Italic)
                        End If
                        If .Bold <> word.Font.Bold Then
                            newfontstyle(Drawing.FontStyle.Bold)
                        End If
                        If .Italic <> word.Font.Italic Then
                            newfontstyle(Drawing.FontStyle.Italic)
                        End If
                        If .Underline <> word.Font.Underline Then
                            newfontstyle(Drawing.FontStyle.Underline)
                        End If
                    End With
                    txtNotes.DeselectAll()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub getnotespage() 'Time Function 
        Try
            If txtNotes.Text <> notesshape.TextFrame.TextRange.Text Then
                gettext()
            End If
            getfont()
            getfontstyle()
        Catch ex As Exception
        End Try
    End Sub

    Sub setnotespage()
        settext()
    End Sub
    Sub setfontstyle()
            For j = 1 To txtNotes.Text.Count
                Dim letter As TextRange = notesshape.TextFrame.TextRange.Characters(j, 1)
                Dim ifbold As Boolean = letter.Font.Bold
                Dim ifitalic As Boolean = letter.Font.Italic
                Dim ifunderline As Boolean = letter.Font.Underline
                Dim text As String = letter.Text
            If text <> " " Then
 
                txtNotes.Select(j - 1, 1)
                If ifbold <> txtNotes.SelectionFont.Bold Then
                    letter.Font.Bold = MsoTriState.msoCTrue
                End If
                If ifitalic <> txtNotes.SelectionFont.Italic Then
                    letter.Font.Italic = MsoTriState.msoCTrue
                End If
                If ifunderline <> txtNotes.SelectionFont.Underline Then
                    letter.Font.Underline = MsoTriState.msoCTrue
                End If

            End If
        Next
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
    Sub settext()
        Dim mytext As String = txtNotes.Text
        Dim notestext As String = notesshape.TextFrame.TextRange.Text
        If notestext <> mytext Then
            notesshape.TextFrame.TextRange.Text = txtNotes.Text
        End If
    End Sub
    Sub setfont()
        notesshape.TextFrame.TextRange.Font.Name = cboxFontFamily.SelectedItem.ToString
        notesshape.TextFrame.TextRange.Font.Size = CInt(cboxFontSize.SelectedItem.ToString)
    End Sub
    Sub defaultfontstyle()
        txtNotes.SelectionFont = New Drawing.Font(notesshape.TextFrame.TextRange.Font.Name, notesshape.TextFrame.TextRange.Font.Size, FontStyle.Regular)
    End Sub
    Sub newfontstyle(ByVal style As System.Drawing.FontStyle)
        txtNotes.SelectionFont = New Drawing.Font(notesshape.TextFrame.TextRange.Font.Name _
                                                  , notesshape.TextFrame.TextRange.Font.Size, style)
    End Sub

    Sub makenewfont(ByVal choosestyle As Drawing.FontStyle)
        txtNotes.Font = New Drawing.Font(notesshape.TextFrame.TextRange.Font.Name, notesshape.TextFrame.TextRange.Font.Size, choosestyle)
    End Sub
#End Region

#Region "Control_Buttons"
    Private Sub cboxFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontSize.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, CInt(cboxFontSize.SelectedItem.ToString))
        setfont()
    End Sub
    Private Sub cboxFontFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontFamily.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, CInt(cboxFontSize.SelectedItem.ToString))
        setfont()
    End Sub

    Private Sub btnAlignLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignLeft.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Left
        setalignment()
    End Sub
    Private Sub btnAlignCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignCenter.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Center
        setalignment()
    End Sub
    Private Sub btnAlignRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlignRight.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Right
        setalignment()
    End Sub

    Private Sub btnitalic_CheckedChanged(sender As Object, e As EventArgs) Handles btnitalic.CheckedChanged
        If txtNotes.SelectedText.Length <> 0 Then
            If btnitalic.Checked = True Then
                newfontstyle(FontStyle.Italic)
            Else
                defaultfontstyle()
            End If
        Else
            btnitalic.Checked = False
            MsgBox(" please select text")
        End If
    End Sub
    Private Sub btnBold_CheckedChanged(sender As Object, e As EventArgs) Handles btnBold.CheckedChanged
        If txtNotes.SelectedText.Length <> 0 Then
            If btnBold.Checked = True Then
                newfontstyle(FontStyle.Bold)
            Else
                defaultfontstyle()
            End If
        Else
            btnBold.Checked = False
            MsgBox(" please select text")
        End If
    End Sub
    Private Sub btnunderline_CheckedChanged(sender As Object, e As EventArgs) Handles btnunderline.CheckedChanged
        If txtNotes.SelectedText.Length <> 0 Then
            If btnunderline.Checked = True Then
                newfontstyle(FontStyle.Underline)
            Else
                defaultfontstyle()
            End If
        Else
            btnunderline.Checked = False
            MsgBox(" please select text")
        End If
    End Sub

    Private Sub btnRefresh_Click() Handles btnRefresh.Click
        setfontstyle()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            objapp.CommandBars("standard").Controls(3).Execute()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try
            If txtNotes.SelectedText.Count <> 0 Then
                txtNotes.Copy()
            Else
                MsgBox("Please Select Text")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        Try
            If txtNotes.SelectedText.Length <> 0 Then
                txtNotes.Copy()
                txtNotes.SelectedText = ""
            Else
                MsgBox("Please Select Text")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        Try
            txtNotes.Paste()
        Catch ex As Exception
        End Try
    End Sub
#End Region

#End Region


    '===============================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ====================='
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


    '===================================TEST TEST TEST TEST TEST ====================================='
 
End Class
