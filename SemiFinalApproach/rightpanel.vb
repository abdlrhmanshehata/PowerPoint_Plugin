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
    Dim l As Integer
    Dim relativestate As MsoTriState
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
            selectedshape = objapp.ActivePresentation.Slides(k).Shapes(g)
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
        '===============================Mouse In=============================================
        If location.X > critical.X Then
            settextPage()
            'setsizepage()
            setnotespage()
            '===============================Mouse Out=============================================
        Else
            gettextpage()
            'getsizepage()
            getnotespage()
            Try
                btnRefresh_Click()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub vscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles vscroll.Scroll
        Select Case vscroll.Value
            Case 0
                setloc(3, 24, 0)
            Case 10
                setloc(3, 24, 1)
            Case 20
                setloc(3, 24, 2)
            Case 30
                setloc(3, 24, 3)
            Case 40
                setloc(3, 24, 4)
            Case 50
                setloc(3, 24, 5.5)
        End Select
    End Sub
    Sub setloc(ByVal start As Integer, ByVal portion As Integer, ByVal caseindex As Integer)
        Dim y As Integer
        y = start - (caseindex * portion)
        If TextBoxPage.Visible = True Then
            TextBoxPage.Location = New Drawing.Point(TextBoxPage.Location.X, y)
        End If
        If SizePage.Visible = True Then
            SizePage.Location = New Drawing.Point(TextBoxPage.Location.X, y)
        End If
    End Sub
    Private Sub rightpanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboxFormatShape.SelectedIndex = 0
    End Sub
    Private Sub rightpanel_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TextBoxPage.Width = Me.Width - 30
    End Sub

#End Region


    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES============================================='
    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES============================================='
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

    Private Sub btnRefresh_Click()
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

    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ====================================='
    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ====================================='
#Region "Format Shape"
    Sub resetall()
        TextBoxPage.Visible = False
        SizePage.Visible = False
    End Sub
    Sub adjustpage(ByVal control As TableLayoutPanel)    ' width : 288 , height :315    X:4 , Y:3
        resetall()
        control.Location = New Drawing.Point(4, 3)
        control.Size = New Drawing.Size(340, 330)
        control.BringToFront()
        control.Visible = True
    End Sub
    Private Sub cboxFormatShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFormatShape.SelectedIndexChanged
        Select Case cboxFormatShape.SelectedIndex
            Case 0
                adjustpage(TextBoxPage)
            Case 1
                'adjustpage(SizePage)
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
        selectshape()
        Try
            If selectedshape.HasTextFrame = MsoTriState.msoFalse Then
                chkbox_Scale2.Enabled = True
                chkbox_Scale3.Enabled = True
                cbox_Resolution.Enabled = True
            Else
                chkbox_Scale2.Enabled = False
                chkbox_Scale3.Enabled = False
                cbox_Resolution.Enabled = False
            End If

            '----------------------------------------Size and rotate----------------------------------'
            If num_Height.Value <> selectedshape.Height / 72 Or num_Width.Value <> selectedshape.Width / 72 Or _
                num_Rot.Value <> selectedshape.Rotation / 72 Then
                num_Height.Value = selectedshape.Height / 72
                num_Width.Value = selectedshape.Width / 72
                num_Rot.Value = selectedshape.Rotation / 72
            End If

            '----------------------------------------Scale----------------------------------'

        Catch ex As Exception

        End Try
    End Sub
    Sub checkrelativestate()
        If chkbox_Scale2.Checked Then
            relativestate = MsoTriState.msoTrue
        Else
            relativestate = MsoTriState.msoFalse
        End If
    End Sub
    Private Sub num_Height_ValueChanged(sender As Object, e As EventArgs) Handles num_Height.ValueChanged
        Try
            selectedshape.Height = num_Height.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Width_ValueChanged(sender As Object, e As EventArgs) Handles num_Width.ValueChanged
        Try
            selectedshape.Width = num_Width.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Rot_ValueChanged(sender As Object, e As EventArgs) Handles num_Rot.ValueChanged
        Try
            selectedshape.Rotation = num_Rot.Value
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
        selectshape()
        checkrelativestate()
        Try
            selectedshape.ScaleHeight(num_ScaleHeight.Value / 100, relativestate, MsoScaleFrom.msoScaleFromTopLeft)
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_ScaleWidth_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleWidth.ValueChanged
        selectshape()
        checkrelativestate()
        Try
            selectedshape.ScaleWidth(num_ScaleWidth.Value / 100, relativestate, MsoScaleFrom.msoScaleFromTopLeft)
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_AlignLeft.Click
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
#End Region
 
End Class
