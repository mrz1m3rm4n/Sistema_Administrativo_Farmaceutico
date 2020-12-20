<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistro))
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.tbxnombre = New System.Windows.Forms.TextBox()
        Me.tbxapellidos = New System.Windows.Forms.TextBox()
        Me.tbxcelular = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblcontrasena = New System.Windows.Forms.Label()
        Me.tbxcontrasena = New System.Windows.Forms.TextBox()
        Me.lblconfirmar = New System.Windows.Forms.Label()
        Me.tbxconfirmar = New System.Windows.Forms.TextBox()
        Me.lblestatus = New System.Windows.Forms.Label()
        Me.cbxestatus = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.tbxcorreo = New System.Windows.Forms.TextBox()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(44, 90)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(100, 23)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombre:"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblapellidos
        '
        Me.lblapellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblapellidos.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellidos.Location = New System.Drawing.Point(421, 89)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(100, 23)
        Me.lblapellidos.TabIndex = 2
        Me.lblapellidos.Text = "Apellidos:"
        Me.lblapellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcelular
        '
        Me.lblcelular.BackColor = System.Drawing.Color.Transparent
        Me.lblcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcelular.Location = New System.Drawing.Point(44, 141)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(100, 23)
        Me.lblcelular.TabIndex = 3
        Me.lblcelular.Text = "Celular:"
        Me.lblcelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxnombre
        '
        Me.tbxnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxnombre.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnombre.Location = New System.Drawing.Point(150, 88)
        Me.tbxnombre.MaxLength = 10
        Me.tbxnombre.Name = "tbxnombre"
        Me.tbxnombre.Size = New System.Drawing.Size(227, 29)
        Me.tbxnombre.TabIndex = 1
        '
        'tbxapellidos
        '
        Me.tbxapellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxapellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxapellidos.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxapellidos.Location = New System.Drawing.Point(527, 87)
        Me.tbxapellidos.MaxLength = 25
        Me.tbxapellidos.Name = "tbxapellidos"
        Me.tbxapellidos.Size = New System.Drawing.Size(227, 29)
        Me.tbxapellidos.TabIndex = 2
        '
        'tbxcelular
        '
        Me.tbxcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxcelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcelular.Location = New System.Drawing.Point(150, 139)
        Me.tbxcelular.MaxLength = 10
        Me.tbxcelular.Name = "tbxcelular"
        Me.tbxcelular.Size = New System.Drawing.Size(227, 29)
        Me.tbxcelular.TabIndex = 3
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(273, 312)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 43)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblcontrasena
        '
        Me.lblcontrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblcontrasena.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontrasena.Location = New System.Drawing.Point(421, 140)
        Me.lblcontrasena.Name = "lblcontrasena"
        Me.lblcontrasena.Size = New System.Drawing.Size(100, 23)
        Me.lblcontrasena.TabIndex = 3
        Me.lblcontrasena.Text = "Contraseña:"
        Me.lblcontrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxcontrasena
        '
        Me.tbxcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcontrasena.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcontrasena.Location = New System.Drawing.Point(527, 138)
        Me.tbxcontrasena.MaxLength = 10
        Me.tbxcontrasena.Name = "tbxcontrasena"
        Me.tbxcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxcontrasena.Size = New System.Drawing.Size(227, 29)
        Me.tbxcontrasena.TabIndex = 4
        '
        'lblconfirmar
        '
        Me.lblconfirmar.BackColor = System.Drawing.Color.Transparent
        Me.lblconfirmar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmar.Location = New System.Drawing.Point(44, 196)
        Me.lblconfirmar.Name = "lblconfirmar"
        Me.lblconfirmar.Size = New System.Drawing.Size(100, 23)
        Me.lblconfirmar.TabIndex = 3
        Me.lblconfirmar.Text = "Confirmar:"
        Me.lblconfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxconfirmar
        '
        Me.tbxconfirmar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxconfirmar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxconfirmar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxconfirmar.Location = New System.Drawing.Point(150, 194)
        Me.tbxconfirmar.MaxLength = 10
        Me.tbxconfirmar.Name = "tbxconfirmar"
        Me.tbxconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxconfirmar.Size = New System.Drawing.Size(227, 29)
        Me.tbxconfirmar.TabIndex = 5
        '
        'lblestatus
        '
        Me.lblestatus.BackColor = System.Drawing.Color.Transparent
        Me.lblestatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestatus.Location = New System.Drawing.Point(421, 196)
        Me.lblestatus.Name = "lblestatus"
        Me.lblestatus.Size = New System.Drawing.Size(100, 23)
        Me.lblestatus.TabIndex = 3
        Me.lblestatus.Text = "Estatus:"
        Me.lblestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxestatus
        '
        Me.cbxestatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxestatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxestatus.FormattingEnabled = True
        Me.cbxestatus.Location = New System.Drawing.Point(528, 193)
        Me.cbxestatus.Name = "cbxestatus"
        Me.cbxestatus.Size = New System.Drawing.Size(226, 31)
        Me.cbxestatus.TabIndex = 6
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(413, 312)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 43)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(42, 21)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(298, 31)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "Registro de Nuevo Empleado"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(704, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(50, 50)
        Me.pbxlogo.TabIndex = 7
        Me.pbxlogo.TabStop = False
        '
        'lblcorreo
        '
        Me.lblcorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblcorreo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(249, 262)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(100, 23)
        Me.lblcorreo.TabIndex = 3
        Me.lblcorreo.Text = "Correo:"
        Me.lblcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxcorreo
        '
        Me.tbxcorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxcorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcorreo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcorreo.Location = New System.Drawing.Point(355, 260)
        Me.tbxcorreo.Name = "tbxcorreo"
        Me.tbxcorreo.Size = New System.Drawing.Size(227, 29)
        Me.tbxcorreo.TabIndex = 7
        '
        'frmregistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.cbxestatus)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.tbxcorreo)
        Me.Controls.Add(Me.tbxconfirmar)
        Me.Controls.Add(Me.tbxcontrasena)
        Me.Controls.Add(Me.lblestatus)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.tbxcelular)
        Me.Controls.Add(Me.lblconfirmar)
        Me.Controls.Add(Me.tbxapellidos)
        Me.Controls.Add(Me.lblcontrasena)
        Me.Controls.Add(Me.tbxnombre)
        Me.Controls.Add(Me.lblcelular)
        Me.Controls.Add(Me.lblapellidos)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lbltitulo)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmregistro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRAR EMPLEADO"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblapellidos As Label
    Friend WithEvents lblcelular As Label
    Friend WithEvents tbxnombre As TextBox
    Friend WithEvents tbxapellidos As TextBox
    Friend WithEvents tbxcelular As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblcontrasena As Label
    Friend WithEvents tbxcontrasena As TextBox
    Friend WithEvents lblconfirmar As Label
    Friend WithEvents tbxconfirmar As TextBox
    Friend WithEvents lblestatus As Label
    Friend WithEvents cbxestatus As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents tbxcorreo As TextBox
End Class
