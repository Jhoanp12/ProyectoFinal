<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeviceConsult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeviceConsult))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblIdUser = New System.Windows.Forms.Label()
        Me.txtboxIdUser = New System.Windows.Forms.TextBox()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnConsult = New System.Windows.Forms.Button()
        Me.btnDeviceExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TipoEquipo, Me.Usuario, Me.Serial, Me.Marca, Me.Fecha_Ingreso, Me.Hora_Ingreso, Me.Fecha_Salida, Me.Hora_Salida})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 107)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(886, 242)
        Me.DataGridView1.TabIndex = 20
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
        'Fecha_Salida
        '
        Me.Fecha_Salida.HeaderText = "Fecha_Salida"
        Me.Fecha_Salida.Name = "Fecha_Salida"
        '
        'Hora_Salida
        '
        Me.Hora_Salida.HeaderText = "Hora_Salida"
        Me.Hora_Salida.Name = "Hora_Salida"
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
        Me.btnLoad.Location = New System.Drawing.Point(11, 70)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(34, 33)
        Me.btnLoad.TabIndex = 25
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'lblIdUser
        '
        Me.lblIdUser.AutoSize = True
        Me.lblIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdUser.Location = New System.Drawing.Point(170, 16)
        Me.lblIdUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdUser.Name = "lblIdUser"
        Me.lblIdUser.Size = New System.Drawing.Size(133, 21)
        Me.lblIdUser.TabIndex = 26
        Me.lblIdUser.Text = "Documento Usuario:"
        Me.lblIdUser.UseCompatibleTextRendering = True
        '
        'txtboxIdUser
        '
        Me.txtboxIdUser.Enabled = False
        Me.txtboxIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxIdUser.Location = New System.Drawing.Point(307, 13)
        Me.txtboxIdUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxIdUser.Name = "txtboxIdUser"
        Me.txtboxIdUser.Size = New System.Drawing.Size(116, 23)
        Me.txtboxIdUser.TabIndex = 27
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.Location = New System.Drawing.Point(170, 52)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(115, 21)
        Me.lblSerial.TabIndex = 28
        Me.lblSerial.Text = "Serial del Equipo:"
        Me.lblSerial.UseCompatibleTextRendering = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(307, 49)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2.TabIndex = 29
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
        Me.btnExit.Location = New System.Drawing.Point(852, 60)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 43)
        Me.btnExit.TabIndex = 30
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnConsult
        '
        Me.btnConsult.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnConsult.Location = New System.Drawing.Point(454, 26)
        Me.btnConsult.Name = "btnConsult"
        Me.btnConsult.Size = New System.Drawing.Size(95, 31)
        Me.btnConsult.TabIndex = 31
        Me.btnConsult.Text = "Consultar"
        Me.btnConsult.UseVisualStyleBackColor = False
        '
        'btnDeviceExit
        '
        Me.btnDeviceExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDeviceExit.Location = New System.Drawing.Point(555, 26)
        Me.btnDeviceExit.Name = "btnDeviceExit"
        Me.btnDeviceExit.Size = New System.Drawing.Size(95, 31)
        Me.btnDeviceExit.TabIndex = 32
        Me.btnDeviceExit.Text = "Marcar salida"
        Me.btnDeviceExit.UseVisualStyleBackColor = False
        '
        'DeviceConsult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(890, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDeviceExit)
        Me.Controls.Add(Me.btnConsult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.txtboxIdUser)
        Me.Controls.Add(Me.lblIdUser)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeviceConsult"
        Me.Text = "DeviceConsult"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents TipoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents Hora_Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Salida As DataGridViewTextBoxColumn
    Friend WithEvents Hora_Salida As DataGridViewTextBoxColumn
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblIdUser As Label
    Friend WithEvents txtboxIdUser As TextBox
    Friend WithEvents lblSerial As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnConsult As Button
    Friend WithEvents btnDeviceExit As Button
End Class
