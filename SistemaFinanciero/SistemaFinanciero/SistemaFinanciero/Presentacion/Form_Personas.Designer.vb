<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Personas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_cedula = New System.Windows.Forms.TextBox()
        Me.t_nombre1 = New System.Windows.Forms.TextBox()
        Me.t_nombre2 = New System.Windows.Forms.TextBox()
        Me.t_apellido1 = New System.Windows.Forms.TextBox()
        Me.t_apellido2 = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.t_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre I:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre II:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido I:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apellido II:"
        '
        't_cedula
        '
        Me.t_cedula.Location = New System.Drawing.Point(75, 6)
        Me.t_cedula.Name = "t_cedula"
        Me.t_cedula.Size = New System.Drawing.Size(156, 20)
        Me.t_cedula.TabIndex = 5
        '
        't_nombre1
        '
        Me.t_nombre1.Location = New System.Drawing.Point(74, 32)
        Me.t_nombre1.Name = "t_nombre1"
        Me.t_nombre1.Size = New System.Drawing.Size(157, 20)
        Me.t_nombre1.TabIndex = 6
        '
        't_nombre2
        '
        Me.t_nombre2.Location = New System.Drawing.Point(75, 58)
        Me.t_nombre2.Name = "t_nombre2"
        Me.t_nombre2.Size = New System.Drawing.Size(156, 20)
        Me.t_nombre2.TabIndex = 7
        '
        't_apellido1
        '
        Me.t_apellido1.Location = New System.Drawing.Point(75, 84)
        Me.t_apellido1.Name = "t_apellido1"
        Me.t_apellido1.Size = New System.Drawing.Size(156, 20)
        Me.t_apellido1.TabIndex = 8
        '
        't_apellido2
        '
        Me.t_apellido2.Location = New System.Drawing.Point(74, 110)
        Me.t_apellido2.Name = "t_apellido2"
        Me.t_apellido2.Size = New System.Drawing.Size(157, 20)
        Me.t_apellido2.TabIndex = 9
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(156, 149)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(12, 149)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(105, 23)
        Me.btn_guardar.TabIndex = 12
        Me.btn_guardar.Text = "Guardar/Actualizar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        't_id
        '
        Me.t_id.AutoSize = True
        Me.t_id.Location = New System.Drawing.Point(237, 9)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(13, 13)
        Me.t_id.TabIndex = 14
        Me.t_id.Text = "0"
        '
        'Form_Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 207)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.t_apellido2)
        Me.Controls.Add(Me.t_apellido1)
        Me.Controls.Add(Me.t_nombre2)
        Me.Controls.Add(Me.t_nombre1)
        Me.Controls.Add(Me.t_cedula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Personas"
        Me.Text = "Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents t_cedula As System.Windows.Forms.TextBox
    Friend WithEvents t_nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents t_nombre2 As System.Windows.Forms.TextBox
    Friend WithEvents t_apellido1 As System.Windows.Forms.TextBox
    Friend WithEvents t_apellido2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents t_id As System.Windows.Forms.Label
End Class
