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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.cboxFontSize = New System.Windows.Forms.ComboBox()
        Me.cboxFontFamily = New System.Windows.Forms.ComboBox()
        Me.btnAlignCenter = New System.Windows.Forms.Button()
        Me.btnAlignLeft = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.btnItalic = New System.Windows.Forms.Button()
        Me.btnUnderline = New System.Windows.Forms.Button()
        Me.txtSlideId = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(367, 521)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DimGray
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(359, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notes Section"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSlideId)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNotes)
        Me.SplitContainer1.Size = New System.Drawing.Size(353, 489)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveChanges, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDisplay, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(353, 100)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(91, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 94)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveChanges.Enabled = False
        Me.btnSaveChanges.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(263, 3)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(87, 94)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = " Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(175, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 94)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDisplay.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(3, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(82, 94)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 78)
        Me.Panel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.92494!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.07505!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCut, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPaste, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCopy, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboxFontSize, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboxFontFamily, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAlignCenter, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAlignLeft, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAlignRight, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.04762!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.95238!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(353, 78)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Enabled = False
        Me.btnSave.ImageIndex = 4
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(308, 34)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 44)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = " "
        Me.btnSave.UseVisualStyleBackColor = True
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
        'btnCut
        '
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.Enabled = False
        Me.btnCut.ImageIndex = 1
        Me.btnCut.ImageList = Me.ImageList1
        Me.btnCut.Location = New System.Drawing.Point(228, 34)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(40, 44)
        Me.btnCut.TabIndex = 18
        Me.btnCut.Text = " "
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.Enabled = False
        Me.btnPaste.ImageIndex = 6
        Me.btnPaste.ImageList = Me.ImageList1
        Me.btnPaste.Location = New System.Drawing.Point(178, 34)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(50, 44)
        Me.btnPaste.TabIndex = 17
        Me.btnPaste.Text = " "
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.Enabled = False
        Me.btnCopy.ImageIndex = 2
        Me.btnCopy.ImageList = Me.ImageList1
        Me.btnCopy.Location = New System.Drawing.Point(268, 34)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(40, 44)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = " "
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Enabled = False
        Me.cboxFontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Items.AddRange(New Object() {"8", "9", "10", "10.5", "11", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "44", "48", "54", "60", "66", "72", "80", "88", "96", "", "", ""})
        Me.cboxFontSize.Location = New System.Drawing.Point(181, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(44, 24)
        Me.cboxFontSize.TabIndex = 14
        '
        'cboxFontFamily
        '
        Me.cboxFontFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontFamily.Enabled = False
        Me.cboxFontFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontFamily.FormattingEnabled = True
        Me.cboxFontFamily.Items.AddRange(New Object() {"Abadi MT Condensed", "Adobe Minion Web", "Agency FB", "Aharoni", "Aldhabi", "Algerian", "Almanac MT", "American Uncial", "Andale Mono", "Andalus", "Andy", "Angsana New", "AngsanaUPC", "Aparajita", "Arabic Transparent", "Arabic Typesetting", "Arial", "Arial Black", "Arial Narrow", "Arial Narrow Special", "Arial Rounded MT", "Arial Special", "Arial Unicode MS", "Augsburger Initials", "Baskerville Old Face", "Batang", "BatangChe", "Bauhaus 93", "Beesknees ITC", "Bell MT", "Berlin Sans FB", "Bernard MT Condensed", "Bickley Script", "Blackadder ITC", "Bodoni MT", "Bodoni MT Condensed", "Bon Apetit MT", "Book Antiqua", "Bookman Old Style", "Bookshelf Symbol", "Bradley Hand ITC", "Braggadocio", "BriemScript", "Britannic", "Britannic Bold", "Broadway", "Browallia New", "BrowalliaUPC", "Brush Script MT", "Calibri", "Californian FB", "Calisto MT", "Cambria", "Cambria Math", "Candara", "Cariadings", "Castellar", "Centaur", "Century", "Century Gothic", "Century Schoolbook", "Chiller", "Colonna MT", "Comic Sans MS", "Consolas", "Constantia", "Contemporary Brush", "Cooper Black", "Copperplate Gothic", "Corbel", "Cordia New", "CordiaUPC", "Courier New", "Curlz MT", "DaunPenh", "David", "Desdemona", "DFKai-SB", "DilleniaUPC", "Directions MT", "DokChampa", "Dotum", "DotumChe", "Ebrima", "Eckmann", "Edda", "Edwardian Script ITC", "Elephant", "Engravers MT", "Enviro", "Eras ITC", "Estrangelo Edessa", "EucrosiaUPC", "Euphemia", "Eurostile", "FangSong", "Felix Titling", "Fine Hand", "Fixed Miriam Transparent", "Flexure", "Footlight MT", "Forte", "Franklin Gothic", "Franklin Gothic Medium", "FrankRuehl", "FreesiaUPC", "Freestyle Script", "French Script MT", "Futura", "Gabriola", "Gadugi", "Garamond", "Garamond MT", "Gautami", "Georgia", "Georgia Ref", "Gigi", "Gill Sans MT", "Gill Sans MT Condensed", "Gisha", "Gloucester", "Goudy Old Style", "Goudy Stout", "Gradl", "Gulim", "GulimChe", "Gungsuh", "GungsuhChe", "Haettenschweiler", "Harlow Solid Italic", "Harrington", "High Tower Text", "Holidays MT", "Impact", "Imprint MT Shadow", "Informal Roman", "IrisUPC", "Iskoola Pota", "JasmineUPC", "Jokerman", "Juice ITC", "KaiTi", "Kalinga", "Kartika", "Keystrokes MT", "Khmer UI", "Kino MT", "KodchiangUPC", "Kokila", "Kristen ITC", "Kunstler Script", "Lao UI", "Latha", "LCD", "Leelawadee", "Levenim MT", "LilyUPC", "Lucida Blackletter", "Lucida Bright", "Lucida Bright Math", "Lucida Calligraphy", "Lucida Console", "Lucida Fax", "Lucida Handwriting", "Lucida Sans", "Lucida Sans Typewriter", "Lucida Sans Unicode", "Magneto", "Maiandra GD", "Malgun Gothic", "Mangal", "Map Symbols", "Marlett", "Matisse ITC", "Matura MT Script Capitals", "McZee", "Mead Bold", "Meiryo", "Meiryo UI", "Mercurius Script MT Bold", "Microsoft Himalaya", "Microsoft JhengHei", "Microsoft JhengHei UI", "Microsoft New Tai Lue", "Microsoft PhagsPa", "Microsoft Sans Serif", "Microsoft Tai Le", "Microsoft Uighur", "Microsoft YaHei", "Microsoft YaHei UI", "Microsoft Yi Baiti", "MingLiU", "MingLiU_HKSCS", "MingLiU_HKSCS-ExtB", "MingLiU-ExtB", "Minion Web", "Miriam", "Miriam Fixed", "Mistral", "Modern No. 20", "Mongolian Baiti", "Monotype Corsiva", "Monotype Sorts", "Monotype.com", "MoolBoran", "MS Gothic", "MS LineDraw", "MS Mincho", "MS Outlook", "MS PGothic", "MS PMincho", "MS Reference", "MS UI Gothic", "MT Extra", "MV Boli", "Myanmar Text", "Narkisim", "New Caledonia", "News Gothic MT", "Niagara", "Nirmala UI", "NSimSun", "Nyala", "OCR A Extended", "OCRB", "OCR-B-Digits", "Old English Text MT", "Onyx", "Palace Script MT", "Palatino Linotype", "Papyrus", "Parade", "Parchment", "Parties MT", "Peignot Medium", "Pepita MT", "Perpetua", "Perpetua Titling MT", "Placard Condensed", "Plantagenet Cherokee", "Playbill", "PMingLiU", "PMingLiU-ExtB", "Poor Richard", "Pristina", "Raavi", "Rage Italic", "Ransom", "Ravie", "RefSpecialty", "Rockwell", "Rockwell Condensed", "Rockwell Extra Bold", "Rod", "Runic MT Condensed", "Sakkal Majalla", "Script MT Bold", "Segoe Chess", "Segoe Print", "Segoe Pseudo", "Segoe Script", "Segoe UI", "Segoe UI Symbol", "Shonar Bangla", "Showcard Gothic", "Shruti", "Signs MT", "SimHei", "Simplified Arabic", "Simplified Arabic Fixed", "SimSun", "SimSun-ExtB", "Snap ITC", "Sports MT", "Stencil", "Stop", "Sylfaen", "Symbol", "Tahoma", "Temp Installer Font", "Tempo Grunge", "Tempus Sans ITC", "Times New Roman", "Times New Roman Special", "Traditional Arabic", "Transport MT", "Trebuchet MS", "Tunga", "Tw Cen MT", "Tw Cen MT Condensed", "Urdu Typesetting", "Utsaah", "Vacation MT", "Vani", "Verdana", "Verdana Ref", "Vijaya", "Viner Hand ITC", "Vivaldi", "Vixar ASCI", "Vladimir Script", "Vrinda", "Webdings", "Westminster", "Wide Latin", "Wingdings"})
        Me.cboxFontFamily.Location = New System.Drawing.Point(3, 3)
        Me.cboxFontFamily.Name = "cboxFontFamily"
        Me.cboxFontFamily.Size = New System.Drawing.Size(172, 24)
        Me.cboxFontFamily.TabIndex = 15
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.Enabled = False
        Me.btnAlignCenter.ImageIndex = 7
        Me.btnAlignCenter.ImageList = Me.ImageList1
        Me.btnAlignCenter.Location = New System.Drawing.Point(268, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(40, 34)
        Me.btnAlignCenter.TabIndex = 4
        Me.btnAlignCenter.Text = " "
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignLeft.Enabled = False
        Me.btnAlignLeft.ImageIndex = 8
        Me.btnAlignLeft.ImageList = Me.ImageList1
        Me.btnAlignLeft.Location = New System.Drawing.Point(228, 0)
        Me.btnAlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(40, 34)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.Text = " "
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.Enabled = False
        Me.btnAlignRight.ImageIndex = 9
        Me.btnAlignRight.ImageList = Me.ImageList1
        Me.btnAlignRight.Location = New System.Drawing.Point(308, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(45, 34)
        Me.btnAlignRight.TabIndex = 5
        Me.btnAlignRight.Text = " "
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnBold, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnItalic, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnUnderline, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 37)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(172, 38)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'btnBold
        '
        Me.btnBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBold.Enabled = False
        Me.btnBold.ImageIndex = 0
        Me.btnBold.ImageList = Me.ImageList1
        Me.btnBold.Location = New System.Drawing.Point(80, 0)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(40, 38)
        Me.btnBold.TabIndex = 7
        Me.btnBold.Text = " "
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'btnItalic
        '
        Me.btnItalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnItalic.Enabled = False
        Me.btnItalic.ImageIndex = 5
        Me.btnItalic.ImageList = Me.ImageList1
        Me.btnItalic.Location = New System.Drawing.Point(40, 0)
        Me.btnItalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(40, 38)
        Me.btnItalic.TabIndex = 6
        Me.btnItalic.Text = " "
        Me.btnItalic.UseVisualStyleBackColor = True
        '
        'btnUnderline
        '
        Me.btnUnderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUnderline.Enabled = False
        Me.btnUnderline.ImageIndex = 10
        Me.btnUnderline.ImageList = Me.ImageList1
        Me.btnUnderline.Location = New System.Drawing.Point(0, 0)
        Me.btnUnderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(40, 38)
        Me.btnUnderline.TabIndex = 4
        Me.btnUnderline.Text = " "
        Me.btnUnderline.UseVisualStyleBackColor = True
        '
        'txtSlideId
        '
        Me.txtSlideId.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSlideId.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlideId.Location = New System.Drawing.Point(0, 190)
        Me.txtSlideId.Multiline = True
        Me.txtSlideId.Name = "txtSlideId"
        Me.txtSlideId.ReadOnly = True
        Me.txtSlideId.Size = New System.Drawing.Size(353, 33)
        Me.txtSlideId.TabIndex = 2
        Me.txtSlideId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(353, 262)
        Me.txtNotes.TabIndex = 1
        Me.txtNotes.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DimGray
        Me.TabPage2.Controls.Add(Me.btnTest)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(359, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Picture Format"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(96, 79)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(110, 72)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'rightpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "rightpanel"
        Me.Size = New System.Drawing.Size(367, 521)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAlignCenter As System.Windows.Forms.Button
    Friend WithEvents btnAlignRight As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSlideId As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents cboxFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboxFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAlignLeft As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnBold As System.Windows.Forms.Button
    Friend WithEvents btnItalic As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnUnderline As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
