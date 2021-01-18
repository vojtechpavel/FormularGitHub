<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonRestart = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NastaveníToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ScitaciBox1 = New System.Windows.Forms.TextBox()
        Me.ScitaciBox2 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabelPosuvnik = New System.Windows.Forms.Label()
        Me.VysledekSouctu = New System.Windows.Forms.Label()
        Me.LabelTrackBar = New System.Windows.Forms.Label()
        Me.LabelSoucetCisel = New System.Windows.Forms.Label()
        Me.LabelSoucetKratTrackBar = New System.Windows.Forms.Label()
        Me.LabelVysledekSoucinu = New System.Windows.Forms.Label()
        Me.TlacitkoOpen = New System.Windows.Forms.OpenFileDialog()
        Me.TlacitkoSave = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(444, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(446, 203)
        Me.TextBox1.TabIndex = 0
        '
        'ButtonRestart
        '
        Me.ButtonRestart.BackgroundImage = CType(resources.GetObject("ButtonRestart.BackgroundImage"), System.Drawing.Image)
        Me.ButtonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonRestart.Location = New System.Drawing.Point(771, 395)
        Me.ButtonRestart.Name = "ButtonRestart"
        Me.ButtonRestart.Size = New System.Drawing.Size(63, 58)
        Me.ButtonRestart.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ButtonRestart, "Tlačítko s obrázkem")
        Me.ButtonRestart.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 326)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Yellow
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(103, 202)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(260, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.TickFrequency = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(56, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "dřevo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(56, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "kov"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(56, 79)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "plast"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(56, 102)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "sklo"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(690, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 143)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Materiál"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(923, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložitToolStripMenuItem, Me.NastaveníToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "&Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.OtevřítToolStripMenuItem.Text = "&Otevřít"
        '
        'UložitToolStripMenuItem
        '
        Me.UložitToolStripMenuItem.Name = "UložitToolStripMenuItem"
        Me.UložitToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.UložitToolStripMenuItem.Text = "&Uložit"
        '
        'NastaveníToolStripMenuItem
        '
        Me.NastaveníToolStripMenuItem.Name = "NastaveníToolStripMenuItem"
        Me.NastaveníToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NastaveníToolStripMenuItem.Text = "Nastavení"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(589, 280)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "delší"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(589, 303)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "vyšší"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(589, 326)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "hlubší"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ScitaciBox1
        '
        Me.ScitaciBox1.Location = New System.Drawing.Point(103, 118)
        Me.ScitaciBox1.Name = "ScitaciBox1"
        Me.ScitaciBox1.Size = New System.Drawing.Size(31, 20)
        Me.ScitaciBox1.TabIndex = 14
        '
        'ScitaciBox2
        '
        Me.ScitaciBox2.Location = New System.Drawing.Point(163, 118)
        Me.ScitaciBox2.Name = "ScitaciBox2"
        Me.ScitaciBox2.Size = New System.Drawing.Size(31, 20)
        Me.ScitaciBox2.TabIndex = 15
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(216, 119)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(147, 20)
        Me.NumericUpDown1.TabIndex = 16
        '
        'LabelPosuvnik
        '
        Me.LabelPosuvnik.AutoSize = True
        Me.LabelPosuvnik.Location = New System.Drawing.Point(279, 250)
        Me.LabelPosuvnik.Name = "LabelPosuvnik"
        Me.LabelPosuvnik.Size = New System.Drawing.Size(0, 13)
        Me.LabelPosuvnik.TabIndex = 17
        '
        'VysledekSouctu
        '
        Me.VysledekSouctu.AutoSize = True
        Me.VysledekSouctu.Location = New System.Drawing.Point(176, 163)
        Me.VysledekSouctu.Name = "VysledekSouctu"
        Me.VysledekSouctu.Size = New System.Drawing.Size(0, 13)
        Me.VysledekSouctu.TabIndex = 18
        '
        'LabelTrackBar
        '
        Me.LabelTrackBar.AutoSize = True
        Me.LabelTrackBar.Location = New System.Drawing.Point(150, 250)
        Me.LabelTrackBar.Name = "LabelTrackBar"
        Me.LabelTrackBar.Size = New System.Drawing.Size(123, 13)
        Me.LabelTrackBar.TabIndex = 19
        Me.LabelTrackBar.Text = "Posuvníkem nastaveno:"
        '
        'LabelSoucetCisel
        '
        Me.LabelSoucetCisel.AutoSize = True
        Me.LabelSoucetCisel.Location = New System.Drawing.Point(100, 163)
        Me.LabelSoucetCisel.Name = "LabelSoucetCisel"
        Me.LabelSoucetCisel.Size = New System.Drawing.Size(70, 13)
        Me.LabelSoucetCisel.TabIndex = 20
        Me.LabelSoucetCisel.Text = "Součet čísel:"
        '
        'LabelSoucetKratTrackBar
        '
        Me.LabelSoucetKratTrackBar.AutoSize = True
        Me.LabelSoucetKratTrackBar.Location = New System.Drawing.Point(100, 294)
        Me.LabelSoucetKratTrackBar.Name = "LabelSoucetKratTrackBar"
        Me.LabelSoucetKratTrackBar.Size = New System.Drawing.Size(104, 13)
        Me.LabelSoucetKratTrackBar.TabIndex = 21
        Me.LabelSoucetKratTrackBar.Text = "Součet * TrackBar ="
        '
        'LabelVysledekSoucinu
        '
        Me.LabelVysledekSoucinu.AutoSize = True
        Me.LabelVysledekSoucinu.Location = New System.Drawing.Point(230, 294)
        Me.LabelVysledekSoucinu.Name = "LabelVysledekSoucinu"
        Me.LabelVysledekSoucinu.Size = New System.Drawing.Size(0, 13)
        Me.LabelVysledekSoucinu.TabIndex = 22
        '
        'TlacitkoOpen
        '
        Me.TlacitkoOpen.FileName = "TlacitkoOpen"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(103, 395)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(644, 44)
        Me.ProgressBar1.TabIndex = 23
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(923, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "Time"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Progress bar bude běžet ještě:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 523)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelVysledekSoucinu)
        Me.Controls.Add(Me.LabelSoucetKratTrackBar)
        Me.Controls.Add(Me.LabelSoucetCisel)
        Me.Controls.Add(Me.LabelTrackBar)
        Me.Controls.Add(Me.VysledekSouctu)
        Me.Controls.Add(Me.LabelPosuvnik)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ScitaciBox2)
        Me.Controls.Add(Me.ScitaciBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonRestart)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents ButtonRestart As Windows.Forms.Button
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As Windows.Forms.CheckBox
    Friend WithEvents ScitaciBox1 As Windows.Forms.TextBox
    Friend WithEvents ScitaciBox2 As Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents LabelPosuvnik As Windows.Forms.Label
    Friend WithEvents VysledekSouctu As Windows.Forms.Label
    Friend WithEvents LabelTrackBar As Windows.Forms.Label
    Friend WithEvents LabelSoucetCisel As Windows.Forms.Label
    Friend WithEvents LabelSoucetKratTrackBar As Windows.Forms.Label
    Friend WithEvents LabelVysledekSoucinu As Windows.Forms.Label
    Friend WithEvents TlacitkoOpen As Windows.Forms.OpenFileDialog
    Friend WithEvents TlacitkoSave As Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents NastaveníToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
