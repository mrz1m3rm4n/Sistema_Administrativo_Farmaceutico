<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.tbxcelular = New System.Windows.Forms.TextBox()
        Me.tbxapellidos = New System.Windows.Forms.TextBox()
        Me.tbxnombre = New System.Windows.Forms.TextBox()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(702, 21)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(50, 50)
        Me.pbxlogo.TabIndex = 23
        Me.pbxlogo.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(606, 150)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 43)
        Me.btnguardar.TabIndex = 4
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
        Me.btncancelar.Location = New System.Drawing.Point(466, 150)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 43)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'tbxcelular
        '
        Me.tbxcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcelular.Location = New System.Drawing.Point(148, 148)
        Me.tbxcelular.MaxLength = 10
        Me.tbxcelular.Name = "tbxcelular"
        Me.tbxcelular.Size = New System.Drawing.Size(227, 29)
        Me.tbxcelular.TabIndex = 3
        '
        'tbxapellidos
        '
        Me.tbxapellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxapellidos.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxapellidos.Location = New System.Drawing.Point(525, 96)
        Me.tbxapellidos.MaxLength = 25
        Me.tbxapellidos.Name = "tbxapellidos"
        Me.tbxapellidos.Size = New System.Drawing.Size(227, 29)
        Me.tbxapellidos.TabIndex = 2
        '
        'tbxnombre
        '
        Me.tbxnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxnombre.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnombre.Location = New System.Drawing.Point(148, 97)
        Me.tbxnombre.MaxLength = 10
        Me.tbxnombre.Name = "tbxnombre"
        Me.tbxnombre.Size = New System.Drawing.Size(227, 29)
        Me.tbxnombre.TabIndex = 1
        '
        'lblcelular
        '
        Me.lblcelular.BackColor = System.Drawing.Color.Transparent
        Me.lblcelular.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcelular.Location = New System.Drawing.Point(42, 150)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(100, 23)
        Me.lblcelular.TabIndex = 14
        Me.lblcelular.Text = "Celular:"
        Me.lblcelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblapellidos
        '
        Me.lblapellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblapellidos.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellidos.Location = New System.Drawing.Point(419, 98)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(100, 23)
        Me.lblapellidos.TabIndex = 10
        Me.lblapellidos.Text = "Apellidos:"
        Me.lblapellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(42, 99)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(100, 23)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "Nombre:"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(40, 30)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(210, 31)
        Me.lbltitulo.TabIndex = 8
        Me.lbltitulo.Text = "Registro de Clientes"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.tbxcelular)
        Me.Controls.Add(Me.tbxapellidos)
        Me.Controls.Add(Me.tbxnombre)
        Me.Controls.Add(Me.lblcelular)
        Me.Controls.Add(Me.lblapellidos)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE CLIENTES"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents tbxcelular As TextBox
    Friend WithEvents tbxapellidos As TextBox
    Friend WithEvents tbxnombre As TextBox
    Friend WithEvents lblcelular As Label
    Friend WithEvents lblapellidos As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lbltitulo As Label
End Class
