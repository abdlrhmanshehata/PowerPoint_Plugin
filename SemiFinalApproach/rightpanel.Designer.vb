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
        Me.Part1_notes = New System.Windows.Forms.Panel()
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
        Me.vscroll = New System.Windows.Forms.VScrollBar()
        Me.TextBoxPage = New System.Windows.Forms.TableLayoutPanel()
        Me.UppremostPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.SizePage = New System.Windows.Forms.TableLayoutPanel()
        Me.NotesTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.Part1_notes.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
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
        Me.UppremostPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.NotesTableLayout.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
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
        'Part1_notes
        '
        Me.Part1_notes.Controls.Add(Me.TableLayoutPanel1)
        Me.Part1_notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Part1_notes.Location = New System.Drawing.Point(3, 3)
        Me.Part1_notes.Name = "Part1_notes"
        Me.Part1_notes.Size = New System.Drawing.Size(311, 72)
        Me.Part1_notes.TabIndex = 16
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(311, 72)
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(180, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(128, 66)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnCut
        '
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.ImageIndex = 1
        Me.btnCut.ImageList = Me.ImageList1
        Me.btnCut.Location = New System.Drawing.Point(0, 33)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(42, 33)
        Me.btnCut.TabIndex = 18
        Me.btnCut.Text = " "
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.ImageIndex = 4
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(84, 33)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 33)
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
        Me.btnAlignLeft.Size = New System.Drawing.Size(42, 33)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.Text = " "
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.ImageList = Me.ImageList1
        Me.btnCopy.Location = New System.Drawing.Point(42, 33)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(42, 33)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = " "
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.ImageIndex = 7
        Me.btnAlignCenter.ImageList = Me.ImageList1
        Me.btnAlignCenter.Location = New System.Drawing.Point(42, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(42, 33)
        Me.btnAlignCenter.TabIndex = 4
        Me.btnAlignCenter.Text = " "
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.ImageIndex = 9
        Me.btnAlignRight.ImageList = Me.ImageList1
        Me.btnAlignRight.Location = New System.Drawing.Point(84, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(44, 33)
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
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(171, 66)
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
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(165, 27)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'btnitalic
        '
        Me.btnitalic.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnitalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnitalic.ImageKey = "Italic.jpg"
        Me.btnitalic.ImageList = Me.ImageList1
        Me.btnitalic.Location = New System.Drawing.Point(41, 0)
        Me.btnitalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnitalic.Name = "btnitalic"
        Me.btnitalic.Size = New System.Drawing.Size(41, 27)
        Me.btnitalic.TabIndex = 3
        Me.btnitalic.Text = " "
        Me.btnitalic.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.ImageIndex = 6
        Me.btnPaste.ImageList = Me.ImageList1
        Me.btnPaste.Location = New System.Drawing.Point(123, 0)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(42, 27)
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
        Me.btnunderline.Location = New System.Drawing.Point(82, 0)
        Me.btnunderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnunderline.Name = "btnunderline"
        Me.btnunderline.Size = New System.Drawing.Size(41, 27)
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
        Me.btnBold.Size = New System.Drawing.Size(41, 27)
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
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(165, 27)
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
        Me.cboxFontFamily.Size = New System.Drawing.Size(111, 24)
        Me.cboxFontFamily.TabIndex = 15
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Items.AddRange(New Object() {"8", "9", "10", "10.5", "11", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "44", "48", "54", "60", "66", "72", "80", "88", "96", "", "", ""})
        Me.cboxFontSize.Location = New System.Drawing.Point(120, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(42, 24)
        Me.cboxFontSize.TabIndex = 14
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(3, 81)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(311, 179)
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
        Me.cboxFormatShape.DropDownHeight = 105
        Me.cboxFormatShape.FormattingEnabled = True
        Me.cboxFormatShape.IntegralHeight = False
        Me.cboxFormatShape.Items.AddRange(New Object() {"Text Box", "Size"})
        Me.cboxFormatShape.Location = New System.Drawing.Point(0, 0)
        Me.cboxFormatShape.Name = "cboxFormatShape"
        Me.cboxFormatShape.Size = New System.Drawing.Size(319, 21)
        Me.cboxFormatShape.TabIndex = 0
        Me.cboxFormatShape.Text = " "
        '
        'AutoFit
        '
        Me.AutoFit.Controls.Add(Me.ContentAutofit)
        Me.AutoFit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoFit.Location = New System.Drawing.Point(3, 29)
        Me.AutoFit.Name = "AutoFit"
        Me.AutoFit.Size = New System.Drawing.Size(98, 30)
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
        Me.ContentAutofit.Size = New System.Drawing.Size(92, 11)
        Me.ContentAutofit.TabIndex = 0
        '
        'Donnotautofit
        '
        Me.Donnotautofit.AutoSize = True
        Me.Donnotautofit.Location = New System.Drawing.Point(3, 3)
        Me.Donnotautofit.Name = "Donnotautofit"
        Me.Donnotautofit.Size = New System.Drawing.Size(86, 1)
        Me.Donnotautofit.TabIndex = 0
        Me.Donnotautofit.TabStop = True
        Me.Donnotautofit.Text = "&Do not Autofit"
        Me.Donnotautofit.UseVisualStyleBackColor = True
        '
        'Shrinktext
        '
        Me.Shrinktext.AutoSize = True
        Me.Shrinktext.Location = New System.Drawing.Point(3, 6)
        Me.Shrinktext.Name = "Shrinktext"
        Me.Shrinktext.Size = New System.Drawing.Size(86, 1)
        Me.Shrinktext.TabIndex = 1
        Me.Shrinktext.TabStop = True
        Me.Shrinktext.Text = "&Shrink text on overflow"
        Me.Shrinktext.UseVisualStyleBackColor = True
        '
        'ResizeShape
        '
        Me.ResizeShape.AutoSize = True
        Me.ResizeShape.Location = New System.Drawing.Point(3, 9)
        Me.ResizeShape.Name = "ResizeShape"
        Me.ResizeShape.Size = New System.Drawing.Size(86, 1)
        Me.ResizeShape.TabIndex = 2
        Me.ResizeShape.TabStop = True
        Me.ResizeShape.Text = "&Resize Shape to fit text"
        Me.ResizeShape.UseVisualStyleBackColor = True
        '
        'InternalMargin
        '
        Me.InternalMargin.Controls.Add(Me.contentInternalMargin)
        Me.InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InternalMargin.Location = New System.Drawing.Point(3, 65)
        Me.InternalMargin.Name = "InternalMargin"
        Me.InternalMargin.Size = New System.Drawing.Size(98, 22)
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
        Me.contentInternalMargin.Size = New System.Drawing.Size(92, 3)
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
        Me.paneltopmargin.Location = New System.Drawing.Point(3, 4)
        Me.paneltopmargin.Name = "paneltopmargin"
        Me.paneltopmargin.RowCount = 1
        Me.paneltopmargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.paneltopmargin.Size = New System.Drawing.Size(40, 1)
        Me.paneltopmargin.TabIndex = 2
        '
        'txttopmargin
        '
        Me.txttopmargin.DecimalPlaces = 2
        Me.txttopmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttopmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txttopmargin.Location = New System.Drawing.Point(19, 3)
        Me.txttopmargin.Name = "txttopmargin"
        Me.txttopmargin.Size = New System.Drawing.Size(18, 20)
        Me.txttopmargin.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 1)
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
        Me.panelleftmargin.Size = New System.Drawing.Size(40, 1)
        Me.panelleftmargin.TabIndex = 0
        '
        'txtleftmargin
        '
        Me.txtleftmargin.DecimalPlaces = 2
        Me.txtleftmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtleftmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtleftmargin.Location = New System.Drawing.Point(18, 3)
        Me.txtleftmargin.Name = "txtleftmargin"
        Me.txtleftmargin.Size = New System.Drawing.Size(19, 20)
        Me.txtleftmargin.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 1)
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
        Me.panelrightmargin.Location = New System.Drawing.Point(49, 3)
        Me.panelrightmargin.Name = "panelrightmargin"
        Me.panelrightmargin.RowCount = 1
        Me.panelrightmargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelrightmargin.Size = New System.Drawing.Size(40, 1)
        Me.panelrightmargin.TabIndex = 3
        '
        'txtrightmargin
        '
        Me.txtrightmargin.DecimalPlaces = 2
        Me.txtrightmargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrightmargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtrightmargin.Location = New System.Drawing.Point(19, 3)
        Me.txtrightmargin.Name = "txtrightmargin"
        Me.txtrightmargin.Size = New System.Drawing.Size(18, 20)
        Me.txtrightmargin.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 1)
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
        Me.panelbottommargin.Location = New System.Drawing.Point(49, 4)
        Me.panelbottommargin.Name = "panelbottommargin"
        Me.panelbottommargin.RowCount = 1
        Me.panelbottommargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelbottommargin.Size = New System.Drawing.Size(40, 1)
        Me.panelbottommargin.TabIndex = 4
        '
        'txtbottommargin
        '
        Me.txtbottommargin.DecimalPlaces = 2
        Me.txtbottommargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbottommargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtbottommargin.Location = New System.Drawing.Point(19, 3)
        Me.txtbottommargin.Name = "txtbottommargin"
        Me.txtbottommargin.Size = New System.Drawing.Size(18, 20)
        Me.txtbottommargin.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 1)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Bot :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkboxWrap
        '
        Me.chkboxWrap.AutoSize = True
        Me.chkboxWrap.Location = New System.Drawing.Point(3, 93)
        Me.chkboxWrap.Name = "chkboxWrap"
        Me.chkboxWrap.Size = New System.Drawing.Size(98, 6)
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
        Me.TextLayout.Size = New System.Drawing.Size(98, 20)
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
        Me.contenttextlayout.Size = New System.Drawing.Size(92, 1)
        Me.contenttextlayout.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 1)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Te&xt Direction :    "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1, 1)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Vertical Alignment : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxtextdirection
        '
        Me.cboxtextdirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextdirection.FormattingEnabled = True
        Me.cboxtextdirection.Items.AddRange(New Object() {"Horizontal", "Rotate all text 90*", "Rotate all text 270*"})
        Me.cboxtextdirection.Location = New System.Drawing.Point(-58, 3)
        Me.cboxtextdirection.Name = "cboxtextdirection"
        Me.cboxtextdirection.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextdirection.TabIndex = 1
        '
        'cboxtextalignment
        '
        Me.cboxtextalignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextalignment.FormattingEnabled = True
        Me.cboxtextalignment.Items.AddRange(New Object() {"Top", "Middle", "Bottom"})
        Me.cboxtextalignment.Location = New System.Drawing.Point(-58, 3)
        Me.cboxtextalignment.Name = "cboxtextalignment"
        Me.cboxtextalignment.Size = New System.Drawing.Size(147, 21)
        Me.cboxtextalignment.TabIndex = 3
        '
        'vscroll
        '
        Me.vscroll.Dock = System.Windows.Forms.DockStyle.Right
        Me.vscroll.LargeChange = 51
        Me.vscroll.Location = New System.Drawing.Point(295, 0)
        Me.vscroll.Name = "vscroll"
        Me.vscroll.Size = New System.Drawing.Size(24, 206)
        Me.vscroll.SmallChange = 10
        Me.vscroll.TabIndex = 20
        '
        'TextBoxPage
        '
        Me.TextBoxPage.ColumnCount = 1
        Me.TextBoxPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TextBoxPage.Controls.Add(Me.chkboxWrap, 0, 3)
        Me.TextBoxPage.Controls.Add(Me.InternalMargin, 0, 2)
        Me.TextBoxPage.Controls.Add(Me.AutoFit, 0, 1)
        Me.TextBoxPage.Controls.Add(Me.TextLayout, 0, 0)
        Me.TextBoxPage.Location = New System.Drawing.Point(167, 29)
        Me.TextBoxPage.Name = "TextBoxPage"
        Me.TextBoxPage.RowCount = 4
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.71428!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.87302!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61905!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TextBoxPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TextBoxPage.Size = New System.Drawing.Size(104, 102)
        Me.TextBoxPage.TabIndex = 21
        Me.TextBoxPage.Visible = False
        '
        'UppremostPanel
        '
        Me.UppremostPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UppremostPanel.Controls.Add(Me.cboxFormatShape)
        Me.UppremostPanel.Location = New System.Drawing.Point(3, 8)
        Me.UppremostPanel.Name = "UppremostPanel"
        Me.UppremostPanel.Size = New System.Drawing.Size(321, 25)
        Me.UppremostPanel.TabIndex = 21
        '
        'TopPanel
        '
        Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPanel.Controls.Add(Me.vscroll)
        Me.TopPanel.Controls.Add(Me.TextBoxPage)
        Me.TopPanel.Controls.Add(Me.SizePage)
        Me.TopPanel.Location = New System.Drawing.Point(3, 38)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(321, 208)
        Me.TopPanel.TabIndex = 22
        '
        'SizePage
        '
        Me.SizePage.ColumnCount = 1
        Me.SizePage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SizePage.Location = New System.Drawing.Point(36, 32)
        Me.SizePage.Name = "SizePage"
        Me.SizePage.RowCount = 4
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.SizePage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.SizePage.Size = New System.Drawing.Size(88, 72)
        Me.SizePage.TabIndex = 23
        Me.SizePage.Visible = False
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
        Me.NotesTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.NotesTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.NotesTableLayout.Size = New System.Drawing.Size(317, 263)
        Me.NotesTableLayout.TabIndex = 24
        '
        'BottomPanel
        '
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPanel.Controls.Add(Me.NotesTableLayout)
        Me.BottomPanel.Location = New System.Drawing.Point(4, 252)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(319, 265)
        Me.BottomPanel.TabIndex = 25
        '
        'rightpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.UppremostPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Name = "rightpanel"
        Me.Size = New System.Drawing.Size(880, 520)
        Me.Part1_notes.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
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
        Me.UppremostPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.NotesTableLayout.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
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
    Friend WithEvents panelleftmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents paneltopmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelrightmargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelbottommargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkboxWrap As System.Windows.Forms.CheckBox
    Friend WithEvents Part1_notes As System.Windows.Forms.Panel
    Friend WithEvents vscroll As System.Windows.Forms.VScrollBar
    Friend WithEvents TextBoxPage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtleftmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtbottommargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txttopmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtrightmargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents UppremostPanel As System.Windows.Forms.Panel
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents SizePage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotesTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BottomPanel As System.Windows.Forms.Panel

End Class
