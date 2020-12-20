<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.tbxusuario = New System.Windows.Forms.TextBox()
        Me.tbxcontrasena = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblcontrasena = New System.Windows.Forms.Label()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.InitialImage = CType(resources.GetObject("pbxlogo.InitialImage"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(179, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(157, 157)
        Me.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxlogo.TabIndex = 0
        Me.pbxlogo.TabStop = False
        '
        'btniniciar
        '
        Me.btniniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btniniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btniniciar.FlatAppearance.BorderSize = 0
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniniciar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciar.ForeColor = System.Drawing.Color.White
        Me.btniniciar.Location = New System.Drawing.Point(202, 346)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(108, 43)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "INICIAR"
        Me.btniniciar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(139, 406)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 43)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnregistro
        '
        Me.btnregistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistro.FlatAppearance.BorderSize = 0
        Me.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistro.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistro.ForeColor = System.Drawing.Color.White
        Me.btnregistro.Location = New System.Drawing.Point(266, 406)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Size = New System.Drawing.Size(108, 43)
        Me.btnregistro.TabIndex = 5
        Me.btnregistro.Text = "REGISTRO"
        Me.btnregistro.UseVisualStyleBackColor = False
        '
        'tbxusuario
        '
        Me.tbxusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxusuario.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxusuario.Location = New System.Drawing.Point(139, 226)
        Me.tbxusuario.MaxLength = 10
        Me.tbxusuario.Name = "tbxusuario"
        Me.tbxusuario.Size = New System.Drawing.Size(235, 29)
        Me.tbxusuario.TabIndex = 1
        '
        'tbxcontrasena
        '
        Me.tbxcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxcontrasena.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxcontrasena.Location = New System.Drawing.Point(139, 302)
        Me.tbxcontrasena.MaxLength = 10
        Me.tbxcontrasena.Name = "tbxcontrasena"
        Me.tbxcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxcontrasena.Size = New System.Drawing.Size(235, 29)
        Me.tbxcontrasena.TabIndex = 2
        '
        'lblusuario
        '
        Me.lblusuario.BackColor = System.Drawing.Color.Transparent
        Me.lblusuario.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.Location = New System.Drawing.Point(135, 190)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(100, 23)
        Me.lblusuario.TabIndex = 3
        Me.lblusuario.Text = "Usuario:"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcontrasena
        '
        Me.lblcontrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblcontrasena.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontrasena.Location = New System.Drawing.Point(135, 270)
        Me.lblcontrasena.Name = "lblcontrasena"
        Me.lblcontrasena.Size = New System.Drawing.Size(100, 23)
        Me.lblcontrasena.TabIndex = 3
        Me.lblcontrasena.Text = "Contraseña:"
        Me.lblcontrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcontrasena)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.tbxcontrasena)
        Me.Controls.Add(Me.tbxusuario)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.btnregistro)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btniniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FARMACIA BIENSALUD"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents btniniciar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnregistro As Button
    Friend WithEvents tbxusuario As TextBox
    Friend WithEvents tbxcontrasena As TextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblcontrasena As Label
End Class
