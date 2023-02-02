<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.Panel()
        Me.btnUpedate = New System.Windows.Forms.Button()
        Me.userRol = New System.Windows.Forms.TextBox()
        Me.userEmail = New System.Windows.Forms.TextBox()
        Me.userPass = New System.Windows.Forms.TextBox()
        Me.userUser = New System.Windows.Forms.TextBox()
        Me.userApellido = New System.Windows.Forms.TextBox()
        Me.userNombre = New System.Windows.Forms.TextBox()
        Me.userID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buscarUser = New System.Windows.Forms.TextBox()
        Me.autocompleta = New System.Windows.Forms.Timer(Me.components)
        Me.addUserPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.roles = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.User.SuspendLayout()
        Me.addUserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.username)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(604, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¡Hola!"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DarkRed
        Me.username.Location = New System.Drawing.Point(59, 0)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(68, 20)
        Me.username.TabIndex = 1
        Me.username.Text = "usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bienvenido al Sistema"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUser)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNewUser)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(1, 46)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(104, 291)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(3, 3)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(99, 28)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "Usuarios"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(3, 37)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(99, 28)
        Me.btnNewUser.TabIndex = 0
        Me.btnNewUser.Text = "Nuevo Usuario"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.User.Controls.Add(Me.btnUpedate)
        Me.User.Controls.Add(Me.userRol)
        Me.User.Controls.Add(Me.userEmail)
        Me.User.Controls.Add(Me.userPass)
        Me.User.Controls.Add(Me.userUser)
        Me.User.Controls.Add(Me.userApellido)
        Me.User.Controls.Add(Me.userNombre)
        Me.User.Controls.Add(Me.userID)
        Me.User.Controls.Add(Me.Label10)
        Me.User.Controls.Add(Me.Label9)
        Me.User.Controls.Add(Me.Label8)
        Me.User.Controls.Add(Me.Label7)
        Me.User.Controls.Add(Me.Label6)
        Me.User.Controls.Add(Me.Label5)
        Me.User.Controls.Add(Me.Label4)
        Me.User.Controls.Add(Me.btnBuscarUser)
        Me.User.Controls.Add(Me.Label3)
        Me.User.Controls.Add(Me.buscarUser)
        Me.User.Location = New System.Drawing.Point(122, 46)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(500, 290)
        Me.User.TabIndex = 3
        '
        'btnUpedate
        '
        Me.btnUpedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpedate.Location = New System.Drawing.Point(353, 169)
        Me.btnUpedate.Name = "btnUpedate"
        Me.btnUpedate.Size = New System.Drawing.Size(138, 92)
        Me.btnUpedate.TabIndex = 17
        Me.btnUpedate.Text = "Modificar Datos"
        Me.btnUpedate.UseVisualStyleBackColor = True
        '
        'userRol
        '
        Me.userRol.Location = New System.Drawing.Point(127, 241)
        Me.userRol.Name = "userRol"
        Me.userRol.Size = New System.Drawing.Size(215, 20)
        Me.userRol.TabIndex = 16
        '
        'userEmail
        '
        Me.userEmail.Location = New System.Drawing.Point(127, 217)
        Me.userEmail.Name = "userEmail"
        Me.userEmail.Size = New System.Drawing.Size(215, 20)
        Me.userEmail.TabIndex = 15
        '
        'userPass
        '
        Me.userPass.Location = New System.Drawing.Point(127, 193)
        Me.userPass.Name = "userPass"
        Me.userPass.Size = New System.Drawing.Size(215, 20)
        Me.userPass.TabIndex = 14
        '
        'userUser
        '
        Me.userUser.Location = New System.Drawing.Point(127, 169)
        Me.userUser.Name = "userUser"
        Me.userUser.Size = New System.Drawing.Size(215, 20)
        Me.userUser.TabIndex = 13
        '
        'userApellido
        '
        Me.userApellido.Location = New System.Drawing.Point(127, 144)
        Me.userApellido.Name = "userApellido"
        Me.userApellido.Size = New System.Drawing.Size(215, 20)
        Me.userApellido.TabIndex = 12
        '
        'userNombre
        '
        Me.userNombre.Location = New System.Drawing.Point(127, 118)
        Me.userNombre.Name = "userNombre"
        Me.userNombre.Size = New System.Drawing.Size(215, 20)
        Me.userNombre.TabIndex = 11
        '
        'userID
        '
        Me.userID.Location = New System.Drawing.Point(127, 93)
        Me.userID.Name = "userID"
        Me.userID.Size = New System.Drawing.Size(215, 20)
        Me.userID.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Rol:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Corroe:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID:"
        '
        'btnBuscarUser
        '
        Me.btnBuscarUser.Location = New System.Drawing.Point(432, 20)
        Me.btnBuscarUser.Name = "btnBuscarUser"
        Me.btnBuscarUser.Size = New System.Drawing.Size(59, 36)
        Me.btnBuscarUser.TabIndex = 2
        Me.btnBuscarUser.Text = "Buscar"
        Me.btnBuscarUser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre de Usuario:"
        '
        'buscarUser
        '
        Me.buscarUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.buscarUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.buscarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarUser.Location = New System.Drawing.Point(208, 24)
        Me.buscarUser.Name = "buscarUser"
        Me.buscarUser.Size = New System.Drawing.Size(218, 29)
        Me.buscarUser.TabIndex = 0
        '
        'autocompleta
        '
        Me.autocompleta.Enabled = True
        '
        'addUserPanel
        '
        Me.addUserPanel.Controls.Add(Me.Button2)
        Me.addUserPanel.Controls.Add(Me.roles)
        Me.addUserPanel.Controls.Add(Me.TextBox5)
        Me.addUserPanel.Controls.Add(Me.TextBox4)
        Me.addUserPanel.Controls.Add(Me.TextBox3)
        Me.addUserPanel.Controls.Add(Me.TextBox2)
        Me.addUserPanel.Controls.Add(Me.TextBox1)
        Me.addUserPanel.Controls.Add(Me.Label17)
        Me.addUserPanel.Controls.Add(Me.Label16)
        Me.addUserPanel.Controls.Add(Me.Label15)
        Me.addUserPanel.Controls.Add(Me.Label14)
        Me.addUserPanel.Controls.Add(Me.Label13)
        Me.addUserPanel.Controls.Add(Me.Label12)
        Me.addUserPanel.Controls.Add(Me.Label11)
        Me.addUserPanel.Location = New System.Drawing.Point(122, 46)
        Me.addUserPanel.Name = "addUserPanel"
        Me.addUserPanel.Size = New System.Drawing.Size(500, 290)
        Me.addUserPanel.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 24)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Agregar Usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'roles
        '
        Me.roles.FormattingEnabled = True
        Me.roles.Items.AddRange(New Object() {"Admin"})
        Me.roles.Location = New System.Drawing.Point(325, 173)
        Me.roles.Name = "roles"
        Me.roles.Size = New System.Drawing.Size(122, 21)
        Me.roles.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(323, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(124, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(322, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(149, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(279, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Rol:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(264, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Email:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(220, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 20)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Contraseña:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Nombre de Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Apellido:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(168, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(174, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Agregar Nuevo Usuario"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 336)
        Me.Controls.Add(Me.addUserPanel)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.User.ResumeLayout(False)
        Me.User.PerformLayout()
        Me.addUserPanel.ResumeLayout(False)
        Me.addUserPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents username As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnUser As Button
    Friend WithEvents btnNewUser As Button
    Friend WithEvents User As Panel
    Friend WithEvents userRol As TextBox
    Friend WithEvents userEmail As TextBox
    Friend WithEvents userPass As TextBox
    Friend WithEvents userUser As TextBox
    Friend WithEvents userApellido As TextBox
    Friend WithEvents userNombre As TextBox
    Friend WithEvents userID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscarUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents buscarUser As TextBox
    Friend WithEvents autocompleta As Timer
    Friend WithEvents btnUpedate As Button
    Friend WithEvents addUserPanel As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents roles As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
