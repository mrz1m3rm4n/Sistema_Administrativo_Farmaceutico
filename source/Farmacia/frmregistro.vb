Imports System.Data.OleDb
Public Class frmregistro
    Private Sub frmregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Call carga_estatus()
        cn_Conexion.Close()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validar_campos_vacios() = True Then
            If validar_campo_existencia() = False Then
                If Len(Trim(tbxnombre.Text)) >= 0 And Len(Trim(tbxapellidos.Text)) >= 0 Then
                    Call registra_datos()
                    MsgBox("La informacion fue guardada exitosamente", vbInformation, "REGISTRO")
                    Call resetear_campos()
                    Exit Sub
                Else
                    MsgBox("Debe de ingresar la informacion requerida", vbInformation, "REGISTRO")
                    Exit Sub
                End If
            Else
                MsgBox("Ya existe el registro", vbInformation, "REGISTRO")
                Exit Sub
            End If
        End If
    End Sub

    Function validar_campos_vacios() As Boolean
        validar_campos_vacios = False
        If Len(Trim(tbxnombre.Text)) = 0 Then
            MsgBox("El nombre esta vacio", vbInformation, "EMPLEADOS")
            tbxnombre.Focus()
            Exit Function
        ElseIf Len(Trim(tbxapellidos.Text)) = 0 Then
            MsgBox("Los apellidos estan vacios", vbInformation, "EMPLEADOS")
            tbxapellidos.Focus()
            Exit Function
        ElseIf Len(Trim(tbxcelular.Text)) = 0 Then
            MsgBox("El numero celular esta vacio", vbInformation, "EMPLEADOS")
            tbxcelular.Focus()
            Exit Function
        ElseIf Len(Trim(tbxcontrasena.Text)) = 0 Then
            MsgBox("La contraseña esta vacia", vbInformation, "EMPLEADOS")
            tbxcontrasena.Focus()
            Exit Function
        ElseIf Len(Trim(tbxconfirmar.Text)) = 0 Then
            MsgBox("Debe de confirmar su contraseña", vbInformation, "EMPLEADOS")
            tbxconfirmar.Focus()
            Exit Function
        ElseIf cbxestatus.SelectedIndex = -1 Then
            MsgBox("Debe de seleccionar un estatus", vbInformation, "EMPLEADOS")
            cbxestatus.Focus()
            Exit Function
        ElseIf tbxcontrasena.Text <> tbxconfirmar.Text Then
            MsgBox("Contraseña y Confirmar deben ser iguales", vbCritical, "EMPLEADOS")
            Exit Function
        End If
        validar_campos_vacios = True
    End Function

    Function validar_campo_existencia() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        validar_campo_existencia = False

        s_Sql = "SELECT nombre, apellidos FROM cat_empleado WHERE nombre = '" & tbxnombre.Text & "' and apellidos = '" & tbxapellidos.Text & "'"
        AbrirConexion()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            validar_campo_existencia = True
        Next

        cn_Conexion.Close()
    End Function

    Private Sub carga_estatus()
        Dim da_Datos As New OleDb.OleDbDataAdapter("SELECT id_estatus, estatus FROM cat_estatus ORDER BY estatus", cn_Conexion)
        Dim ds_Datos As New DataSet
        da_Datos.Fill(ds_Datos)
        If ds_Datos.Tables(0).Rows.Count > 0 Then
            cbxestatus.DataSource = ds_Datos.Tables(0)
            cbxestatus.DisplayMember = "estatus"
            cbxestatus.ValueMember = "id_estatus"
            cbxestatus.SelectedIndex = -1
        End If
    End Sub

    Private Sub registra_datos()
        Dim s_Sql As String

        s_Sql = "INSERT INTO cat_empleado(id_estatus, contrasena, nombre, apellidos, celular, correo)" _
              & "VALUES ('" & cbxestatus.SelectedValue & "','" & tbxcontrasena.Text & "','" & tbxnombre.Text & "','" & tbxapellidos.Text & "','" _
              & tbxcelular.Text & "','" & tbxcorreo.Text & "')"

        AbrirConexion()
        Dim cm_comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Private Sub resetear_campos()
        tbxnombre.Text = ""
        tbxapellidos.Text = ""
        tbxcelular.Text = ""
        tbxcorreo.Text = ""
        tbxcontrasena.Text = ""
        tbxconfirmar.Text = ""
        cbxestatus.SelectedIndex = -1
    End Sub

    Private Sub tbxcelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxcelular.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE EL NUMERO DE CELULAR", MsgBoxStyle.Exclamation, "EMPLEADO")
        End If
    End Sub
End Class