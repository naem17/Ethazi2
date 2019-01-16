<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeraPageInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeraPageInsert))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Siguiente = New System.Windows.Forms.Button()
        Me.txt_Web = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Firma = New System.Windows.Forms.TextBox()
        Me.lbl_Web = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Firma = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(749, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "/4 )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(736, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(725, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "("
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Location = New System.Drawing.Point(575, 492)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(148, 40)
        Me.btn_Siguiente.TabIndex = 31
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'txt_Web
        '
        Me.txt_Web.Location = New System.Drawing.Point(276, 411)
        Me.txt_Web.Name = "txt_Web"
        Me.txt_Web.Size = New System.Drawing.Size(363, 33)
        Me.txt_Web.TabIndex = 30
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(276, 336)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(363, 33)
        Me.txt_Telefono.TabIndex = 29
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(276, 267)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(363, 33)
        Me.txt_Email.TabIndex = 28
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(276, 199)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(363, 33)
        Me.txt_Nombre.TabIndex = 27
        '
        'txt_Firma
        '
        Me.txt_Firma.Location = New System.Drawing.Point(309, 94)
        Me.txt_Firma.Name = "txt_Firma"
        Me.txt_Firma.Size = New System.Drawing.Size(199, 33)
        Me.txt_Firma.TabIndex = 26
        '
        'lbl_Web
        '
        Me.lbl_Web.AutoSize = True
        Me.lbl_Web.Location = New System.Drawing.Point(116, 419)
        Me.lbl_Web.Name = "lbl_Web"
        Me.lbl_Web.Size = New System.Drawing.Size(57, 25)
        Me.lbl_Web.TabIndex = 25
        Me.lbl_Web.Text = "Web:"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(116, 344)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(93, 25)
        Me.lbl_Telefono.TabIndex = 24
        Me.lbl_Telefono.Text = "Teléfono:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(116, 275)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(66, 25)
        Me.lbl_Email.TabIndex = 23
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_Firma
        '
        Me.lbl_Firma.AutoSize = True
        Me.lbl_Firma.Location = New System.Drawing.Point(221, 97)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(67, 25)
        Me.lbl_Firma.TabIndex = 22
        Me.lbl_Firma.Text = "Firma:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(116, 207)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(88, 25)
        Me.lbl_Nombre.TabIndex = 21
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(217, 35)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Datos Personales"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(819, 46)
        Me.Label2.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(514, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(645, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PrimeraPageInsert
        '
        Me.AcceptButton = Me.btn_Siguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 613)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Siguiente)
        Me.Controls.Add(Me.txt_Web)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Firma)
        Me.Controls.Add(Me.lbl_Web)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Firma)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "PrimeraPageInsert"
        Me.Text = "PrimeraPageInsert"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_Siguiente As System.Windows.Forms.Button
    Friend WithEvents txt_Web As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_Firma As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Web As System.Windows.Forms.Label
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents lbl_Firma As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
