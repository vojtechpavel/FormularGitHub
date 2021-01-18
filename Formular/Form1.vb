' kvuli dialogresult
Imports System.Windows.Forms
Public Class Form1
    Public vysledek As String = ""
    Public vysledekBarvy As String = ""
    Public posuvnik As Integer          'public promenne, abych se k nim dostal
    Public vysledekTextboxu As Integer

    ' nahrani itemu do DropDown ComboBoxu pri nacteni formulare
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Clear()
            .Items.Add("hnědá")
            .Items.Add("červená")
            .Items.Add("fialová")
            .Items.Add("zelená")
            .Items.Add("modrá")
        End With

        'progress bar s timerem
        ProgressBar1.Maximum = 10000  '10 vterin
        Me.Timer1.Start() 'timer1 kvuli progress baru

        Me.Timer2.Start() 'timer2 kvuli datumu na toolstripstatusu
    End Sub
    Private Sub CheckBoxesRadioButtonsComboBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged, RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged, ComboBox1.SelectedIndexChanged, ComboBox1.TextChanged
        Dim vysledek As String = ""

        If CheckBox1.Checked = True Then
            vysledek += " delší"
        End If

        If CheckBox2.Checked = True Then
            vysledek += " vyšší"
        End If

        If CheckBox3.Checked = True Then
            vysledek += " hlubší"
        End If

        If RadioButton1.Checked = True Then
            vysledek += " dřevo"
        End If

        If RadioButton2.Checked = True Then
            vysledek += " kov"
        End If

        If RadioButton3.Checked = True Then
            vysledek += " plast"
        End If

        If RadioButton4.Checked = True Then
            vysledek += " sklo"
        End If

        'comboBox na DropDown list, musí byt  +1 (protože index začíná na -1)

        If ComboBox1.SelectedIndex + 1 Then
            vysledekBarvy = ComboBox1.Text
        Else
            vysledekBarvy = ComboBox1.Text
        End If

        Label1.Text = (vysledekTextboxu * posuvnik).ToString + vysledek + Chr(32) + vysledekBarvy

    End Sub

    'textbox, může být i možnost mínus, ale pouze na prvním místě.
    Private Sub ScitaciBox1_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles ScitaciBox1.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso System.Convert.ToByte(e.KeyChar) <> 8 AndAlso Convert.ToByte(e.KeyChar) <> 45 Then
            e.Handled = True
        ElseIf ScitaciBox1.Text.Length > 0 Then            'tento radek zajisti pozici pouze 0 pro minus
            If Not IsNumeric(e.KeyChar) AndAlso System.Convert.ToByte(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ScitaciBox2_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles ScitaciBox2.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso System.Convert.ToByte(e.KeyChar) <> 8 AndAlso Convert.ToByte(e.KeyChar) <> 45 Then
            e.Handled = True
        ElseIf ScitaciBox2.Text.Length > 0 Then            'tento radek zajisti pozici pouze 0 pro minus
            If Not IsNumeric(e.KeyChar) AndAlso System.Convert.ToByte(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    'trackbar, musi byt vzdy cely vypocet
    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        posuvnik = TrackBar1.Value
        LabelPosuvnik.Text = posuvnik
        vysledekTextboxu = Val(ScitaciBox1.Text) + Val(ScitaciBox2.Text) + (NumericUpDown1.Value)
        LabelVysledekSoucinu.Text = vysledekTextboxu * posuvnik

        Label1.Text = (vysledekTextboxu * posuvnik).ToString + vysledek + Chr(32) + vysledekBarvy
    End Sub

    'kvuli zapsani rucne
    Private Sub NumericUpDown1_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles ScitaciBox2.KeyUp, ScitaciBox1.KeyUp, NumericUpDown1.KeyUp
        vysledekTextboxu = Val(ScitaciBox1.Text) + Val(ScitaciBox2.Text) + (NumericUpDown1.Value)
        VysledekSouctu.Text = vysledekTextboxu
        LabelVysledekSoucinu.Text = vysledekTextboxu * posuvnik

        Label1.Text = (vysledekTextboxu * posuvnik).ToString + vysledek + Chr(32) + vysledekBarvy
    End Sub

    'kvuli numericu, kdyz by se klikalo pres posuvnicek / pres value changed!!!
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        vysledekTextboxu = Val(ScitaciBox1.Text) + Val(ScitaciBox2.Text) + (NumericUpDown1.Value)
        VysledekSouctu.Text = vysledekTextboxu
        LabelVysledekSoucinu.Text = vysledekTextboxu * posuvnik
        Label1.Text = (vysledekTextboxu * posuvnik).ToString + vysledek + Chr(32) + vysledekBarvy
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Toto je nápověda.")
    End Sub

    'otevreni souboru a nacteni do textboxu
    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevřítToolStripMenuItem.Click

        With TlacitkoOpen 'TlacitkoOpen akt. prvek OpenFileDialog vložený v šedém pruhu dole
            .Title = "Zvolte soubor"
            .Filter = "Všechno (*.*)|*.*|Texty (*.doc)|*.doc"
            .FilterIndex = 2
        End With

        'zajisteni aby, program nezhavaroval pri kliku storno/cancel/zrusit
        Dim tlac As DialogResult
        tlac = TlacitkoOpen.ShowDialog()
        If (tlac.Equals(DialogResult.OK)) Then
            FileOpen(1, TlacitkoOpen.FileName, OpenMode.Input)
            Input(1, TextBox1.Text) : FileClose(1)
            ToolStripStatusLabel2.Text = "Naposledy otevřený soubor: " + TlacitkoOpen.FileName
        End If
    End Sub

    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložitToolStripMenuItem.Click

        'zajisteni aby, program nezhavaroval pri kliku storno/cancel/zrusit
        Dim tlSave As DialogResult
        tlSave = TlacitkoSave.ShowDialog()
        If (tlSave.Equals(DialogResult.OK)) Then
            FileOpen(1, TlacitkoSave.FileName, OpenMode.Output)  'POZOR ZDE OUTPUT !!!!!!
            Write(1, TextBox1.Text) : FileClose(1)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value += Me.Timer1.Interval
        If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
            Me.Timer1.Stop()
        End If

        Label3.Text = ((Me.ProgressBar1.Maximum - Me.ProgressBar1.Value) / 1000).ToString + " s"
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonRestart.Click
        ProgressBar1.Value = 0  'restart pocatecni hodnoty na nulu
        Me.Timer1.Start()       'zahajeni timeru
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'aktualni cas
        ToolStripStatusLabel1.Text = "Aktuální čas: " + DateTime.Now.ToString("dddd dd. MMM yyyy HH:mm:ss")
    End Sub

    Private Sub NastaveníToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NastaveníToolStripMenuItem.Click
        Dim G As New Form2
        G.Text = "Druhy formular"
        G.Show()
    End Sub

End Class