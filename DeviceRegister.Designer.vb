<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeviceRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeviceRegister))
        Me.lblTipoEquipo = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblIdUser = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtboxIdUser = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoEquipo
        '
        Me.lblTipoEquipo.AutoSize = True
        Me.lblTipoEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEquipo.Location = New System.Drawing.Point(418, 9)
        Me.lblTipoEquipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoEquipo.Name = "lblTipoEquipo"
        Me.lblTipoEquipo.Size = New System.Drawing.Size(185, 21)
        Me.lblTipoEquipo.TabIndex = 8
        Me.lblTipoEquipo.Text = "Seleccione el tipo de Equipo:"
        Me.lblTipoEquipo.UseCompatibleTextRendering = True
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.Location = New System.Drawing.Point(125, 43)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(115, 21)
        Me.lblSerial.TabIndex = 9
        Me.lblSerial.Text = "Serial del Equipo:"
        Me.lblSerial.UseCompatibleTextRendering = True
        '
        'lblIdUser
        '
        Me.lblIdUser.AutoSize = True
        Me.lblIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdUser.Location = New System.Drawing.Point(125, 9)
        Me.lblIdUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdUser.Name = "lblIdUser"
        Me.lblIdUser.Size = New System.Drawing.Size(133, 21)
        Me.lblIdUser.TabIndex = 11
        Me.lblIdUser.Text = "Documento Usuario:"
        Me.lblIdUser.UseCompatibleTextRendering = True
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(125, 75)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(118, 21)
        Me.lblMarca.TabIndex = 12
        Me.lblMarca.Text = "Marca del Equipo:"
        Me.lblMarca.UseCompatibleTextRendering = True
        '
        'txtboxIdUser
        '
        Me.txtboxIdUser.Enabled = False
        Me.txtboxIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxIdUser.Location = New System.Drawing.Point(281, 7)
        Me.txtboxIdUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxIdUser.Name = "txtboxIdUser"
        Me.txtboxIdUser.Size = New System.Drawing.Size(116, 23)
        Me.txtboxIdUser.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(281, 41)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(281, 73)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 23)
        Me.TextBox3.TabIndex = 15
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNew.Location = New System.Drawing.Point(452, 43)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(95, 31)
        Me.btnNew.TabIndex = 16
        Me.btnNew.Text = "Nuevo"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(579, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 31)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbType
        '
        Me.cbType.Enabled = False
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Portátil", "Monitor", "Torre", "Video bean", "Parlante"})
        Me.cbType.Location = New System.Drawing.Point(607, 6)
        Me.cbType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(82, 25)
        Me.cbType.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TipoEquipo, Me.Usuario, Me.Serial, Me.Marca, Me.Fecha_Ingreso, Me.Hora_Ingreso})
        Me.DataGridView1.Location = New System.Drawing.Point(64, 107)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(683, 242)
        Me.DataGridView1.TabIndex = 19
        '
        'ID
        '
        Me.ID.DataPropertyName = "rec_id"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 90
        '
        'TipoEquipo
        '
        Me.TipoEquipo.DataPropertyName = "tip_id"
        Me.TipoEquipo.HeaderText = "Tipo Equipo"
        Me.TipoEquipo.MinimumWidth = 6
        Me.TipoEquipo.Name = "TipoEquipo"
        Me.TipoEquipo.Width = 90
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "usu_usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 6
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 90
        '
        'Serial
        '
        Me.Serial.DataPropertyName = "rec_serial"
        Me.Serial.HeaderText = "Serial"
        Me.Serial.MinimumWidth = 6
        Me.Serial.Name = "Serial"
        Me.Serial.Width = 90
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "rec_marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.MinimumWidth = 6
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 90
        '
        'Fecha_Ingreso
        '
        Me.Fecha_Ingreso.HeaderText = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Name = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Width = 90
        '
        'Hora_Ingreso
        '
        Me.Hora_Ingreso.HeaderText = "Hora_Ingreso"
        Me.Hora_Ingreso.Name = "Hora_Ingreso"
        Me.Hora_Ingreso.Width = 90
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(20, 107)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(40, 43)
        Me.btnLoad.TabIndex = 20
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(751, 300)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(49, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DeviceRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtboxIdUser)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblIdUser)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblTipoEquipo)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeviceRegister"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeviceRegister"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblTipoEquipo As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents lblIdUser As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtboxIdUser As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbType As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents TipoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents Hora_Ingreso As DataGridViewTextBoxColumn
End Class
