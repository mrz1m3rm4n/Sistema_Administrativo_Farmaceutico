<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmproveedor))
        Me.tbxproveedor = New System.Windows.Forms.TextBox()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.lblcontacto = New System.Windows.Forms.Label()
        Me.tbxcontacto = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.tbxtelefono = New System.Windows.Forms.TextBox()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.tbxcelular = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.tbxcorreo = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxproveedor
        '
        Me.tbxproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxproveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxproveedor.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxproveedor.Location = New System.Drawing.Point(150, 101)
        Me.tbxproveedor.MaxLength = 15
        Me.tbxproveedor.Name = "tbxproveedor"
        Me.tbxproveedor.Size = New System.Drawing.Size(227, 29)
        Me.tbxproveedor.TabIndex = 1
        '
        'lblproveedor
        '
        Me.lblproveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblproveedor.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor.Location = New System.Drawing.Point(44, 103)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(100, 23)
        Me.lblproveedor.TabIndex = 5
        Me.lblproveedor.Text = "Proveedor:"
        Me.lblproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcontacto
        '
        Me.lblcontacto.BackColor = System.Drawing.Color.Transparent
        Me.lblcontacto.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontacto.Location = New System.Drawing.Point(415, 103)
        Me.lblcontacto.Name = "lblcontacto"
        Me.lblcontacto.Size = New System.Drawing.Size(100, 23)
        Me.lblcontacto.TabIndex = 5
        Me.lblcontacto.Text = "Contacto:"
        Me.lblcontacto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tbxcontacto
        '
        Me.tbxcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxcontacto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcontacto.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcontacto.Location = New System.Drawing.Point(521, 101)
        Me.tbxcontacto.MaxLength = 30
        Me.tbxcontacto.Name = "tbxcontacto"
        Me.tbxcontacto.Size = New System.Drawing.Size(227, 29)
        Me.tbxcontacto.TabIndex = 2
        '
        'lbltelefono
        '
        Me.lbltelefono.BackColor = System.Drawing.Color.Transparent
        Me.lbltelefono.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(44, 158)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(100, 23)
        Me.lbltelefono.TabIndex = 5
        Me.lbltelefono.Text = "Telefono:"
        Me.lbltelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxtelefono
        '
        Me.tbxtelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxtelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxtelefono.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxtelefono.Location = New System.Drawing.Point(150, 156)
        Me.tbxtelefono.MaxLength = 10
        Me.tbxtelefono.Name = "tbxtelefono"
        Me.tbxtelefono.Size = New System.Drawing.Size(227, 29)
        Me.tbxtelefono.TabIndex = 3
        '
        'lblcelular
        '
        Me.lblcelular.BackColor = System.Drawing.Color.Transparent
        Me.lblcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcelular.Location = New System.Drawing.Point(415, 158)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(100, 23)
        Me.lblcelular.TabIndex = 5
        Me.lblcelular.Text = "Celular:"
        Me.lblcelular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tbxcelular
        '
        Me.tbxcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxcelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcelular.Location = New System.Drawing.Point(521, 156)
        Me.tbxcelular.MaxLength = 10
        Me.tbxcelular.Name = "tbxcelular"
        Me.tbxcelular.Size = New System.Drawing.Size(227, 29)
        Me.tbxcelular.TabIndex = 4
        '
        'lblcorreo
        '
        Me.lblcorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblcorreo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(44, 212)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(100, 23)
        Me.lblcorreo.TabIndex = 5
        Me.lblcorreo.Text = "Correo:"
        Me.lblcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxcorreo
        '
        Me.tbxcorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxcorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcorreo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcorreo.Location = New System.Drawing.Point(150, 210)
        Me.tbxcorreo.MaxLength = 20
        Me.tbxcorreo.Name = "tbxcorreo"
        Me.tbxcorreo.Size = New System.Drawing.Size(227, 29)
        Me.tbxcorreo.TabIndex = 5
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(462, 205)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 43)
        Me.btnguardar.TabIndex = 6
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(626, 205)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 43)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(698, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(50, 50)
        Me.pbxlogo.TabIndex = 10
        Me.pbxlogo.TabStop = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(42, 21)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(231, 31)
        Me.lbltitulo.TabIndex = 9
        Me.lbltitulo.Text = "Registro de Proveedor"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmproveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.tbxcelular)
        Me.Controls.Add(Me.lblcelular)
        Me.Controls.Add(Me.tbxcontacto)
        Me.Controls.Add(Me.tbxcorreo)
        Me.Controls.Add(Me.tbxtelefono)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.lblcontacto)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.tbxproveedor)
        Me.Controls.Add(Me.lblproveedor)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmproveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE PROVEEDOR"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxproveedor As TextBox
    Friend WithEvents lblproveedor As Label
    Friend WithEvents lblcontacto As Label
    Friend WithEvents tbxcontacto As TextBox
    Friend WithEvents lbltelefono As Label
    Friend WithEvents tbxtelefono As TextBox
    Friend WithEvents lblcelular As Label
    Friend WithEvents tbxcelular As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents tbxcorreo As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents lbltitulo As Label
End Class
