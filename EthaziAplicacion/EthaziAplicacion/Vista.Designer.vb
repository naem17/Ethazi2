﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vista))
        Me.txt_Firma = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_descripcionNOabre = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_DescripcionNOABRE = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcionAbre = New System.Windows.Forms.Label()
        Me.lbl_Firma = New System.Windows.Forms.Label()
        Me.btn_actualizarDato = New System.Windows.Forms.Button()
        Me.pb_Restablecer = New System.Windows.Forms.PictureBox()
        Me.txt_descripcionAbre = New System.Windows.Forms.TextBox()
        Me.lbl_Capacidad = New System.Windows.Forms.Label()
        Me.lbl_Coordenadas = New System.Windows.Forms.Label()
        Me.lbl_Municipio = New System.Windows.Forms.Label()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.lbl_Categoria = New System.Windows.Forms.Label()
        Me.lbl_Codpostal = New System.Windows.Forms.Label()
        Me.cmb_Municipio = New System.Windows.Forms.ComboBox()
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox()
        Me.txt_Coordenadas = New System.Windows.Forms.TextBox()
        Me.txt_Capacidad = New System.Windows.Forms.TextBox()
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.cmb_Categoria = New System.Windows.Forms.ComboBox()
        Me.ckb_Gastro = New System.Windows.Forms.CheckBox()
        Me.ckb_Club = New System.Windows.Forms.CheckBox()
        Me.ckb_Tienda = New System.Windows.Forms.CheckBox()
        Me.ckb_Restaurante = New System.Windows.Forms.CheckBox()
        Me.ckb_Autocaravana = New System.Windows.Forms.CheckBox()
        Me.ckb_Surfing = New System.Windows.Forms.CheckBox()
        Me.ckb_calidad = New System.Windows.Forms.CheckBox()
        Me.txt_descripcionAbreEus = New System.Windows.Forms.TextBox()
        Me.txt_descripcionNoAbreEus = New System.Windows.Forms.TextBox()
        Me.lbl_Web = New System.Windows.Forms.Label()
        Me.txt_Web = New System.Windows.Forms.TextBox()
        Me.lbl_Aviso = New System.Windows.Forms.Label()
        Me.btn_euskera = New System.Windows.Forms.Button()
        Me.cmb_CodPostal = New System.Windows.Forms.ComboBox()
        CType(Me.pb_Restablecer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Firma
        '
        Me.txt_Firma.Enabled = False
        Me.txt_Firma.Location = New System.Drawing.Point(389, 27)
        Me.txt_Firma.Name = "txt_Firma"
        Me.txt_Firma.Size = New System.Drawing.Size(235, 33)
        Me.txt_Firma.TabIndex = 26
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(126, 159)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(509, 33)
        Me.txt_Direccion.TabIndex = 25
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(496, 89)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(453, 33)
        Me.txt_Email.TabIndex = 24
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(758, 159)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(191, 33)
        Me.txt_Telefono.TabIndex = 23
        '
        'txt_descripcionNOabre
        '
        Me.txt_descripcionNOabre.Location = New System.Drawing.Point(37, 552)
        Me.txt_descripcionNOabre.Multiline = True
        Me.txt_descripcionNOabre.Name = "txt_descripcionNOabre"
        Me.txt_descripcionNOabre.Size = New System.Drawing.Size(673, 115)
        Me.txt_descripcionNOabre.TabIndex = 22
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(127, 92)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(292, 33)
        Me.txt_Nombre.TabIndex = 21
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(25, 172)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(95, 25)
        Me.lbl_Direccion.TabIndex = 20
        Me.lbl_Direccion.Text = "Direccion"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(650, 167)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(93, 25)
        Me.lbl_Telefono.TabIndex = 19
        Me.lbl_Telefono.Text = "Telefono:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(420, 95)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(66, 25)
        Me.lbl_Email.TabIndex = 18
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_DescripcionNOABRE
        '
        Me.lbl_DescripcionNOABRE.AutoSize = True
        Me.lbl_DescripcionNOABRE.Location = New System.Drawing.Point(32, 524)
        Me.lbl_DescripcionNOABRE.Name = "lbl_DescripcionNOABRE"
        Me.lbl_DescripcionNOABRE.Size = New System.Drawing.Size(179, 25)
        Me.lbl_DescripcionNOABRE.TabIndex = 17
        Me.lbl_DescripcionNOABRE.Text = "Descripcion extensa"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(32, 97)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(88, 25)
        Me.lbl_Nombre.TabIndex = 16
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_descripcionAbre
        '
        Me.lbl_descripcionAbre.AutoSize = True
        Me.lbl_descripcionAbre.Location = New System.Drawing.Point(32, 423)
        Me.lbl_descripcionAbre.Name = "lbl_descripcionAbre"
        Me.lbl_descripcionAbre.Size = New System.Drawing.Size(203, 25)
        Me.lbl_descripcionAbre.TabIndex = 15
        Me.lbl_descripcionAbre.Text = "Descripción  abreviada"
        '
        'lbl_Firma
        '
        Me.lbl_Firma.AutoSize = True
        Me.lbl_Firma.Location = New System.Drawing.Point(294, 35)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(67, 25)
        Me.lbl_Firma.TabIndex = 14
        Me.lbl_Firma.Text = "Firma:"
        '
        'btn_actualizarDato
        '
        Me.btn_actualizarDato.Location = New System.Drawing.Point(773, 637)
        Me.btn_actualizarDato.Name = "btn_actualizarDato"
        Me.btn_actualizarDato.Size = New System.Drawing.Size(176, 40)
        Me.btn_actualizarDato.TabIndex = 27
        Me.btn_actualizarDato.Text = "Editar datos"
        Me.btn_actualizarDato.UseVisualStyleBackColor = True
        '
        'pb_Restablecer
        '
        Me.pb_Restablecer.Image = CType(resources.GetObject("pb_Restablecer.Image"), System.Drawing.Image)
        Me.pb_Restablecer.Location = New System.Drawing.Point(735, 647)
        Me.pb_Restablecer.Name = "pb_Restablecer"
        Me.pb_Restablecer.Size = New System.Drawing.Size(30, 30)
        Me.pb_Restablecer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_Restablecer.TabIndex = 28
        Me.pb_Restablecer.TabStop = False
        '
        'txt_descripcionAbre
        '
        Me.txt_descripcionAbre.Location = New System.Drawing.Point(37, 457)
        Me.txt_descripcionAbre.Multiline = True
        Me.txt_descripcionAbre.Name = "txt_descripcionAbre"
        Me.txt_descripcionAbre.Size = New System.Drawing.Size(923, 47)
        Me.txt_descripcionAbre.TabIndex = 29
        '
        'lbl_Capacidad
        '
        Me.lbl_Capacidad.AutoSize = True
        Me.lbl_Capacidad.Location = New System.Drawing.Point(346, 299)
        Me.lbl_Capacidad.Name = "lbl_Capacidad"
        Me.lbl_Capacidad.Size = New System.Drawing.Size(106, 25)
        Me.lbl_Capacidad.TabIndex = 35
        Me.lbl_Capacidad.Text = "Capacidad:"
        '
        'lbl_Coordenadas
        '
        Me.lbl_Coordenadas.AutoSize = True
        Me.lbl_Coordenadas.Location = New System.Drawing.Point(32, 299)
        Me.lbl_Coordenadas.Name = "lbl_Coordenadas"
        Me.lbl_Coordenadas.Size = New System.Drawing.Size(129, 25)
        Me.lbl_Coordenadas.TabIndex = 38
        Me.lbl_Coordenadas.Text = "Coordenadas:"
        '
        'lbl_Municipio
        '
        Me.lbl_Municipio.AutoSize = True
        Me.lbl_Municipio.Location = New System.Drawing.Point(32, 236)
        Me.lbl_Municipio.Name = "lbl_Municipio"
        Me.lbl_Municipio.Size = New System.Drawing.Size(106, 25)
        Me.lbl_Municipio.TabIndex = 39
        Me.lbl_Municipio.Text = "Municipio:"
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(346, 231)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(96, 25)
        Me.lbl_Provincia.TabIndex = 40
        Me.lbl_Provincia.Text = "Provincia:"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(32, 353)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(58, 25)
        Me.lbl_Tipo.TabIndex = 41
        Me.lbl_Tipo.Text = "Tipo:"
        '
        'lbl_Categoria
        '
        Me.lbl_Categoria.AutoSize = True
        Me.lbl_Categoria.Location = New System.Drawing.Point(242, 348)
        Me.lbl_Categoria.Name = "lbl_Categoria"
        Me.lbl_Categoria.Size = New System.Drawing.Size(98, 25)
        Me.lbl_Categoria.TabIndex = 42
        Me.lbl_Categoria.Text = "Categoria:"
        '
        'lbl_Codpostal
        '
        Me.lbl_Codpostal.AutoSize = True
        Me.lbl_Codpostal.Location = New System.Drawing.Point(641, 236)
        Me.lbl_Codpostal.Name = "lbl_Codpostal"
        Me.lbl_Codpostal.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Codpostal.TabIndex = 43
        Me.lbl_Codpostal.Text = "Cod. Postal:"
        '
        'cmb_Municipio
        '
        Me.cmb_Municipio.FormattingEnabled = True
        Me.cmb_Municipio.Location = New System.Drawing.Point(157, 228)
        Me.cmb_Municipio.Name = "cmb_Municipio"
        Me.cmb_Municipio.Size = New System.Drawing.Size(183, 33)
        Me.cmb_Municipio.TabIndex = 44
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.FormattingEnabled = True
        Me.cmb_Provincia.Location = New System.Drawing.Point(448, 228)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(187, 33)
        Me.cmb_Provincia.TabIndex = 45
        '
        'txt_Coordenadas
        '
        Me.txt_Coordenadas.Location = New System.Drawing.Point(157, 296)
        Me.txt_Coordenadas.Name = "txt_Coordenadas"
        Me.txt_Coordenadas.Size = New System.Drawing.Size(184, 33)
        Me.txt_Coordenadas.TabIndex = 47
        '
        'txt_Capacidad
        '
        Me.txt_Capacidad.Location = New System.Drawing.Point(448, 291)
        Me.txt_Capacidad.Name = "txt_Capacidad"
        Me.txt_Capacidad.Size = New System.Drawing.Size(59, 33)
        Me.txt_Capacidad.TabIndex = 48
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(96, 345)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(121, 33)
        Me.cmb_Tipo.TabIndex = 49
        '
        'cmb_Categoria
        '
        Me.cmb_Categoria.FormattingEnabled = True
        Me.cmb_Categoria.Location = New System.Drawing.Point(347, 345)
        Me.cmb_Categoria.Name = "cmb_Categoria"
        Me.cmb_Categoria.Size = New System.Drawing.Size(121, 33)
        Me.cmb_Categoria.TabIndex = 50
        '
        'ckb_Gastro
        '
        Me.ckb_Gastro.AutoSize = True
        Me.ckb_Gastro.Location = New System.Drawing.Point(516, 347)
        Me.ckb_Gastro.Name = "ckb_Gastro"
        Me.ckb_Gastro.Size = New System.Drawing.Size(152, 29)
        Me.ckb_Gastro.TabIndex = 51
        Me.ckb_Gastro.Text = "Gastronomico"
        Me.ckb_Gastro.UseVisualStyleBackColor = True
        '
        'ckb_Club
        '
        Me.ckb_Club.AutoSize = True
        Me.ckb_Club.Location = New System.Drawing.Point(692, 347)
        Me.ckb_Club.Name = "ckb_Club"
        Me.ckb_Club.Size = New System.Drawing.Size(73, 29)
        Me.ckb_Club.TabIndex = 52
        Me.ckb_Club.Text = "Club"
        Me.ckb_Club.UseVisualStyleBackColor = True
        '
        'ckb_Tienda
        '
        Me.ckb_Tienda.AutoSize = True
        Me.ckb_Tienda.Location = New System.Drawing.Point(804, 347)
        Me.ckb_Tienda.Name = "ckb_Tienda"
        Me.ckb_Tienda.Size = New System.Drawing.Size(91, 29)
        Me.ckb_Tienda.TabIndex = 53
        Me.ckb_Tienda.Text = "Tienda"
        Me.ckb_Tienda.UseVisualStyleBackColor = True
        '
        'ckb_Restaurante
        '
        Me.ckb_Restaurante.AutoSize = True
        Me.ckb_Restaurante.Location = New System.Drawing.Point(516, 382)
        Me.ckb_Restaurante.Name = "ckb_Restaurante"
        Me.ckb_Restaurante.Size = New System.Drawing.Size(130, 29)
        Me.ckb_Restaurante.TabIndex = 54
        Me.ckb_Restaurante.Text = "Restaurante"
        Me.ckb_Restaurante.UseVisualStyleBackColor = True
        '
        'ckb_Autocaravana
        '
        Me.ckb_Autocaravana.AutoSize = True
        Me.ckb_Autocaravana.Location = New System.Drawing.Point(804, 382)
        Me.ckb_Autocaravana.Name = "ckb_Autocaravana"
        Me.ckb_Autocaravana.Size = New System.Drawing.Size(145, 29)
        Me.ckb_Autocaravana.TabIndex = 55
        Me.ckb_Autocaravana.Text = "Autocaravana"
        Me.ckb_Autocaravana.UseVisualStyleBackColor = True
        '
        'ckb_Surfing
        '
        Me.ckb_Surfing.AutoSize = True
        Me.ckb_Surfing.Location = New System.Drawing.Point(692, 382)
        Me.ckb_Surfing.Name = "ckb_Surfing"
        Me.ckb_Surfing.Size = New System.Drawing.Size(93, 29)
        Me.ckb_Surfing.TabIndex = 56
        Me.ckb_Surfing.Text = "Surfing"
        Me.ckb_Surfing.UseVisualStyleBackColor = True
        '
        'ckb_calidad
        '
        Me.ckb_calidad.AutoSize = True
        Me.ckb_calidad.Location = New System.Drawing.Point(516, 422)
        Me.ckb_calidad.Name = "ckb_calidad"
        Me.ckb_calidad.Size = New System.Drawing.Size(97, 29)
        Me.ckb_calidad.TabIndex = 57
        Me.ckb_calidad.Text = "Calidad"
        Me.ckb_calidad.UseVisualStyleBackColor = True
        '
        'txt_descripcionAbreEus
        '
        Me.txt_descripcionAbreEus.Location = New System.Drawing.Point(37, 457)
        Me.txt_descripcionAbreEus.Multiline = True
        Me.txt_descripcionAbreEus.Name = "txt_descripcionAbreEus"
        Me.txt_descripcionAbreEus.Size = New System.Drawing.Size(923, 47)
        Me.txt_descripcionAbreEus.TabIndex = 58
        Me.txt_descripcionAbreEus.Visible = False
        '
        'txt_descripcionNoAbreEus
        '
        Me.txt_descripcionNoAbreEus.Location = New System.Drawing.Point(37, 552)
        Me.txt_descripcionNoAbreEus.Multiline = True
        Me.txt_descripcionNoAbreEus.Name = "txt_descripcionNoAbreEus"
        Me.txt_descripcionNoAbreEus.Size = New System.Drawing.Size(673, 115)
        Me.txt_descripcionNoAbreEus.TabIndex = 59
        Me.txt_descripcionNoAbreEus.Visible = False
        '
        'lbl_Web
        '
        Me.lbl_Web.AutoSize = True
        Me.lbl_Web.Location = New System.Drawing.Point(513, 299)
        Me.lbl_Web.Name = "lbl_Web"
        Me.lbl_Web.Size = New System.Drawing.Size(57, 25)
        Me.lbl_Web.TabIndex = 60
        Me.lbl_Web.Text = "Web:"
        '
        'txt_Web
        '
        Me.txt_Web.Location = New System.Drawing.Point(576, 291)
        Me.txt_Web.Name = "txt_Web"
        Me.txt_Web.Size = New System.Drawing.Size(384, 33)
        Me.txt_Web.TabIndex = 61
        '
        'lbl_Aviso
        '
        Me.lbl_Aviso.AutoSize = True
        Me.lbl_Aviso.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Aviso.Location = New System.Drawing.Point(38, 685)
        Me.lbl_Aviso.Name = "lbl_Aviso"
        Me.lbl_Aviso.Size = New System.Drawing.Size(381, 21)
        Me.lbl_Aviso.TabIndex = 62
        Me.lbl_Aviso.Text = "*Si quieres que tus descripciones esten tambien en Euskera"
        '
        'btn_euskera
        '
        Me.btn_euskera.Location = New System.Drawing.Point(854, 518)
        Me.btn_euskera.Name = "btn_euskera"
        Me.btn_euskera.Size = New System.Drawing.Size(106, 37)
        Me.btn_euskera.TabIndex = 65
        Me.btn_euskera.Text = "*Euskera"
        Me.btn_euskera.UseVisualStyleBackColor = True
        '
        'cmb_CodPostal
        '
        Me.cmb_CodPostal.FormattingEnabled = True
        Me.cmb_CodPostal.Location = New System.Drawing.Point(758, 236)
        Me.cmb_CodPostal.Name = "cmb_CodPostal"
        Me.cmb_CodPostal.Size = New System.Drawing.Size(147, 33)
        Me.cmb_CodPostal.TabIndex = 67
        '
        'Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 715)
        Me.Controls.Add(Me.cmb_CodPostal)
        Me.Controls.Add(Me.btn_euskera)
        Me.Controls.Add(Me.lbl_Aviso)
        Me.Controls.Add(Me.txt_Web)
        Me.Controls.Add(Me.lbl_Web)
        Me.Controls.Add(Me.txt_descripcionNoAbreEus)
        Me.Controls.Add(Me.txt_descripcionAbreEus)
        Me.Controls.Add(Me.ckb_calidad)
        Me.Controls.Add(Me.ckb_Surfing)
        Me.Controls.Add(Me.ckb_Autocaravana)
        Me.Controls.Add(Me.ckb_Restaurante)
        Me.Controls.Add(Me.ckb_Tienda)
        Me.Controls.Add(Me.ckb_Club)
        Me.Controls.Add(Me.ckb_Gastro)
        Me.Controls.Add(Me.cmb_Categoria)
        Me.Controls.Add(Me.cmb_Tipo)
        Me.Controls.Add(Me.txt_Capacidad)
        Me.Controls.Add(Me.txt_Coordenadas)
        Me.Controls.Add(Me.cmb_Provincia)
        Me.Controls.Add(Me.cmb_Municipio)
        Me.Controls.Add(Me.lbl_Codpostal)
        Me.Controls.Add(Me.lbl_Categoria)
        Me.Controls.Add(Me.lbl_Tipo)
        Me.Controls.Add(Me.lbl_Provincia)
        Me.Controls.Add(Me.lbl_Municipio)
        Me.Controls.Add(Me.lbl_Coordenadas)
        Me.Controls.Add(Me.lbl_Capacidad)
        Me.Controls.Add(Me.txt_descripcionAbre)
        Me.Controls.Add(Me.pb_Restablecer)
        Me.Controls.Add(Me.btn_actualizarDato)
        Me.Controls.Add(Me.txt_Firma)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_descripcionNOabre)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Direccion)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_DescripcionNOABRE)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_descripcionAbre)
        Me.Controls.Add(Me.lbl_Firma)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Vista"
        Me.Text = "CamposInsersion"
        CType(Me.pb_Restablecer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Firma As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcionNOabre As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents lbl_DescripcionNOABRE As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcionAbre As System.Windows.Forms.Label
    Friend WithEvents lbl_Firma As System.Windows.Forms.Label
    Friend WithEvents btn_actualizarDato As System.Windows.Forms.Button
    Friend WithEvents pb_Restablecer As System.Windows.Forms.PictureBox
    Friend WithEvents txt_descripcionAbre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Capacidad As System.Windows.Forms.Label
    Friend WithEvents lbl_Coordenadas As System.Windows.Forms.Label
    Friend WithEvents lbl_Municipio As System.Windows.Forms.Label
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_Categoria As System.Windows.Forms.Label
    Friend WithEvents lbl_Codpostal As System.Windows.Forms.Label
    Friend WithEvents cmb_Municipio As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Coordenadas As System.Windows.Forms.TextBox
    Friend WithEvents txt_Capacidad As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents ckb_Gastro As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Club As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Tienda As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Restaurante As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Autocaravana As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Surfing As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_calidad As System.Windows.Forms.CheckBox
    Friend WithEvents txt_descripcionAbreEus As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcionNoAbreEus As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Web As System.Windows.Forms.Label
    Friend WithEvents txt_Web As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Aviso As System.Windows.Forms.Label
    Friend WithEvents btn_euskera As System.Windows.Forms.Button
    Friend WithEvents cmb_CodPostal As System.Windows.Forms.ComboBox
End Class