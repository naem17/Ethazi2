<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.lbl_Nickname = New System.Windows.Forms.Label()
        Me.lbl_Contrasenya = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Apellidos = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_RepeContrasenya = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Apellidos = New System.Windows.Forms.TextBox()
        Me.txt_Contrasenya = New System.Windows.Forms.TextBox()
        Me.txt_RepeContrasenya = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Nickname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Nickname
        '
        Me.lbl_Nickname.AutoSize = True
        Me.lbl_Nickname.Location = New System.Drawing.Point(214, 60)
        Me.lbl_Nickname.Name = "lbl_Nickname"
        Me.lbl_Nickname.Size = New System.Drawing.Size(104, 25)
        Me.lbl_Nickname.TabIndex = 0
        Me.lbl_Nickname.Text = "Nickname:"
        '
        'lbl_Contrasenya
        '
        Me.lbl_Contrasenya.AutoSize = True
        Me.lbl_Contrasenya.Location = New System.Drawing.Point(29, 216)
        Me.lbl_Contrasenya.Name = "lbl_Contrasenya"
        Me.lbl_Contrasenya.Size = New System.Drawing.Size(114, 25)
        Me.lbl_Contrasenya.TabIndex = 1
        Me.lbl_Contrasenya.Text = "Contraseña:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(29, 141)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(88, 25)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.AutoSize = True
        Me.lbl_Apellidos.Location = New System.Drawing.Point(372, 136)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(96, 25)
        Me.lbl_Apellidos.TabIndex = 3
        Me.lbl_Apellidos.Text = "Apellidos:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(29, 293)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(66, 25)
        Me.lbl_Email.TabIndex = 4
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(477, 293)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(93, 25)
        Me.lbl_Telefono.TabIndex = 5
        Me.lbl_Telefono.Text = "Telefono:"
        '
        'lbl_RepeContrasenya
        '
        Me.lbl_RepeContrasenya.AutoSize = True
        Me.lbl_RepeContrasenya.Location = New System.Drawing.Point(372, 208)
        Me.lbl_RepeContrasenya.Name = "lbl_RepeContrasenya"
        Me.lbl_RepeContrasenya.Size = New System.Drawing.Size(181, 25)
        Me.lbl_RepeContrasenya.TabIndex = 6
        Me.lbl_RepeContrasenya.Text = "Repetir Contraseña:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(118, 133)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(234, 33)
        Me.txt_Nombre.TabIndex = 7
        '
        'txt_Apellidos
        '
        Me.txt_Apellidos.Location = New System.Drawing.Point(472, 130)
        Me.txt_Apellidos.Name = "txt_Apellidos"
        Me.txt_Apellidos.Size = New System.Drawing.Size(309, 33)
        Me.txt_Apellidos.TabIndex = 8
        '
        'txt_Contrasenya
        '
        Me.txt_Contrasenya.Location = New System.Drawing.Point(144, 208)
        Me.txt_Contrasenya.Name = "txt_Contrasenya"
        Me.txt_Contrasenya.Size = New System.Drawing.Size(211, 33)
        Me.txt_Contrasenya.TabIndex = 9
        '
        'txt_RepeContrasenya
        '
        Me.txt_RepeContrasenya.Location = New System.Drawing.Point(556, 200)
        Me.txt_RepeContrasenya.Name = "txt_RepeContrasenya"
        Me.txt_RepeContrasenya.Size = New System.Drawing.Size(211, 33)
        Me.txt_RepeContrasenya.TabIndex = 10
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(101, 285)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(353, 33)
        Me.txt_Email.TabIndex = 11
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(597, 282)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(184, 33)
        Me.txt_Telefono.TabIndex = 12
        '
        'txt_Nickname
        '
        Me.txt_Nickname.Location = New System.Drawing.Point(335, 52)
        Me.txt_Nickname.Name = "txt_Nickname"
        Me.txt_Nickname.Size = New System.Drawing.Size(235, 33)
        Me.txt_Nickname.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Finalizar el registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(513, 418)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(813, 502)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_Nickname)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_RepeContrasenya)
        Me.Controls.Add(Me.txt_Contrasenya)
        Me.Controls.Add(Me.txt_Apellidos)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_RepeContrasenya)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Apellidos)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_Contrasenya)
        Me.Controls.Add(Me.lbl_Nickname)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Nickname As System.Windows.Forms.Label
    Friend WithEvents lbl_Contrasenya As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_RepeContrasenya As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contrasenya As System.Windows.Forms.TextBox
    Friend WithEvents txt_RepeContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nickname As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
