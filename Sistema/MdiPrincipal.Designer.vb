<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMdiPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("USUARIOS")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ADMINISTRADORES", 2, 11)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REDES", 3, 11)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TIPO SERVICIO", 7, 11)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RECONEXION", 9, 11)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REVISAR ADEUDOS", 5, 11)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VER PAGOS", 6, 11)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PAGAR", 8, 11)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CORTE DE CAJA", 10, 11)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("INICIO", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMdiPrincipal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEstadoEstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EstaSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCopiaSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.ContainerMenuNotificacion = New System.Windows.Forms.SplitContainer()
        Me.pnlAbrirCerrarMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeMenu = New System.Windows.Forms.TreeView()
        Me.ImageListMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlNotificaciones = New System.Windows.Forms.Panel()
        Me.menuTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CerrarTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPrincipal = New Sistema.StyleTab()
        Me.TabPrueba = New System.Windows.Forms.TabPage()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContainerPrincipal.Panel1.SuspendLayout()
        Me.ContainerPrincipal.Panel2.SuspendLayout()
        Me.ContainerPrincipal.SuspendLayout()
        CType(Me.ContainerMenuNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContainerMenuNotificacion.Panel1.SuspendLayout()
        Me.ContainerMenuNotificacion.Panel2.SuspendLayout()
        Me.ContainerMenuNotificacion.SuspendLayout()
        Me.menuTab.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEstadoEstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 681)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1169, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEstadoEstatus
        '
        Me.lblEstadoEstatus.Name = "lblEstadoEstatus"
        Me.lblEstadoEstatus.Size = New System.Drawing.Size(54, 17)
        Me.lblEstadoEstatus.Text = "Estado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstaSesion, Me.OpcionesToolStripMenuItem, Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 32)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EstaSesion
        '
        Me.EstaSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.EstaSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesiónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.EstaSesion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstaSesion.Image = Global.Sistema.My.Resources.Resources.userPrueba
        Me.EstaSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EstaSesion.Name = "EstaSesion"
        Me.EstaSesion.Size = New System.Drawing.Size(36, 28)
        Me.EstaSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EstaSesion.ToolTipText = "Sesión del Usuario"
        '
        'IniciarSesiónToolStripMenuItem
        '
        Me.IniciarSesiónToolStripMenuItem.Image = Global.Sistema.My.Resources.Resources.checked_user
        Me.IniciarSesiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IniciarSesiónToolStripMenuItem.Name = "IniciarSesiónToolStripMenuItem"
        Me.IniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(168, 32)
        Me.IniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión "
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.Sistema.My.Resources.Resources.remove_user
        Me.CerrarSesiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(168, 32)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCopiaSeguridadToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(75, 28)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CrearCopiaSeguridadToolStripMenuItem
        '
        Me.CrearCopiaSeguridadToolStripMenuItem.Image = Global.Sistema.My.Resources.Resources.resp
        Me.CrearCopiaSeguridadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CrearCopiaSeguridadToolStripMenuItem.Name = "CrearCopiaSeguridadToolStripMenuItem"
        Me.CrearCopiaSeguridadToolStripMenuItem.Size = New System.Drawing.Size(138, 30)
        Me.CrearCopiaSeguridadToolStripMenuItem.Text = "Respaldo"
        '
        'CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem
        '
        Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem.Name = "CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem"
        Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem.Size = New System.Drawing.Size(399, 28)
        Me.CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem.Text = "CONTROL DE PAGOS DEL SISTEMA DE AGUA JESUS MARIA"
        '
        'ContainerPrincipal
        '
        Me.ContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerPrincipal.Location = New System.Drawing.Point(0, 32)
        Me.ContainerPrincipal.Name = "ContainerPrincipal"
        '
        'ContainerPrincipal.Panel1
        '
        Me.ContainerPrincipal.Panel1.Controls.Add(Me.ContainerMenuNotificacion)
        '
        'ContainerPrincipal.Panel2
        '
        Me.ContainerPrincipal.Panel2.Controls.Add(Me.TabPrincipal)
        Me.ContainerPrincipal.Size = New System.Drawing.Size(1169, 649)
        Me.ContainerPrincipal.SplitterDistance = 219
        Me.ContainerPrincipal.TabIndex = 3
        '
        'ContainerMenuNotificacion
        '
        Me.ContainerMenuNotificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerMenuNotificacion.Location = New System.Drawing.Point(0, 0)
        Me.ContainerMenuNotificacion.Name = "ContainerMenuNotificacion"
        Me.ContainerMenuNotificacion.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ContainerMenuNotificacion.Panel1
        '
        Me.ContainerMenuNotificacion.Panel1.Controls.Add(Me.pnlAbrirCerrarMenu)
        Me.ContainerMenuNotificacion.Panel1.Controls.Add(Me.Panel1)
        Me.ContainerMenuNotificacion.Panel1.Controls.Add(Me.TreeMenu)
        '
        'ContainerMenuNotificacion.Panel2
        '
        Me.ContainerMenuNotificacion.Panel2.Controls.Add(Me.pnlNotificaciones)
        Me.ContainerMenuNotificacion.Size = New System.Drawing.Size(219, 649)
        Me.ContainerMenuNotificacion.SplitterDistance = 314
        Me.ContainerMenuNotificacion.TabIndex = 0
        '
        'pnlAbrirCerrarMenu
        '
        Me.pnlAbrirCerrarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAbrirCerrarMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlAbrirCerrarMenu.BackgroundImage = Global.Sistema.My.Resources.Resources.preview
        Me.pnlAbrirCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlAbrirCerrarMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAbrirCerrarMenu.Location = New System.Drawing.Point(179, 3)
        Me.pnlAbrirCerrarMenu.Name = "pnlAbrirCerrarMenu"
        Me.pnlAbrirCerrarMenu.Size = New System.Drawing.Size(34, 26)
        Me.pnlAbrirCerrarMenu.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Sistema.My.Resources.Resources.resp
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(325, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(47, 26)
        Me.Panel1.TabIndex = 1
        '
        'TreeMenu
        '
        Me.TreeMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeMenu.FullRowSelect = True
        Me.TreeMenu.ImageIndex = 0
        Me.TreeMenu.ImageList = Me.ImageListMenu
        Me.TreeMenu.Location = New System.Drawing.Point(0, 0)
        Me.TreeMenu.Name = "TreeMenu"
        TreeNode11.ImageIndex = 2
        TreeNode11.Name = "Nodo5"
        TreeNode11.SelectedImageKey = "OK.png"
        TreeNode11.Text = "USUARIOS"
        TreeNode12.ImageIndex = 2
        TreeNode12.Name = "Nodo0"
        TreeNode12.SelectedImageIndex = 11
        TreeNode12.Text = "ADMINISTRADORES"
        TreeNode13.ImageIndex = 3
        TreeNode13.Name = "Nodo1"
        TreeNode13.SelectedImageIndex = 11
        TreeNode13.Text = "REDES"
        TreeNode14.ImageIndex = 7
        TreeNode14.Name = "Nodo0"
        TreeNode14.SelectedImageIndex = 11
        TreeNode14.Text = "TIPO SERVICIO"
        TreeNode15.ImageIndex = 9
        TreeNode15.Name = "Nodo1"
        TreeNode15.SelectedImageIndex = 11
        TreeNode15.Text = "RECONEXION"
        TreeNode16.ImageIndex = 5
        TreeNode16.Name = "Nodo2"
        TreeNode16.SelectedImageIndex = 11
        TreeNode16.Text = "REVISAR ADEUDOS"
        TreeNode17.ImageIndex = 6
        TreeNode17.Name = "Nodo3"
        TreeNode17.SelectedImageIndex = 11
        TreeNode17.Text = "VER PAGOS"
        TreeNode18.ImageIndex = 8
        TreeNode18.Name = "Nodo4"
        TreeNode18.SelectedImageIndex = 11
        TreeNode18.Text = "PAGAR"
        TreeNode19.ImageIndex = 10
        TreeNode19.Name = "Nodo5"
        TreeNode19.SelectedImageIndex = 11
        TreeNode19.Text = "CORTE DE CAJA"
        TreeNode20.ImageIndex = 0
        TreeNode20.Name = "Nodo4"
        TreeNode20.StateImageKey = "(ninguno)"
        TreeNode20.Text = "INICIO"
        Me.TreeMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode20})
        Me.TreeMenu.SelectedImageIndex = 0
        Me.TreeMenu.Size = New System.Drawing.Size(219, 314)
        Me.TreeMenu.StateImageList = Me.ImageListMenu
        Me.TreeMenu.TabIndex = 0
        '
        'ImageListMenu
        '
        Me.ImageListMenu.ImageStream = CType(resources.GetObject("ImageListMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMenu.Images.SetKeyName(0, "folder1.png")
        Me.ImageListMenu.Images.SetKeyName(1, "users.png")
        Me.ImageListMenu.Images.SetKeyName(2, "users (2).png")
        Me.ImageListMenu.Images.SetKeyName(3, "red.png")
        Me.ImageListMenu.Images.SetKeyName(4, "buscar.png")
        Me.ImageListMenu.Images.SetKeyName(5, "monto.png")
        Me.ImageListMenu.Images.SetKeyName(6, "verpagos.png")
        Me.ImageListMenu.Images.SetKeyName(7, "tipo.png")
        Me.ImageListMenu.Images.SetKeyName(8, "pagar.png")
        Me.ImageListMenu.Images.SetKeyName(9, "reconexion.png")
        Me.ImageListMenu.Images.SetKeyName(10, "cortecaja.png")
        Me.ImageListMenu.Images.SetKeyName(11, "OK.png")
        '
        'pnlNotificaciones
        '
        Me.pnlNotificaciones.BackColor = System.Drawing.Color.White
        Me.pnlNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNotificaciones.Location = New System.Drawing.Point(0, 0)
        Me.pnlNotificaciones.Name = "pnlNotificaciones"
        Me.pnlNotificaciones.Size = New System.Drawing.Size(219, 331)
        Me.pnlNotificaciones.TabIndex = 0
        '
        'menuTab
        '
        Me.menuTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarTabToolStripMenuItem})
        Me.menuTab.Name = "ContextMenuStrip1"
        Me.menuTab.Size = New System.Drawing.Size(151, 26)
        '
        'CerrarTabToolStripMenuItem
        '
        Me.CerrarTabToolStripMenuItem.Image = Global.Sistema.My.Resources.Resources._1465005143_close_red
        Me.CerrarTabToolStripMenuItem.Name = "CerrarTabToolStripMenuItem"
        Me.CerrarTabToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CerrarTabToolStripMenuItem.Text = "Cerrar Pestaña"
        Me.CerrarTabToolStripMenuItem.ToolTipText = "CERRAR LA PESTAÑA ACTUAL"
        '
        'ImageListTabs
        '
        Me.ImageListTabs.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListTabs.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListTabs.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabPrincipal
        '
        Me.TabPrincipal.ContextMenuStrip = Me.menuTab
        Me.TabPrincipal.Controls.Add(Me.TabPrueba)
        Me.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrincipal.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(946, 649)
        Me.TabPrincipal.TabIndex = 0
        '
        'TabPrueba
        '
        Me.TabPrueba.Location = New System.Drawing.Point(4, 25)
        Me.TabPrueba.Name = "TabPrueba"
        Me.TabPrueba.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrueba.Size = New System.Drawing.Size(938, 620)
        Me.TabPrueba.TabIndex = 0
        Me.TabPrueba.Text = "Pestaña de Prueba"
        Me.TabPrueba.UseVisualStyleBackColor = True
        '
        'FrmMdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1169, 703)
        Me.Controls.Add(Me.ContainerPrincipal)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMdiPrincipal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContainerPrincipal.Panel1.ResumeLayout(False)
        Me.ContainerPrincipal.Panel2.ResumeLayout(False)
        CType(Me.ContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContainerPrincipal.ResumeLayout(False)
        Me.ContainerMenuNotificacion.Panel1.ResumeLayout(False)
        Me.ContainerMenuNotificacion.Panel2.ResumeLayout(False)
        CType(Me.ContainerMenuNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContainerMenuNotificacion.ResumeLayout(False)
        Me.menuTab.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents EstaSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEstadoEstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearCopiaSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainerPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents IniciarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ImageListMenu As System.Windows.Forms.ImageList
    Friend WithEvents TreeMenu As System.Windows.Forms.TreeView
    Friend WithEvents ContainerMenuNotificacion As System.Windows.Forms.SplitContainer
    Friend WithEvents CONTROLDEPAGOSDELSISTEMADEAGUAJESUSMARIAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageListTabs As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlAbrirCerrarMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlNotificaciones As System.Windows.Forms.Panel
    Friend WithEvents TabPrincipal As Sistema.StyleTab
    Friend WithEvents menuTab As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TabPrueba As System.Windows.Forms.TabPage
    Friend WithEvents CerrarTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
