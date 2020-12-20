<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.btnpventa = New System.Windows.Forms.Button()
        Me.btnregmedicamento = New System.Windows.Forms.Button()
        Me.btnregempleado = New System.Windows.Forms.Button()
        Me.btnregcliente = New System.Windows.Forms.Button()
        Me.btngridmedicamento = New System.Windows.Forms.Button()
        Me.btngridempleado = New System.Windows.Forms.Button()
        Me.btngridcliente = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btninformacion = New System.Windows.Forms.Button()
        Me.btnregiproveedor = New System.Windows.Forms.Button()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.Location = New System.Drawing.Point(31, 68)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(233, 233)
        Me.pbxlogo.TabIndex = 0
        Me.pbxlogo.TabStop = False
        '
        'btnpventa
        '
        Me.btnpventa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnpventa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpventa.FlatAppearance.BorderSize = 0
        Me.btnpventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpventa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpventa.ForeColor = System.Drawing.Color.White
        Me.btnpventa.Location = New System.Drawing.Point(312, 35)
        Me.btnpventa.Name = "btnpventa"
        Me.btnpventa.Size = New System.Drawing.Size(193, 43)
        Me.btnpventa.TabIndex = 10
        Me.btnpventa.Text = "PANEL VENTA"
        Me.btnpventa.UseVisualStyleBackColor = False
        '
        'btnregmedicamento
        '
        Me.btnregmedicamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnregmedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregmedicamento.FlatAppearance.BorderSize = 0
        Me.btnregmedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregmedicamento.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregmedicamento.ForeColor = System.Drawing.Color.White
        Me.btnregmedicamento.Location = New System.Drawing.Point(312, 98)
        Me.btnregmedicamento.Name = "btnregmedicamento"
        Me.btnregmedicamento.Size = New System.Drawing.Size(193, 43)
        Me.btnregmedicamento.TabIndex = 10
        Me.btnregmedicamento.Text = "REGISTRO MEDICAMENTO"
        Me.btnregmedicamento.UseVisualStyleBackColor = False
        '
        'btnregempleado
        '
        Me.btnregempleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnregempleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregempleado.FlatAppearance.BorderSize = 0
        Me.btnregempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregempleado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregempleado.ForeColor = System.Drawing.Color.White
        Me.btnregempleado.Location = New System.Drawing.Point(312, 162)
        Me.btnregempleado.Name = "btnregempleado"
        Me.btnregempleado.Size = New System.Drawing.Size(193, 43)
        Me.btnregempleado.TabIndex = 10
        Me.btnregempleado.Text = "REGISTRO EMPLEADO"
        Me.btnregempleado.UseVisualStyleBackColor = False
        '
        'btnregcliente
        '
        Me.btnregcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnregcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregcliente.FlatAppearance.BorderSize = 0
        Me.btnregcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregcliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregcliente.ForeColor = System.Drawing.Color.White
        Me.btnregcliente.Location = New System.Drawing.Point(312, 224)
        Me.btnregcliente.Name = "btnregcliente"
        Me.btnregcliente.Size = New System.Drawing.Size(193, 43)
        Me.btnregcliente.TabIndex = 10
        Me.btnregcliente.Text = "REGISTRO CLIENTE"
        Me.btnregcliente.UseVisualStyleBackColor = False
        '
        'btngridmedicamento
        '
        Me.btngridmedicamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btngridmedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngridmedicamento.FlatAppearance.BorderSize = 0
        Me.btngridmedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngridmedicamento.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngridmedicamento.ForeColor = System.Drawing.Color.White
        Me.btngridmedicamento.Location = New System.Drawing.Point(533, 98)
        Me.btngridmedicamento.Name = "btngridmedicamento"
        Me.btngridmedicamento.Size = New System.Drawing.Size(193, 43)
        Me.btngridmedicamento.TabIndex = 10
        Me.btngridmedicamento.Text = "GRID MEDICAMENTO"
        Me.btngridmedicamento.UseVisualStyleBackColor = False
        '
        'btngridempleado
        '
        Me.btngridempleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btngridempleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngridempleado.FlatAppearance.BorderSize = 0
        Me.btngridempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngridempleado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngridempleado.ForeColor = System.Drawing.Color.White
        Me.btngridempleado.Location = New System.Drawing.Point(533, 162)
        Me.btngridempleado.Name = "btngridempleado"
        Me.btngridempleado.Size = New System.Drawing.Size(193, 43)
        Me.btngridempleado.TabIndex = 10
        Me.btngridempleado.Text = "GRID EMPLEADO"
        Me.btngridempleado.UseVisualStyleBackColor = False
        '
        'btngridcliente
        '
        Me.btngridcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btngridcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngridcliente.FlatAppearance.BorderSize = 0
        Me.btngridcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngridcliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngridcliente.ForeColor = System.Drawing.Color.White
        Me.btngridcliente.Location = New System.Drawing.Point(533, 224)
        Me.btngridcliente.Name = "btngridcliente"
        Me.btngridcliente.Size = New System.Drawing.Size(193, 43)
        Me.btngridcliente.TabIndex = 10
        Me.btngridcliente.Text = "GRID CLIENTE"
        Me.btngridcliente.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(370, 288)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 43)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btninformacion
        '
        Me.btninformacion.BackColor = System.Drawing.Color.Transparent
        Me.btninformacion.BackgroundImage = CType(resources.GetObject("btninformacion.BackgroundImage"), System.Drawing.Image)
        Me.btninformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btninformacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninformacion.FlatAppearance.BorderSize = 0
        Me.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninformacion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninformacion.ForeColor = System.Drawing.Color.White
        Me.btninformacion.Location = New System.Drawing.Point(607, 282)
        Me.btninformacion.Name = "btninformacion"
        Me.btninformacion.Size = New System.Drawing.Size(55, 55)
        Me.btninformacion.TabIndex = 10
        Me.btninformacion.UseVisualStyleBackColor = False
        '
        'btnregiproveedor
        '
        Me.btnregiproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnregiproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregiproveedor.FlatAppearance.BorderSize = 0
        Me.btnregiproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregiproveedor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregiproveedor.ForeColor = System.Drawing.Color.White
        Me.btnregiproveedor.Location = New System.Drawing.Point(533, 35)
        Me.btnregiproveedor.Name = "btnregiproveedor"
        Me.btnregiproveedor.Size = New System.Drawing.Size(193, 43)
        Me.btnregiproveedor.TabIndex = 10
        Me.btnregiproveedor.Text = "REGISTRO PROVEEDOR"
        Me.btnregiproveedor.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 375)
        Me.Controls.Add(Me.btninformacion)
        Me.Controls.Add(Me.btngridcliente)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngridempleado)
        Me.Controls.Add(Me.btnregcliente)
        Me.Controls.Add(Me.btngridmedicamento)
        Me.Controls.Add(Me.btnregempleado)
        Me.Controls.Add(Me.btnregmedicamento)
        Me.Controls.Add(Me.btnregiproveedor)
        Me.Controls.Add(Me.btnpventa)
        Me.Controls.Add(Me.pbxlogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents btnpventa As Button
    Friend WithEvents btnregmedicamento As Button
    Friend WithEvents btnregempleado As Button
    Friend WithEvents btnregcliente As Button
    Friend WithEvents btngridmedicamento As Button
    Friend WithEvents btngridempleado As Button
    Friend WithEvents btngridcliente As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btninformacion As Button
    Friend WithEvents btnregiproveedor As Button
End Class
