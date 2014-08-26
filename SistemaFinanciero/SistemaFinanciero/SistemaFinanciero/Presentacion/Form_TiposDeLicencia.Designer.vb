<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TiposDeLicencia
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_guardar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_salir = New DevComponents.DotNetBar.ButtonX()
        Me.t_tipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipos"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'btn_guardar
        '
        Me.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_guardar.Location = New System.Drawing.Point(13, 55)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar"
        '
        'btn_salir
        '
        Me.btn_salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_salir.Location = New System.Drawing.Point(139, 55)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "Salir"
        '
        't_tipo
        '
        '
        '
        '
        Me.t_tipo.Border.Class = "TextBoxBorder"
        Me.t_tipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t_tipo.Location = New System.Drawing.Point(50, 14)
        Me.t_tipo.Name = "t_tipo"
        Me.t_tipo.PreventEnterBeep = True
        Me.t_tipo.Size = New System.Drawing.Size(164, 20)
        Me.t_tipo.TabIndex = 10
        '
        'Form_TiposDeLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 106)
        Me.Controls.Add(Me.t_tipo)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form_TiposDeLicencia"
        Me.Text = "Tipos De Licencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_guardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_salir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents t_tipo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
