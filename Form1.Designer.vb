<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSayIt = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbVoice = New System.Windows.Forms.ComboBox()
        Me.btnReloadVoices = New System.Windows.Forms.Button()
        Me.btnSrcFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSrcFile = New System.Windows.Forms.TextBox()
        Me.btnProcessTextFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.btnChapters = New System.Windows.Forms.Button()
        Me.txtTestFile = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.selHighlight = New System.Windows.Forms.ComboBox()
        Me.chkPlayOnKeyUp = New System.Windows.Forms.CheckBox()
        Me.chkBackupFile = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStopPlay = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSilence = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.selSilence = New System.Windows.Forms.ComboBox()
        Me.btnReGenerate = New System.Windows.Forms.Button()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.btn192Bitrate = New System.Windows.Forms.Button()
        Me.btnYouTubeIndex = New System.Windows.Forms.Button()
        Me.btnChangeVolume = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImageFile = New System.Windows.Forms.TextBox()
        Me.btnImageFile = New System.Windows.Forms.Button()
        Me.btnMakeVideos = New System.Windows.Forms.Button()
        Me.btnMakeVideo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnApiKeyShow = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.urlApiKey = New System.Windows.Forms.LinkLabel()
        Me.chkImageText = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSayIt
        '
        Me.btnSayIt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSayIt.Location = New System.Drawing.Point(1601, 10)
        Me.btnSayIt.Name = "btnSayIt"
        Me.btnSayIt.Size = New System.Drawing.Size(64, 60)
        Me.btnSayIt.TabIndex = 0
        Me.btnSayIt.Text = "Say It"
        Me.btnSayIt.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.Location = New System.Drawing.Point(5, 41)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(1590, 26)
        Me.txtText.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Voice"
        '
        'cbVoice
        '
        Me.cbVoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVoice.FormattingEnabled = True
        Me.cbVoice.Items.AddRange(New Object() {"Antoni"})
        Me.cbVoice.Location = New System.Drawing.Point(135, 136)
        Me.cbVoice.Name = "cbVoice"
        Me.cbVoice.Size = New System.Drawing.Size(1488, 28)
        Me.cbVoice.TabIndex = 11
        '
        'btnReloadVoices
        '
        Me.btnReloadVoices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReloadVoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadVoices.Location = New System.Drawing.Point(1631, 128)
        Me.btnReloadVoices.Name = "btnReloadVoices"
        Me.btnReloadVoices.Size = New System.Drawing.Size(42, 40)
        Me.btnReloadVoices.TabIndex = 13
        Me.btnReloadVoices.Text = "..."
        Me.btnReloadVoices.UseVisualStyleBackColor = True
        '
        'btnSrcFile
        '
        Me.btnSrcFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSrcFile.Location = New System.Drawing.Point(1631, 51)
        Me.btnSrcFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSrcFile.Name = "btnSrcFile"
        Me.btnSrcFile.Size = New System.Drawing.Size(42, 35)
        Me.btnSrcFile.TabIndex = 16
        Me.btnSrcFile.Text = "..."
        Me.btnSrcFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Text File Path"
        '
        'txtSrcFile
        '
        Me.txtSrcFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrcFile.Location = New System.Drawing.Point(135, 55)
        Me.txtSrcFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSrcFile.Name = "txtSrcFile"
        Me.txtSrcFile.Size = New System.Drawing.Size(1488, 26)
        Me.txtSrcFile.TabIndex = 14
        '
        'btnProcessTextFile
        '
        Me.btnProcessTextFile.Location = New System.Drawing.Point(24, 174)
        Me.btnProcessTextFile.Name = "btnProcessTextFile"
        Me.btnProcessTextFile.Size = New System.Drawing.Size(173, 48)
        Me.btnProcessTextFile.TabIndex = 17
        Me.btnProcessTextFile.Text = "1. Process Text File"
        Me.btnProcessTextFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 296)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1587, 22)
        Me.ProgressBar1.TabIndex = 18
        Me.ProgressBar1.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(1611, 296)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(61, 25)
        Me.btnStop.TabIndex = 19
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "API key"
        '
        'txtApiKey
        '
        Me.txtApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApiKey.Location = New System.Drawing.Point(135, 14)
        Me.txtApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(1488, 26)
        Me.txtApiKey.TabIndex = 20
        '
        'lbCount
        '
        Me.lbCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCount.AutoSize = True
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.Location = New System.Drawing.Point(1527, 182)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(31, 32)
        Me.lbCount.TabIndex = 22
        Me.lbCount.Text = "0"
        Me.lbCount.Visible = False
        '
        'btnChapters
        '
        Me.btnChapters.Location = New System.Drawing.Point(202, 174)
        Me.btnChapters.Name = "btnChapters"
        Me.btnChapters.Size = New System.Drawing.Size(178, 48)
        Me.btnChapters.TabIndex = 24
        Me.btnChapters.Text = "2. MP3 Chapters"
        Me.btnChapters.UseVisualStyleBackColor = True
        '
        'txtTestFile
        '
        Me.txtTestFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTestFile.Location = New System.Drawing.Point(606, 5)
        Me.txtTestFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTestFile.Name = "txtTestFile"
        Me.txtTestFile.Size = New System.Drawing.Size(988, 26)
        Me.txtTestFile.TabIndex = 25
        Me.txtTestFile.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.selHighlight)
        Me.Panel1.Controls.Add(Me.txtText)
        Me.Panel1.Controls.Add(Me.chkPlayOnKeyUp)
        Me.Panel1.Controls.Add(Me.txtTestFile)
        Me.Panel1.Controls.Add(Me.btnSayIt)
        Me.Panel1.Location = New System.Drawing.Point(10, 757)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1665, 70)
        Me.Panel1.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Highlight text when"
        '
        'selHighlight
        '
        Me.selHighlight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.selHighlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selHighlight.FormattingEnabled = True
        Me.selHighlight.Items.AddRange(New Object() {"Begins with number", "Contains number", "Begins with lower case character"})
        Me.selHighlight.Location = New System.Drawing.Point(322, 5)
        Me.selHighlight.Name = "selHighlight"
        Me.selHighlight.Size = New System.Drawing.Size(276, 28)
        Me.selHighlight.TabIndex = 35
        '
        'chkPlayOnKeyUp
        '
        Me.chkPlayOnKeyUp.AutoSize = True
        Me.chkPlayOnKeyUp.Location = New System.Drawing.Point(5, 10)
        Me.chkPlayOnKeyUp.Name = "chkPlayOnKeyUp"
        Me.chkPlayOnKeyUp.Size = New System.Drawing.Size(136, 24)
        Me.chkPlayOnKeyUp.TabIndex = 28
        Me.chkPlayOnKeyUp.Text = "Play on key up"
        Me.chkPlayOnKeyUp.UseVisualStyleBackColor = True
        '
        'chkBackupFile
        '
        Me.chkBackupFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBackupFile.AutoSize = True
        Me.chkBackupFile.Location = New System.Drawing.Point(366, 396)
        Me.chkBackupFile.Name = "chkBackupFile"
        Me.chkBackupFile.Size = New System.Drawing.Size(143, 24)
        Me.chkBackupFile.TabIndex = 29
        Me.chkBackupFile.Text = "Backup text file"
        Me.chkBackupFile.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(949, 419)
        Me.DataGridView1.TabIndex = 27
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(8, 3)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(246, 48)
        Me.btnPlay.TabIndex = 28
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStopPlay
        '
        Me.btnStopPlay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopPlay.Enabled = False
        Me.btnStopPlay.Location = New System.Drawing.Point(264, 3)
        Me.btnStopPlay.Name = "btnStopPlay"
        Me.btnStopPlay.Size = New System.Drawing.Size(434, 48)
        Me.btnStopPlay.TabIndex = 29
        Me.btnStopPlay.Text = "Stop"
        Me.btnStopPlay.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(8, 57)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(246, 48)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtLine
        '
        Me.txtLine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine.Location = New System.Drawing.Point(5, 111)
        Me.txtLine.Multiline = True
        Me.txtLine.Name = "txtLine"
        Me.txtLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLine.Size = New System.Drawing.Size(693, 277)
        Me.txtLine.TabIndex = 26
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(15, 326)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkBackupFile)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSilence)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.selSilence)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnReGenerate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLine)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPlay)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStopPlay)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Size = New System.Drawing.Size(1660, 425)
        Me.SplitContainer1.SplitterDistance = 955
        Me.SplitContainer1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Silence"
        '
        'btnSilence
        '
        Me.btnSilence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSilence.Location = New System.Drawing.Point(292, 394)
        Me.btnSilence.Name = "btnSilence"
        Me.btnSilence.Size = New System.Drawing.Size(43, 28)
        Me.btnSilence.TabIndex = 33
        Me.btnSilence.Text = ">"
        Me.btnSilence.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(515, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 37)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save Text File"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'selSilence
        '
        Me.selSilence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.selSilence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selSilence.FormattingEnabled = True
        Me.selSilence.Items.AddRange(New Object() {"100ms", "200ms", "300ms", "500ms", "600ms", "700ms", "800ms", "900ms", "1sec"})
        Me.selSilence.Location = New System.Drawing.Point(71, 394)
        Me.selSilence.Name = "selSilence"
        Me.selSilence.Size = New System.Drawing.Size(215, 28)
        Me.selSilence.TabIndex = 32
        '
        'btnReGenerate
        '
        Me.btnReGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReGenerate.Location = New System.Drawing.Point(264, 57)
        Me.btnReGenerate.Name = "btnReGenerate"
        Me.btnReGenerate.Size = New System.Drawing.Size(434, 48)
        Me.btnReGenerate.TabIndex = 31
        Me.btnReGenerate.Text = "Regenerate"
        Me.btnReGenerate.UseVisualStyleBackColor = True
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(6, 20)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(172, 42)
        Me.btnMerge.TabIndex = 33
        Me.btnMerge.Text = "Make MP3 File"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'btn192Bitrate
        '
        Me.btn192Bitrate.Location = New System.Drawing.Point(6, 20)
        Me.btn192Bitrate.Name = "btn192Bitrate"
        Me.btn192Bitrate.Size = New System.Drawing.Size(178, 42)
        Me.btn192Bitrate.TabIndex = 34
        Me.btn192Bitrate.Text = "Make192 Bitrate files"
        Me.btn192Bitrate.UseVisualStyleBackColor = True
        '
        'btnYouTubeIndex
        '
        Me.btnYouTubeIndex.Location = New System.Drawing.Point(368, 20)
        Me.btnYouTubeIndex.Name = "btnYouTubeIndex"
        Me.btnYouTubeIndex.Size = New System.Drawing.Size(178, 42)
        Me.btnYouTubeIndex.TabIndex = 35
        Me.btnYouTubeIndex.Text = "YouTube Index"
        Me.btnYouTubeIndex.UseVisualStyleBackColor = True
        '
        'btnChangeVolume
        '
        Me.btnChangeVolume.Location = New System.Drawing.Point(190, 17)
        Me.btnChangeVolume.Name = "btnChangeVolume"
        Me.btnChangeVolume.Size = New System.Drawing.Size(178, 45)
        Me.btnChangeVolume.TabIndex = 36
        Me.btnChangeVolume.Text = "Change Volume"
        Me.btnChangeVolume.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Image File Path"
        '
        'txtImageFile
        '
        Me.txtImageFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImageFile.Location = New System.Drawing.Point(135, 95)
        Me.txtImageFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImageFile.Name = "txtImageFile"
        Me.txtImageFile.Size = New System.Drawing.Size(1375, 26)
        Me.txtImageFile.TabIndex = 38
        '
        'btnImageFile
        '
        Me.btnImageFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImageFile.Location = New System.Drawing.Point(1631, 91)
        Me.btnImageFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImageFile.Name = "btnImageFile"
        Me.btnImageFile.Size = New System.Drawing.Size(42, 35)
        Me.btnImageFile.TabIndex = 39
        Me.btnImageFile.Text = "..."
        Me.btnImageFile.UseVisualStyleBackColor = True
        '
        'btnMakeVideos
        '
        Me.btnMakeVideos.Location = New System.Drawing.Point(386, 174)
        Me.btnMakeVideos.Name = "btnMakeVideos"
        Me.btnMakeVideos.Size = New System.Drawing.Size(178, 48)
        Me.btnMakeVideos.TabIndex = 40
        Me.btnMakeVideos.Text = "3. MP4 Videos"
        Me.btnMakeVideos.UseVisualStyleBackColor = True
        '
        'btnMakeVideo
        '
        Me.btnMakeVideo.Location = New System.Drawing.Point(184, 20)
        Me.btnMakeVideo.Name = "btnMakeVideo"
        Me.btnMakeVideo.Size = New System.Drawing.Size(178, 42)
        Me.btnMakeVideo.TabIndex = 41
        Me.btnMakeVideo.Text = "Make Video File"
        Me.btnMakeVideo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMerge)
        Me.GroupBox1.Controls.Add(Me.btnYouTubeIndex)
        Me.GroupBox1.Controls.Add(Me.btnMakeVideo)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 68)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Single File (mp3 or mp4)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn192Bitrate)
        Me.GroupBox2.Controls.Add(Me.btnChangeVolume)
        Me.GroupBox2.Location = New System.Drawing.Point(593, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 68)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audible (acx.com)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(724, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Each paragraph must be on one line.  There is a 0.3 second pause between paragrap" &
    "hs.  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(624, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "One blank line means 1 second pause.  Two blank lines means new Chapter. "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(593, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(792, 55)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'btnApiKeyShow
        '
        Me.btnApiKeyShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApiKeyShow.Location = New System.Drawing.Point(1631, 10)
        Me.btnApiKeyShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApiKeyShow.Name = "btnApiKeyShow"
        Me.btnApiKeyShow.Size = New System.Drawing.Size(42, 35)
        Me.btnApiKeyShow.TabIndex = 48
        Me.btnApiKeyShow.Text = "*"
        Me.btnApiKeyShow.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'urlApiKey
        '
        Me.urlApiKey.AutoSize = True
        Me.urlApiKey.Location = New System.Drawing.Point(77, 14)
        Me.urlApiKey.Name = "urlApiKey"
        Me.urlApiKey.Size = New System.Drawing.Size(18, 20)
        Me.urlApiKey.TabIndex = 49
        Me.urlApiKey.TabStop = True
        Me.urlApiKey.Text = "?"
        '
        'chkImageText
        '
        Me.chkImageText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImageText.AutoSize = True
        Me.chkImageText.Location = New System.Drawing.Point(1526, 97)
        Me.chkImageText.Name = "chkImageText"
        Me.chkImageText.Size = New System.Drawing.Size(98, 24)
        Me.chkImageText.TabIndex = 50
        Me.chkImageText.Text = "Add Text"
        Me.chkImageText.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1687, 837)
        Me.Controls.Add(Me.chkImageText)
        Me.Controls.Add(Me.urlApiKey)
        Me.Controls.Add(Me.btnApiKeyShow)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMakeVideos)
        Me.Controls.Add(Me.btnImageFile)
        Me.Controls.Add(Me.txtImageFile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnChapters)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnProcessTextFile)
        Me.Controls.Add(Me.btnSrcFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSrcFile)
        Me.Controls.Add(Me.btnReloadVoices)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbVoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Audio Book Creator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSayIt As Button
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbVoice As ComboBox
    Friend WithEvents btnReloadVoices As Button
    Friend WithEvents btnSrcFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSrcFile As TextBox
    Friend WithEvents btnProcessTextFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnStop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApiKey As TextBox
    Friend WithEvents lbCount As Label
    Friend WithEvents btnChapters As Button
    Friend WithEvents txtTestFile As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStopPlay As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtLine As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents chkPlayOnKeyUp As CheckBox
    Friend WithEvents btnReGenerate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSilence As Button
    Friend WithEvents selSilence As ComboBox
    Friend WithEvents chkBackupFile As CheckBox
    Friend WithEvents btnMerge As Button
    Friend WithEvents btn192Bitrate As Button
    Friend WithEvents btnYouTubeIndex As Button
    Friend WithEvents btnChangeVolume As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtImageFile As TextBox
    Friend WithEvents btnImageFile As Button
    Friend WithEvents btnMakeVideos As Button
    Friend WithEvents btnMakeVideo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnApiKeyShow As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents selHighlight As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents urlApiKey As LinkLabel
    Friend WithEvents chkImageText As CheckBox
End Class
