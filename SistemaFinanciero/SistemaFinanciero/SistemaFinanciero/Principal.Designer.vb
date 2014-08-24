<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DatosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeSangreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeLicenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeComunicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosRRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosGeneralesToolStripMenuItem, Me.DatosRRHHToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(828, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 310)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel1.Text = "..."
        '
        'DatosGeneralesToolStripMenuItem
        '
        Me.DatosGeneralesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeSangreToolStripMenuItem, Me.TiposDeLicenciaToolStripMenuItem, Me.TiposDeComunicacionToolStripMenuItem, Me.ToolStripMenuItem1, Me.BuscarPersonasToolStripMenuItem, Me.PersonasToolStripMenuItem, Me.ToolStripMenuItem2, Me.BuscarEmpresasToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.ToolStripMenuItem3, Me.SalirToolStripMenuItem})
        Me.DatosGeneralesToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Bitmap_editor
        Me.DatosGeneralesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DatosGeneralesToolStripMenuItem.Name = "DatosGeneralesToolStripMenuItem"
        Me.DatosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(135, 36)
        Me.DatosGeneralesToolStripMenuItem.Text = "Datos Generales"
        '
        'TiposDeSangreToolStripMenuItem
        '
        Me.TiposDeSangreToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Color_test
        Me.TiposDeSangreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TiposDeSangreToolStripMenuItem.Name = "TiposDeSangreToolStripMenuItem"
        Me.TiposDeSangreToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.TiposDeSangreToolStripMenuItem.Text = "Tipos de Sangre"
        '
        'TiposDeLicenciaToolStripMenuItem
        '
        Me.TiposDeLicenciaToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Color_layers
        Me.TiposDeLicenciaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TiposDeLicenciaToolStripMenuItem.Name = "TiposDeLicenciaToolStripMenuItem"
        Me.TiposDeLicenciaToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.TiposDeLicenciaToolStripMenuItem.Text = "Tipos de Licencia"
        '
        'TiposDeComunicacionToolStripMenuItem
        '
        Me.TiposDeComunicacionToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Comment
        Me.TiposDeComunicacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TiposDeComunicacionToolStripMenuItem.Name = "TiposDeComunicacionToolStripMenuItem"
        Me.TiposDeComunicacionToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.TiposDeComunicacionToolStripMenuItem.Text = "Tipos de Comunicacion"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
        '
        'BuscarPersonasToolStripMenuItem
        '
        Me.BuscarPersonasToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Find
        Me.BuscarPersonasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarPersonasToolStripMenuItem.Name = "BuscarPersonasToolStripMenuItem"
        Me.BuscarPersonasToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.BuscarPersonasToolStripMenuItem.Text = "Buscar Personas"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Designer
        Me.PersonasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(213, 6)
        '
        'BuscarEmpresasToolStripMenuItem
        '
        Me.BuscarEmpresasToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Find
        Me.BuscarEmpresasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarEmpresasToolStripMenuItem.Name = "BuscarEmpresasToolStripMenuItem"
        Me.BuscarEmpresasToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.BuscarEmpresasToolStripMenuItem.Text = "Buscar Empresas"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Registry
        Me.EmpresasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(213, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Close
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(216, 38)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DatosRRHHToolStripMenuItem
        '
        Me.DatosRRHHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarEmpleadosToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.DatosRRHHToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Flow_block
        Me.DatosRRHHToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DatosRRHHToolStripMenuItem.Name = "DatosRRHHToolStripMenuItem"
        Me.DatosRRHHToolStripMenuItem.Size = New System.Drawing.Size(186, 36)
        Me.DatosRRHHToolStripMenuItem.Text = "Datos Recursos Humanos"
        '
        'BuscarEmpleadosToolStripMenuItem
        '
        Me.BuscarEmpleadosToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Find
        Me.BuscarEmpleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarEmpleadosToolStripMenuItem.Name = "BuscarEmpleadosToolStripMenuItem"
        Me.BuscarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(186, 38)
        Me.BuscarEmpleadosToolStripMenuItem.Text = "Buscar Empleados"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Image = Global.SistemaFinanciero.My.Resources.Resources.Work_area
        Me.EmpleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(186, 38)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 332)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Sistema Financiero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeSangreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeLicenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeComunicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuscarPersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarEmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatosRRHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
