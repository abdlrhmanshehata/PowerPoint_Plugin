﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rightpanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Fixedtimer = New System.Windows.Forms.Timer(Me.components)
        Me.cboxFormatShape = New System.Windows.Forms.ComboBox()
        Me.AutoFit = New System.Windows.Forms.GroupBox()
        Me.ContentAutofit = New System.Windows.Forms.TableLayoutPanel()
        Me.Donnotautofit = New System.Windows.Forms.RadioButton()
        Me.Shrinktext = New System.Windows.Forms.RadioButton()
        Me.ResizeShape = New System.Windows.Forms.RadioButton()
        Me.InternalMargin = New System.Windows.Forms.GroupBox()
        Me.contentInternalMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.paneltopmargin = New System.Windows.Forms.TableLayoutPanel()
        Me.txttopmargin = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelleftmargin = New System.Windows.Forms.TableLayoutPanel()
        Me.txtleftmargin = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelrightmargin = New System.Windows.Forms.TableLayoutPanel()
        Me.txtrightmargin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelbottommargin = New System.Windows.Forms.TableLayoutPanel()
        Me.txtbottommargin = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkboxWrap = New System.Windows.Forms.CheckBox()
        Me.TextLayout = New System.Windows.Forms.GroupBox()
        Me.contenttextlayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxtextdirection = New System.Windows.Forms.ComboBox()
        Me.cboxtextalignment = New System.Windows.Forms.ComboBox()
        Me.Scroll_General = New System.Windows.Forms.VScrollBar()
        Me.TextBoxPage = New System.Windows.Forms.TableLayoutPanel()
        Me.ChoosePanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.SizePage = New System.Windows.Forms.TableLayoutPanel()
        Me.Gbox_Scale = New System.Windows.Forms.GroupBox()
        Me.TLP_Scale = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Scale1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_ScaleHeight = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_H = New System.Windows.Forms.Label()
        Me.num_ScaleHeight = New System.Windows.Forms.NumericUpDown()
        Me.TLP_ScaleWidth = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_W = New System.Windows.Forms.Label()
        Me.num_ScaleWidth = New System.Windows.Forms.NumericUpDown()
        Me.TLP_Scale2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkbox_Scale3 = New System.Windows.Forms.CheckBox()
        Me.chkbox_Scale2 = New System.Windows.Forms.CheckBox()
        Me.chkbox_Scale1 = New System.Windows.Forms.CheckBox()
        Me.TLP_Scale2_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblResolution = New System.Windows.Forms.Label()
        Me.cbox_Resolution = New System.Windows.Forms.ComboBox()
        Me.Gbox_SizeandRotate = New System.Windows.Forms.GroupBox()
        Me.TLP_Sizeandrotate = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Rotation = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRotation = New System.Windows.Forms.Label()
        Me.num_Rot = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TLP_Width = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.num_Width = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TLP_Height = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.num_Height = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Gbox_OriginalSize = New System.Windows.Forms.GroupBox()
        Me.TLP_OriginalSize = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TLP_OriginalSize1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_OriginalSize1_2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_OriginalSizeWidth = New System.Windows.Forms.Label()
        Me.lbl_Width = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TLP_OriginalSize1_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_height = New System.Windows.Forms.Label()
        Me.lbl_OriginalSizeHeight = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TLP_Alignment = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_DistRows = New System.Windows.Forms.Button()
        Me.btn_BringForward = New System.Windows.Forms.Button()
        Me.btn_DistColumns = New System.Windows.Forms.Button()
        Me.btn_SendtoBack = New System.Windows.Forms.Button()
        Me.btn_AlignCenter = New System.Windows.Forms.Button()
        Me.btn_BorderTop = New System.Windows.Forms.Button()
        Me.btn_BorderBottom = New System.Windows.Forms.Button()
        Me.btn_Borderleft = New System.Windows.Forms.Button()
        Me.btn_BorderRight = New System.Windows.Forms.Button()
        Me.btn_BorderAll = New System.Windows.Forms.Button()
        Me.btn_PasteText = New System.Windows.Forms.Button()
        Me.btn_Paragraph = New System.Windows.Forms.Button()
        Me.btn_FormatShape = New System.Windows.Forms.Button()
        Me.btn_AlignBottom = New System.Windows.Forms.Button()
        Me.btn_AlignRight = New System.Windows.Forms.Button()
        Me.btn_AlignTop = New System.Windows.Forms.Button()
        Me.btn_AlignLeft = New System.Windows.Forms.Button()
        Me.btn_DistVer = New System.Windows.Forms.Button()
        Me.btn_DistHor = New System.Windows.Forms.Button()
        Me.btn_AlignMiddle = New System.Windows.Forms.Button()
        Me.SCont_A = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Scont_B = New System.Windows.Forms.SplitContainer()
        Me.TLP_Upper = New System.Windows.Forms.TableLayoutPanel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.NotesTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Part1_notes = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboxFontFamily = New System.Windows.Forms.ComboBox()
        Me.cboxFontSize = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Bullet = New System.Windows.Forms.CheckBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_IndentDec = New System.Windows.Forms.Button()
        Me.btn_IndentInc = New System.Windows.Forms.Button()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBold = New System.Windows.Forms.CheckBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnitalic = New System.Windows.Forms.CheckBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnunderline = New System.Windows.Forms.CheckBox()
        Me.btnAlignLeft = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.Button()
        Me.btnAlignCenter = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.EventsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AutoFit.SuspendLayout()
        Me.ContentAutofit.SuspendLayout()
        Me.InternalMargin.SuspendLayout()
        Me.contentInternalMargin.SuspendLayout()
        Me.paneltopmargin.SuspendLayout()
        CType(Me.txttopmargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelleftmargin.SuspendLayout()
        CType(Me.txtleftmargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrightmargin.SuspendLayout()
        CType(Me.txtrightmargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbottommargin.SuspendLayout()
        CType(Me.txtbottommargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextLayout.SuspendLayout()
        Me.contenttextlayout.SuspendLayout()
        Me.TextBoxPage.SuspendLayout()
        Me.ChoosePanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.SizePage.SuspendLayout()
        Me.Gbox_Scale.SuspendLayout()
        Me.TLP_Scale.SuspendLayout()
        Me.TLP_Scale1.SuspendLayout()
        Me.TLP_ScaleHeight.SuspendLayout()
        CType(Me.num_ScaleHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_ScaleWidth.SuspendLayout()
        CType(Me.num_ScaleWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Scale2.SuspendLayout()
        Me.TLP_Scale2_1.SuspendLayout()
        Me.Gbox_SizeandRotate.SuspendLayout()
        Me.TLP_Sizeandrotate.SuspendLayout()
        Me.TLP_Rotation.SuspendLayout()
        CType(Me.num_Rot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Width.SuspendLayout()
        CType(Me.num_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Height.SuspendLayout()
        CType(Me.num_Height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbox_OriginalSize.SuspendLayout()
        Me.TLP_OriginalSize.SuspendLayout()
        Me.TLP_OriginalSize1.SuspendLayout()
        Me.TLP_OriginalSize1_2.SuspendLayout()
        Me.TLP_OriginalSize1_1.SuspendLayout()
        Me.TLP_Alignment.SuspendLayout()
        CType(Me.SCont_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCont_A.Panel1.SuspendLayout()
        Me.SCont_A.Panel2.SuspendLayout()
        Me.SCont_A.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_B.Panel1.SuspendLayout()
        Me.Scont_B.Panel2.SuspendLayout()
        Me.Scont_B.SuspendLayout()
        Me.TLP_Upper.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.NotesTableLayout.SuspendLayout()
        Me.Part1_notes.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fixedtimer
        '
        Me.Fixedtimer.Enabled = True
        '
        'cboxFormatShape
        '
        Me.cboxFormatShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFormatShape.DropDownHeight = 105
        Me.cboxFormatShape.FormattingEnabled = True
        Me.cboxFormatShape.IntegralHeight = False
        Me.cboxFormatShape.Items.AddRange(New Object() {"Text Box", "Size"})
        Me.cboxFormatShape.Location = New System.Drawing.Point(0, 0)
        Me.cboxFormatShape.Name = "cboxFormatShape"
        Me.cboxFormatShape.Size = New System.Drawing.Size(303, 21)
        Me.cboxFormatShape.TabIndex = 0
        Me.cboxFormatShape.Text = " "
        '
        'AutoFit
        '
        Me.AutoFit.Controls.Add(Me.ContentAutofit)
        Me.AutoFit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoFit.Location = New System.Drawing.Point(3, 17)
        Me.AutoFit.Name = "AutoFit"
        Me.AutoFit.Size = New System.Drawing.Size(253, 14)
        Me.AutoFit.TabIndex = 0
        Me.AutoFit.TabStop = False
        Me.AutoFit.Text = "AutoFit"
        '
        'ContentAutofit
        '
        Me.ContentAutofit.ColumnCount = 1
        Me.ContentAutofit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ContentAutofit.Controls.Add(Me.Donnotautofit, 0, 0)
        Me.ContentAutofit.Controls.Add(Me.Shrinktext, 0, 1)
        Me.ContentAutofit.Controls.Add(Me.ResizeShape, 0, 2)
        Me.ContentAutofit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentAutofit.Location = New System.Drawing.Point(3, 16)
        Me.ContentAutofit.Name = "ContentAutofit"
        Me.ContentAutofit.RowCount = 3
        Me.ContentAutofit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ContentAutofit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ContentAutofit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ContentAutofit.Size = New System.Drawing.Size(247, 0)
        Me.ContentAutofit.TabIndex = 0
        '
        'Donnotautofit
        '
        Me.Donnotautofit.AutoSize = True
        Me.Donnotautofit.Location = New System.Drawing.Point(3, 3)
        Me.Donnotautofit.Name = "Donnotautofit"
        Me.Donnotautofit.Size = New System.Drawing.Size(90, 1)
        Me.Donnotautofit.TabIndex = 0
        Me.Donnotautofit.TabStop = True
        Me.Donnotautofit.Text = "&Do not Autofit"
        Me.Donnotautofit.UseVisualStyleBackColor = True
        '
        'Shrinktext
        '
        Me.Shrinktext.AutoSize = True
        Me.Shrinktext.Location = New System.Drawing.Point(3, 3)
        Me.Shrinktext.Name = "Shrinktext"
        Me.Shrinktext.Size = New System.Drawing.Size(133, 1)
        Me.Shrinktext.TabIndex = 1
        Me.Shrinktext.TabStop = True
        Me.Shrinktext.Text = "&Shrink text on overflow"
        Me.Shrinktext.UseVisualStyleBackColor = True
        '
        'ResizeShape
        '
        Me.ResizeShape.AutoSize = True
        Me.ResizeShape.Location = New System.Drawing.Point(3, 3)
        Me.ResizeShape.Name = "ResizeShape"
        Me.ResizeShape.Size = New System.Drawing.Size(134, 1)
        Me.ResizeShape.TabIndex = 2
        Me.ResizeShape.TabStop = True
        Me.ResizeShape.Text = "&Resize Shape to fit text"
        Me.ResizeShape.UseVisualStyleBackColor = True
        '
        'InternalMargin
        '
        Me.InternalMargin.Controls.Add(Me.contentInternalMargin)
        Me.InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InternalMargin.Location = New System.Drawing.Point(3, 37)
        Me.InternalMargin.Name = "InternalMargin"
        Me.InternalMargin.Size = New System.Drawing.Size(253, 10)
        Me.InternalMargin.TabIndex = 0
        Me.InternalMargin.TabStop = False
        Me.InternalMargin.Text = "InternalMargin"
        '
        'contentInternalMargin
        '
        Me.contentInternalMargin.ColumnCount = 2
        Me.contentInternalMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.Controls.Add(Me.paneltopmargin, 0, 1)
        Me.contentInternalMargin.Controls.Add(Me.panelleftmargin, 0, 0)
        Me.contentInternalMargin.Controls.Add(Me.panelrightmargin, 1, 0)
        Me.contentInternalMargin.Controls.Add(Me.panelbottommargin, 1, 1)
        Me.contentInternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentInternalMargin.Location = New System.Drawing.Point(3, 16)
        Me.contentInternalMargin.Name = "contentInternalMargin"
        Me.contentInternalMargin.RowCount = 2
        Me.contentInternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.Size = New System.Drawing.Size(247, 0)
        Me.contentInternalMargin.TabIndex = 2
        '
        'paneltopmargin
        '
        Me.paneltopmargin.ColumnCount = 2
        Me.paneltopmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.paneltopmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.paneltopmargin.Controls.Add(Me.txttopmargin, 1, 0)
        Me.paneltopmargin.Controls.Add(Me.Label2, 0, 0)
        Me.paneltopmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneltopmargin.Location = New System.Drawing.Point(3, 3)
        Me.paneltopmargin.Name = "paneltopmargin"
        Me.paneltopmargin.RowCount = 1
        Me.paneltopmargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.paneltopmargin.Size = New System.Drawing.Size(117, 1)
        Me.paneltopmargin.TabIndex = 2
        '
        'txttopmargin
        '
        Me.txttopmargin.DecimalPlaces = 2
        Me.txttopmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttopmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txttopmargin.Location = New System.Drawing.Point(49, 3)
        Me.txttopmargin.Name = "txttopmargin"
        Me.txttopmargin.Size = New System.Drawing.Size(65, 20)
        Me.txttopmargin.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 1)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Top :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelleftmargin
        '
        Me.panelleftmargin.ColumnCount = 2
        Me.panelleftmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.58333!))
        Me.panelleftmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.41667!))
        Me.panelleftmargin.Controls.Add(Me.txtleftmargin, 1, 0)
        Me.panelleftmargin.Controls.Add(Me.Label1, 0, 0)
        Me.panelleftmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelleftmargin.Location = New System.Drawing.Point(3, 3)
        Me.panelleftmargin.Name = "panelleftmargin"
        Me.panelleftmargin.RowCount = 1
        Me.panelleftmargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelleftmargin.Size = New System.Drawing.Size(117, 1)
        Me.panelleftmargin.TabIndex = 0
        '
        'txtleftmargin
        '
        Me.txtleftmargin.DecimalPlaces = 2
        Me.txtleftmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtleftmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtleftmargin.Location = New System.Drawing.Point(49, 3)
        Me.txtleftmargin.Name = "txtleftmargin"
        Me.txtleftmargin.Size = New System.Drawing.Size(65, 20)
        Me.txtleftmargin.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 1)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Left :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelrightmargin
        '
        Me.panelrightmargin.ColumnCount = 2
        Me.panelrightmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.12903!))
        Me.panelrightmargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.87097!))
        Me.panelrightmargin.Controls.Add(Me.txtrightmargin, 1, 0)
        Me.panelrightmargin.Controls.Add(Me.Label3, 0, 0)
        Me.panelrightmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelrightmargin.Location = New System.Drawing.Point(126, 3)
        Me.panelrightmargin.Name = "panelrightmargin"
        Me.panelrightmargin.RowCount = 1
        Me.panelrightmargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelrightmargin.Size = New System.Drawing.Size(118, 1)
        Me.panelrightmargin.TabIndex = 3
        '
        'txtrightmargin
        '
        Me.txtrightmargin.DecimalPlaces = 2
        Me.txtrightmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrightmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtrightmargin.Location = New System.Drawing.Point(51, 3)
        Me.txtrightmargin.Name = "txtrightmargin"
        Me.txtrightmargin.Size = New System.Drawing.Size(64, 20)
        Me.txtrightmargin.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 1)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Right :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelbottommargin
        '
        Me.panelbottommargin.ColumnCount = 2
        Me.panelbottommargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.panelbottommargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.panelbottommargin.Controls.Add(Me.txtbottommargin, 1, 0)
        Me.panelbottommargin.Controls.Add(Me.Label4, 0, 0)
        Me.panelbottommargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelbottommargin.Location = New System.Drawing.Point(126, 3)
        Me.panelbottommargin.Name = "panelbottommargin"
        Me.panelbottommargin.RowCount = 1
        Me.panelbottommargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelbottommargin.Size = New System.Drawing.Size(118, 1)
        Me.panelbottommargin.TabIndex = 4
        '
        'txtbottommargin
        '
        Me.txtbottommargin.DecimalPlaces = 2
        Me.txtbottommargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbottommargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtbottommargin.Location = New System.Drawing.Point(50, 3)
        Me.txtbottommargin.Name = "txtbottommargin"
        Me.txtbottommargin.Size = New System.Drawing.Size(65, 20)
        Me.txtbottommargin.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 1)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Bot :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkboxWrap
        '
        Me.chkboxWrap.AutoSize = True
        Me.chkboxWrap.Location = New System.Drawing.Point(3, 53)
        Me.chkboxWrap.Name = "chkboxWrap"
        Me.chkboxWrap.Size = New System.Drawing.Size(115, 2)
        Me.chkboxWrap.TabIndex = 1
        Me.chkboxWrap.Text = "&Wrap text in shape"
        Me.chkboxWrap.UseVisualStyleBackColor = True
        '
        'TextLayout
        '
        Me.TextLayout.Controls.Add(Me.contenttextlayout)
        Me.TextLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextLayout.Location = New System.Drawing.Point(3, 3)
        Me.TextLayout.Name = "TextLayout"
        Me.TextLayout.Size = New System.Drawing.Size(253, 8)
        Me.TextLayout.TabIndex = 0
        Me.TextLayout.TabStop = False
        Me.TextLayout.Text = "TextLayout"
        '
        'contenttextlayout
        '
        Me.contenttextlayout.ColumnCount = 2
        Me.contenttextlayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contenttextlayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.contenttextlayout.Controls.Add(Me.Label5, 0, 1)
        Me.contenttextlayout.Controls.Add(Me.Label6, 0, 0)
        Me.contenttextlayout.Controls.Add(Me.cboxtextdirection, 1, 1)
        Me.contenttextlayout.Controls.Add(Me.cboxtextalignment, 1, 0)
        Me.contenttextlayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contenttextlayout.Location = New System.Drawing.Point(3, 16)
        Me.contenttextlayout.Name = "contenttextlayout"
        Me.contenttextlayout.RowCount = 2
        Me.contenttextlayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033!))
        Me.contenttextlayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967!))
        Me.contenttextlayout.Size = New System.Drawing.Size(247, 0)
        Me.contenttextlayout.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 1)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Te&xt Direction :    "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 1)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Vertical Alignment : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxtextdirection
        '
        Me.cboxtextdirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextdirection.FormattingEnabled = True
        Me.cboxtextdirection.Items.AddRange(New Object() {"Horizontal", "Rotate all text 90*", "Rotate all text 270*", "Stacked"})
        Me.cboxtextdirection.Location = New System.Drawing.Point(97, 3)
        Me.cboxtextdirection.Name = "cboxtextdirection"
        Me.cboxtextdirection.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextdirection.TabIndex = 1
        '
        'cboxtextalignment
        '
        Me.cboxtextalignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextalignment.FormattingEnabled = True
        Me.cboxtextalignment.Items.AddRange(New Object() {"Top", "Middle", "Bottom"})
        Me.cboxtextalignment.Location = New System.Drawing.Point(97, 3)
        Me.cboxtextalignment.Name = "cboxtextalignment"
        Me.cboxtextalignment.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextalignment.TabIndex = 3
        '
        'Scroll_General
        '
        Me.Scroll_General.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scroll_General.LargeChange = 51
        Me.Scroll_General.Location = New System.Drawing.Point(289, 0)
        Me.Scroll_General.Name = "Scroll_General"
        Me.Scroll_General.Size = New System.Drawing.Size(22, 162)
        Me.Scroll_General.SmallChange = 10
        Me.Scroll_General.TabIndex = 20
        '
        'TextBoxPage
        '
        Me.TextBoxPage.BackColor = System.Drawing.Color.White
        Me.TextBoxPage.ColumnCount = 1
        Me.TextBoxPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TextBoxPage.Controls.Add(Me.chkboxWrap, 0, 3)
        Me.TextBoxPage.Controls.Add(Me.InternalMargin, 0, 2)
        Me.TextBoxPage.Controls.Add(Me.AutoFit, 0, 1)
        Me.TextBoxPage.Controls.Add(Me.TextLayout, 0, 0)
        Me.TextBoxPage.Location = New System.Drawing.Point(12, 99)
        Me.TextBoxPage.Name = "TextBoxPage"
        Me.TextBoxPage.RowCount = 4
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.71428!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.87302!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61905!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TextBoxPage.Size = New System.Drawing.Size(259, 58)
        Me.TextBoxPage.TabIndex = 21
        Me.TextBoxPage.Visible = False
        '
        'ChoosePanel
        '
        Me.ChoosePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChoosePanel.Controls.Add(Me.cboxFormatShape)
        Me.ChoosePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChoosePanel.Location = New System.Drawing.Point(3, 52)
        Me.ChoosePanel.MaximumSize = New System.Drawing.Size(800, 22)
        Me.ChoosePanel.MinimumSize = New System.Drawing.Size(2, 22)
        Me.ChoosePanel.Name = "ChoosePanel"
        Me.ChoosePanel.Size = New System.Drawing.Size(305, 22)
        Me.ChoosePanel.TabIndex = 21
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.White
        Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPanel.Controls.Add(Me.SizePage)
        Me.TopPanel.Controls.Add(Me.TextBoxPage)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(289, 162)
        Me.TopPanel.TabIndex = 22
        '
        'SizePage
        '
        Me.SizePage.BackColor = System.Drawing.Color.White
        Me.SizePage.ColumnCount = 1
        Me.SizePage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SizePage.Controls.Add(Me.Gbox_Scale, 0, 1)
        Me.SizePage.Controls.Add(Me.Gbox_SizeandRotate, 0, 0)
        Me.SizePage.Controls.Add(Me.Gbox_OriginalSize, 0, 2)
        Me.SizePage.Location = New System.Drawing.Point(21, 16)
        Me.SizePage.Name = "SizePage"
        Me.SizePage.RowCount = 3
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.9697!))
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.87879!))
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.84848!))
        Me.SizePage.Size = New System.Drawing.Size(214, 55)
        Me.SizePage.TabIndex = 28
        Me.SizePage.Visible = False
        '
        'Gbox_Scale
        '
        Me.Gbox_Scale.Controls.Add(Me.TLP_Scale)
        Me.Gbox_Scale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_Scale.Location = New System.Drawing.Point(3, 17)
        Me.Gbox_Scale.Name = "Gbox_Scale"
        Me.Gbox_Scale.Size = New System.Drawing.Size(208, 20)
        Me.Gbox_Scale.TabIndex = 1
        Me.Gbox_Scale.TabStop = False
        Me.Gbox_Scale.Text = "Scale"
        '
        'TLP_Scale
        '
        Me.TLP_Scale.ColumnCount = 1
        Me.TLP_Scale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Scale.Controls.Add(Me.TLP_Scale1, 0, 0)
        Me.TLP_Scale.Controls.Add(Me.TLP_Scale2, 0, 1)
        Me.TLP_Scale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Scale.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Scale.Name = "TLP_Scale"
        Me.TLP_Scale.RowCount = 2
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.81159!))
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.18841!))
        Me.TLP_Scale.Size = New System.Drawing.Size(202, 1)
        Me.TLP_Scale.TabIndex = 0
        '
        'TLP_Scale1
        '
        Me.TLP_Scale1.ColumnCount = 2
        Me.TLP_Scale1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45228!))
        Me.TLP_Scale1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54772!))
        Me.TLP_Scale1.Controls.Add(Me.TLP_ScaleHeight, 0, 0)
        Me.TLP_Scale1.Controls.Add(Me.TLP_ScaleWidth, 1, 0)
        Me.TLP_Scale1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Scale1.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Scale1.Name = "TLP_Scale1"
        Me.TLP_Scale1.RowCount = 1
        Me.TLP_Scale1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.76471!))
        Me.TLP_Scale1.Size = New System.Drawing.Size(196, 1)
        Me.TLP_Scale1.TabIndex = 0
        '
        'TLP_ScaleHeight
        '
        Me.TLP_ScaleHeight.ColumnCount = 3
        Me.TLP_ScaleHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.88034!))
        Me.TLP_ScaleHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.17094!))
        Me.TLP_ScaleHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.80342!))
        Me.TLP_ScaleHeight.Controls.Add(Me.Label12, 2, 0)
        Me.TLP_ScaleHeight.Controls.Add(Me.lbl_H, 0, 0)
        Me.TLP_ScaleHeight.Controls.Add(Me.num_ScaleHeight, 1, 0)
        Me.TLP_ScaleHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_ScaleHeight.Location = New System.Drawing.Point(3, 3)
        Me.TLP_ScaleHeight.Name = "TLP_ScaleHeight"
        Me.TLP_ScaleHeight.RowCount = 1
        Me.TLP_ScaleHeight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_ScaleHeight.Size = New System.Drawing.Size(94, 1)
        Me.TLP_ScaleHeight.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 1)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "%"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_H
        '
        Me.lbl_H.AutoSize = True
        Me.lbl_H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_H.Location = New System.Drawing.Point(3, 0)
        Me.lbl_H.Name = "lbl_H"
        Me.lbl_H.Size = New System.Drawing.Size(33, 1)
        Me.lbl_H.TabIndex = 0
        Me.lbl_H.Text = "Height:"
        Me.lbl_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_ScaleHeight
        '
        Me.num_ScaleHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleHeight.Location = New System.Drawing.Point(42, 3)
        Me.num_ScaleHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_ScaleHeight.Name = "num_ScaleHeight"
        Me.num_ScaleHeight.Size = New System.Drawing.Size(31, 20)
        Me.num_ScaleHeight.TabIndex = 1
        Me.num_ScaleHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'TLP_ScaleWidth
        '
        Me.TLP_ScaleWidth.ColumnCount = 3
        Me.TLP_ScaleWidth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571!))
        Me.TLP_ScaleWidth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.96429!))
        Me.TLP_ScaleWidth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714!))
        Me.TLP_ScaleWidth.Controls.Add(Me.Label13, 2, 0)
        Me.TLP_ScaleWidth.Controls.Add(Me.lbl_W, 0, 0)
        Me.TLP_ScaleWidth.Controls.Add(Me.num_ScaleWidth, 1, 0)
        Me.TLP_ScaleWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_ScaleWidth.Location = New System.Drawing.Point(103, 3)
        Me.TLP_ScaleWidth.Name = "TLP_ScaleWidth"
        Me.TLP_ScaleWidth.RowCount = 1
        Me.TLP_ScaleWidth.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_ScaleWidth.Size = New System.Drawing.Size(90, 1)
        Me.TLP_ScaleWidth.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(76, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 1)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_W
        '
        Me.lbl_W.AutoSize = True
        Me.lbl_W.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_W.Location = New System.Drawing.Point(3, 0)
        Me.lbl_W.Name = "lbl_W"
        Me.lbl_W.Size = New System.Drawing.Size(29, 1)
        Me.lbl_W.TabIndex = 1
        Me.lbl_W.Text = "Width:"
        Me.lbl_W.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_ScaleWidth
        '
        Me.num_ScaleWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleWidth.Location = New System.Drawing.Point(38, 3)
        Me.num_ScaleWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_ScaleWidth.Name = "num_ScaleWidth"
        Me.num_ScaleWidth.Size = New System.Drawing.Size(32, 20)
        Me.num_ScaleWidth.TabIndex = 2
        Me.num_ScaleWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'TLP_Scale2
        '
        Me.TLP_Scale2.ColumnCount = 1
        Me.TLP_Scale2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Scale2.Controls.Add(Me.chkbox_Scale3, 0, 2)
        Me.TLP_Scale2.Controls.Add(Me.chkbox_Scale2, 0, 1)
        Me.TLP_Scale2.Controls.Add(Me.chkbox_Scale1, 0, 0)
        Me.TLP_Scale2.Controls.Add(Me.TLP_Scale2_1, 0, 3)
        Me.TLP_Scale2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Scale2.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Scale2.Name = "TLP_Scale2"
        Me.TLP_Scale2.RowCount = 4
        Me.TLP_Scale2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Scale2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Scale2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Scale2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP_Scale2.Size = New System.Drawing.Size(196, 1)
        Me.TLP_Scale2.TabIndex = 1
        '
        'chkbox_Scale3
        '
        Me.chkbox_Scale3.AutoSize = True
        Me.chkbox_Scale3.Enabled = False
        Me.chkbox_Scale3.Location = New System.Drawing.Point(3, -15)
        Me.chkbox_Scale3.Name = "chkbox_Scale3"
        Me.chkbox_Scale3.Size = New System.Drawing.Size(142, 1)
        Me.chkbox_Scale3.TabIndex = 2
        Me.chkbox_Scale3.Text = "Best scale for slide show"
        Me.chkbox_Scale3.UseVisualStyleBackColor = True
        '
        'chkbox_Scale2
        '
        Me.chkbox_Scale2.AutoSize = True
        Me.chkbox_Scale2.Enabled = False
        Me.chkbox_Scale2.Location = New System.Drawing.Point(3, -6)
        Me.chkbox_Scale2.Name = "chkbox_Scale2"
        Me.chkbox_Scale2.Size = New System.Drawing.Size(171, 1)
        Me.chkbox_Scale2.TabIndex = 1
        Me.chkbox_Scale2.Text = "Relative to original picture Size"
        Me.chkbox_Scale2.UseVisualStyleBackColor = True
        '
        'chkbox_Scale1
        '
        Me.chkbox_Scale1.AutoSize = True
        Me.chkbox_Scale1.Location = New System.Drawing.Point(3, 3)
        Me.chkbox_Scale1.Name = "chkbox_Scale1"
        Me.chkbox_Scale1.Size = New System.Drawing.Size(108, 1)
        Me.chkbox_Scale1.TabIndex = 0
        Me.chkbox_Scale1.Text = "Lock aspect ratio"
        Me.chkbox_Scale1.UseVisualStyleBackColor = True
        '
        'TLP_Scale2_1
        '
        Me.TLP_Scale2_1.ColumnCount = 2
        Me.TLP_Scale2_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.91489!))
        Me.TLP_Scale2_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.08511!))
        Me.TLP_Scale2_1.Controls.Add(Me.lblResolution, 0, 0)
        Me.TLP_Scale2_1.Controls.Add(Me.cbox_Resolution, 1, 0)
        Me.TLP_Scale2_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Scale2_1.Location = New System.Drawing.Point(3, -24)
        Me.TLP_Scale2_1.Name = "TLP_Scale2_1"
        Me.TLP_Scale2_1.RowCount = 1
        Me.TLP_Scale2_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Scale2_1.Size = New System.Drawing.Size(190, 24)
        Me.TLP_Scale2_1.TabIndex = 3
        '
        'lblResolution
        '
        Me.lblResolution.AutoSize = True
        Me.lblResolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResolution.Location = New System.Drawing.Point(3, 0)
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(54, 24)
        Me.lblResolution.TabIndex = 0
        Me.lblResolution.Text = "Resolution: "
        Me.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbox_Resolution
        '
        Me.cbox_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbox_Resolution.Enabled = False
        Me.cbox_Resolution.FormattingEnabled = True
        Me.cbox_Resolution.Items.AddRange(New Object() {"640 x 480", "720 x 512", "800 x 600", "1024 x 768", "1280 x 1024"})
        Me.cbox_Resolution.Location = New System.Drawing.Point(63, 3)
        Me.cbox_Resolution.Name = "cbox_Resolution"
        Me.cbox_Resolution.Size = New System.Drawing.Size(124, 21)
        Me.cbox_Resolution.TabIndex = 1
        '
        'Gbox_SizeandRotate
        '
        Me.Gbox_SizeandRotate.Controls.Add(Me.TLP_Sizeandrotate)
        Me.Gbox_SizeandRotate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_SizeandRotate.Location = New System.Drawing.Point(3, 3)
        Me.Gbox_SizeandRotate.Name = "Gbox_SizeandRotate"
        Me.Gbox_SizeandRotate.Size = New System.Drawing.Size(208, 8)
        Me.Gbox_SizeandRotate.TabIndex = 0
        Me.Gbox_SizeandRotate.TabStop = False
        Me.Gbox_SizeandRotate.Text = "Size and rotate"
        '
        'TLP_Sizeandrotate
        '
        Me.TLP_Sizeandrotate.ColumnCount = 2
        Me.TLP_Sizeandrotate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82186!))
        Me.TLP_Sizeandrotate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17814!))
        Me.TLP_Sizeandrotate.Controls.Add(Me.TLP_Rotation, 0, 1)
        Me.TLP_Sizeandrotate.Controls.Add(Me.TLP_Width, 1, 0)
        Me.TLP_Sizeandrotate.Controls.Add(Me.TLP_Height, 0, 0)
        Me.TLP_Sizeandrotate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Sizeandrotate.Location = New System.Drawing.Point(3, 16)
        Me.TLP_Sizeandrotate.Name = "TLP_Sizeandrotate"
        Me.TLP_Sizeandrotate.RowCount = 2
        Me.TLP_Sizeandrotate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333!))
        Me.TLP_Sizeandrotate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667!))
        Me.TLP_Sizeandrotate.Size = New System.Drawing.Size(202, 0)
        Me.TLP_Sizeandrotate.TabIndex = 0
        '
        'TLP_Rotation
        '
        Me.TLP_Rotation.ColumnCount = 3
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.16667!))
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90323!))
        Me.TLP_Rotation.Controls.Add(Me.lblRotation, 0, 0)
        Me.TLP_Rotation.Controls.Add(Me.num_Rot, 1, 0)
        Me.TLP_Rotation.Controls.Add(Me.Label11, 2, 0)
        Me.TLP_Rotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Rotation.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Rotation.Name = "TLP_Rotation"
        Me.TLP_Rotation.RowCount = 1
        Me.TLP_Rotation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Rotation.Size = New System.Drawing.Size(98, 1)
        Me.TLP_Rotation.TabIndex = 1
        '
        'lblRotation
        '
        Me.lblRotation.AutoSize = True
        Me.lblRotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRotation.Location = New System.Drawing.Point(3, 0)
        Me.lblRotation.Name = "lblRotation"
        Me.lblRotation.Size = New System.Drawing.Size(37, 1)
        Me.lblRotation.TabIndex = 1
        Me.lblRotation.Text = "Roation:"
        Me.lblRotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Rot
        '
        Me.num_Rot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Rot.Location = New System.Drawing.Point(46, 3)
        Me.num_Rot.Name = "num_Rot"
        Me.num_Rot.Size = New System.Drawing.Size(35, 20)
        Me.num_Rot.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(87, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(8, 1)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "o"
        '
        'TLP_Width
        '
        Me.TLP_Width.ColumnCount = 3
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.54054!))
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.04504!))
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51351!))
        Me.TLP_Width.Controls.Add(Me.lblWidth, 0, 0)
        Me.TLP_Width.Controls.Add(Me.num_Width, 1, 0)
        Me.TLP_Width.Controls.Add(Me.Label10, 2, 0)
        Me.TLP_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Width.Location = New System.Drawing.Point(107, 3)
        Me.TLP_Width.Name = "TLP_Width"
        Me.TLP_Width.RowCount = 1
        Me.TLP_Width.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Width.Size = New System.Drawing.Size(92, 1)
        Me.TLP_Width.TabIndex = 1
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWidth.Location = New System.Drawing.Point(3, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(31, 1)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "Width:"
        Me.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Width
        '
        Me.num_Width.DecimalPlaces = 2
        Me.num_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Width.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_Width.Location = New System.Drawing.Point(40, 3)
        Me.num_Width.Name = "num_Width"
        Me.num_Width.Size = New System.Drawing.Size(35, 20)
        Me.num_Width.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(81, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 1)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = """"
        '
        'TLP_Height
        '
        Me.TLP_Height.ColumnCount = 3
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.83333!))
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333!))
        Me.TLP_Height.Controls.Add(Me.lblHeight, 0, 0)
        Me.TLP_Height.Controls.Add(Me.num_Height, 1, 0)
        Me.TLP_Height.Controls.Add(Me.Label9, 2, 0)
        Me.TLP_Height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Height.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Height.Name = "TLP_Height"
        Me.TLP_Height.RowCount = 1
        Me.TLP_Height.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Height.Size = New System.Drawing.Size(98, 1)
        Me.TLP_Height.TabIndex = 0
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeight.Location = New System.Drawing.Point(3, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(33, 1)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Height:"
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Height
        '
        Me.num_Height.DecimalPlaces = 2
        Me.num_Height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Height.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_Height.Location = New System.Drawing.Point(42, 3)
        Me.num_Height.Name = "num_Height"
        Me.num_Height.Size = New System.Drawing.Size(39, 20)
        Me.num_Height.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(8, 1)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = """"
        '
        'Gbox_OriginalSize
        '
        Me.Gbox_OriginalSize.Controls.Add(Me.TLP_OriginalSize)
        Me.Gbox_OriginalSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_OriginalSize.Location = New System.Drawing.Point(3, 43)
        Me.Gbox_OriginalSize.Name = "Gbox_OriginalSize"
        Me.Gbox_OriginalSize.Size = New System.Drawing.Size(208, 9)
        Me.Gbox_OriginalSize.TabIndex = 2
        Me.Gbox_OriginalSize.TabStop = False
        Me.Gbox_OriginalSize.Text = "Original size"
        '
        'TLP_OriginalSize
        '
        Me.TLP_OriginalSize.ColumnCount = 1
        Me.TLP_OriginalSize.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.Controls.Add(Me.btnReset, 0, 1)
        Me.TLP_OriginalSize.Controls.Add(Me.TLP_OriginalSize1, 0, 0)
        Me.TLP_OriginalSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSize.Location = New System.Drawing.Point(3, 16)
        Me.TLP_OriginalSize.Name = "TLP_OriginalSize"
        Me.TLP_OriginalSize.RowCount = 2
        Me.TLP_OriginalSize.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.Size = New System.Drawing.Size(202, 0)
        Me.TLP_OriginalSize.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(3, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(196, 1)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TLP_OriginalSize1
        '
        Me.TLP_OriginalSize1.ColumnCount = 2
        Me.TLP_OriginalSize1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize1.Controls.Add(Me.TLP_OriginalSize1_2, 1, 0)
        Me.TLP_OriginalSize1.Controls.Add(Me.TLP_OriginalSize1_1, 0, 0)
        Me.TLP_OriginalSize1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSize1.Location = New System.Drawing.Point(3, 3)
        Me.TLP_OriginalSize1.Name = "TLP_OriginalSize1"
        Me.TLP_OriginalSize1.RowCount = 1
        Me.TLP_OriginalSize1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_OriginalSize1.Size = New System.Drawing.Size(196, 1)
        Me.TLP_OriginalSize1.TabIndex = 1
        '
        'TLP_OriginalSize1_2
        '
        Me.TLP_OriginalSize1_2.ColumnCount = 3
        Me.TLP_OriginalSize1_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TLP_OriginalSize1_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826!))
        Me.TLP_OriginalSize1_2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913!))
        Me.TLP_OriginalSize1_2.Controls.Add(Me.lbl_OriginalSizeWidth, 1, 0)
        Me.TLP_OriginalSize1_2.Controls.Add(Me.lbl_Width, 0, 0)
        Me.TLP_OriginalSize1_2.Controls.Add(Me.Label8, 2, 0)
        Me.TLP_OriginalSize1_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSize1_2.Location = New System.Drawing.Point(101, 3)
        Me.TLP_OriginalSize1_2.Name = "TLP_OriginalSize1_2"
        Me.TLP_OriginalSize1_2.RowCount = 1
        Me.TLP_OriginalSize1_2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_OriginalSize1_2.Size = New System.Drawing.Size(92, 1)
        Me.TLP_OriginalSize1_2.TabIndex = 27
        '
        'lbl_OriginalSizeWidth
        '
        Me.lbl_OriginalSizeWidth.AutoSize = True
        Me.lbl_OriginalSizeWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OriginalSizeWidth.Location = New System.Drawing.Point(39, 0)
        Me.lbl_OriginalSizeWidth.Name = "lbl_OriginalSizeWidth"
        Me.lbl_OriginalSizeWidth.Size = New System.Drawing.Size(12, 1)
        Me.lbl_OriginalSizeWidth.TabIndex = 28
        Me.lbl_OriginalSizeWidth.Text = " "
        Me.lbl_OriginalSizeWidth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Width
        '
        Me.lbl_Width.AutoSize = True
        Me.lbl_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Width.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Width.Name = "lbl_Width"
        Me.lbl_Width.Size = New System.Drawing.Size(30, 1)
        Me.lbl_Width.TabIndex = 27
        Me.lbl_Width.Text = "Width: "
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 1)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = """"
        '
        'TLP_OriginalSize1_1
        '
        Me.TLP_OriginalSize1_1.ColumnCount = 3
        Me.TLP_OriginalSize1_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47475!))
        Me.TLP_OriginalSize1_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.37374!))
        Me.TLP_OriginalSize1_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TLP_OriginalSize1_1.Controls.Add(Me.lbl_height, 0, 0)
        Me.TLP_OriginalSize1_1.Controls.Add(Me.lbl_OriginalSizeHeight, 1, 0)
        Me.TLP_OriginalSize1_1.Controls.Add(Me.Label7, 2, 0)
        Me.TLP_OriginalSize1_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSize1_1.Location = New System.Drawing.Point(3, 3)
        Me.TLP_OriginalSize1_1.Name = "TLP_OriginalSize1_1"
        Me.TLP_OriginalSize1_1.RowCount = 1
        Me.TLP_OriginalSize1_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_OriginalSize1_1.Size = New System.Drawing.Size(92, 1)
        Me.TLP_OriginalSize1_1.TabIndex = 26
        '
        'lbl_height
        '
        Me.lbl_height.AutoSize = True
        Me.lbl_height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_height.Location = New System.Drawing.Point(3, 0)
        Me.lbl_height.Name = "lbl_height"
        Me.lbl_height.Size = New System.Drawing.Size(37, 1)
        Me.lbl_height.TabIndex = 26
        Me.lbl_height.Text = "Height: "
        '
        'lbl_OriginalSizeHeight
        '
        Me.lbl_OriginalSizeHeight.AutoSize = True
        Me.lbl_OriginalSizeHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OriginalSizeHeight.Location = New System.Drawing.Point(46, 0)
        Me.lbl_OriginalSizeHeight.Name = "lbl_OriginalSizeHeight"
        Me.lbl_OriginalSizeHeight.Size = New System.Drawing.Size(12, 1)
        Me.lbl_OriginalSizeHeight.TabIndex = 27
        Me.lbl_OriginalSizeHeight.Text = " "
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 1)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = """"
        '
        'TLP_Alignment
        '
        Me.TLP_Alignment.BackColor = System.Drawing.Color.Transparent
        Me.TLP_Alignment.ColumnCount = 11
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.Controls.Add(Me.btn_DistRows, 8, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BringForward, 0, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistColumns, 7, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_SendtoBack, 1, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignCenter, 0, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderTop, 2, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderBottom, 3, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_Borderleft, 4, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderRight, 5, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderAll, 6, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_PasteText, 10, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_Paragraph, 9, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_FormatShape, 8, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignBottom, 7, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignRight, 6, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignTop, 5, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignLeft, 4, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistVer, 3, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistHor, 2, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignMiddle, 1, 1)
        Me.TLP_Alignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Alignment.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Alignment.MaximumSize = New System.Drawing.Size(500, 45)
        Me.TLP_Alignment.MinimumSize = New System.Drawing.Size(0, 45)
        Me.TLP_Alignment.Name = "TLP_Alignment"
        Me.TLP_Alignment.RowCount = 2
        Me.TLP_Alignment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Alignment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Alignment.Size = New System.Drawing.Size(305, 45)
        Me.TLP_Alignment.TabIndex = 0
        '
        'btn_DistRows
        '
        Me.btn_DistRows.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._182
        Me.btn_DistRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistRows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_DistRows.FlatAppearance.BorderSize = 0
        Me.btn_DistRows.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistRows.Location = New System.Drawing.Point(216, 0)
        Me.btn_DistRows.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistRows.Name = "btn_DistRows"
        Me.btn_DistRows.Size = New System.Drawing.Size(27, 22)
        Me.btn_DistRows.TabIndex = 9
        Me.btn_DistRows.Text = " "
        Me.btn_DistRows.UseVisualStyleBackColor = True
        '
        'btn_BringForward
        '
        Me.btn_BringForward.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._101
        Me.btn_BringForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BringForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BringForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_BringForward.FlatAppearance.BorderSize = 0
        Me.btn_BringForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BringForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BringForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BringForward.Location = New System.Drawing.Point(0, 0)
        Me.btn_BringForward.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BringForward.Name = "btn_BringForward"
        Me.btn_BringForward.Size = New System.Drawing.Size(27, 22)
        Me.btn_BringForward.TabIndex = 9
        Me.btn_BringForward.Text = " "
        Me.btn_BringForward.UseVisualStyleBackColor = True
        '
        'btn_DistColumns
        '
        Me.btn_DistColumns.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._17
        Me.btn_DistColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistColumns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_DistColumns.FlatAppearance.BorderSize = 0
        Me.btn_DistColumns.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistColumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistColumns.Location = New System.Drawing.Point(189, 0)
        Me.btn_DistColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistColumns.Name = "btn_DistColumns"
        Me.btn_DistColumns.Size = New System.Drawing.Size(27, 22)
        Me.btn_DistColumns.TabIndex = 9
        Me.btn_DistColumns.Text = " "
        Me.btn_DistColumns.UseVisualStyleBackColor = True
        '
        'btn_SendtoBack
        '
        Me.btn_SendtoBack.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._11_
        Me.btn_SendtoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_SendtoBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SendtoBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_SendtoBack.FlatAppearance.BorderSize = 0
        Me.btn_SendtoBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_SendtoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_SendtoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SendtoBack.Location = New System.Drawing.Point(27, 0)
        Me.btn_SendtoBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_SendtoBack.Name = "btn_SendtoBack"
        Me.btn_SendtoBack.Size = New System.Drawing.Size(27, 22)
        Me.btn_SendtoBack.TabIndex = 8
        Me.btn_SendtoBack.Text = " "
        Me.btn_SendtoBack.UseVisualStyleBackColor = True
        '
        'btn_AlignCenter
        '
        Me.btn_AlignCenter.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._2_
        Me.btn_AlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignCenter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignCenter.FlatAppearance.BorderSize = 0
        Me.btn_AlignCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignCenter.Location = New System.Drawing.Point(0, 22)
        Me.btn_AlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignCenter.Name = "btn_AlignCenter"
        Me.btn_AlignCenter.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignCenter.TabIndex = 4
        Me.btn_AlignCenter.Text = " "
        Me.btn_AlignCenter.UseVisualStyleBackColor = True
        '
        'btn_BorderTop
        '
        Me.btn_BorderTop.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._14
        Me.btn_BorderTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_BorderTop.FlatAppearance.BorderSize = 0
        Me.btn_BorderTop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderTop.Location = New System.Drawing.Point(54, 0)
        Me.btn_BorderTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderTop.Name = "btn_BorderTop"
        Me.btn_BorderTop.Size = New System.Drawing.Size(27, 22)
        Me.btn_BorderTop.TabIndex = 9
        Me.btn_BorderTop.Text = " "
        Me.btn_BorderTop.UseVisualStyleBackColor = True
        '
        'btn_BorderBottom
        '
        Me.btn_BorderBottom.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._121
        Me.btn_BorderBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderBottom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_BorderBottom.FlatAppearance.BorderSize = 0
        Me.btn_BorderBottom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderBottom.Location = New System.Drawing.Point(81, 0)
        Me.btn_BorderBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderBottom.Name = "btn_BorderBottom"
        Me.btn_BorderBottom.Size = New System.Drawing.Size(27, 22)
        Me.btn_BorderBottom.TabIndex = 9
        Me.btn_BorderBottom.Text = " "
        Me.btn_BorderBottom.UseVisualStyleBackColor = True
        '
        'btn_Borderleft
        '
        Me.btn_Borderleft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._15
        Me.btn_Borderleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Borderleft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Borderleft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Borderleft.FlatAppearance.BorderSize = 0
        Me.btn_Borderleft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Borderleft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Borderleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Borderleft.Location = New System.Drawing.Point(108, 0)
        Me.btn_Borderleft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Borderleft.Name = "btn_Borderleft"
        Me.btn_Borderleft.Size = New System.Drawing.Size(27, 22)
        Me.btn_Borderleft.TabIndex = 9
        Me.btn_Borderleft.Text = " "
        Me.btn_Borderleft.UseVisualStyleBackColor = True
        '
        'btn_BorderRight
        '
        Me.btn_BorderRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._16
        Me.btn_BorderRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_BorderRight.FlatAppearance.BorderSize = 0
        Me.btn_BorderRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderRight.Location = New System.Drawing.Point(135, 0)
        Me.btn_BorderRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderRight.Name = "btn_BorderRight"
        Me.btn_BorderRight.Size = New System.Drawing.Size(27, 22)
        Me.btn_BorderRight.TabIndex = 9
        Me.btn_BorderRight.Text = " "
        Me.btn_BorderRight.UseVisualStyleBackColor = True
        '
        'btn_BorderAll
        '
        Me.btn_BorderAll.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._13
        Me.btn_BorderAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_BorderAll.FlatAppearance.BorderSize = 0
        Me.btn_BorderAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderAll.Location = New System.Drawing.Point(162, 0)
        Me.btn_BorderAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderAll.Name = "btn_BorderAll"
        Me.btn_BorderAll.Size = New System.Drawing.Size(27, 22)
        Me.btn_BorderAll.TabIndex = 9
        Me.btn_BorderAll.Text = " "
        Me.btn_BorderAll.UseVisualStyleBackColor = True
        '
        'btn_PasteText
        '
        Me.btn_PasteText.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._20
        Me.btn_PasteText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_PasteText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PasteText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_PasteText.FlatAppearance.BorderSize = 0
        Me.btn_PasteText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_PasteText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_PasteText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PasteText.Location = New System.Drawing.Point(270, 22)
        Me.btn_PasteText.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_PasteText.Name = "btn_PasteText"
        Me.btn_PasteText.Size = New System.Drawing.Size(35, 23)
        Me.btn_PasteText.TabIndex = 9
        Me.btn_PasteText.Text = " "
        Me.btn_PasteText.UseVisualStyleBackColor = True
        '
        'btn_Paragraph
        '
        Me.btn_Paragraph.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._211
        Me.btn_Paragraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Paragraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Paragraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Paragraph.FlatAppearance.BorderSize = 0
        Me.btn_Paragraph.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Paragraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Paragraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Paragraph.Location = New System.Drawing.Point(243, 22)
        Me.btn_Paragraph.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Paragraph.Name = "btn_Paragraph"
        Me.btn_Paragraph.Size = New System.Drawing.Size(27, 23)
        Me.btn_Paragraph.TabIndex = 9
        Me.btn_Paragraph.Text = " "
        Me.btn_Paragraph.UseVisualStyleBackColor = True
        '
        'btn_FormatShape
        '
        Me.btn_FormatShape.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._32
        Me.btn_FormatShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_FormatShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_FormatShape.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_FormatShape.FlatAppearance.BorderSize = 0
        Me.btn_FormatShape.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_FormatShape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_FormatShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FormatShape.Location = New System.Drawing.Point(216, 22)
        Me.btn_FormatShape.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_FormatShape.Name = "btn_FormatShape"
        Me.btn_FormatShape.Size = New System.Drawing.Size(27, 23)
        Me.btn_FormatShape.TabIndex = 9
        Me.btn_FormatShape.Text = " "
        Me.btn_FormatShape.UseVisualStyleBackColor = True
        '
        'btn_AlignBottom
        '
        Me.btn_AlignBottom.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._9
        Me.btn_AlignBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignBottom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignBottom.FlatAppearance.BorderSize = 0
        Me.btn_AlignBottom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignBottom.ImageIndex = 0
        Me.btn_AlignBottom.Location = New System.Drawing.Point(189, 22)
        Me.btn_AlignBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignBottom.Name = "btn_AlignBottom"
        Me.btn_AlignBottom.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignBottom.TabIndex = 3
        Me.btn_AlignBottom.Text = " "
        Me.btn_AlignBottom.UseVisualStyleBackColor = True
        '
        'btn_AlignRight
        '
        Me.btn_AlignRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._3
        Me.btn_AlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignRight.FlatAppearance.BorderSize = 0
        Me.btn_AlignRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignRight.Location = New System.Drawing.Point(162, 22)
        Me.btn_AlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignRight.Name = "btn_AlignRight"
        Me.btn_AlignRight.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignRight.TabIndex = 2
        Me.btn_AlignRight.Text = " "
        Me.btn_AlignRight.UseVisualStyleBackColor = True
        '
        'btn_AlignTop
        '
        Me.btn_AlignTop.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._4
        Me.btn_AlignTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignTop.FlatAppearance.BorderSize = 0
        Me.btn_AlignTop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignTop.Location = New System.Drawing.Point(135, 22)
        Me.btn_AlignTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignTop.Name = "btn_AlignTop"
        Me.btn_AlignTop.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignTop.TabIndex = 1
        Me.btn_AlignTop.UseVisualStyleBackColor = True
        '
        'btn_AlignLeft
        '
        Me.btn_AlignLeft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._5
        Me.btn_AlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignLeft.FlatAppearance.BorderSize = 0
        Me.btn_AlignLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignLeft.ImageIndex = 3
        Me.btn_AlignLeft.Location = New System.Drawing.Point(108, 22)
        Me.btn_AlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignLeft.Name = "btn_AlignLeft"
        Me.btn_AlignLeft.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignLeft.TabIndex = 0
        Me.btn_AlignLeft.UseVisualStyleBackColor = True
        '
        'btn_DistVer
        '
        Me.btn_DistVer.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._8
        Me.btn_DistVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_DistVer.FlatAppearance.BorderSize = 0
        Me.btn_DistVer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistVer.Location = New System.Drawing.Point(81, 22)
        Me.btn_DistVer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistVer.Name = "btn_DistVer"
        Me.btn_DistVer.Size = New System.Drawing.Size(27, 23)
        Me.btn_DistVer.TabIndex = 7
        Me.btn_DistVer.Text = " "
        Me.btn_DistVer.UseVisualStyleBackColor = True
        '
        'btn_DistHor
        '
        Me.btn_DistHor.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._7
        Me.btn_DistHor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistHor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistHor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_DistHor.FlatAppearance.BorderSize = 0
        Me.btn_DistHor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistHor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistHor.Location = New System.Drawing.Point(54, 22)
        Me.btn_DistHor.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistHor.Name = "btn_DistHor"
        Me.btn_DistHor.Size = New System.Drawing.Size(27, 23)
        Me.btn_DistHor.TabIndex = 6
        Me.btn_DistHor.Text = " "
        Me.btn_DistHor.UseVisualStyleBackColor = True
        '
        'btn_AlignMiddle
        '
        Me.btn_AlignMiddle.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._6
        Me.btn_AlignMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignMiddle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_AlignMiddle.FlatAppearance.BorderSize = 0
        Me.btn_AlignMiddle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignMiddle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignMiddle.Location = New System.Drawing.Point(27, 22)
        Me.btn_AlignMiddle.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignMiddle.Name = "btn_AlignMiddle"
        Me.btn_AlignMiddle.Size = New System.Drawing.Size(27, 23)
        Me.btn_AlignMiddle.TabIndex = 5
        Me.btn_AlignMiddle.Text = " "
        Me.btn_AlignMiddle.UseVisualStyleBackColor = True
        '
        'SCont_A
        '
        Me.SCont_A.BackColor = System.Drawing.SystemColors.Control
        Me.SCont_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCont_A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCont_A.Location = New System.Drawing.Point(0, 0)
        Me.SCont_A.Name = "SCont_A"
        Me.SCont_A.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SCont_A.Panel1
        '
        Me.SCont_A.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SCont_A.Panel2
        '
        Me.SCont_A.Panel2.Controls.Add(Me.Scont_B)
        Me.SCont_A.Size = New System.Drawing.Size(313, 493)
        Me.SCont_A.SplitterDistance = 79
        Me.SCont_A.TabIndex = 27
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TLP_Alignment, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChoosePanel, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(311, 77)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Scont_B
        '
        Me.Scont_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scont_B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_B.Location = New System.Drawing.Point(0, 0)
        Me.Scont_B.Name = "Scont_B"
        Me.Scont_B.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_B.Panel1
        '
        Me.Scont_B.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Scont_B.Panel1.Controls.Add(Me.TLP_Upper)
        '
        'Scont_B.Panel2
        '
        Me.Scont_B.Panel2.Controls.Add(Me.BottomPanel)
        Me.Scont_B.Size = New System.Drawing.Size(313, 410)
        Me.Scont_B.SplitterDistance = 164
        Me.Scont_B.TabIndex = 0
        '
        'TLP_Upper
        '
        Me.TLP_Upper.BackColor = System.Drawing.Color.White
        Me.TLP_Upper.ColumnCount = 2
        Me.TLP_Upper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Upper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TLP_Upper.Controls.Add(Me.Scroll_General, 1, 0)
        Me.TLP_Upper.Controls.Add(Me.TopPanel, 0, 0)
        Me.TLP_Upper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Upper.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Upper.Name = "TLP_Upper"
        Me.TLP_Upper.RowCount = 1
        Me.TLP_Upper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Upper.Size = New System.Drawing.Size(311, 162)
        Me.TLP_Upper.TabIndex = 28
        '
        'BottomPanel
        '
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.NotesTableLayout)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(311, 240)
        Me.BottomPanel.TabIndex = 25
        '
        'NotesTableLayout
        '
        Me.NotesTableLayout.ColumnCount = 1
        Me.NotesTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NotesTableLayout.Controls.Add(Me.txtNotes, 0, 1)
        Me.NotesTableLayout.Controls.Add(Me.Part1_notes, 0, 0)
        Me.NotesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotesTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.NotesTableLayout.Name = "NotesTableLayout"
        Me.NotesTableLayout.RowCount = 2
        Me.NotesTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.NotesTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NotesTableLayout.Size = New System.Drawing.Size(309, 238)
        Me.NotesTableLayout.TabIndex = 24
        '
        'txtNotes
        '
        Me.txtNotes.AutoWordSelection = True
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(3, 80)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(303, 155)
        Me.txtNotes.TabIndex = 1
        Me.txtNotes.Text = ""
        Me.txtNotes.WordWrap = False
        '
        'Part1_notes
        '
        Me.Part1_notes.Controls.Add(Me.TableLayoutPanel1)
        Me.Part1_notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Part1_notes.Location = New System.Drawing.Point(3, 3)
        Me.Part1_notes.Name = "Part1_notes"
        Me.Part1_notes.Size = New System.Drawing.Size(303, 71)
        Me.Part1_notes.TabIndex = 16
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.37396!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 71)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.57576!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(297, 65)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.91045!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16418!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55224!))
        Me.TableLayoutPanel8.Controls.Add(Me.cboxFontFamily, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cboxFontSize, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(291, 31)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'cboxFontFamily
        '
        Me.cboxFontFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontFamily.FormattingEnabled = True
        Me.cboxFontFamily.Items.AddRange(New Object() {"Agency FB", "Agency FB Bold", "Algerian", "Arial Narrow", "Arial Narrow Bold", "Arial Narrow Bold Italic", "Arial Narrow Italic", "Arial Rounded MT Bold", "Arial Unicode MS", "Baskerville Old Face", "Bauhaus 93", "Bell MT", "Bell MT Bold", "Bell MT Italic", "Berlin Sans FB", "Berlin Sans FB Bold", "Berlin Sans FB Demi Bold", "Bernard MT Condensed", "Blackadder ITC", "Bodoni MT", "Bodoni MT Black", "Bodoni MT Black Italic", "Bodoni MT Bold", "Bodoni MT Bold Italic", "Bodoni MT Condensed", "Bodoni MT Condensed Bold", "Bodoni MT Condensed Bold Italic", "Bodoni MT Condensed Italic", "Bodoni MT Italic", "Bodoni MT Poster Compressed", "Book Antiqua", "Book Antiqua Bold", "Book Antiqua Bold Italic", "Book Antiqua Italic", "Bookman Old Style", "Bookman Old Style Bold", "Bookman Old Style Bold Italic", "Bookman Old Style Italic", "Bradley Hand ITC", "Britannic Bold", "Broadway", "Brush Script MT Italic", "Calibri", "Calibri Bold", "Calibri Bold Italic", "Calibri Italic", "Californian FB", "Californian FB Bold", "Californian FB Italic", "Calisto MT", "Calisto MT Bold", "Calisto MT Bold Italic", "Calisto MT Italic", "Cambria & Cambria Math", "Cambria Bold", "Candara", "Candara Bold", "Candara Italic", "Candara Bold Italic", "Centaur", "Century", "Century Gothic", "Century Gothic Bold", "Century Gothic Italic", "Century Schoolbook", "Century Schoolbook Bold", "Century Schoolbook Bold Italic", "Century Schoolbook Italic", "Chiller", "Colonna MT", "Consolas", "Consolas Bold", "Consolas Bold Italic", "Consolas Italic", "Constantia", "Constantia Bold", "Constantia Bold Italic", "Constantia Italic", "Cooper Black", "Copperplate Gothic Bold", "Copperplate Gothic Light", "Corbel", "Corbel Bold", "Corbel Bold Italic", "Corbel Italic", "Curlz MT", "Edwardian Script ITC", "Elephant", "Elephant Italic", "Engraveras", "Eras Bold ITC", "Eras Demi ITC", "Eras Light ITC", "Eras Medium ITC", "Felix Titling", "Footlight MT Light", "Forte", "Franklin", "Gothic Book", "Franklin Gothic Book Italic", "Franklin Gothic Demi", "Franklin Gothic Demi Cond", "Franklin Gothic Demi Italic", "Franklin Gothic Heavy", "Franklin Gothic Heavy Italic", "Franklin Gothic Medium Cond", "Freestyle Script", "French Script MT", "Garamond", "Garamond Bold", "Garamond Italic", "Gigi", "Gill Sans MT", "Gill Sans MT Bold", "Gill Sans MT Bold Italic", "Gill Sans MT Condensed", "Gill Sans MT Ext Condensed Bold", "Gill Sans MT Italic", "Gill Sans Ultra Bold", "Gill Sans Ultra Bold Condensed", "Gloucester MT Extra Condensed", "Goudy Old Style", "Goudy Old Style Bold", "Goudy Old Style Italic", "Goudy Stout", "Haettenschweiler", "Harlow Solid Italic", "Harrington", "High Tower Text", "High Tower Text Italic", "Imprint MT Shadow", "Informal Roman", "Jokerman", "Juice ITC", "Kristen ITC", "Kunstler Script", "Lucida Bright", "Lucida Bright Demibold", "Lucida Bright Demibold Italic", "Lucida Bright Italic", "Lucida Calligraphy Italic", "Lucida Fax Demibold", "Lucida Fax Demibold Italic", "Lucida Fax Italic", "Lucida Fax Regular", "Lucida Handwriting Italic", "Lucida Sans Demibold Italic", "Lucida Sans Demibold Roman", "Lucida Sans Italic", "Lucida Sans Regular", "Lucida Sans Typewriter Bold", "Lucida Sans Typewriter Bold Oblique", "Lucida Sans Typewriter Oblique", "Lucida Sans Typewriter Regular", "Magneto Bold", "Maiandra GD", "Matura MT Script Capitals", "Mistral", "Modern No. 20", "Monotype Corsiva", "MS Mincho", "MS Outlook", "MS Reference Sans Serif", "MS Reference Specialty", "MT Extra", "Niagara Engraved", "Niagara Solid", "OCR A Extended", "Old English Text MT", "Onyx", "Palace Script MT", "Palatino Linotype", "Palatino Linotype Bold", "Palatino Linotype Bold Italic", "Palatino Linotype Italic", "Papyrus", "Parchment", "Perpetua", "Perpetua Bold", "Perpetua Bold Italic", "Perpetua Italic", "Perpetua Titling MT Bold", "Perpetua Titling MT Light", "Playbill", "Poor Richard", "Pristina", "Rage Italic", "Ravie Rockwell", "Rockwell Bold", "Rockwell Bold Italic", "Rockwell Condensed", "Rockwell Condensed Bold", "Rockwell Extra Bold", "Rockwell Italic", "Script MT Bold", "Segoe UI*", "Segoe UI Bold*", "Segoe UI Bold Italic*", "Segoe UI Italic*", "Showcard Gothic", "Snap ITC", "Stencil", "Tempus Sans ITC", "Tw Cen MT", "Tw Cen MT Bold", "Tw Cen MT Bold Italic", "Tw Cen MT Condensed", "Tw Cen MT Condensed Bold", "Tw Cen MT Condensed Extra Bold", "Tw Cen MT Italic", "Viner Hand ITC", "Vivaldi Italic", "Vladimir Script", "Wide Latin", "Wingdings 2", "Wingdings 3"})
        Me.cboxFontFamily.Location = New System.Drawing.Point(3, 3)
        Me.cboxFontFamily.Name = "cboxFontFamily"
        Me.cboxFontFamily.Size = New System.Drawing.Size(119, 23)
        Me.cboxFontFamily.TabIndex = 15
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Items.AddRange(New Object() {"8", "8.25", "9", "10", "10.5", "11", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "44", "48", "54", "60", "66", "72", "80", "88", "96", "", ""})
        Me.cboxFontSize.Location = New System.Drawing.Point(128, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(44, 23)
        Me.cboxFontSize.TabIndex = 14
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Bullet, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Reset, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_IndentDec, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_IndentInc, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(178, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(110, 25)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'btn_Bullet
        '
        Me.btn_Bullet.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_Bullet.AutoSize = True
        Me.btn_Bullet.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._291
        Me.btn_Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Bullet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Bullet.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_Bullet.FlatAppearance.BorderSize = 0
        Me.btn_Bullet.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bullet.Location = New System.Drawing.Point(28, 1)
        Me.btn_Bullet.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Bullet.Name = "btn_Bullet"
        Me.btn_Bullet.Size = New System.Drawing.Size(25, 23)
        Me.btn_Bullet.TabIndex = 28
        Me.btn_Bullet.Text = " "
        Me.btn_Bullet.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._33
        Me.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Reset.FlatAppearance.BorderSize = 0
        Me.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset.Location = New System.Drawing.Point(4, 4)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(19, 17)
        Me.btn_Reset.TabIndex = 29
        Me.btn_Reset.Text = " "
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_IndentDec
        '
        Me.btn_IndentDec.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._35
        Me.btn_IndentDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentDec.Enabled = False
        Me.btn_IndentDec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_IndentDec.FlatAppearance.BorderSize = 0
        Me.btn_IndentDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentDec.Location = New System.Drawing.Point(55, 1)
        Me.btn_IndentDec.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_IndentDec.Name = "btn_IndentDec"
        Me.btn_IndentDec.Size = New System.Drawing.Size(25, 23)
        Me.btn_IndentDec.TabIndex = 29
        Me.btn_IndentDec.Text = " "
        Me.btn_IndentDec.UseVisualStyleBackColor = True
        '
        'btn_IndentInc
        '
        Me.btn_IndentInc.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._34
        Me.btn_IndentInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentInc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentInc.Enabled = False
        Me.btn_IndentInc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_IndentInc.FlatAppearance.BorderSize = 0
        Me.btn_IndentInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentInc.Location = New System.Drawing.Point(82, 1)
        Me.btn_IndentInc.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_IndentInc.Name = "btn_IndentInc"
        Me.btn_IndentInc.Size = New System.Drawing.Size(27, 23)
        Me.btn_IndentInc.TabIndex = 29
        Me.btn_IndentInc.Text = " "
        Me.btn_IndentInc.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 9
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnBold, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnPaste, 8, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnitalic, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnCopy, 7, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnCut, 6, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnunderline, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAlignLeft, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAlignRight, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAlignCenter, 4, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 40)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(291, 22)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'btnBold
        '
        Me.btnBold.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnBold.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._23_g
        Me.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBold.FlatAppearance.BorderSize = 0
        Me.btnBold.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBold.ImageKey = "Italic.jpg"
        Me.btnBold.Location = New System.Drawing.Point(0, 0)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(32, 22)
        Me.btnBold.TabIndex = 19
        Me.btnBold.Text = " "
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._201
        Me.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.ImageIndex = 6
        Me.btnPaste.Location = New System.Drawing.Point(256, 0)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(35, 22)
        Me.btnPaste.TabIndex = 17
        Me.btnPaste.Text = " "
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnitalic
        '
        Me.btnitalic.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnitalic.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._24_g
        Me.btnitalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnitalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnitalic.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnitalic.FlatAppearance.BorderSize = 0
        Me.btnitalic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnitalic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnitalic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnitalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitalic.ImageKey = "Italic.jpg"
        Me.btnitalic.Location = New System.Drawing.Point(32, 0)
        Me.btnitalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnitalic.Name = "btnitalic"
        Me.btnitalic.Size = New System.Drawing.Size(32, 22)
        Me.btnitalic.TabIndex = 3
        Me.btnitalic.Text = " "
        Me.btnitalic.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._31__
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.Location = New System.Drawing.Point(224, 0)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(32, 22)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = " "
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._28
        Me.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.ImageIndex = 1
        Me.btnCut.Location = New System.Drawing.Point(192, 0)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(32, 22)
        Me.btnCut.TabIndex = 18
        Me.btnCut.Text = " "
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnunderline
        '
        Me.btnunderline.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnunderline.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._22_g
        Me.btnunderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnunderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnunderline.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnunderline.FlatAppearance.BorderSize = 0
        Me.btnunderline.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnunderline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnunderline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnunderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunderline.ImageKey = "Underline.jpg"
        Me.btnunderline.Location = New System.Drawing.Point(64, 0)
        Me.btnunderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnunderline.Name = "btnunderline"
        Me.btnunderline.Size = New System.Drawing.Size(32, 22)
        Me.btnunderline.TabIndex = 2
        Me.btnunderline.Text = " "
        Me.btnunderline.UseVisualStyleBackColor = True
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._26
        Me.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.BorderSize = 0
        Me.btnAlignLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignLeft.Location = New System.Drawing.Point(96, 0)
        Me.btnAlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(32, 22)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.Text = " "
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._27
        Me.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.BorderSize = 0
        Me.btnAlignRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAlignRight.ImageIndex = 9
        Me.btnAlignRight.Location = New System.Drawing.Point(160, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(32, 22)
        Me.btnAlignRight.TabIndex = 5
        Me.btnAlignRight.Text = " "
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._25
        Me.btnAlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.BorderSize = 0
        Me.btnAlignCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignCenter.Location = New System.Drawing.Point(128, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(32, 22)
        Me.btnAlignCenter.TabIndex = 4
        Me.btnAlignCenter.Text = " "
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'EventsTimer
        '
        Me.EventsTimer.Enabled = True
        '
        'rightpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SCont_A)
        Me.Name = "rightpanel"
        Me.Size = New System.Drawing.Size(313, 493)
        Me.AutoFit.ResumeLayout(False)
        Me.ContentAutofit.ResumeLayout(False)
        Me.ContentAutofit.PerformLayout()
        Me.InternalMargin.ResumeLayout(False)
        Me.contentInternalMargin.ResumeLayout(False)
        Me.paneltopmargin.ResumeLayout(False)
        CType(Me.txttopmargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelleftmargin.ResumeLayout(False)
        CType(Me.txtleftmargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrightmargin.ResumeLayout(False)
        CType(Me.txtrightmargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelbottommargin.ResumeLayout(False)
        CType(Me.txtbottommargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextLayout.ResumeLayout(False)
        Me.contenttextlayout.ResumeLayout(False)
        Me.TextBoxPage.ResumeLayout(False)
        Me.TextBoxPage.PerformLayout()
        Me.ChoosePanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.SizePage.ResumeLayout(False)
        Me.Gbox_Scale.ResumeLayout(False)
        Me.TLP_Scale.ResumeLayout(False)
        Me.TLP_Scale1.ResumeLayout(False)
        Me.TLP_ScaleHeight.ResumeLayout(False)
        Me.TLP_ScaleHeight.PerformLayout()
        CType(Me.num_ScaleHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_ScaleWidth.ResumeLayout(False)
        Me.TLP_ScaleWidth.PerformLayout()
        CType(Me.num_ScaleWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Scale2.ResumeLayout(False)
        Me.TLP_Scale2.PerformLayout()
        Me.TLP_Scale2_1.ResumeLayout(False)
        Me.TLP_Scale2_1.PerformLayout()
        Me.Gbox_SizeandRotate.ResumeLayout(False)
        Me.TLP_Sizeandrotate.ResumeLayout(False)
        Me.TLP_Rotation.ResumeLayout(False)
        Me.TLP_Rotation.PerformLayout()
        CType(Me.num_Rot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Width.ResumeLayout(False)
        Me.TLP_Width.PerformLayout()
        CType(Me.num_Width, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Height.ResumeLayout(False)
        Me.TLP_Height.PerformLayout()
        CType(Me.num_Height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbox_OriginalSize.ResumeLayout(False)
        Me.TLP_OriginalSize.ResumeLayout(False)
        Me.TLP_OriginalSize1.ResumeLayout(False)
        Me.TLP_OriginalSize1_2.ResumeLayout(False)
        Me.TLP_OriginalSize1_2.PerformLayout()
        Me.TLP_OriginalSize1_1.ResumeLayout(False)
        Me.TLP_OriginalSize1_1.PerformLayout()
        Me.TLP_Alignment.ResumeLayout(False)
        Me.SCont_A.Panel1.ResumeLayout(False)
        Me.SCont_A.Panel2.ResumeLayout(False)
        CType(Me.SCont_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCont_A.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Scont_B.Panel1.ResumeLayout(False)
        Me.Scont_B.Panel2.ResumeLayout(False)
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_B.ResumeLayout(False)
        Me.TLP_Upper.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.NotesTableLayout.ResumeLayout(False)
        Me.Part1_notes.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fixedtimer As System.Windows.Forms.Timer
    Friend WithEvents cboxFormatShape As System.Windows.Forms.ComboBox
    Friend WithEvents TextLayout As System.Windows.Forms.GroupBox
    Friend WithEvents contenttextlayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboxtextdirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboxtextalignment As System.Windows.Forms.ComboBox
    Friend WithEvents AutoFit As System.Windows.Forms.GroupBox
    Friend WithEvents ContentAutofit As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Donnotautofit As System.Windows.Forms.RadioButton
    Friend WithEvents Shrinktext As System.Windows.Forms.RadioButton
    Friend WithEvents ResizeShape As System.Windows.Forms.RadioButton
    Friend WithEvents InternalMargin As System.Windows.Forms.GroupBox
    Friend WithEvents contentInternalMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelleftmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents paneltopmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelrightmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelbottommargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkboxWrap As System.Windows.Forms.CheckBox
    Friend WithEvents Scroll_General As System.Windows.Forms.VScrollBar
    Friend WithEvents TextBoxPage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtleftmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtbottommargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txttopmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtrightmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChoosePanel As System.Windows.Forms.Panel
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents TLP_Alignment As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_AlignLeft As System.Windows.Forms.Button
    Friend WithEvents btn_AlignBottom As System.Windows.Forms.Button
    Friend WithEvents btn_AlignRight As System.Windows.Forms.Button
    Friend WithEvents btn_AlignTop As System.Windows.Forms.Button
    Friend WithEvents btn_AlignCenter As System.Windows.Forms.Button
    Friend WithEvents btn_AlignMiddle As System.Windows.Forms.Button
    Friend WithEvents btn_DistVer As System.Windows.Forms.Button
    Friend WithEvents btn_DistHor As System.Windows.Forms.Button
    Friend WithEvents SCont_A As System.Windows.Forms.SplitContainer
    Friend WithEvents Scont_B As System.Windows.Forms.SplitContainer
    Friend WithEvents BottomPanel As System.Windows.Forms.Panel
    Friend WithEvents NotesTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents TLP_Upper As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_SendtoBack As System.Windows.Forms.Button
    Friend WithEvents btn_BringForward As System.Windows.Forms.Button
    Friend WithEvents btn_Borderleft As System.Windows.Forms.Button
    Friend WithEvents btn_BorderRight As System.Windows.Forms.Button
    Friend WithEvents btn_BorderTop As System.Windows.Forms.Button
    Friend WithEvents btn_BorderBottom As System.Windows.Forms.Button
    Friend WithEvents btn_BorderAll As System.Windows.Forms.Button
    Friend WithEvents btn_DistColumns As System.Windows.Forms.Button
    Friend WithEvents btn_DistRows As System.Windows.Forms.Button
    Friend WithEvents btn_FormatShape As System.Windows.Forms.Button
    Friend WithEvents btn_Paragraph As System.Windows.Forms.Button
    Friend WithEvents btn_PasteText As System.Windows.Forms.Button
    Friend WithEvents Part1_notes As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents btnAlignLeft As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnAlignCenter As System.Windows.Forms.Button
    Friend WithEvents btnAlignRight As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnitalic As System.Windows.Forms.CheckBox
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnunderline As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboxFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents cboxFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Bullet As System.Windows.Forms.CheckBox
    Friend WithEvents btnBold As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Reset As System.Windows.Forms.Button
    Friend WithEvents SizePage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Gbox_Scale As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_Scale As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_Scale1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_ScaleHeight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_H As System.Windows.Forms.Label
    Friend WithEvents num_ScaleHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_ScaleWidth As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_W As System.Windows.Forms.Label
    Friend WithEvents num_ScaleWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_Scale2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkbox_Scale3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_Scale2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_Scale1 As System.Windows.Forms.CheckBox
    Friend WithEvents TLP_Scale2_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblResolution As System.Windows.Forms.Label
    Friend WithEvents cbox_Resolution As System.Windows.Forms.ComboBox
    Friend WithEvents Gbox_SizeandRotate As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_Sizeandrotate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_Rotation As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRotation As System.Windows.Forms.Label
    Friend WithEvents num_Rot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TLP_Width As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents num_Width As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TLP_Height As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents num_Height As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Gbox_OriginalSize As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_OriginalSize As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents TLP_OriginalSize1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_OriginalSize1_2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_OriginalSizeWidth As System.Windows.Forms.Label
    Friend WithEvents lbl_Width As System.Windows.Forms.Label
    Friend WithEvents TLP_OriginalSize1_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_height As System.Windows.Forms.Label
    Friend WithEvents lbl_OriginalSizeHeight As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_IndentDec As System.Windows.Forms.Button
    Friend WithEvents btn_IndentInc As System.Windows.Forms.Button
    Friend WithEvents EventsTimer As System.Windows.Forms.Timer

End Class