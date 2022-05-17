<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imgUe = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.bttnLogin = New System.Windows.Forms.Button()
        Me.lklForgetPass = New System.Windows.Forms.LinkLabel()
        Me.lblBy = New System.Windows.Forms.Label()
        CType(Me.imgUe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgUe
        '
        Me.imgUe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imgUe.Cursor = System.Windows.Forms.Cursors.No
        Me.imgUe.Image = Global.Proyecto.My.Resources.Resources.ue1
        Me.imgUe.Location = New System.Drawing.Point(0, 2)
        Me.imgUe.Name = "imgUe"
        Me.imgUe.Size = New System.Drawing.Size(333, 51)
        Me.imgUe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUe.TabIndex = 0
        Me.imgUe.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(51, 56)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(237, 16)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Bienvenido al gestor de ingreso de equipos"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(108, 81)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(128, 25)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Iniciar Sesión"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(137, 119)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(69, 23)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Usuario"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2
        '
        Me.lblLine2.AutoSize = True
        Me.lblLine2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.Location = New System.Drawing.Point(71, 222)
        Me.lblLine2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(199, 16)
        Me.lblLine2.TabIndex = 5
        Me.lblLine2.Text = "________________________________"
        Me.lblLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1
        '
        Me.lblLine1.AutoSize = True
        Me.lblLine1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.Location = New System.Drawing.Point(71, 159)
        Me.lblLine1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(199, 16)
        Me.lblLine1.TabIndex = 7
        Me.lblLine1.Text = "________________________________"
        Me.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxUser
        '
        Me.tbxUser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUser.Location = New System.Drawing.Point(74, 159)
        Me.tbxUser.MaxLength = 50
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(186, 13)
        Me.tbxUser.TabIndex = 8
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(124, 184)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(98, 23)
        Me.lblPass.TabIndex = 9
        Me.lblPass.Text = "Contraseña"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Location = New System.Drawing.Point(74, 222)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(186, 13)
        Me.txtPass.TabIndex = 10
        '
        'bttnLogin
        '
        Me.bttnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bttnLogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttnLogin.Location = New System.Drawing.Point(128, 253)
        Me.bttnLogin.Name = "bttnLogin"
        Me.bttnLogin.Size = New System.Drawing.Size(94, 24)
        Me.bttnLogin.TabIndex = 11
        Me.bttnLogin.Text = "Login"
        Me.bttnLogin.UseVisualStyleBackColor = True
        '
        'lklForgetPass
        '
        Me.lklForgetPass.ActiveLinkColor = System.Drawing.Color.Black
        Me.lklForgetPass.AutoSize = True
        Me.lklForgetPass.LinkColor = System.Drawing.Color.Black
        Me.lklForgetPass.Location = New System.Drawing.Point(120, 280)
        Me.lklForgetPass.Name = "lklForgetPass"
        Me.lklForgetPass.Size = New System.Drawing.Size(113, 13)
        Me.lklForgetPass.TabIndex = 12
        Me.lklForgetPass.TabStop = True
        Me.lklForgetPass.Text = "Recuperar contraseña"
        Me.lklForgetPass.VisitedLinkColor = System.Drawing.Color.White
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(194, 345)
        Me.lblBy.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(139, 16)
        Me.lblBy.TabIndex = 13
        Me.lblBy.Text = "Desarrollado por ISF7 JF"
        Me.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(334, 361)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lklForgetPass)
        Me.Controls.Add(Me.bttnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblLine1)
        Me.Controls.Add(Me.lblLine2)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.imgUe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.imgUe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgUe As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblLine2 As Label
    Friend WithEvents lblLine1 As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents bttnLogin As Button
    Friend WithEvents lklForgetPass As LinkLabel
    Friend WithEvents lblBy As Label
End Class
