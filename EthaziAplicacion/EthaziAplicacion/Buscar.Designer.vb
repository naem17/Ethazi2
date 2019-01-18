<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscar))
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_capacidad = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.ckb_provincias = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.ckb_tipos = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(47, 65)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(88, 25)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Provincia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(168, 65)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(361, 33)
        Me.txt_Nombre.TabIndex = 4
        '
        'txt_capacidad
        '
        Me.txt_capacidad.Location = New System.Drawing.Point(168, 161)
        Me.txt_capacidad.Name = "txt_capacidad"
        Me.txt_capacidad.Size = New System.Drawing.Size(65, 33)
        Me.txt_capacidad.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(250, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Items.AddRange(New Object() {""})
        Me.cmb_provincia.Location = New System.Drawing.Point(168, 112)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(121, 33)
        Me.cmb_provincia.TabIndex = 10
        '
        'ckb_provincias
        '
        Me.ckb_provincias.AutoSize = True
        Me.ckb_provincias.Location = New System.Drawing.Point(302, 114)
        Me.ckb_provincias.Name = "ckb_provincias"
        Me.ckb_provincias.Size = New System.Drawing.Size(227, 29)
        Me.ckb_provincias.TabIndex = 11
        Me.ckb_provincias.Text = "Ver todas las provincias"
        Me.ckb_provincias.UseVisualStyleBackColor = True
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(350, 161)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(179, 33)
        Me.cmb_tipo.TabIndex = 12
        '
        'ckb_tipos
        '
        Me.ckb_tipos.AutoSize = True
        Me.ckb_tipos.Location = New System.Drawing.Point(350, 200)
        Me.ckb_tipos.Name = "ckb_tipos"
        Me.ckb_tipos.Size = New System.Drawing.Size(186, 29)
        Me.ckb_tipos.TabIndex = 13
        Me.ckb_tipos.Text = "Ver todos los tipos"
        Me.ckb_tipos.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 274)
        Me.Controls.Add(Me.ckb_tipos)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.ckb_provincias)
        Me.Controls.Add(Me.cmb_provincia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_capacidad)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nombre)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Buscar"
        Me.Text = "Buscar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_capacidad As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents ckb_provincias As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents ckb_tipos As System.Windows.Forms.CheckBox
End Class
