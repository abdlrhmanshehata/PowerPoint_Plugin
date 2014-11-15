Imports Microsoft.Office.Interop.PowerPoint
Imports Microsoft.Office.Core
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows

Public Class rightpanel
    Dim objapp As PowerPoint.Application = Globals.ThisAddIn.Application
    Dim i As Integer
    Dim notesshape As PowerPoint.Shape
    Dim shapename As String
    Dim selectedshape As PowerPoint.Shape
    Dim currentshapename As String = ""
    Dim l As Integer
    Dim relativestate As MsoTriState
    Dim originallength, originalwidth As Integer
    '===============================GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL ====================================='
    '===============================GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL ====================================='
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
        Catch ex As Exception

        End Try

    End Sub
    Sub selectshape()
        Try
            Dim k, g As Object
            k = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
            g = objapp.ActiveWindow.Selection.ShapeRange.Name
            If currentshapename <> objapp.ActivePresentation.Slides(k).Shapes(g).Name Then
                currentshapename = objapp.ActivePresentation.Slides(k).Shapes(g).Name
                selectedshape = objapp.ActivePresentation.Slides(k).Shapes(g)
                If selectedshape.Type.ToString = "msoPicture" Then
                    ' Picture
                    picturetools()
                Else
                    ' TextBox
                    textboxtools()
                End If
                originallength = selectedshape.Height
                originalwidth = selectedshape.Width
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Fixedtimer_Tick(sender As Object, e As EventArgs) Handles Fixedtimer.Tick
        getcurrentindex()
        getnoteshape()
        selectshape()
        Dim location As System.Drawing.Point
        Dim critical As System.Drawing.Point
        critical.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        location.X = MousePosition.X
        location.Y = MousePosition.Y
        '===============================Mouse In the Plug_IN=============================================
        If location.X > critical.X Then
            settextPage()
            setnotespage()
            '===============================Mouse Out the Plug_IN=============================================
        Else
            gettextpage()
            getsizepage()
            getnotespage()
        End If


    End Sub

    Private Sub generalscroll(sender As Object, e As ScrollEventArgs) Handles Scroll_General.Scroll
        Select Case Scroll_General.Value
            Case 0
                setloc(TextBoxPage, 3, TopPanel.Height, 0)
            Case 10
                setloc(TextBoxPage, 3, TopPanel.Height, 1)
            Case 20
                setloc(TextBoxPage, 3, TopPanel.Height, 2)
            Case 30
                setloc(TextBoxPage, 3, TopPanel.Height, 3)
            Case 40
                setloc(TextBoxPage, 3, TopPanel.Height, 4)
            Case 50
                setloc(TextBoxPage, 3, TopPanel.Height, 5)
        End Select
    End Sub
    Sub setloc(ByVal page As TableLayoutPanel, ByVal start As Integer, ByVal contOutside As Integer, ByVal caseindex As Integer)
        Dim y, portion As Integer
        Dim contInside As Integer
        Dim text As Boolean = TextBoxPage.Visible
        Dim size As Boolean = SizePage.Visible
        Dim line As Boolean = LinePage.Visible
        If text = True Then
            page = TextBoxPage
            contInside = TextBoxPage.Height
        End If
        If size = True Then
            page = SizePage
            contInside = SizePage.Height
        End If
        If line = True Then
            page = LinePage
            contInside = LinePage.Height
        End If

        portion = (contInside - contOutside) / 4.9
        y = start - (caseindex * portion)
        If page.Visible = True Then
            page.Location = New Drawing.Point(page.Location.X, y)
        End If
    End Sub
    Private Sub rightpanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboxFormatShape.SelectedIndex = 0
    End Sub

    Private Sub rightpanel_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TextBoxPage.Width = Me.Width - 28
        SCont_A.Height = Me.Height - 12
    End Sub
    Private Sub TopPanel_SizeChanged(sender As Object, e As EventArgs) Handles TopPanel.SizeChanged
        If TopPanel.Height > TextBoxPage.Height Then
            Scroll_General.Enabled = False
        Else
            Scroll_General.Enabled = True
        End If
    End Sub
#End Region
    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES============================================='
    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES============================================='
#Region "Notes"

#Region "Methods"
    '--------------------------------------------------------Get methods-------------------------------------------------'
    Sub getnotespage()
        gettext()
        getfont()
    End Sub
    Sub gettext()
        Try
            If txtNotes.Text <> notesshape.TextFrame.TextRange.Text Then
                txtNotes.Text = notesshape.TextFrame.TextRange.Text
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub getfont()
        Try
            For Each word As TextRange In notesshape.TextFrame.TextRange.Words
                Dim index As Integer = word.Start - 1
                Dim wheretostop As Integer = 0
                Dim bold, italic, underline As MsoTriState
                Dim fontname As String
                Dim fontsize As Single
                Dim style As FontStyle = FontStyle.Regular
                With word.Characters(1, 1).Font
                    bold = .Bold
                    italic = .Italic
                    underline = .Underline
                    fontname = word.Font.Name
                    fontsize = word.Font.Size
                    For Each element As TextRange In word.Characters
                        If element.Text <> " " Then
                            wheretostop += 1
                        End If
                    Next
                End With
                txtNotes.Select(index, wheretostop)
                If bold = 0 And italic = 0 And underline = 0 Then
                    style = FontStyle.Regular
                ElseIf bold = -1 And italic = -1 And underline = -1 Then
                    style = FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline
                ElseIf bold = -1 And italic = 0 And underline = 0 Then
                    style = FontStyle.Bold
                ElseIf bold = 0 And italic = -1 And underline = 0 Then
                    style = FontStyle.Italic
                ElseIf bold = 0 And italic = 0 And underline = -1 Then
                    style = FontStyle.Underline
                ElseIf bold = -1 And italic = -1 And underline = 0 Then
                    style = FontStyle.Bold Or FontStyle.Italic
                ElseIf bold = -1 And italic = 0 And underline = -1 Then
                    style = FontStyle.Bold Or FontStyle.Underline
                ElseIf bold = 0 And italic = -1 And underline = -1 Then
                    style = FontStyle.Underline Or FontStyle.Italic
                End If
                txtNotes.SelectionFont = New Drawing.Font(fontname, fontsize, style)
                txtNotes.Select(0, 1)

            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub disable()
        txtNotes.Enabled = False
        cboxFontFamily.Enabled = False
        cboxFontSize.Enabled = False
        btnBold.Enabled = False
        btnitalic.Enabled = False
        btnunderline.Enabled = False
    End Sub
    '--------------------------------------------------------Set methods-------------------------------------------------'
    Sub setnotespage()
        enable()
    End Sub
    Sub settext()
        If notesshape.TextFrame.TextRange.Text <> txtNotes.Text Then
            notesshape.TextFrame.TextRange.Text = txtNotes.Text
        End If
    End Sub
    Sub setalignment()
        Try
            With notesshape.TextFrame.TextRange.ParagraphFormat
                If txtNotes.SelectionAlignment = HorizontalAlignment.Center Then
                    .Alignment = PpParagraphAlignment.ppAlignCenter
                ElseIf txtNotes.SelectionAlignment = HorizontalAlignment.Left Then
                    .Alignment = PpParagraphAlignment.ppAlignLeft
                ElseIf txtNotes.SelectionAlignment = HorizontalAlignment.Right Then
                    .Alignment = PpParagraphAlignment.ppAlignRight
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub
    Sub setfont() ' checks that each word in notes are exactly like the word in PowerPlug
        Try
            For Each word As TextRange In notesshape.TextFrame.TextRange.Words
                Dim index As Integer = word.Start - 1
                Dim wheretostop As Integer = 0
                Dim bold, italic, underline As Boolean
                Dim fontname As String
                Dim fontsize As Single
                Dim selectionstart As Integer = txtNotes.SelectionStart
                Dim selectionlength As Integer = txtNotes.SelectedText.Length
                For Each element As TextRange In word.Characters
                    If element.Text <> " " Then
                        wheretostop += 1
                    End If
                Next
                txtNotes.Select(index, wheretostop)
                With txtNotes.SelectionFont
                    bold = .Bold
                    italic = .Italic
                    underline = .Underline
                    fontname = .Name
                    fontsize = .Size
                End With
                With word.Font
                    .Bold = MsoTriState.msoFalse
                    .Italic = MsoTriState.msoFalse
                    .Underline = MsoTriState.msoFalse
                    If bold = True And italic = True And underline = True Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                    ElseIf bold = True And italic = False And underline = False Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = False And italic = True And underline = False Then
                        .Italic = MsoTriState.msoTrue
                        .Bold = MsoTriState.msoFalse
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = False And italic = False And underline = True Then
                        .Underline = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                        .Bold = MsoTriState.msoFalse
                    ElseIf bold = True And italic = True And underline = False Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = True And italic = False And underline = True Then
                        .Bold = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                    ElseIf bold = False And italic = True And underline = True Then
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                        .Bold = MsoTriState.msoFalse
                    End If
                End With
                word.Font.Name = fontname
                word.Font.Size = fontsize
                txtNotes.Select(selectionstart, selectionlength)

            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub enable()
        txtNotes.Enabled = True
        cboxFontFamily.Enabled = True
        cboxFontSize.Enabled = True
        btnBold.Enabled = True
        btnitalic.Enabled = True
        btnunderline.Enabled = True
    End Sub
    '--------------------------------------------------------General methods-------------------------------------------------'
    Sub B_I_U() 'controls PowerPlug Font_Style
        Try
            Dim bold, italic, underline As Boolean
            Dim fontname As String = txtNotes.SelectionFont.Name
            Dim fontsize As Single = txtNotes.SelectionFont.Size
            Dim style As FontStyle = FontStyle.Regular
            bold = btnBold.Checked
            italic = btnitalic.Checked
            underline = btnunderline.Checked

            If bold = False And italic = False And underline = False Then
                style = FontStyle.Regular
            ElseIf bold = True And italic = True And underline = True Then
                style = FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline
            ElseIf bold = True And italic = False And underline = False Then
                style = FontStyle.Bold
            ElseIf bold = False And italic = True And underline = False Then
                style = FontStyle.Italic
            ElseIf bold = False And italic = False And underline = True Then
                style = FontStyle.Underline
            ElseIf bold = True And italic = True And underline = False Then
                style = FontStyle.Bold Or FontStyle.Italic
            ElseIf bold = True And italic = False And underline = True Then
                style = FontStyle.Bold Or FontStyle.Underline
            ElseIf bold = False And italic = True And underline = True Then
                style = FontStyle.Italic Or FontStyle.Underline
            End If

            txtNotes.SelectionFont = New Drawing.Font(fontname, fontsize, style)
        Catch ex As Exception
        End Try
    End Sub
    Sub check_B_I_U()
        Try
            If txtNotes.SelectionFont.Bold = True Then
                btnBold.Checked = True
            Else
                btnBold.Checked = False
            End If

            If txtNotes.SelectionFont.Italic = True Then
                btnitalic.Checked = True
            Else
                btnitalic.Checked = False
            End If

            If txtNotes.SelectionFont.Underline = True Then
                btnunderline.Checked = True
            Else
                btnunderline.Checked = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub check_name_size()
        Try
            cboxFontFamily.SelectedItem = txtNotes.SelectionFont.Name
            cboxFontSize.SelectedItem = CStr(txtNotes.SelectionFont.Size)
        Catch ex As Exception
        End Try
    End Sub
    Sub checkbullets()
        If txtNotes.SelectionBullet = True Then
            btn_Bullet.Checked = True
        Else
            btn_Bullet.Checked = False
        End If
    End Sub
#End Region

#Region "Event Handlers"
    'controls Font 
    Private Sub cboxFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontSize.SelectionChangeCommitted
        Try
            txtNotes.SelectionFont = New Drawing.Font(txtNotes.SelectionFont.Name, CInt(cboxFontSize.SelectedItem.ToString))
            B_I_U()
            setfont()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cboxFontFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontFamily.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, txtNotes.SelectionFont.Size)
        B_I_U()
        setfont()
    End Sub

    Private Sub btnunderline_Click(sender As Object, e As EventArgs) Handles btnunderline.Click
        B_I_U()
        setfont()
    End Sub
    Private Sub btnitalic_Click(sender As Object, e As EventArgs) Handles btnitalic.Click
        B_I_U()
        setfont()
    End Sub
    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        B_I_U()
        setfont()
    End Sub
    'Bullet & indent
    Private Sub btn_Bullet_CheckedChanged(sender As Object, e As EventArgs) Handles btn_Bullet.CheckedChanged
        If btn_Bullet.Checked Then
            txtNotes.SelectionBullet = True
            Dim start As Integer = txtNotes.SelectionStart
            Dim length As Integer = txtNotes.SelectionLength

            btn_IndentDec.Enabled = True
            btn_IndentInc.Enabled = True
        Else
            txtNotes.SelectionBullet = False

            btn_IndentDec.Enabled = False
            btn_IndentInc.Enabled = False
        End If
    End Sub
    Private Sub btn_IndentInc_Click(sender As Object, e As EventArgs) Handles btn_IndentInc.Click
        Try
            txtNotes.SelectionIndent += 35
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_IndentDec_Click(sender As Object, e As EventArgs) Handles btn_IndentDec.Click
        Try
            txtNotes.SelectionIndent -= 35
        Catch ex As Exception
        End Try
    End Sub
    'save & cut & ...
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
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
    'alignment
    Private Sub btnAlignLeft_Click(sender As Object, e As EventArgs) Handles btnAlignLeft.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Left
        setalignment()
    End Sub
    Private Sub btnAlignRight_Click(sender As Object, e As EventArgs) Handles btnAlignRight.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Right
        setalignment()
    End Sub
    Private Sub btnAlignCenter_Click(sender As Object, e As EventArgs) Handles btnAlignCenter.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Center
        setalignment()
    End Sub
    'general
    Private Sub txtNotes_SelectionChanged(sender As Object, e As EventArgs) Handles txtNotes.SelectionChanged
        check_B_I_U()
        check_name_size()
        checkbullets()
    End Sub
    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        settext()
        B_I_U()
        setfont()
    End Sub
    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txtNotes.SelectionFont = New Drawing.Font("Calibri", 12, FontStyle.Regular)
    End Sub


#End Region

#End Region
    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ====================================='
    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ====================================='
#Region "Format Shape"
    Sub resetall()
        TextBoxPage.Visible = False
        SizePage.Visible = False
        LinePage.Visible = False
    End Sub
    Sub adjustpage(ByVal control As TableLayoutPanel, ByVal length As Integer)    ' width : 288 , height :315    X:4 , Y:3
        Try
            resetall()
            control.Location = New Drawing.Point(4, 3)
            control.Size = New Drawing.Size(TopPanel.Width - 8, length)
            control.BringToFront()
            control.Visible = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cboxFormatShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFormatShape.SelectedIndexChanged
        Select Case cboxFormatShape.SelectedIndex
            Case 0
                adjustpage(TextBoxPage, 330)
                Scroll_General.Value = 0
            Case 1
                adjustpage(SizePage, 337)
                Scroll_General.Value = 0
            Case 2
                adjustpage(LinePage, 390)
                RadBtn_nocolor.Select()
                Scroll_General.Value = 0
        End Select
    End Sub

    '-----------------------------------TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ------------------------------------'
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
                txtleftmargin.Value = selectedshape.TextFrame.MarginLeft / 72
                txtrightmargin.Value = selectedshape.TextFrame.MarginRight / 72
                txttopmargin.Value = selectedshape.TextFrame.MarginTop / 72
                txtbottommargin.Value = selectedshape.TextFrame.MarginBottom / 72

            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub settextPage()
        selectshape()
        Try
            If selectedshape.HasTextFrame Then
                '======================================================TEXT DIRECTION==========================================================='
                With selectedshape.TextFrame
                    Select Case cboxtextdirection.SelectedIndex
                        Case 0
                            .Orientation = MsoTextOrientation.msoTextOrientationHorizontal
                        Case 1
                            .Orientation = MsoTextOrientation.msoTextOrientationDownward
                        Case 2
                            .Orientation = MsoTextOrientation.msoTextOrientationUpward
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
    Private Sub txtleftmargin_ValueChanged(sender As Object, e As EventArgs) Handles txtleftmargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginLeft = txtleftmargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtrightmargin_ValueChanged(sender As Object, e As EventArgs) Handles txtrightmargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginRight = txtleftmargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txttopmargin_ValueChanged(sender As Object, e As EventArgs) Handles txttopmargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginTop = txttopmargin.Value * 72
        Catch ex As Exception
        End Try

    End Sub
    Private Sub txtbottommargin_ValueChanged(sender As Object, e As EventArgs) Handles txtbottommargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginBottom = txtbottommargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub

    '----------------------------------SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE ---------------------------------------'
    Sub getsizepage()
        Try

            If selectedshape.LockAspectRatio = MsoTriState.msoTrue Then
                chkbox_Scale1.Checked = True
            Else
                chkbox_Scale1.Checked = False
            End If
            num_Height.Value = selectedshape.Height / 72
            num_Width.Value = selectedshape.Width / 72
            num_Rot.Value = selectedshape.Rotation
            If selectedshape.Type.ToString = "msoPicture" Then
                If chkbox_Scale2.Checked Then
                    num_ScaleHeight.Value = (selectedshape.Height * 100) / (lbl_OriginalSizeHeight.Text * 72)
                    num_ScaleWidth.Value = (selectedshape.Width * 100) / (lbl_OriginalSizeWidth.Text * 72)
                Else
                    num_ScaleHeight.Value = (selectedshape.Height * 100) / (originallength)
                    num_ScaleWidth.Value = (selectedshape.Width * 100) / (originalwidth)
                End If

            Else
                num_ScaleHeight.Value = (selectedshape.Height * 100) / (originallength)
                num_ScaleWidth.Value = (selectedshape.Width * 100) / (originalwidth)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub picturetools() ' got the original width and height of the picture
        chkbox_Scale2.Enabled = True
        chkbox_Scale3.Enabled = True
        btnReset.Enabled = True

        Dim currentlength = selectedshape.Height
        Dim currentwidth = selectedshape.Width
        selectedshape.ScaleHeight(1, MsoTriState.msoTrue)
        selectedshape.ScaleWidth(1, MsoTriState.msoTrue)
        lbl_OriginalSizeHeight.Text = selectedshape.Height / 72
        lbl_OriginalSizeWidth.Text = selectedshape.Width / 72

        selectedshape.ScaleHeight(currentlength / (lbl_OriginalSizeHeight.Text * 72), MsoTriState.msoTrue)
        selectedshape.ScaleWidth(currentwidth / (lbl_OriginalSizeWidth.Text * 72), MsoTriState.msoTrue)


    End Sub
    Sub textboxtools()
        chkbox_Scale2.Enabled = False
        chkbox_Scale3.Enabled = False
        cbox_Resolution.Enabled = False
        lbl_OriginalSizeHeight.Text = ""
        lbl_OriginalSizeWidth.Text = ""
        btnReset.Enabled = False
    End Sub
    Sub changedimensions(ByVal height As Integer, ByVal width As Integer)
        selectedshape.Height = height
        selectedshape.Width = width
    End Sub
    Sub resolutioncontrol()
        Select Case cbox_Resolution.SelectedIndex
            Case 0
                changedimensions(72 * 48.71, 72 * 35.42)
            Case 1

            Case 2

            Case 3

        End Select
    End Sub

    Private Sub num_Height_ValueChanged(sender As Object, e As EventArgs) Handles num_Height.ValueChanged
        Try
            selectedshape.Height = num_Height.Value * 72
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Width_ValueChanged(sender As Object, e As EventArgs) Handles num_Width.ValueChanged
        Try
            selectedshape.Width = num_Width.Value * 72
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Rot_ValueChanged(sender As Object, e As EventArgs) Handles num_Rot.ValueChanged
        Try
            selectedshape.Rotation = num_Rot.Value
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkbox_Scale1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_Scale1.CheckedChanged
        If chkbox_Scale1.Checked Then
            selectshape()
            selectedshape.LockAspectRatio = MsoTriState.msoTrue
        Else
            selectedshape.LockAspectRatio = MsoTriState.msoFalse
        End If
    End Sub

    Private Sub num_ScaleHeight_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleHeight.ValueChanged
        Try
            If chkbox_Scale2.Checked Then
                selectedshape.Height = (num_ScaleHeight.Value / 100) * (lbl_OriginalSizeHeight.Text * 72)
                getsizepage()
            Else
                selectedshape.Height = (num_ScaleHeight.Value / 100) * originallength
                getsizepage()
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_ScaleWidth_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleWidth.ValueChanged
        Try
            If chkbox_Scale2.Checked Then
                selectedshape.Width = (num_ScaleWidth.Value / 100) * (lbl_OriginalSizeWidth.Text * 72)
            Else
                selectedshape.Width = (num_ScaleWidth.Value / 100) * originalwidth
                getsizepage()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkbox_Scale2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_Scale2.CheckedChanged
        getsizepage()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        selectedshape.Height = lbl_OriginalSizeHeight.Text * 72
        selectedshape.Width = lbl_OriginalSizeWidth.Text * 72
    End Sub
    Private Sub chkbox_Scale3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_Scale3.CheckedChanged
    End Sub
    Private Sub cbox_Resolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_Resolution.SelectedIndexChanged
        resolutioncontrol()
    End Sub

    '----------------------------------LINE LINE LINE LINE LINE LINE LINE LINE LINE LINE LINE  ---------------------------------------'
    'Methods
    Sub setscroll(inner As TableLayoutPanel, outer As Panel, scroll As VScrollBar)
        Dim portion As Integer
        portion = (inner.Height - outer.Height) / 4.8
        Select Case scroll.Value
            Case 0
                inner.Location = New Drawing.Point(3, 3 - portion * 0)
            Case 10
                inner.Location = New Drawing.Point(3, 3 - portion * 1)
            Case 20
                inner.Location = New Drawing.Point(3, 3 - portion * 2)
            Case 30
                inner.Location = New Drawing.Point(3, 3 - portion * 3)
            Case 40
                inner.Location = New Drawing.Point(3, 3 - portion * 4)
            Case 50
                inner.Location = New Drawing.Point(3, 3 - portion * 5)
        End Select
    End Sub
    Sub resizelist(ByVal listview As ListView, width As Integer, height As Integer)
        listview.Size = New Drawing.Size(width, height)
    End Sub
    Sub showlstvw(ByVal btn As CheckBox, list As ListView)
        Dim location, delta As Drawing.Point
        delta.X = 5
        delta.Y = 27
        location = MousePosition - Me.Location - delta

        If btn.Checked Then
            list.Show()
            list.BringToFront()
            list.Location = location
        Else
            list.Hide()
        End If
    End Sub
    'Event Handlers
    Private Sub RadBtn_nocolor_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtn_nocolor.CheckedChanged
        If RadBtn_nocolor.Checked = True Then
            Panel_SolidLine.Visible = False
            Scroll_Line.Enabled = False
        End If
    End Sub
    Private Sub RadBtn_Solid_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtn_Solid.CheckedChanged
        If RadBtn_Solid.Checked = True Then
            Panel_SolidLine.Visible = True
            Panel_SolidLine.Location = New Drawing.Point(3, 3)
            Panel_SolidLine.Dock = DockStyle.Fill
            Scroll_Line.Enabled = True
        End If
    End Sub
    Private Sub RadBtn_Grad_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtn_Grad.CheckedChanged
        If RadBtn_Solid.Checked = True Then
            Panel_SolidLine.Visible = True
        End If
    End Sub
    Private Sub btn_colordlg_Click(sender As Object, e As EventArgs) Handles btn_colordlg.Click
        Color_Solidline.ShowDialog()
    End Sub

    Private Sub Scroll_Line_Scroll(sender As Object, e As EventArgs) Handles Scroll_Line.Scroll
        setscroll(tlp_SolidlineInner, Panel_SolidLine, Scroll_Line)
    End Sub
    Private Sub numeric_Transp_ValueChanged(sender As Object, e As EventArgs) Handles numeric_Transp.ValueChanged
        TrackBar_Transp.Value = numeric_Transp.Value / 10
    End Sub


    Private Sub btn_DashType_CheckedChanged(sender As Object, e As EventArgs) Handles btn_DashType.CheckedChanged
        showlstvw(btn_DashType, lstvw_DashType)
        resizelist(lstvw_DashType, 102, 120)
    End Sub
    Private Sub btn_BegArrowType_CheckedChanged(sender As Object, e As EventArgs) Handles btn_BegArrowType.CheckedChanged
        showlstvw(btn_BegArrowType, lstvw_ArrowType)
        resizelist(lstvw_ArrowType, 113, 48)
    End Sub
    Private Sub btn_BegArrowSize_CheckedChanged(sender As Object, e As EventArgs) Handles btn_BegArrowSize.CheckedChanged
        showlstvw(btn_BegArrowSize, lstvw_ArrowSize)
        resizelist(lstvw_ArrowSize, 154, 78)
    End Sub
    Private Sub btn_EndArrowType_CheckedChanged(sender As Object, e As EventArgs) Handles btn_EndArrowType.CheckedChanged
        showlstvw(btn_EndArrowType, lstvw_ArrowType)
        resizelist(lstvw_ArrowType, 113, 48)
    End Sub
    Private Sub btn_EndArrowSize_CheckedChanged(sender As Object, e As EventArgs) Handles btn_EndArrowSize.CheckedChanged
        showlstvw(btn_EndArrowSize, lstvw_ArrowSize)
        resizelist(lstvw_ArrowSize, 154, 78)
    End Sub

    Private Sub btn_Compound_CheckedChanged(sender As Object, e As EventArgs) Handles btn_Compound.CheckedChanged
        showlstvw(btn_Compound, lstvw_Compound)
        resizelist(lstvw_Compound, 90, 91)
    End Sub

    ' lstvw_dashtype >>>> 102,188
    ' lstvw_arrowtype >>>> 113,48
    ' lstvw_Compound >>>> 90,91
    ' lstvw_Size >>>> 154,78
#End Region
    '=======================================ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ==================================='
    '=======================================ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ==================================='
#Region " Alignment"
    Sub execute(ByVal idmso As String)
        Try
            objapp.CommandBars.ExecuteMso(idmso)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_Alignleft_Click(sender As Object, e As EventArgs) Handles btn_AlignLeft.Click
        execute("ObjectsAlignLeftSmart")
    End Sub
    Private Sub btn_AlignTop_Click(sender As Object, e As EventArgs) Handles btn_AlignTop.Click
        execute("ObjectsAlignTopSmart")
    End Sub
    Private Sub btn_AlignRight_Click(sender As Object, e As EventArgs) Handles btn_AlignRight.Click
        execute("ObjectsAlignRightSmart")
    End Sub
    Private Sub btn_AlignBottom_Click(sender As Object, e As EventArgs) Handles btn_AlignBottom.Click
        execute("ObjectsAlignBottomSmart")
    End Sub
    Private Sub btn_AlignCenter_Click(sender As Object, e As EventArgs) Handles btn_AlignCenter.Click
        execute("ObjectsAlignCenterHorizontalSmart")
    End Sub
    Private Sub btn_AlignMiddle_Click(sender As Object, e As EventArgs) Handles btn_AlignMiddle.Click
        execute(" ObjectsAlignMiddleVerticalSmart")
    End Sub
    Private Sub btn_SendtoBack_Click(sender As Object, e As EventArgs) Handles btn_SendtoBack.Click
        execute("ObjectSendToBack")
    End Sub
    Private Sub btn_BringForward_Click(sender As Object, e As EventArgs) Handles btn_BringForward.Click
        execute("ObjectBringForward ")
    End Sub
    Private Sub btn_BorderRight_Click(sender As Object, e As EventArgs) Handles btn_BorderRight.Click
        execute("BorderRight")
    End Sub
    Private Sub btn_BorderTop_Click(sender As Object, e As EventArgs) Handles btn_BorderTop.Click
        execute("BorderTop")
    End Sub
    Private Sub btn_BorderBottom_Click(sender As Object, e As EventArgs) Handles btn_BorderBottom.Click
        execute("BorderBottom")
    End Sub
    Private Sub btn_Borderleft_Click(sender As Object, e As EventArgs) Handles btn_Borderleft.Click
        execute("BorderLeft")
    End Sub
    Private Sub btn_BorderAll_Click(sender As Object, e As EventArgs) Handles btn_BorderAll.Click
        execute("BordersAll")
    End Sub
    Private Sub btn_DistColumns_Click(sender As Object, e As EventArgs) Handles btn_DistColumns.Click
        execute("TableColumnsDistribute")
    End Sub
    Private Sub btn_DistRows_Click(sender As Object, e As EventArgs) Handles btn_DistRows.Click
        execute("TableRowsDistribute")
    End Sub
    Private Sub btn_PasteText_Click(sender As Object, e As EventArgs) Handles btn_PasteText.Click
        execute("Paste")
    End Sub
    Private Sub btn_FormatShape_Click(sender As Object, e As EventArgs) Handles btn_FormatShape.Click
        execute("ObjectFormatDialog")
    End Sub
    Private Sub btn_Paragraph_Click(sender As Object, e As EventArgs) Handles btn_Paragraph.Click
        execute("PowerPointParagraphDialog")
    End Sub
#End Region


End Class
