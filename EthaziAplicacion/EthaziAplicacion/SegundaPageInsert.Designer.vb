﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Fondo = New System.Windows.Forms.Label()
        Me.cmb_CodPostal = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Location = New System.Drawing.Point(559, 427)
        Me.btn_Siguiente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(134, 37)
        Me.btn_Siguiente.TabIndex = 48
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'txt_Coordenadas
        '
        Me.txt_Coordenadas.Location = New System.Drawing.Point(478, 299)
        Me.txt_Coordenadas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Coordenadas.Name = "txt_Coordenadas"
        Me.txt_Coordenadas.Size = New System.Drawing.Size(215, 30)
        Me.txt_Coordenadas.TabIndex = 47
        '
        'cmb_Municipio
        '
        Me.cmb_Municipio.FormattingEnabled = True
        Me.cmb_Municipio.Location = New System.Drawing.Point(473, 232)
        Me.cmb_Municipio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_Municipio.Name = "cmb_Municipio"
        Me.cmb_Municipio.Size = New System.Drawing.Size(220, 31)
        Me.cmb_Municipio.TabIndex = 45
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Provincia.FormattingEnabled = True
        Me.cmb_Provincia.Items.AddRange(New Object() {""})
        Me.cmb_Provincia.Location = New System.Drawing.Point(163, 232)
        Me.cmb_Provincia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(157, 31)
        Me.cmb_Provincia.TabIndex = 44
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(163, 147)
        Me.txt_Direccion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(530, 30)
        Me.txt_Direccion.TabIndex = 43
        '
        'lbl_Coordenadas
        '
        Me.lbl_Coordenadas.AutoSize = True
        Me.lbl_Coordenadas.Location = New System.Drawing.Point(351, 307)
        Me.lbl_Coordenadas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Coordenadas.Name = "lbl_Coordenadas"
        Me.lbl_Coordenadas.Size = New System.Drawing.Size(115, 23)
        Me.lbl_Coordenadas.TabIndex = 42
        Me.lbl_Coordenadas.Text = "Coordenadas:"
        '
        'lbl_CodPostal
        '
        Me.lbl_CodPostal.AutoSize = True
        Me.lbl_CodPostal.Location = New System.Drawing.Point(56, 307)
        Me.lbl_CodPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_CodPostal.Name = "lbl_CodPostal"
        Me.lbl_CodPostal.Size = New System.Drawing.Size(103, 23)
        Me.lbl_CodPostal.TabIndex = 41
        Me.lbl_CodPostal.Text = "Cod. Postal:"
        '
        'lbl_Municipio
        '
        Me.lbl_Municipio.AutoSize = True
        Me.lbl_Municipio.Location = New System.Drawing.Point(372, 234)
        Me.lbl_Municipio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Municipio.Name = "lbl_Municipio"
        Me.lbl_Municipio.Size = New System.Drawing.Size(94, 23)
        Me.lbl_Municipio.TabIndex = 40
        Me.lbl_Municipio.Text = "Municipio:"
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(56, 239)
        Me.lbl_Provincia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(86, 23)
        Me.lbl_Provincia.TabIndex = 39
        Me.lbl_Provincia.Text = "Provincia:"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(52, 154)
        Me.lbl_Direccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(90, 23)
        Me.lbl_Direccion.TabIndex = 38
        Me.lbl_Direccion.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(673, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 23)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "(2/4 )"
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Titulo.Font = New System.Drawing.Font("Goudy Old Style", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(277, -2)
        Me.lbl_Titulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Titulo.Size = New System.Drawing.Size(215, 35)
        Me.lbl_Titulo.TabIndex = 33
        Me.lbl_Titulo.Text = "Datos Ubicacion"
        '
        'lbl_Fondo
        '
        Me.lbl_Fondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Fondo.Location = New System.Drawing.Point(0, -2)
        Me.lbl_Fondo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Fondo.Name = "lbl_Fondo"
        Me.lbl_Fondo.Size = New System.Drawing.Size(744, 44)
        Me.lbl_Fondo.TabIndex = 34
        '
        'cmb_CodPostal
        '
        Me.cmb_CodPostal.FormattingEnabled = True
        Me.cmb_CodPostal.Location = New System.Drawing.Point(163, 299)
        Me.cmb_CodPostal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_CodPostal.Name = "cmb_CodPostal"
        Me.cmb_CodPostal.Size = New System.Drawing.Size(132, 31)
        Me.cmb_CodPostal.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.EthaziAplicacion.My.Resources.Resources.exclamation_mark
        Me.PictureBox3.Location = New System.Drawing.Point(698, 239)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.EthaziAplicacion.My.Resources.Resources.exclamation_mark
        Me.PictureBox4.Location = New System.Drawing.Point(301, 313)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 53
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'SegundaPageInsert
        '
        Me.AcceptButton = Me.btn_Siguiente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 522)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
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
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.lbl_Fondo)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "SegundaPageInsert"
        Me.Text = "SegundaPageInsert"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_Fondo As System.Windows.Forms.Label
    Friend WithEvents cmb_CodPostal As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class