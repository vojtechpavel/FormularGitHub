<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonZmenPozadi = New System.Windows.Forms.Button()
        Me.ButtonZmenProgressBar = New System.Windows.Forms.Button()
        Me.ButtonPridejBarvy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonZmenPozadi
        '
        Me.ButtonZmenPozadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonZmenPozadi.Location = New System.Drawing.Point(281, 42)
        Me.ButtonZmenPozadi.Name = "ButtonZmenPozadi"
        Me.ButtonZmenPozadi.Size = New System.Drawing.Size(208, 85)
        Me.ButtonZmenPozadi.TabIndex = 0
        Me.ButtonZmenPozadi.Text = "Změnit Pozadí Úvodního Formu"
        Me.ButtonZmenPozadi.UseVisualStyleBackColor = True
        '
        'ButtonZmenProgressBar
        '
        Me.ButtonZmenProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonZmenProgressBar.Location = New System.Drawing.Point(281, 165)
        Me.ButtonZmenProgressBar.Name = "ButtonZmenProgressBar"
        Me.ButtonZmenProgressBar.Size = New System.Drawing.Size(208, 85)
        Me.ButtonZmenProgressBar.TabIndex = 1
        Me.ButtonZmenProgressBar.Text = "Změnit barvu ProgressBaru"
        Me.ButtonZmenProgressBar.UseVisualStyleBackColor = True
        '
        'ButtonPridejBarvy
        '
        Me.ButtonPridejBarvy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPridejBarvy.Location = New System.Drawing.Point(281, 285)
        Me.ButtonPridejBarvy.Name = "ButtonPridejBarvy"
        Me.ButtonPridejBarvy.Size = New System.Drawing.Size(208, 85)
        Me.ButtonPridejBarvy.TabIndex = 2
        Me.ButtonPridejBarvy.Text = "Přidat barvy do ComboBoxu"
        Me.ButtonPridejBarvy.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 467)
        Me.Controls.Add(Me.ButtonPridejBarvy)
        Me.Controls.Add(Me.ButtonZmenProgressBar)
        Me.Controls.Add(Me.ButtonZmenPozadi)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonZmenPozadi As Windows.Forms.Button
    Friend WithEvents ButtonZmenProgressBar As Windows.Forms.Button
    Friend WithEvents ButtonPridejBarvy As Windows.Forms.Button
End Class
