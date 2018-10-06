<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGrados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGrados
        '
        Me.btnGrados.Location = New System.Drawing.Point(242, 216)
        Me.btnGrados.Name = "btnGrados"
        Me.btnGrados.Size = New System.Drawing.Size(75, 23)
        Me.btnGrados.TabIndex = 0
        Me.btnGrados.Text = "Grados"
        Me.btnGrados.UseVisualStyleBackColor = True
        '
        'Menuvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 304)
        Me.Controls.Add(Me.btnGrados)
        Me.Name = "Menuvb"
        Me.Text = "Menuvb"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGrados As Button
End Class
