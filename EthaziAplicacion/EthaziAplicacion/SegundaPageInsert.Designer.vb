<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegundaPageInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SegundaPageInsert))
        Me.btn_Siguiente = New System.Windows.Forms.Button()
        Me.txt_Coordenadas = New System.Windows.Forms.TextBox()
        Me.cmb_Municipio = New System.Windows.Forms.ComboBox()
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.lbl_Coordenadas = New System.Windows.Forms.Label()
        Me.lbl_CodPostal = New System.Windows.Forms.Label()
        Me.lbl_Municipio = New System.Windows.Forms.Label()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Fondo = New System.Windows.Forms.Label()
        Me.cmb_CodPostal = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Location = New System.Drawing.Point(603, 522)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(148, 40)
        Me.btn_Siguiente.TabIndex = 48
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'txt_Coordenadas
        '
        Me.txt_Coordenadas.Location = New System.Drawing.Point(521, 346)
        Me.txt_Coordenadas.Name = "txt_Coordenadas"
        Me.txt_Coordenadas.Size = New System.Drawing.Size(209, 33)
        Me.txt_Coordenadas.TabIndex = 47
        '
        'cmb_Municipio
        '
        Me.cmb_Municipio.FormattingEnabled = True
        Me.cmb_Municipio.Location = New System.Drawing.Point(521, 252)
        Me.cmb_Municipio.Name = "cmb_Municipio"
        Me.cmb_Municipio.Size = New System.Drawing.Size(209, 33)
        Me.cmb_Municipio.TabIndex = 45
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.FormattingEnabled = True
        Me.cmb_Provincia.Items.AddRange(New Object() {""})
        Me.cmb_Provincia.Location = New System.Drawing.Point(196, 252)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(173, 33)
        Me.cmb_Provincia.TabIndex = 44
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(196, 160)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(566, 33)
        Me.txt_Direccion.TabIndex = 43
        '
        'lbl_Coordenadas
        '
        Me.lbl_Coordenadas.AutoSize = True
        Me.lbl_Coordenadas.Location = New System.Drawing.Point(366, 349)
        Me.lbl_Coordenadas.Name = "lbl_Coordenadas"
        Me.lbl_Coordenadas.Size = New System.Drawing.Size(129, 25)
        Me.lbl_Coordenadas.TabIndex = 42
        Me.lbl_Coordenadas.Text = "Coordenadas:"
        '
        'lbl_CodPostal
        '
        Me.lbl_CodPostal.AutoSize = True
        Me.lbl_CodPostal.Location = New System.Drawing.Point(90, 349)
        Me.lbl_CodPostal.Name = "lbl_CodPostal"
        Me.lbl_CodPostal.Size = New System.Drawing.Size(113, 25)
        Me.lbl_CodPostal.TabIndex = 41
        Me.lbl_CodPostal.Text = "Cod. Postal:"
        '
        'lbl_Municipio
        '
        Me.lbl_Municipio.AutoSize = True
        Me.lbl_Municipio.Location = New System.Drawing.Point(389, 260)
        Me.lbl_Municipio.Name = "lbl_Municipio"
        Me.lbl_Municipio.Size = New System.Drawing.Size(106, 25)
        Me.lbl_Municipio.TabIndex = 40
        Me.lbl_Municipio.Text = "Municipio:"
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(90, 260)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(96, 25)
        Me.lbl_Provincia.TabIndex = 39
        Me.lbl_Provincia.Text = "Provincia:"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(90, 168)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(100, 25)
        Me.lbl_Direccion.TabIndex = 38
        Me.lbl_Direccion.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(741, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "/4 )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(728, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(717, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 25)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "("
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Titulo.Font = New System.Drawing.Font("Goudy Old Style", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(304, 3)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Titulo.Size = New System.Drawing.Size(215, 35)
        Me.lbl_Titulo.TabIndex = 33
        Me.lbl_Titulo.Text = "Datos Ubicacion"
        '
        'lbl_Fondo
        '
        Me.lbl_Fondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lbl_Fondo.Location = New System.Drawing.Point(0, -2)
        Me.lbl_Fondo.Name = "lbl_Fondo"
        Me.lbl_Fondo.Size = New System.Drawing.Size(819, 43)
        Me.lbl_Fondo.TabIndex = 34
        '
        'cmb_CodPostal
        '
        Me.cmb_CodPostal.FormattingEnabled = True
        Me.cmb_CodPostal.Location = New System.Drawing.Point(196, 341)
        Me.cmb_CodPostal.Name = "cmb_CodPostal"
        Me.cmb_CodPostal.Size = New System.Drawing.Size(145, 33)
        Me.cmb_CodPostal.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'SegundaPageInsert
        '
        Me.AcceptButton = Me.btn_Siguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 613)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_CodPostal)
        Me.Controls.Add(Me.btn_Siguiente)
        Me.Controls.Add(Me.txt_Coordenadas)
        Me.Controls.Add(Me.cmb_Municipio)
        Me.Controls.Add(Me.cmb_Provincia)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.lbl_Coordenadas)
        Me.Controls.Add(Me.lbl_CodPostal)
        Me.Controls.Add(Me.lbl_Municipio)
        Me.Controls.Add(Me.lbl_Provincia)
        Me.Controls.Add(Me.lbl_Direccion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.lbl_Fondo)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SegundaPageInsert"
        Me.Text = "SegundaPageInsert"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Siguiente As System.Windows.Forms.Button
    Friend WithEvents txt_Coordenadas As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Municipio As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Coordenadas As System.Windows.Forms.Label
    Friend WithEvents lbl_CodPostal As System.Windows.Forms.Label
    Friend WithEvents lbl_Municipio As System.Windows.Forms.Label
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_Fondo As System.Windows.Forms.Label
    Friend WithEvents cmb_CodPostal As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
