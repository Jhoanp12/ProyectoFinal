<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.itmMnDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmMnUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblUser = New System.Windows.Forms.Label()
        Me.itmDeviceRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmDeviceConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmUserRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmUserConsul = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmMnDevice, Me.itmMnUser, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'itmMnDevice
        '
        Me.itmMnDevice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmDeviceRegister, Me.itmDeviceConsult})
        Me.itmMnDevice.Name = "itmMnDevice"
        Me.itmMnDevice.Size = New System.Drawing.Size(56, 20)
        Me.itmMnDevice.Text = "Equipo"
        '
        'itmMnUser
        '
        Me.itmMnUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmUserRegister, Me.itmUserConsul})
        Me.itmMnUser.Name = "itmMnUser"
        Me.itmMnUser.Size = New System.Drawing.Size(59, 20)
        Me.itmMnUser.Text = "Usuario"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(963, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(45, 16)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Admin"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'itmDeviceRegister
        '
        Me.itmDeviceRegister.BackColor = System.Drawing.SystemColors.Control
        Me.itmDeviceRegister.Image = Global.Proyecto.My.Resources.Resources._1458264592_laptop_computer_pc_device_notebook_netbook_internet_icon_icons_com_55334
        Me.itmDeviceRegister.Name = "itmDeviceRegister"
        Me.itmDeviceRegister.Size = New System.Drawing.Size(180, 22)
        Me.itmDeviceRegister.Text = "Registrar"
        '
        'itmDeviceConsult
        '
        Me.itmDeviceConsult.Image = Global.Proyecto.My.Resources.Resources.view_search_find_9565
        Me.itmDeviceConsult.Name = "itmDeviceConsult"
        Me.itmDeviceConsult.Size = New System.Drawing.Size(180, 22)
        Me.itmDeviceConsult.Text = "Consultar"
        '
        'itmUserRegister
        '
        Me.itmUserRegister.BackColor = System.Drawing.SystemColors.Control
        Me.itmUserRegister.Image = Global.Proyecto.My.Resources.Resources.new_add_user_16734
        Me.itmUserRegister.Name = "itmUserRegister"
        Me.itmUserRegister.Size = New System.Drawing.Size(121, 22)
        Me.itmUserRegister.Text = "Registrar"
        '
        'itmUserConsul
        '
        Me.itmUserConsul.BackColor = System.Drawing.SystemColors.Control
        Me.itmUserConsul.Image = Global.Proyecto.My.Resources.Resources.search_find_user_16727
        Me.itmUserConsul.Name = "itmUserConsul"
        Me.itmUserConsul.Size = New System.Drawing.Size(121, 22)
        Me.itmUserConsul.Text = "Consular"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1008, 461)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "RegistroEquipos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents itmMnDevice As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents itmMnUser As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents itmDeviceRegister As ToolStripMenuItem
    Friend WithEvents itmDeviceConsult As ToolStripMenuItem
    Friend WithEvents itmUserRegister As ToolStripMenuItem
    Friend WithEvents itmUserConsul As ToolStripMenuItem
    Friend WithEvents lblUser As Label
End Class
