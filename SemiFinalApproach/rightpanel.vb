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
    Sub getfontstyle()

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
        getnoteshape()
        getfont()
        getalignment()
        getfontstyle()
    End Sub
    Sub exportnotes()
        getnoteshape()
        setfont()
        setalignment()
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

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        importnotes()
        btnEdit.Enabled = True
    End Sub
    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        exportnotes()
        txtNotes.Text = ""
        btnDisplay.Enabled = True
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnSaveChanges.Enabled = False
        txtNotes.ReadOnly = True
        cboxFontFamily.Enabled = False
        cboxFontSize.Enabled = False
        disablecontrols()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtNotes.Text = ""
        btnDisplay.Enabled = True
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnSaveChanges.Enabled = False
        txtNotes.ReadOnly = True
        cboxFontFamily.Enabled = False
        cboxFontSize.Enabled = False
        disablecontrols()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtNotes.ReadOnly = False
        btnEdit.Enabled = False
        btnDisplay.Enabled = False
        btnCancel.Enabled = True
        btnSaveChanges.Enabled = True
        cboxFontFamily.Enabled = True
        cboxFontSize.Enabled = True
        enablecontrol()
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


#End Region

#End Region


    '-----------------------------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------'
    'all the following commands are for " txtbox.jpeg" file
    'shape.texteffect.alignment >>> align left or right
    'shape.TextFrame.TextRange.ParagraphFormat.TextDirection = PpDirection.ppDirectionRightToLeft >>> right to left or vice versa like ctrl + shift
    'shape.texteffect.bold , italic , name , size >>>> control the font in the shape
    'shape.TextEffect.PresetTextEffect = MsoPresetTextEffect.msoTextEffect10 >>> wordart styles
    'shape.TextEffect.PresetShape = MsoPresetTextEffectShape.msoTextEffectShapeCircleCurve >>> word art shapes
    '========================================================================================'
    '========================================================================================'
    'shape.TextFrame.TextRange.ParagraphFormat.Alignment >>> 1
    'shape.TextFrame.VerticalAnchor >>> 1   === i think all about 1 ===
    'shape.TextFrame.Orientation = MsoTextOrientation.msoTextOrientationHorizontal >>> 2a
    'shape.TextFrame.Orientation = MsoTextOrientation.msoTextOrientationDownward >>> 2b
    'shape.TextFrame.Orientation = MsoTextOrientation.msoTextOrientationUpward >>> 2c
    'shape.TextEffect.ToggleVerticalText()  >>>  2d
    'shape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeNone  >>> 3
    'shape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeShapeToFitText  >>>  5
    'shape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeTextToFitShape >>> 4
    'shape.TextFrame.MarginLeft -= 0.4 >>> 6
    'shape.TextFrame.WordWrap = MsoTriState.msoTriStateToggle >>> 7
    'shape.TextFrame2.Column  >>> 8   ==== HINT : needs a messagebox ====
    '========================================================================================'
    '========================================================================================'
    'all the following commands are for "general.jpeg" Fill
    'shape.Fill.Solid() >>> 2 " Fill property contains all Fill features"
    '========================================================================================'
    '========================================================================================'
    'all the following commands are for "Size.jpeg" Size
    'selectedshape.height=30 >>> 1
    'selectedshape.width=30 >>> 2 
    'selectedshape.rotation=30 >>> 3
    'selectedshape.ScaleHeight(ForTestOnly2.Text, MsoTriState.msoCTrue, MsoScaleFrom.msoScaleFromTopLeft) >>> 4
    'selectedshape.ScaleWidth(ForTestOnly2.Text, MsoTriState.msoCTrue, MsoScaleFrom.msoScaleFromTopLeft) >>> 5
    'selectedshape.LockAspectRatio = MsoTriState.msoTriStateToggle >>> 6
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
                gettimer.Enabled = True
            Case 1
                hideall()
                showpage(FillPage)
                gettimer.Enabled = True
            Case 2
                hideall()
                showpage(LineColorPage)
                gettimer.Enabled = True
            Case 3
                hideall()
                showpage(LineStylePage)
                gettimer.Enabled = True
            Case 4
                hideall()
                showpage(ShadowPage)
                gettimer.Enabled = True
            Case 5
                hideall()
                showpage(SizePage)
                gettimer.Enabled = True
        End Select
    End Sub
    Sub selectshape()
        Dim k, g As Object
        k = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
        g = objapp.ActiveWindow.Selection.ShapeRange.Name
        selectedshape = objapp.ActivePresentation.Slides(k).Shapes(g)
    End Sub
    Public Sub gettimer_Tick(sender As Object, e As EventArgs) Handles gettimer.Tick
        l += 1
        If l = 1 Then
            gettimer.Enabled = False
            gettextpage()
        End If
        l = 0
        gettimer.Enabled = True
    End Sub

    '======================================TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ===================================================='
    '======================================TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ===================================================='
    Sub gettextpage()
        Try
            selectshape()
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
        gettimer.Enabled = False
        If selectedshape.HasTextFrame Then
            With selectedshape.TextFrame
                Select Case (cboxtextdirection.SelectedIndex)
                    Case 0
                        .Orientation = MsoTextOrientation.msoTextOrientationHorizontal
                    Case 1
                        .Orientation = MsoTextOrientation.msoTextOrientationDownward
                    Case 2
                        .Orientation = MsoTextOrientation.msoTextOrientationUpward
                End Select
            End With
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
        End If
    End Sub


    Private Sub cboxtextdirection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxtextdirection.Click, cboxtextdirection.MouseEnter, cboxtextdirection.SelectedIndexChanged
        settextPage()
    End Sub
    Private Sub chkboxStacked_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxStacked.CheckedChanged
        selectshape()
        selectedshape.TextEffect.ToggleVerticalText()
    End Sub
    Private Sub Donnotautofit_CheckedChanged(sender As Object, e As EventArgs) Handles Donnotautofit.CheckedChanged
        selectshape()
        selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeNone
    End Sub
    Private Sub Shrinktext_CheckedChanged(sender As Object, e As EventArgs) Handles Shrinktext.CheckedChanged
        selectshape()
        selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeTextToFitShape
    End Sub
    Private Sub ResizeShape_CheckedChanged(sender As Object, e As EventArgs) Handles ResizeShape.CheckedChanged
        selectshape()
        selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeShapeToFitText
    End Sub
    Private Sub chkboxWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxWrap.CheckedChanged
        If chkboxWrap.Checked Then
            selectedshape.TextFrame.WordWrap = MsoTriState.msoCTrue
        Else
            selectedshape.TextFrame.WordWrap = MsoTriState.msoFalse
        End If

    End Sub
    Private Sub btnColumns_Click(sender As Object, e As EventArgs) Handles btnColumns.Click
        MsgBox("Columns")
    End Sub
    Private Sub TextBoxPage_Leave(sender As Object, e As EventArgs) Handles TextBoxPage.MouseLeave
        gettimer.Enabled = True
    End Sub

#Region "Margin Buttons"
    Private Sub plsLM_Click(sender As Object, e As EventArgs) Handles plsLM.Click
        selectshape()
        selectedshape.TextFrame.MarginLeft += 7.2
    End Sub
    Private Sub mnsLM_Click(sender As Object, e As EventArgs) Handles mnsLM.Click
        selectshape()
        selectedshape.TextFrame.MarginLeft -= 7.2
    End Sub
    Private Sub plsRM_Click(sender As Object, e As EventArgs) Handles plsRM.Click
        selectshape()
        selectedshape.TextFrame.MarginRight += 7.2
    End Sub
    Private Sub msnRM_Click(sender As Object, e As EventArgs) Handles msnRM.Click
        selectshape()
        selectedshape.TextFrame.MarginRight -= 7.2
    End Sub
    Private Sub plsTM_Click(sender As Object, e As EventArgs) Handles plsTM.Click
        selectshape()
        selectedshape.TextFrame.MarginTop += 7.2
    End Sub
    Private Sub mnsTM_Click(sender As Object, e As EventArgs) Handles mnsTM.Click
        selectshape()
        selectedshape.TextFrame.MarginTop -= 7.2
    End Sub
    Private Sub plsBM_Click(sender As Object, e As EventArgs) Handles plsBM.Click
        selectshape()
        selectedshape.TextFrame.MarginBottom += 7.2
    End Sub
    Private Sub mnsMN_Click(sender As Object, e As EventArgs) Handles mnsMN.Click
        selectshape()
        selectedshape.TextFrame.MarginBottom -= 7.2
    End Sub
#End Region

    '======================================SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE ===================================================='
    '======================================SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE ===================================================='














#End Region
 

End Class
