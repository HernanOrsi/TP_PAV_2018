<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HeladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarSaboresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarHeladosEspecialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeladosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HeladosToolStripMenuItem
        '
        Me.HeladosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarSaboresToolStripMenuItem, Me.GestionarHeladosEspecialesToolStripMenuItem})
        Me.HeladosToolStripMenuItem.Name = "HeladosToolStripMenuItem"
        Me.HeladosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HeladosToolStripMenuItem.Text = "Helados"
        '
        'GestionarSaboresToolStripMenuItem
        '
        Me.GestionarSaboresToolStripMenuItem.Name = "GestionarSaboresToolStripMenuItem"
        Me.GestionarSaboresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarSaboresToolStripMenuItem.Text = "Gestionar sabores"
        '
        'GestionarHeladosEspecialesToolStripMenuItem
        '
        Me.GestionarHeladosEspecialesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConProveedorToolStripMenuItem, Me.SinProveedorToolStripMenuItem})
        Me.GestionarHeladosEspecialesToolStripMenuItem.Name = "GestionarHeladosEspecialesToolStripMenuItem"
        Me.GestionarHeladosEspecialesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarHeladosEspecialesToolStripMenuItem.Text = "Gestionar helados"
        '
        'ConProveedorToolStripMenuItem
        '
        Me.ConProveedorToolStripMenuItem.Name = "ConProveedorToolStripMenuItem"
        Me.ConProveedorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConProveedorToolStripMenuItem.Text = "Helados simples"
        '
        'SinProveedorToolStripMenuItem
        '
        Me.SinProveedorToolStripMenuItem.Name = "SinProveedorToolStripMenuItem"
        Me.SinProveedorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SinProveedorToolStripMenuItem.Text = "Helados especiales"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'GestionarProveedoresToolStripMenuItem
        '
        Me.GestionarProveedoresToolStripMenuItem.Name = "GestionarProveedoresToolStripMenuItem"
        Me.GestionarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GestionarProveedoresToolStripMenuItem.Text = "Gestionar proveedores"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.Text = "MENÚ PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HeladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarSaboresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarHeladosEspecialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinProveedorToolStripMenuItem As ToolStripMenuItem
End Class
