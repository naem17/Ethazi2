<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerceraPageInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerceraPageInsert))
        Me.txt_Capacidad = New System.Windows.Forms.TextBox()
        Me.lbl_Capacidad = New System.Windows.Forms.Label()
        Me.cmb_Categorias = New System.Windows.Forms.ComboBox()
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.btn_Siguiente = New System.Windows.Forms.Button()
        Me.txt_Larga = New System.Windows.Forms.TextBox()
        Me.txt_Corta = New System.Windows.Forms.TextBox()
        Me.lbl_DescripcionAbre = New System.Windows.Forms.Label()
        Me.lbl_DescripcionNOABRE = New System.Windows.Forms.Label()
        Me.lbl_Categoria = New System.Windows.Forms.Label()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Capacidad
        '
        Me.txt_Capacidad.Location = New System.Drawing.Point(675, 63)
        Me.txt_Capacidad.Name = "txt_Capacidad"
        Me.txt_Capacidad.Size = New System.Drawing.Size(100, 33)
        Me.txt_Capacidad.TabIndex = 53
        '
        'lbl_Capacidad
        '
        Me.lbl_Capacidad.AutoSize = True
        Me.lbl_Capacidad.Location = New System.Drawing.Point(543, 66)
        Me.lbl_Capacidad.Name = "lbl_Capacidad"
        Me.lbl_Capacidad.Size = New System.Drawing.Size(106, 25)
        Me.lbl_Capacidad.TabIndex = 52
        Me.lbl_Capacidad.Text = "Capacidad:"
        '
        'cmb_Categorias
        '
        Me.cmb_Categorias.FormattingEnabled = True
        Me.cmb_Categorias.Location = New System.Drawing.Point(378, 58)
        Me.cmb_Categorias.Name = "cmb_Categorias"
        Me.cmb_Categorias.Size = New System.Drawing.Size(121, 33)
        Me.cmb_Categorias.TabIndex = 51
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(91, 66)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(121, 33)
        Me.cmb_Tipo.TabIndex = 50
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Location = New System.Drawing.Point(618, 546)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(148, 40)
        Me.btn_Siguiente.TabIndex = 49
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'txt_Larga
        '
        Me.txt_Larga.Location = New System.Drawing.Point(35, 305)
        Me.txt_Larga.Multiline = True
        Me.txt_Larga.Name = "txt_Larga"
        Me.txt_Larga.Size = New System.Drawing.Size(753, 235)
        Me.txt_Larga.TabIndex = 48
        '
        'txt_Corta
        '
        Me.txt_Corta.Location = New System.Drawing.Point(35, 174)
        Me.txt_Corta.Multiline = True
        Me.txt_Corta.Name = "txt_Corta"
        Me.txt_Corta.Size = New System.Drawing.Size(753, 70)
        Me.txt_Corta.TabIndex = 47
        '
        'lbl_DescripcionAbre
        '
        Me.lbl_DescripcionAbre.AutoSize = True
        Me.lbl_DescripcionAbre.Location = New System.Drawing.Point(11, 129)
        Me.lbl_DescripcionAbre.Name = "lbl_DescripcionAbre"
        Me.lbl_DescripcionAbre.Size = New System.Drawing.Size(164, 25)
        Me.lbl_DescripcionAbre.TabIndex = 46
        Me.lbl_DescripcionAbre.Text = "Descripcion corta:"
        '
        'lbl_DescripcionNOABRE
        '
        Me.lbl_DescripcionNOABRE.AutoSize = True
        Me.lbl_DescripcionNOABRE.Location = New System.Drawing.Point(11, 268)
        Me.lbl_DescripcionNOABRE.Name = "lbl_DescripcionNOABRE"
        Me.lbl_DescripcionNOABRE.Size = New System.Drawing.Size(151, 25)
        Me.lbl_DescripcionNOABRE.TabIndex = 45
        Me.lbl_DescripcionNOABRE.Text = "Descrpcion larga"
        '
        'lbl_Categoria
        '
        Me.lbl_Categoria.AutoSize = True
        Me.lbl_Categoria.Location = New System.Drawing.Point(274, 69)
        Me.lbl_Categoria.Name = "lbl_Categoria"
        Me.lbl_Categoria.Size = New System.Drawing.Size(98, 25)
        Me.lbl_Categoria.TabIndex = 44
        Me.lbl_Categoria.Text = "Categoria:"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(11, 74)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(58, 25)
        Me.lbl_Tipo.TabIndex = 43
        Me.lbl_Tipo.Text = "Tipo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(744, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "/4 )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(731, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(720, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 25)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "("
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Titulo.Font = New System.Drawing.Font("Goudy Old Style", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(288, 5)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Titulo.Size = New System.Drawing.Size(265, 35)
        Me.lbl_Titulo.TabIndex = 38
        Me.lbl_Titulo.Text = "Datos de descripción"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(821, 43)
        Me.Label2.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'TerceraPageInsert
        '
        Me.AcceptButton = Me.btn_Siguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 613)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_Capacidad)
        Me.Controls.Add(Me.lbl_Capacidad)
        Me.Controls.Add(Me.cmb_Categorias)
        Me.Controls.Add(Me.cmb_Tipo)
        Me.Controls.Add(Me.btn_Siguiente)
        Me.Controls.Add(Me.txt_Larga)
        Me.Controls.Add(Me.txt_Corta)
        Me.Controls.Add(Me.lbl_DescripcionAbre)
        Me.Controls.Add(Me.lbl_DescripcionNOABRE)
        Me.Controls.Add(Me.lbl_Categoria)
        Me.Controls.Add(Me.lbl_Tipo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "TerceraPageInsert"
        Me.Text = "TerceraPageInsert"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Capacidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Capacidad As System.Windows.Forms.Label
    Friend WithEvents cmb_Categorias As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Siguiente As System.Windows.Forms.Button
    Friend WithEvents txt_Larga As System.Windows.Forms.TextBox
    Friend WithEvents txt_Corta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescripcionAbre As System.Windows.Forms.Label
    Friend WithEvents lbl_DescripcionNOABRE As System.Windows.Forms.Label
    Friend WithEvents lbl_Categoria As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
