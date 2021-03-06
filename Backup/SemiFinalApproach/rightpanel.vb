﻿Imports Microsoft.Office.Interop.PowerPoint
Imports Microsoft.Office.Core
Imports System.Windows.Forms
Imports System.Drawing

Public Class rightpanel
    Dim objapp As PowerPoint.Application = Globals.ThisAddIn.Application
    Dim i As Integer
    Dim notesshape As PowerPoint.Shape
    Dim shapename As String
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


#Region "Picture Format"

#End Region





End Class
