<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rightpanel))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitNotes = New System.Windows.Forms.SplitContainer()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAlignLeft = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnAlignCenter = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnitalic = New System.Windows.Forms.CheckBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnunderline = New System.Windows.Forms.CheckBox()
        Me.btnBold = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboxFontFamily = New System.Windows.Forms.ComboBox()
        Me.cboxFontSize = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Fixedtimer = New System.Windows.Forms.Timer(Me.components)
        Me.cboxFormatShape = New System.Windows.Forms.ComboBox()
        Me.AutoFit = New System.Windows.Forms.GroupBox()
        Me.ContentAutofit = New System.Windows.Forms.TableLayoutPanel()
        Me.Donnotautofit = New System.Windows.Forms.RadioButton()
        Me.Shrinktext = New System.Windows.Forms.RadioButton()
        Me.ResizeShape = New System.Windows.Forms.RadioButton()
        Me.InternalMargin = New System.Windows.Forms.GroupBox()
        Me.contentInternalMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.mnsLM = New System.Windows.Forms.Button()
        Me.plsLM = New System.Windows.Forms.Button()
        Me.txtleftmargins = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.txttopmargin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnsTM = New System.Windows.Forms.Button()
        Me.plsTM = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtrightmargin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.plsRM = New System.Windows.Forms.Button()
        Me.mnsRM = New System.Windows.Forms.Button()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtbottommargin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mnsBM = New System.Windows.Forms.Button()
        Me.plsBM = New System.Windows.Forms.Button()
        Me.chkboxWrap = New System.Windows.Forms.CheckBox()
        Me.TextLayout = New System.Windows.Forms.GroupBox()
        Me.contenttextlayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxtextdirection = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxtextalignment = New System.Windows.Forms.ComboBox()
        Me.vscroll = New System.Windows.Forms.VScrollBar()
        Me.PanelTop = New System.Windows.Forms.TableLayoutPanel()
        Me.txtleftmargin = New System.Windows.Forms.NumericUpDown()
        CType(Me.SplitNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitNotes.Panel1.SuspendLayout()
        Me.SplitNotes.Panel2.SuspendLayout()
        Me.SplitNotes.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.AutoFit.SuspendLayout()
        Me.ContentAutofit.SuspendLayout()
        Me.InternalMargin.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TextLayout.SuspendLayout()
        Me.contenttextlayout.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.txtleftmargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Bold.jpg")
        Me.ImageList1.Images.SetKeyName(1, "ContactCardCut.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Copy.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Cut.jpg")
        Me.ImageList1.Images.SetKeyName(4, "FileSave.png")
        Me.ImageList1.Images.SetKeyName(5, "Italic.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Paste.jpg")
        Me.ImageList1.Images.SetKeyName(7, "TextAlignCenter.jpg")
        Me.ImageList1.Images.SetKeyName(8, "TextAlignLeft.jpg")
        Me.ImageList1.Images.SetKeyName(9, "TextAlignRight.jpg")
        Me.ImageList1.Images.SetKeyName(10, "Underline.jpg")
        '
        'SplitNotes
        '
        Me.SplitNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitNotes.Location = New System.Drawing.Point(65, 179)
        Me.SplitNotes.Name = "SplitNotes"
        Me.SplitNotes.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitNotes.Panel1
        '
        Me.SplitNotes.Panel1.Controls.Add(Me.PanelBottom)
        '
        'SplitNotes.Panel2
        '
        Me.SplitNotes.Panel2.Controls.Add(Me.txtNotes)
        Me.SplitNotes.Size = New System.Drawing.Size(319, 260)
        Me.SplitNotes.SplitterDistance = 77
        Me.SplitNotes.TabIndex = 17
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBottom.Location = New System.Drawing.Point(0, 0)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(317, 75)
        Me.PanelBottom.TabIndex = 16
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22543!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77457!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(317, 75)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnCut, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnSave, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAlignLeft, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCopy, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAlignCenter, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAlignRight, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(184, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(130, 69)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnCut
        '
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.ImageIndex = 1
        Me.btnCut.ImageList = Me.ImageList1
        Me.btnCut.Location = New System.Drawing.Point(0, 34)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(43, 35)
        Me.btnCut.TabIndex = 18
        Me.btnCut.Text = " "
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.ImageIndex = 4
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(86, 34)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 35)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = " "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignLeft.ImageIndex = 8
        Me.btnAlignLeft.ImageList = Me.ImageList1
        Me.btnAlignLeft.Location = New System.Drawing.Point(0, 0)
        Me.btnAlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(43, 34)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.Text = " "
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.ImageList = Me.ImageList1
        Me.btnCopy.Location = New System.Drawing.Point(43, 34)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(43, 35)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = " "
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.ImageIndex = 7
        Me.btnAlignCenter.ImageList = Me.ImageList1
        Me.btnAlignCenter.Location = New System.Drawing.Point(43, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(43, 34)
        Me.btnAlignCenter.TabIndex = 4
        Me.btnAlignCenter.Text = " "
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.ImageIndex = 9
        Me.btnAlignRight.ImageList = Me.ImageList1
        Me.btnAlignRight.Location = New System.Drawing.Point(86, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(44, 34)
        Me.btnAlignRight.TabIndex = 5
        Me.btnAlignRight.Text = " "
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(175, 69)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnitalic, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnPaste, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnunderline, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnBold, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 37)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(169, 29)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'btnitalic
        '
        Me.btnitalic.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnitalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnitalic.ImageKey = "Italic.jpg"
        Me.btnitalic.ImageList = Me.ImageList1
        Me.btnitalic.Location = New System.Drawing.Point(42, 0)
        Me.btnitalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnitalic.Name = "btnitalic"
        Me.btnitalic.Size = New System.Drawing.Size(42, 29)
        Me.btnitalic.TabIndex = 3
        Me.btnitalic.Text = " "
        Me.btnitalic.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.ImageIndex = 6
        Me.btnPaste.ImageList = Me.ImageList1
        Me.btnPaste.Location = New System.Drawing.Point(126, 0)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(43, 29)
        Me.btnPaste.TabIndex = 17
        Me.btnPaste.Text = " "
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnunderline
        '
        Me.btnunderline.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnunderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnunderline.ImageKey = "Underline.jpg"
        Me.btnunderline.ImageList = Me.ImageList1
        Me.btnunderline.Location = New System.Drawing.Point(84, 0)
        Me.btnunderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnunderline.Name = "btnunderline"
        Me.btnunderline.Size = New System.Drawing.Size(42, 29)
        Me.btnunderline.TabIndex = 2
        Me.btnunderline.Text = " "
        Me.btnunderline.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBold.ImageIndex = 0
        Me.btnBold.ImageList = Me.ImageList1
        Me.btnBold.Location = New System.Drawing.Point(0, 0)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(42, 29)
        Me.btnBold.TabIndex = 2
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26437!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73563!))
        Me.TableLayoutPanel8.Controls.Add(Me.cboxFontFamily, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cboxFontSize, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(169, 28)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'cboxFontFamily
        '
        Me.cboxFontFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontFamily.FormattingEnabled = True
        Me.cboxFontFamily.Items.AddRange(New Object() {"Abadi MT Condensed", "Adobe Minion Web", "Agency FB", "Aharoni", "Aldhabi", "Algerian", "Almanac MT", "American Uncial", "Andale Mono", "Andalus", "Andy", "Angsana New", "AngsanaUPC", "Aparajita", "Arabic Transparent", "Arabic Typesetting", "Arial", "Arial Black", "Arial Narrow", "Arial Narrow Special", "Arial Rounded MT", "Arial Special", "Arial Unicode MS", "Augsburger Initials", "Baskerville Old Face", "Batang", "BatangChe", "Bauhaus 93", "Beesknees ITC", "Bell MT", "Berlin Sans FB", "Bernard MT Condensed", "Bickley Script", "Blackadder ITC", "Bodoni MT", "Bodoni MT Condensed", "Bon Apetit MT", "Book Antiqua", "Bookman Old Style", "Bookshelf Symbol", "Bradley Hand ITC", "Braggadocio", "BriemScript", "Britannic", "Britannic Bold", "Broadway", "Browallia New", "BrowalliaUPC", "Brush Script MT", "Calibri", "Californian FB", "Calisto MT", "Cambria", "Cambria Math", "Candara", "Cariadings", "Castellar", "Centaur", "Century", "Century Gothic", "Century Schoolbook", "Chiller", "Colonna MT", "Comic Sans MS", "Consolas", "Constantia", "Contemporary Brush", "Cooper Black", "Copperplate Gothic", "Corbel", "Cordia New", "CordiaUPC", "Courier New", "Curlz MT", "DaunPenh", "David", "Desdemona", "DFKai-SB", "DilleniaUPC", "Directions MT", "DokChampa", "Dotum", "DotumChe", "Ebrima", "Eckmann", "Edda", "Edwardian Script ITC", "Elephant", "Engravers MT", "Enviro", "Eras ITC", "Estrangelo Edessa", "EucrosiaUPC", "Euphemia", "Eurostile", "FangSong", "Felix Titling", "Fine Hand", "Fixed Miriam Transparent", "Flexure", "Footlight MT", "Forte", "Franklin Gothic", "Franklin Gothic Medium", "FrankRuehl", "FreesiaUPC", "Freestyle Script", "French Script MT", "Futura", "Gabriola", "Gadugi", "Garamond", "Garamond MT", "Gautami", "Georgia", "Georgia Ref", "Gigi", "Gill Sans MT", "Gill Sans MT Condensed", "Gisha", "Gloucester", "Goudy Old Style", "Goudy Stout", "Gradl", "Gulim", "GulimChe", "Gungsuh", "GungsuhChe", "Haettenschweiler", "Harlow Solid Italic", "Harrington", "High Tower Text", "Holidays MT", "Impact", "Imprint MT Shadow", "Informal Roman", "IrisUPC", "Iskoola Pota", "JasmineUPC", "Jokerman", "Juice ITC", "KaiTi", "Kalinga", "Kartika", "Keystrokes MT", "Khmer UI", "Kino MT", "KodchiangUPC", "Kokila", "Kristen ITC", "Kunstler Script", "Lao UI", "Latha", "LCD", "Leelawadee", "Levenim MT", "LilyUPC", "Lucida Blackletter", "Lucida Bright", "Lucida Bright Math", "Lucida Calligraphy", "Lucida Console", "Lucida Fax", "Lucida Handwriting", "Lucida Sans", "Lucida Sans Typewriter", "Lucida Sans Unicode", "Magneto", "Maiandra GD", "Malgun Gothic", "Mangal", "Map Symbols", "Marlett", "Matisse ITC", "Matura MT Script Capitals", "McZee", "Mead Bold", "Meiryo", "Meiryo UI", "Mercurius Script MT Bold", "Microsoft Himalaya", "Microsoft JhengHei", "Microsoft JhengHei UI", "Microsoft New Tai Lue", "Microsoft PhagsPa", "Microsoft Sans Serif", "Microsoft Tai Le", "Microsoft Uighur", "Microsoft YaHei", "Microsoft YaHei UI", "Microsoft Yi Baiti", "MingLiU", "MingLiU_HKSCS", "MingLiU_HKSCS-ExtB", "MingLiU-ExtB", "Minion Web", "Miriam", "Miriam Fixed", "Mistral", "Modern No. 20", "Mongolian Baiti", "Monotype Corsiva", "Monotype Sorts", "Monotype.com", "MoolBoran", "MS Gothic", "MS LineDraw", "MS Mincho", "MS Outlook", "MS PGothic", "MS PMincho", "MS Reference", "MS UI Gothic", "MT Extra", "MV Boli", "Myanmar Text", "Narkisim", "New Caledonia", "News Gothic MT", "Niagara", "Nirmala UI", "NSimSun", "Nyala", "OCR A Extended", "OCRB", "OCR-B-Digits", "Old English Text MT", "Onyx", "Palace Script MT", "Palatino Linotype", "Papyrus", "Parade", "Parchment", "Parties MT", "Peignot Medium", "Pepita MT", "Perpetua", "Perpetua Titling MT", "Placard Condensed", "Plantagenet Cherokee", "Playbill", "PMingLiU", "PMingLiU-ExtB", "Poor Richard", "Pristina", "Raavi", "Rage Italic", "Ransom", "Ravie", "RefSpecialty", "Rockwell", "Rockwell Condensed", "Rockwell Extra Bold", "Rod", "Runic MT Condensed", "Sakkal Majalla", "Script MT Bold", "Segoe Chess", "Segoe Print", "Segoe Pseudo", "Segoe Script", "Segoe UI", "Segoe UI Symbol", "Shonar Bangla", "Showcard Gothic", "Shruti", "Signs MT", "SimHei", "Simplified Arabic", "Simplified Arabic Fixed", "SimSun", "SimSun-ExtB", "Snap ITC", "Sports MT", "Stencil", "Stop", "Sylfaen", "Symbol", "Tahoma", "Temp Installer Font", "Tempo Grunge", "Tempus Sans ITC", "Times New Roman", "Times New Roman Special", "Traditional Arabic", "Transport MT", "Trebuchet MS", "Tunga", "Tw Cen MT", "Tw Cen MT Condensed", "Urdu Typesetting", "Utsaah", "Vacation MT", "Vani", "Verdana", "Verdana Ref", "Vijaya", "Viner Hand ITC", "Vivaldi", "Vixar ASCI", "Vladimir Script", "Vrinda", "Webdings", "Westminster", "Wide Latin", "Wingdings"})
        Me.cboxFontFamily.Location = New System.Drawing.Point(3, 3)
        Me.cboxFontFamily.Name = "cboxFontFamily"
        Me.cboxFontFamily.Size = New System.Drawing.Size(114, 24)
        Me.cboxFontFamily.TabIndex = 15
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Items.AddRange(New Object() {"8", "9", "10", "10.5", "11", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "44", "48", "54", "60", "66", "72", "80", "88", "96", "", "", ""})
        Me.cboxFontSize.Location = New System.Drawing.Point(123, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(43, 24)
        Me.cboxFontSize.TabIndex = 14
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(317, 177)
        Me.txtNotes.TabIndex = 1
        Me.txtNotes.Text = " "
        '
        'Fixedtimer
        '
        Me.Fixedtimer.Enabled = True
        '
        'cboxFormatShape
        '
        Me.cboxFormatShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFormatShape.FormattingEnabled = True
        Me.cboxFormatShape.Items.AddRange(New Object() {"Text Box"})
        Me.cboxFormatShape.Location = New System.Drawing.Point(3, 3)
        Me.cboxFormatShape.Name = "cboxFormatShape"
        Me.cboxFormatShape.Size = New System.Drawing.Size(266, 21)
        Me.cboxFormatShape.TabIndex = 0
        Me.cboxFormatShape.Text = "Text Box"
        '
        'AutoFit
        '
        Me.AutoFit.Controls.Add(Me.ContentAutofit)
        Me.AutoFit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoFit.Location = New System.Drawing.Point(3, 116)
        Me.AutoFit.Name = "AutoFit"
        Me.AutoFit.Size = New System.Drawing.Size(266, 144)
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
        Me.ContentAutofit.Size = New System.Drawing.Size(260, 125)
        Me.ContentAutofit.TabIndex = 0
        '
        'Donnotautofit
        '
        Me.Donnotautofit.AutoSize = True
        Me.Donnotautofit.Location = New System.Drawing.Point(3, 3)
        Me.Donnotautofit.Name = "Donnotautofit"
        Me.Donnotautofit.Size = New System.Drawing.Size(90, 17)
        Me.Donnotautofit.TabIndex = 0
        Me.Donnotautofit.TabStop = True
        Me.Donnotautofit.Text = "&Do not Autofit"
        Me.Donnotautofit.UseVisualStyleBackColor = True
        '
        'Shrinktext
        '
        Me.Shrinktext.AutoSize = True
        Me.Shrinktext.Location = New System.Drawing.Point(3, 44)
        Me.Shrinktext.Name = "Shrinktext"
        Me.Shrinktext.Size = New System.Drawing.Size(133, 17)
        Me.Shrinktext.TabIndex = 1
        Me.Shrinktext.TabStop = True
        Me.Shrinktext.Text = "&Shrink text on overflow"
        Me.Shrinktext.UseVisualStyleBackColor = True
        '
        'ResizeShape
        '
        Me.ResizeShape.AutoSize = True
        Me.ResizeShape.Location = New System.Drawing.Point(3, 85)
        Me.ResizeShape.Name = "ResizeShape"
        Me.ResizeShape.Size = New System.Drawing.Size(134, 17)
        Me.ResizeShape.TabIndex = 2
        Me.ResizeShape.TabStop = True
        Me.ResizeShape.Text = "&Resize Shape to fit text"
        Me.ResizeShape.UseVisualStyleBackColor = True
        '
        'InternalMargin
        '
        Me.InternalMargin.Controls.Add(Me.contentInternalMargin)
        Me.InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InternalMargin.Location = New System.Drawing.Point(3, 266)
        Me.InternalMargin.Name = "InternalMargin"
        Me.InternalMargin.Size = New System.Drawing.Size(266, 127)
        Me.InternalMargin.TabIndex = 0
        Me.InternalMargin.TabStop = False
        Me.InternalMargin.Text = "InternalMargin"
        '
        'contentInternalMargin
        '
        Me.contentInternalMargin.ColumnCount = 2
        Me.contentInternalMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentInternalMargin.Location = New System.Drawing.Point(3, 16)
        Me.contentInternalMargin.Name = "contentInternalMargin"
        Me.contentInternalMargin.RowCount = 2
        Me.contentInternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.contentInternalMargin.Size = New System.Drawing.Size(260, 108)
        Me.contentInternalMargin.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.58333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.41667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.mnsLM, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.plsLM, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtleftmargins, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(412, 212)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(160, 43)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'mnsLM
        '
        Me.mnsLM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnsLM.Location = New System.Drawing.Point(120, 0)
        Me.mnsLM.Margin = New System.Windows.Forms.Padding(0)
        Me.mnsLM.Name = "mnsLM"
        Me.mnsLM.Size = New System.Drawing.Size(40, 43)
        Me.mnsLM.TabIndex = 2
        Me.mnsLM.Text = "-"
        Me.mnsLM.UseVisualStyleBackColor = True
        '
        'plsLM
        '
        Me.plsLM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plsLM.Location = New System.Drawing.Point(100, 0)
        Me.plsLM.Margin = New System.Windows.Forms.Padding(0)
        Me.plsLM.Name = "plsLM"
        Me.plsLM.Size = New System.Drawing.Size(20, 43)
        Me.plsLM.TabIndex = 3
        Me.plsLM.Text = "+"
        Me.plsLM.UseVisualStyleBackColor = True
        '
        'txtleftmargins
        '
        Me.txtleftmargins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtleftmargins.Location = New System.Drawing.Point(42, 3)
        Me.txtleftmargins.Multiline = True
        Me.txtleftmargins.Name = "txtleftmargins"
        Me.txtleftmargins.Size = New System.Drawing.Size(55, 37)
        Me.txtleftmargins.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Left :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 4
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txttopmargin, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.mnsTM, 3, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.plsTM, 2, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(586, 319)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(155, 31)
        Me.TableLayoutPanel9.TabIndex = 2
        '
        'txttopmargin
        '
        Me.txttopmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttopmargin.Location = New System.Drawing.Point(44, 0)
        Me.txttopmargin.Margin = New System.Windows.Forms.Padding(0)
        Me.txttopmargin.Multiline = True
        Me.txttopmargin.Name = "txttopmargin"
        Me.txttopmargin.Size = New System.Drawing.Size(66, 31)
        Me.txttopmargin.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Top :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnsTM
        '
        Me.mnsTM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnsTM.Location = New System.Drawing.Point(130, 0)
        Me.mnsTM.Margin = New System.Windows.Forms.Padding(0)
        Me.mnsTM.Name = "mnsTM"
        Me.mnsTM.Size = New System.Drawing.Size(25, 31)
        Me.mnsTM.TabIndex = 2
        Me.mnsTM.Text = "-"
        Me.mnsTM.UseVisualStyleBackColor = True
        '
        'plsTM
        '
        Me.plsTM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plsTM.Location = New System.Drawing.Point(110, 0)
        Me.plsTM.Margin = New System.Windows.Forms.Padding(0)
        Me.plsTM.Name = "plsTM"
        Me.plsTM.Size = New System.Drawing.Size(20, 31)
        Me.plsTM.TabIndex = 3
        Me.plsTM.Text = "+"
        Me.plsTM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.35193!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.64807!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txtrightmargin, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.plsRM, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.mnsRM, 3, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(418, 316)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(154, 32)
        Me.TableLayoutPanel10.TabIndex = 3
        '
        'txtrightmargin
        '
        Me.txtrightmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrightmargin.Location = New System.Drawing.Point(47, 3)
        Me.txtrightmargin.Multiline = True
        Me.txtrightmargin.Name = "txtrightmargin"
        Me.txtrightmargin.Size = New System.Drawing.Size(44, 26)
        Me.txtrightmargin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Right :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'plsRM
        '
        Me.plsRM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plsRM.Location = New System.Drawing.Point(94, 0)
        Me.plsRM.Margin = New System.Windows.Forms.Padding(0)
        Me.plsRM.Name = "plsRM"
        Me.plsRM.Size = New System.Drawing.Size(20, 32)
        Me.plsRM.TabIndex = 3
        Me.plsRM.Text = "+"
        Me.plsRM.UseVisualStyleBackColor = True
        '
        'mnsRM
        '
        Me.mnsRM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnsRM.Location = New System.Drawing.Point(114, 0)
        Me.mnsRM.Margin = New System.Windows.Forms.Padding(0)
        Me.mnsRM.Name = "mnsRM"
        Me.mnsRM.Size = New System.Drawing.Size(40, 32)
        Me.mnsRM.TabIndex = 2
        Me.mnsRM.Text = "-"
        Me.mnsRM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 4
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.txtbottommargin, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.mnsBM, 3, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.plsBM, 2, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(592, 212)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(149, 43)
        Me.TableLayoutPanel11.TabIndex = 4
        '
        'txtbottommargin
        '
        Me.txtbottommargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbottommargin.Location = New System.Drawing.Point(44, 3)
        Me.txtbottommargin.Multiline = True
        Me.txtbottommargin.Name = "txtbottommargin"
        Me.txtbottommargin.Size = New System.Drawing.Size(56, 37)
        Me.txtbottommargin.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 43)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Bot :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnsBM
        '
        Me.mnsBM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnsBM.Location = New System.Drawing.Point(123, 0)
        Me.mnsBM.Margin = New System.Windows.Forms.Padding(0)
        Me.mnsBM.Name = "mnsBM"
        Me.mnsBM.Size = New System.Drawing.Size(26, 43)
        Me.mnsBM.TabIndex = 2
        Me.mnsBM.Text = "-"
        Me.mnsBM.UseVisualStyleBackColor = True
        '
        'plsBM
        '
        Me.plsBM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plsBM.Location = New System.Drawing.Point(103, 0)
        Me.plsBM.Margin = New System.Windows.Forms.Padding(0)
        Me.plsBM.Name = "plsBM"
        Me.plsBM.Size = New System.Drawing.Size(20, 43)
        Me.plsBM.TabIndex = 3
        Me.plsBM.Text = "+"
        Me.plsBM.UseVisualStyleBackColor = True
        '
        'chkboxWrap
        '
        Me.chkboxWrap.AutoSize = True
        Me.chkboxWrap.Location = New System.Drawing.Point(3, 399)
        Me.chkboxWrap.Name = "chkboxWrap"
        Me.chkboxWrap.Size = New System.Drawing.Size(115, 17)
        Me.chkboxWrap.TabIndex = 1
        Me.chkboxWrap.Text = "&Wrap text in shape"
        Me.chkboxWrap.UseVisualStyleBackColor = True
        '
        'TextLayout
        '
        Me.TextLayout.Controls.Add(Me.contenttextlayout)
        Me.TextLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextLayout.Location = New System.Drawing.Point(3, 27)
        Me.TextLayout.Name = "TextLayout"
        Me.TextLayout.Size = New System.Drawing.Size(266, 83)
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
        Me.contenttextlayout.Size = New System.Drawing.Size(260, 64)
        Me.contenttextlayout.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Te&xt Direction :    "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxtextdirection
        '
        Me.cboxtextdirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextdirection.FormattingEnabled = True
        Me.cboxtextdirection.Items.AddRange(New Object() {"Horizontal", "Rotate all text 90*", "Rotate all text 270*"})
        Me.cboxtextdirection.Location = New System.Drawing.Point(110, 34)
        Me.cboxtextdirection.Name = "cboxtextdirection"
        Me.cboxtextdirection.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextdirection.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 31)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Vertical Alignment : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxtextalignment
        '
        Me.cboxtextalignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextalignment.FormattingEnabled = True
        Me.cboxtextalignment.Items.AddRange(New Object() {"Top", "Middle", "Bottom"})
        Me.cboxtextalignment.Location = New System.Drawing.Point(110, 3)
        Me.cboxtextalignment.Name = "cboxtextalignment"
        Me.cboxtextalignment.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextalignment.TabIndex = 3
        '
        'vscroll
        '
        Me.vscroll.LargeChange = 41
        Me.vscroll.Location = New System.Drawing.Point(16, 33)
        Me.vscroll.Name = "vscroll"
        Me.vscroll.Size = New System.Drawing.Size(23, 299)
        Me.vscroll.SmallChange = 10
        Me.vscroll.TabIndex = 20
        '
        'PanelTop
        '
        Me.PanelTop.ColumnCount = 1
        Me.PanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelTop.Controls.Add(Me.chkboxWrap, 0, 4)
        Me.PanelTop.Controls.Add(Me.InternalMargin, 0, 3)
        Me.PanelTop.Controls.Add(Me.AutoFit, 0, 2)
        Me.PanelTop.Controls.Add(Me.cboxFormatShape, 0, 0)
        Me.PanelTop.Controls.Add(Me.TextLayout, 0, 1)
        Me.PanelTop.Location = New System.Drawing.Point(783, 33)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.RowCount = 5
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378!))
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.54507!))
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72906!))
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.89245!))
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.924485!))
        Me.PanelTop.Size = New System.Drawing.Size(272, 437)
        Me.PanelTop.TabIndex = 21
        '
        'txtleftmargin
        '
        Me.txtleftmargin.Location = New System.Drawing.Point(492, 149)
        Me.txtleftmargin.Name = "txtleftmargin"
        Me.txtleftmargin.Size = New System.Drawing.Size(80, 20)
        Me.txtleftmargin.TabIndex = 22
        '
        'rightpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtleftmargin)
        Me.Controls.Add(Me.TableLayoutPanel9)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel11)
        Me.Controls.Add(Me.TableLayoutPanel10)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.vscroll)
        Me.Controls.Add(Me.SplitNotes)
        Me.Name = "rightpanel"
        Me.Size = New System.Drawing.Size(1133, 999)
        Me.SplitNotes.Panel1.ResumeLayout(False)
        Me.SplitNotes.Panel2.ResumeLayout(False)
        CType(Me.SplitNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitNotes.ResumeLayout(False)
        Me.PanelBottom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.AutoFit.ResumeLayout(False)
        Me.ContentAutofit.ResumeLayout(False)
        Me.ContentAutofit.PerformLayout()
        Me.InternalMargin.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TextLayout.ResumeLayout(False)
        Me.contenttextlayout.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.txtleftmargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents cboxFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboxFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents btnAlignCenter As System.Windows.Forms.Button
    Friend WithEvents btnAlignLeft As System.Windows.Forms.Button
    Friend WithEvents btnAlignRight As System.Windows.Forms.Button
    Friend WithEvents Fixedtimer As System.Windows.Forms.Timer
    Friend WithEvents SplitNotes As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnBold As System.Windows.Forms.CheckBox
    Friend WithEvents btnitalic As System.Windows.Forms.CheckBox
    Friend WithEvents btnunderline As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
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
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mnsLM As System.Windows.Forms.Button
    Friend WithEvents plsLM As System.Windows.Forms.Button
    Friend WithEvents txtleftmargins As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txttopmargin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnsTM As System.Windows.Forms.Button
    Friend WithEvents plsTM As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtrightmargin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents plsRM As System.Windows.Forms.Button
    Friend WithEvents mnsRM As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtbottommargin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mnsBM As System.Windows.Forms.Button
    Friend WithEvents plsBM As System.Windows.Forms.Button
    Friend WithEvents chkboxWrap As System.Windows.Forms.CheckBox
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents vscroll As System.Windows.Forms.VScrollBar
    Friend WithEvents PanelTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtleftmargin As System.Windows.Forms.NumericUpDown

End Class
