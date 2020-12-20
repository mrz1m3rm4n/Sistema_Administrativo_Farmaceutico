<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmedicamento))
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.tbxmedicamento = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblmedicamento = New System.Windows.Forms.Label()
        Me.lblfechacaducidad = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.lblfecharegistro = New System.Windows.Forms.Label()
        Me.cbxproveedor = New System.Windows.Forms.ComboBox()
        Me.mtbfechacaducidad = New System.Windows.Forms.MaskedTextBox()
        Me.mtbfecharegistro = New System.Windows.Forms.MaskedTextBox()
        Me.tbxdescripcion = New System.Windows.Forms.TextBox()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.tbxstok = New System.Windows.Forms.TextBox()
        Me.lblminimo = New System.Windows.Forms.Label()
        Me.tbxminimo = New System.Windows.Forms.TextBox()
        Me.lblmaximo = New System.Windows.Forms.Label()
        Me.tbxmaximo = New System.Windows.Forms.TextBox()
        Me.dgvmedicamento = New System.Windows.Forms.DataGridView()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxlogo
        '
        Me.pbxlogo.BackgroundImage = CType(resources.GetObject("pbxlogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(766, 16)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(50, 50)
        Me.pbxlogo.TabIndex = 24
        Me.pbxlogo.TabStop = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(46, 35)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(474, 31)
        Me.lbltitulo.TabIndex = 23
        Me.lbltitulo.Text = "REGISTRO Y CONTROL DE MEDICAMENTO"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(219, 377)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 43)
        Me.btnguardar.TabIndex = 9
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
        Me.btncancelar.Location = New System.Drawing.Point(566, 377)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 43)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'tbxmedicamento
        '
        Me.tbxmedicamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxmedicamento.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxmedicamento.Location = New System.Drawing.Point(589, 107)
        Me.tbxmedicamento.MaxLength = 25
        Me.tbxmedicamento.Name = "tbxmedicamento"
        Me.tbxmedicamento.Size = New System.Drawing.Size(227, 29)
        Me.tbxmedicamento.TabIndex = 2
        '
        'lbldescripcion
        '
        Me.lbldescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcion.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(69, 214)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(100, 23)
        Me.lbldescripcion.TabIndex = 12
        Me.lbldescripcion.Text = "Descripcion:"
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmedicamento
        '
        Me.lblmedicamento.BackColor = System.Drawing.Color.Transparent
        Me.lblmedicamento.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedicamento.Location = New System.Drawing.Point(467, 111)
        Me.lblmedicamento.Name = "lblmedicamento"
        Me.lblmedicamento.Size = New System.Drawing.Size(107, 23)
        Me.lblmedicamento.TabIndex = 13
        Me.lblmedicamento.Text = "Medicamento:"
        Me.lblmedicamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblfechacaducidad
        '
        Me.lblfechacaducidad.BackColor = System.Drawing.Color.Transparent
        Me.lblfechacaducidad.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechacaducidad.Location = New System.Drawing.Point(33, 162)
        Me.lblfechacaducidad.Name = "lblfechacaducidad"
        Me.lblfechacaducidad.Size = New System.Drawing.Size(136, 23)
        Me.lblfechacaducidad.TabIndex = 14
        Me.lblfechacaducidad.Text = "Fecha Cadicidad:"
        Me.lblfechacaducidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblproveedor
        '
        Me.lblproveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblproveedor.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor.Location = New System.Drawing.Point(37, 107)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(132, 23)
        Me.lblproveedor.TabIndex = 15
        Me.lblproveedor.Text = "Proveedor:"
        Me.lblproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecharegistro
        '
        Me.lblfecharegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblfecharegistro.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecharegistro.Location = New System.Drawing.Point(451, 162)
        Me.lblfecharegistro.Name = "lblfecharegistro"
        Me.lblfecharegistro.Size = New System.Drawing.Size(136, 23)
        Me.lblfecharegistro.TabIndex = 14
        Me.lblfecharegistro.Text = "Fecha Registro:"
        Me.lblfecharegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxproveedor
        '
        Me.cbxproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxproveedor.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxproveedor.FormattingEnabled = True
        Me.cbxproveedor.Location = New System.Drawing.Point(190, 107)
        Me.cbxproveedor.Name = "cbxproveedor"
        Me.cbxproveedor.Size = New System.Drawing.Size(224, 31)
        Me.cbxproveedor.TabIndex = 1
        '
        'mtbfechacaducidad
        '
        Me.mtbfechacaducidad.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbfechacaducidad.Location = New System.Drawing.Point(190, 158)
        Me.mtbfechacaducidad.Mask = "00/00/0000"
        Me.mtbfechacaducidad.Name = "mtbfechacaducidad"
        Me.mtbfechacaducidad.Size = New System.Drawing.Size(224, 32)
        Me.mtbfechacaducidad.TabIndex = 3
        '
        'mtbfecharegistro
        '
        Me.mtbfecharegistro.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbfecharegistro.Location = New System.Drawing.Point(589, 158)
        Me.mtbfecharegistro.Mask = "00/00/0000"
        Me.mtbfecharegistro.Name = "mtbfecharegistro"
        Me.mtbfecharegistro.Size = New System.Drawing.Size(227, 32)
        Me.mtbfecharegistro.TabIndex = 4
        '
        'tbxdescripcion
        '
        Me.tbxdescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxdescripcion.Location = New System.Drawing.Point(190, 214)
        Me.tbxdescripcion.Multiline = True
        Me.tbxdescripcion.Name = "tbxdescripcion"
        Me.tbxdescripcion.Size = New System.Drawing.Size(626, 88)
        Me.tbxdescripcion.TabIndex = 5
        '
        'lblstock
        '
        Me.lblstock.BackColor = System.Drawing.Color.Transparent
        Me.lblstock.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.Location = New System.Drawing.Point(129, 314)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(107, 23)
        Me.lblstock.TabIndex = 13
        Me.lblstock.Text = "Existencias:"
        Me.lblstock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tbxstok
        '
        Me.tbxstok.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxstok.Location = New System.Drawing.Point(251, 310)
        Me.tbxstok.Name = "tbxstok"
        Me.tbxstok.Size = New System.Drawing.Size(76, 29)
        Me.tbxstok.TabIndex = 6
        '
        'lblminimo
        '
        Me.lblminimo.BackColor = System.Drawing.Color.Transparent
        Me.lblminimo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminimo.Location = New System.Drawing.Point(357, 312)
        Me.lblminimo.Name = "lblminimo"
        Me.lblminimo.Size = New System.Drawing.Size(107, 23)
        Me.lblminimo.TabIndex = 13
        Me.lblminimo.Text = "Minimo:"
        Me.lblminimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tbxminimo
        '
        Me.tbxminimo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxminimo.Location = New System.Drawing.Point(479, 308)
        Me.tbxminimo.Name = "tbxminimo"
        Me.tbxminimo.Size = New System.Drawing.Size(76, 29)
        Me.tbxminimo.TabIndex = 7
        '
        'lblmaximo
        '
        Me.lblmaximo.BackColor = System.Drawing.Color.Transparent
        Me.lblmaximo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaximo.Location = New System.Drawing.Point(584, 312)
        Me.lblmaximo.Name = "lblmaximo"
        Me.lblmaximo.Size = New System.Drawing.Size(107, 23)
        Me.lblmaximo.TabIndex = 13
        Me.lblmaximo.Text = "Maximo:"
        Me.lblmaximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tbxmaximo
        '
        Me.tbxmaximo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxmaximo.Location = New System.Drawing.Point(706, 308)
        Me.tbxmaximo.Name = "tbxmaximo"
        Me.tbxmaximo.Size = New System.Drawing.Size(76, 29)
        Me.tbxmaximo.TabIndex = 8
        '
        'dgvmedicamento
        '
        Me.dgvmedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmedicamento.Location = New System.Drawing.Point(6, 438)
        Me.dgvmedicamento.Name = "dgvmedicamento"
        Me.dgvmedicamento.Size = New System.Drawing.Size(844, 200)
        Me.dgvmedicamento.TabIndex = 25
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Location = New System.Drawing.Point(391, 377)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(108, 43)
        Me.btnactualizar.TabIndex = 9
        Me.btnactualizar.Text = "ACTUALIZAR"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(73, 377)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 29)
        Me.TextBox1.TabIndex = 6
        '
        'frmmedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvmedicamento)
        Me.Controls.Add(Me.tbxdescripcion)
        Me.Controls.Add(Me.mtbfecharegistro)
        Me.Controls.Add(Me.mtbfechacaducidad)
        Me.Controls.Add(Me.cbxproveedor)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.tbxmaximo)
        Me.Controls.Add(Me.tbxminimo)
        Me.Controls.Add(Me.lblmaximo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbxstok)
        Me.Controls.Add(Me.lblminimo)
        Me.Controls.Add(Me.tbxmedicamento)
        Me.Controls.Add(Me.lblstock)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.lblmedicamento)
        Me.Controls.Add(Me.lblfecharegistro)
        Me.Controls.Add(Me.lblfechacaducidad)
        Me.Controls.Add(Me.lblproveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmedicamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO Y CONTROL DE MEDICAMENTOS"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents tbxmedicamento As TextBox
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents lblmedicamento As Label
    Friend WithEvents lblfechacaducidad As Label
    Friend WithEvents lblproveedor As Label
    Friend WithEvents lblfecharegistro As Label
    Friend WithEvents cbxproveedor As ComboBox
    Friend WithEvents mtbfechacaducidad As MaskedTextBox
    Friend WithEvents mtbfecharegistro As MaskedTextBox
    Friend WithEvents tbxdescripcion As TextBox
    Friend WithEvents lblstock As Label
    Friend WithEvents tbxstok As TextBox
    Friend WithEvents lblminimo As Label
    Friend WithEvents tbxminimo As TextBox
    Friend WithEvents lblmaximo As Label
    Friend WithEvents tbxmaximo As TextBox
    Friend WithEvents dgvmedicamento As DataGridView
    Friend WithEvents btnactualizar As Button
    Friend WithEvents TextBox1 As TextBox
End Class
