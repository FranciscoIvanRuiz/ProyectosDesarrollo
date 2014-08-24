<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Empresas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_ruc = New System.Windows.Forms.TextBox()
        Me.t_nombre = New System.Windows.Forms.TextBox()
        Me.t_telefono = New System.Windows.Forms.TextBox()
        Me.t_correo = New System.Windows.Forms.TextBox()
        Me.t_direccion = New System.Windows.Forms.TextBox()
        Me.t_web = New System.Windows.Forms.TextBox()
        Me.t_renta = New System.Windows.Forms.TextBox()
        Me.t_iva = New System.Windows.Forms.TextBox()
        Me.cbx_responsable = New System.Windows.Forms.ComboBox()
        Me.t_id = New System.Windows.Forms.Label()
        Me.t_responsable = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.t_fax = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Web:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Responsable:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Retiene Renta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Retiene Iva:"
        '
        't_ruc
        '
        Me.t_ruc.Location = New System.Drawing.Point(102, 2)
        Me.t_ruc.Name = "t_ruc"
        Me.t_ruc.Size = New System.Drawing.Size(189, 20)
        Me.t_ruc.TabIndex = 9
        '
        't_nombre
        '
        Me.t_nombre.Location = New System.Drawing.Point(102, 28)
        Me.t_nombre.Name = "t_nombre"
        Me.t_nombre.Size = New System.Drawing.Size(189, 20)
        Me.t_nombre.TabIndex = 10
        '
        't_telefono
        '
        Me.t_telefono.Location = New System.Drawing.Point(102, 54)
        Me.t_telefono.Name = "t_telefono"
        Me.t_telefono.Size = New System.Drawing.Size(189, 20)
        Me.t_telefono.TabIndex = 11
        '
        't_correo
        '
        Me.t_correo.Location = New System.Drawing.Point(102, 106)
        Me.t_correo.Name = "t_correo"
        Me.t_correo.Size = New System.Drawing.Size(189, 20)
        Me.t_correo.TabIndex = 12
        '
        't_direccion
        '
        Me.t_direccion.Location = New System.Drawing.Point(102, 132)
        Me.t_direccion.Name = "t_direccion"
        Me.t_direccion.Size = New System.Drawing.Size(189, 20)
        Me.t_direccion.TabIndex = 13
        '
        't_web
        '
        Me.t_web.Location = New System.Drawing.Point(102, 158)
        Me.t_web.Name = "t_web"
        Me.t_web.Size = New System.Drawing.Size(189, 20)
        Me.t_web.TabIndex = 14
        '
        't_renta
        '
        Me.t_renta.Location = New System.Drawing.Point(102, 210)
        Me.t_renta.Name = "t_renta"
        Me.t_renta.Size = New System.Drawing.Size(33, 20)
        Me.t_renta.TabIndex = 16
        '
        't_iva
        '
        Me.t_iva.Location = New System.Drawing.Point(102, 236)
        Me.t_iva.Name = "t_iva"
        Me.t_iva.Size = New System.Drawing.Size(33, 20)
        Me.t_iva.TabIndex = 17
        '
        'cbx_responsable
        '
        Me.cbx_responsable.FormattingEnabled = True
        Me.cbx_responsable.Location = New System.Drawing.Point(102, 184)
        Me.cbx_responsable.Name = "cbx_responsable"
        Me.cbx_responsable.Size = New System.Drawing.Size(189, 21)
        Me.cbx_responsable.TabIndex = 18
        '
        't_id
        '
        Me.t_id.AutoSize = True
        Me.t_id.Location = New System.Drawing.Point(297, 5)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(13, 13)
        Me.t_id.TabIndex = 19
        Me.t_id.Text = "0"
        '
        't_responsable
        '
        Me.t_responsable.AutoSize = True
        Me.t_responsable.Location = New System.Drawing.Point(297, 187)
        Me.t_responsable.Name = "t_responsable"
        Me.t_responsable.Size = New System.Drawing.Size(13, 13)
        Me.t_responsable.TabIndex = 20
        Me.t_responsable.Text = "0"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(162, 274)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 22
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(18, 274)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(105, 23)
        Me.btn_guardar.TabIndex = 21
        Me.btn_guardar.Text = "Guardar/Actualizar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Fax:"
        '
        't_fax
        '
        Me.t_fax.Location = New System.Drawing.Point(102, 80)
        Me.t_fax.Name = "t_fax"
        Me.t_fax.Size = New System.Drawing.Size(189, 20)
        Me.t_fax.TabIndex = 24
        '
        'Form_Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 331)
        Me.Controls.Add(Me.t_fax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.t_responsable)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.cbx_responsable)
        Me.Controls.Add(Me.t_iva)
        Me.Controls.Add(Me.t_renta)
        Me.Controls.Add(Me.t_web)
        Me.Controls.Add(Me.t_direccion)
        Me.Controls.Add(Me.t_correo)
        Me.Controls.Add(Me.t_telefono)
        Me.Controls.Add(Me.t_nombre)
        Me.Controls.Add(Me.t_ruc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Empresas"
        Me.Text = "Empresas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents t_ruc As System.Windows.Forms.TextBox
    Friend WithEvents t_nombre As System.Windows.Forms.TextBox
    Friend WithEvents t_telefono As System.Windows.Forms.TextBox
    Friend WithEvents t_correo As System.Windows.Forms.TextBox
    Friend WithEvents t_direccion As System.Windows.Forms.TextBox
    Friend WithEvents t_web As System.Windows.Forms.TextBox
    Friend WithEvents t_renta As System.Windows.Forms.TextBox
    Friend WithEvents t_iva As System.Windows.Forms.TextBox
    Friend WithEvents cbx_responsable As System.Windows.Forms.ComboBox
    Friend WithEvents t_id As System.Windows.Forms.Label
    Friend WithEvents t_responsable As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents t_fax As System.Windows.Forms.TextBox
End Class
