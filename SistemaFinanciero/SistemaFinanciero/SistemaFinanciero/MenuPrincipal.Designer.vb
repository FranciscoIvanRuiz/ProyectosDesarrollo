<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribbonControl1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.ribbonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribbonTabItem1, Me.RibbonTabItem2})
        Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ribbonControl1.Size = New System.Drawing.Size(928, 120)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 2
        Me.ribbonControl1.Text = "ribbonControl1"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(928, 91)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(100, 88)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 0
        Me.RibbonBar2.Text = "Datos RRHH"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.SistemaFinanciero.My.Resources.Resources.Work_area
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Empleados"
        '
        'ribbonPanel1
        '
        Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
        Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel1.Location = New System.Drawing.Point(0, 26)
        Me.ribbonPanel1.Name = "ribbonPanel1"
        Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ribbonPanel1.Size = New System.Drawing.Size(928, 91)
        '
        '
        '
        Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel1.TabIndex = 1
        Me.ribbonPanel1.Visible = False
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar1.ContainerControlProcessDialogKey = True
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.DragDropSupport = True
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.ButtonItem7})
        Me.ribbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(495, 88)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonBar1.TabIndex = 0
        Me.ribbonBar1.Text = "Datos Generales"
        '
        '
        '
        Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.EnableImageAnimation = True
        Me.ButtonItem3.Image = Global.SistemaFinanciero.My.Resources.Resources.Color_test
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "Tipos de Sangre"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.EnableImageAnimation = True
        Me.ButtonItem4.Image = Global.SistemaFinanciero.My.Resources.Resources.Color_layers
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 14
        Me.ButtonItem4.Text = "Tipos de Licencia"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.EnableImageAnimation = True
        Me.ButtonItem5.Image = Global.SistemaFinanciero.My.Resources.Resources.Comment
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 14
        Me.ButtonItem5.Text = "Tipos de Comunicacion"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.EnableImageAnimation = True
        Me.ButtonItem6.Image = Global.SistemaFinanciero.My.Resources.Resources.Designer
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItemsExpandWidth = 14
        Me.ButtonItem6.Text = "Personas"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.EnableImageAnimation = True
        Me.ButtonItem7.Image = Global.SistemaFinanciero.My.Resources.Resources.Registry
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.SubItemsExpandWidth = 14
        Me.ButtonItem7.Text = "Empresas"
        '
        'ribbonTabItem1
        '
        Me.ribbonTabItem1.Name = "ribbonTabItem1"
        Me.ribbonTabItem1.Panel = Me.ribbonPanel1
        Me.ribbonTabItem1.Text = "Datos Generales"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Checked = True
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel2
        Me.RibbonTabItem2.Text = "Datos Recursos Humanos"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 623)
        Me.Controls.Add(Me.ribbonControl1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "MenuPrincipal"
        Me.Text = "Sistemas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ribbonControl1.ResumeLayout(False)
        Me.ribbonControl1.PerformLayout()
        Me.RibbonPanel2.ResumeLayout(False)
        Me.ribbonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
End Class
