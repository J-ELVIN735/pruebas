<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loge))
        Me.info = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.loandin = New System.Windows.Forms.Label()
        Me.showpass = New System.Windows.Forms.PictureBox()
        Me.carga = New System.Windows.Forms.Timer(Me.components)
        CType(Me.showpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(134, 9)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(236, 31)
        Me.info.TabIndex = 0
        Me.info.Text = "Inicio de Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(157, 101)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(213, 31)
        Me.user.TabIndex = 3
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(157, 146)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(178, 31)
        Me.pass.TabIndex = 4
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(100, 210)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(295, 59)
        Me.login.TabIndex = 5
        Me.login.Text = "Inicial Seccion"
        Me.login.UseVisualStyleBackColor = True
        '
        'loandin
        '
        Me.loandin.AutoSize = True
        Me.loandin.Location = New System.Drawing.Point(223, 233)
        Me.loandin.Name = "loandin"
        Me.loandin.Size = New System.Drawing.Size(52, 13)
        Me.loandin.TabIndex = 6
        Me.loandin.Text = "cargando"
        '
        'showpass
        '
        Me.showpass.Image = Global.pruevaSQL.My.Resources.Resources.show
        Me.showpass.Location = New System.Drawing.Point(335, 146)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(35, 31)
        Me.showpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showpass.TabIndex = 7
        Me.showpass.TabStop = False
        '
        'carga
        '
        Me.carga.Enabled = True
        Me.carga.Interval = 2500
        '
        'loge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 321)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.loandin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loge"
        Me.Text = "Inicio de Seccion"
        CType(Me.showpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents info As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents login As Button
    Friend WithEvents loandin As Label
    Friend WithEvents showpass As PictureBox
    Friend WithEvents carga As Timer
End Class
