Imports System.Drawing

Public Class Form2

    Private Sub ButtonZmenPozadi_Click(sender As Object, e As EventArgs) Handles ButtonZmenPozadi.Click
        'Me.Hide() 'pokud bych chtel schovat form2
        Form1.BackColor = Color.Red
        Form1.Show()
    End Sub

    Private Sub ButtonZmenProgressBar_Click(sender As Object, e As EventArgs) Handles ButtonZmenProgressBar.Click
        Form1.ProgressBar1.BackColor = Color.Blue
    End Sub

    Private Sub ButtonPridejBarvy_Click(sender As Object, e As EventArgs) Handles ButtonPridejBarvy.Click
        Form1.ComboBox1.Items.Add("růžová")
        Form1.ComboBox1.Items.Add("šedá")
        Form1.ComboBox1.Items.Add("žlutá")
        ButtonPridejBarvy.Hide() 'abych to tam uživatel nepřidával vícekrát
    End Sub
End Class