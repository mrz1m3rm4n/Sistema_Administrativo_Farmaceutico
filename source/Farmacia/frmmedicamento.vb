Imports System.Data.OleDb

Public Class frmmedicamento
    Function valida_campos_vacios() As Boolean
        valida_campos_vacios = False
        If cbxproveedor.SelectedIndex = -1 Then
            MsgBox("DEBE DE SELECCIONAR UN PROVEEDOR", vbInformation, "MEDICAMENTO")
            cbxproveedor.Focus()
            Exit Function
        ElseIf Len(Trim(tbxmedicamento.Text)) = 0 Then
            MsgBox("DEBE DE INGRESAR EL NOMBRE DEL MEDICAMENTE", vbInformation, "MEDICAMENTO")
            tbxmedicamento.Focus()
            Exit Function
        ElseIf Len(Trim(mtbfechacaducidad.Text)) = 0 Then
            MsgBox("DEBE DE INTRODUCIR LA FECHA DE CADUCIDAD", vbInformation, "MEDICAMENTO")
            mtbfechacaducidad.Focus()
            Exit Function
        ElseIf Len(Trim(mtbfecharegistro.Text)) = 0 Then
            MsgBox("DEBE DE INTRODUCIR LA FECHA DE CADUCIDAD", vbInformation, "MEDICAMENTO")
            mtbfecharegistro.Focus()
            Exit Function
        ElseIf Len(Trim(tbxdescripcion.Text)) = 0 Then
            MsgBox("DEBE DE INTRODUCIR UNA DESCRIPCION", vbInformation, "MEDICAMENTO")
            tbxdescripcion.Focus()
            Exit Function
        ElseIf Len(Trim(tbxstok.Text)) = 0 Then
            MsgBox("DEBE DE INGREDAR LA CANTIDAD QUE INGRESA AL INVENTARIO", vbInformation, "MEDICAMENTO")
            tbxstok.Focus()
            Exit Function
        ElseIf Len(Trim(tbxminimo.Text)) = 0 Then
            MsgBox("DEBE DE INGRESAR EL MINIMO PARA INVENTARIO")
            tbxminimo.Focus()
            Exit Function
        ElseIf Len(Trim(tbxmaximo.Text)) = 0 Then
            MsgBox("DEBE DE INGRESAR EL MAX PARA INVENTARIO")
            tbxmaximo.Focus()
            Exit Function
        End If
        valida_campos_vacios = True
    End Function

    Function valida_campo_existencia() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        valida_campo_existencia = False

        s_Sql = "SELECT id_proveedor, medicamento, fechacaducidad FROM medicamento WHERE medicamento = '" & tbxmedicamento.Text & "' and fechacaducidad = '" & mtbfechacaducidad.Text & "'"

        AbrirConexion()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            valida_campo_existencia = True
        Next
        cn_Conexion.Close()
    End Function

    Private Sub frmmedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Call carga_proveedor()
        Call carga_info()
        cn_Conexion.Close()
    End Sub

    Private Sub registra_datos()
        Dim s_Sql As String

        s_Sql = "INSERT INTO medicamento(id_proveedor, medicamento, fechacaducidad, fecharegistro, descripcion, stock, stockmin, stockmax)" _
              & "VALUES (" & cbxproveedor.SelectedValue & ",'" & tbxmedicamento.Text & "','" & Format(mtbfechacaducidad.Text, "Short Date") _
              & "','" & Format(mtbfecharegistro.Text, "Short Date") & "','" & tbxdescripcion.Text & "','" & tbxstok.Text & "','" _
              & tbxminimo.Text & "','" & tbxmaximo.Text & "')"

        AbrirConexion()
        Dim cm_Comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_Comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Private Sub actualiza_datos()
        Dim s_Sql As String

        s_Sql = "UPDATE medicamento SET id_proveedor = '" & cbxproveedor.SelectedValue & "', medicamento = '" & tbxmedicamento.Text _
              & "', fechacaducidad = '" & Format(mtbfechacaducidad.Text, "Short Date") & "', fecharegistro = '" & Format(mtbfecharegistro.Text, "Short Date") _
              & "', descripcion = '" & tbxdescripcion.Text & "', stock = '" & tbxstok.Text & "', stockmin = '" & tbxminimo.Text _
              & "', stockmax = '" & tbxmaximo.Text & "' WHERE id_medicamento = " & TextBox1.Text


        AbrirConexion()
        Dim cm_Comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_Comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Private Sub resetear_campos()
        cbxproveedor.SelectedIndex = -1
        tbxmedicamento.Text = ""
        mtbfechacaducidad.Text = ""
        mtbfecharegistro.Text = ""
        tbxdescripcion.Text = ""
        tbxstok.Text = ""
        tbxminimo.Text = ""
        tbxmaximo.Text = ""
    End Sub

    Private Sub carga_proveedor()
        Dim da_Datos As New OleDb.OleDbDataAdapter("SELECT id_proveedor, proveedor FROM cat_proveedor ORDER BY proveedor", cn_Conexion)
        Dim ds_Datos As New DataSet
        da_Datos.Fill(ds_Datos)
        If ds_Datos.Tables(0).Rows.Count > 0 Then
            cbxproveedor.DataSource = ds_Datos.Tables(0)
            cbxproveedor.DisplayMember = "proveedor"
            cbxproveedor.ValueMember = "id_proveedor"
            cbxproveedor.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If valida_campo_existencia() = False Then
            If Len(Trim(cbxproveedor.SelectedIndex)) >= 0 And Len(Trim(tbxmedicamento.Text)) Then
                Call registra_datos()
                MsgBox("DATOS GURADADOS", vbInformation, "MEDICAMENTO")
                Call resetear_campos()
                Exit Sub
            Else
                MsgBox("Ingrese los datos faltantes", vbInformation, "MEDICAMENTO")
                Exit Sub
            End If
        Else
            MsgBox("Ya existe el registro", vbInformation, "MEDICAMENTO")
            Call resetear_campos()
            Exit Sub
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Call actualiza_datos()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub tbxstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxstok.KeyPress, TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE NUMERO", MsgBoxStyle.Exclamation, "MEDICAMENTO")
        End If
    End Sub

    Private Sub tbxminimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxminimo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE NUMERO", MsgBoxStyle.Exclamation, "MEDICAMENTO")
        End If
    End Sub

    Private Sub tbxmaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxmaximo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE NUMERO", MsgBoxStyle.Exclamation, "MEDICAMENTO")
        End If
    End Sub


    Private Sub carga_info()
        Dim ds_Datos As New DataSet
        Dim dt_Datos As New DataTable
        Dim da_Datos As New OleDbDataAdapter
        Dim s_Sql As String

        ds_Datos.Tables.Add(dt_Datos)
        s_Sql = "SELECT medicamento.id_medicamento, cat_proveedor.proveedor, medicamento.medicamento, medicamento.fechacaducidad, medicamento.fecharegistro " _
              & ", medicamento.descripcion, medicamento.stock, medicamento.stockmin, medicamento.stockmax FROM cat_proveedor " _
              & "INNER JOIN medicamento ON cat_proveedor.Id_proveedor = medicamento.id_proveedor "
        da_Datos = New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        dgvmedicamento.DataSource = dt_Datos.DefaultView
    End Sub

    Private Sub dgvmedicamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmedicamento.CellClick
        Dim dgv As DataGridViewRow = dgvmedicamento.Rows(e.RowIndex)
        TextBox1.Text = dgv.Cells(0).Value.ToString()
        cbxproveedor.SelectedText = dgv.Cells(1).Value.ToString()
        tbxmedicamento.Text = dgv.Cells(2).Value.ToString()
        mtbfechacaducidad.Text = dgv.Cells(3).Value.ToString()
        mtbfecharegistro.Text = dgv.Cells(4).Value.ToString()
        tbxdescripcion.Text = dgv.Cells(5).Value.ToString()
        tbxstok.Text = dgv.Cells(6).Value.ToString()
        tbxminimo.Text = dgv.Cells(7).Value.ToString()
        tbxmaximo.Text = dgv.Cells(8).Value.ToString()
    End Sub
End Class