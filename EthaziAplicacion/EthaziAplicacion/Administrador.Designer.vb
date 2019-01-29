<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrador))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.EDITARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActulizarBBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAPAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Alojamientos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(10, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 604)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EDITARToolStripMenuItem, Me.InsertarToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ActulizarBBDDToolStripMenuItem, Me.MAPAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(300, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1212, 31)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.ImportarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(109, 27)
        Me.FileToolStripMenuItem.Text = "ARCHIVO"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.ImportarToolStripMenuItem.Text = "Exportar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(149, 6)
        '
        'EDITARToolStripMenuItem
        '
        Me.EDITARToolStripMenuItem.Name = "EDITARToolStripMenuItem"
        Me.EDITARToolStripMenuItem.Size = New System.Drawing.Size(90, 27)
        Me.EDITARToolStripMenuItem.Text = "EDITAR"
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(112, 27)
        Me.InsertarToolStripMenuItem.Text = "INSERTAR"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(110, 27)
        Me.DeleteToolStripMenuItem.Text = "ELIMINAR"
        '
        'ActulizarBBDDToolStripMenuItem
        '
        Me.ActulizarBBDDToolStripMenuItem.Name = "ActulizarBBDDToolStripMenuItem"
        Me.ActulizarBBDDToolStripMenuItem.Size = New System.Drawing.Size(194, 27)
        Me.ActulizarBBDDToolStripMenuItem.Text = "ACTUALIZAR BBDD"
        '
        'MAPAToolStripMenuItem
        '
        Me.MAPAToolStripMenuItem.Name = "MAPAToolStripMenuItem"
        Me.MAPAToolStripMenuItem.Size = New System.Drawing.Size(74, 27)
        Me.MAPAToolStripMenuItem.Text = "MAPA"
        '
        'lbl_Alojamientos
        '
        Me.lbl_Alojamientos.AutoSize = True
        Me.lbl_Alojamientos.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_Alojamientos.Location = New System.Drawing.Point(11, 44)
        Me.lbl_Alojamientos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Alojamientos.Name = "lbl_Alojamientos"
        Me.lbl_Alojamientos.Size = New System.Drawing.Size(185, 21)
        Me.lbl_Alojamientos.TabIndex = 7
        Me.lbl_Alojamientos.Text = "TABLA ALOJAMIENTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1150, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 687)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Alojamientos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Administrador"
        Me.Text = "ADMINISTRAR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActulizarBBDDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbl_Alojamientos As System.Windows.Forms.Label
    Friend WithEvents EDITARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MAPAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
