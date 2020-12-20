Imports System.Data.OleDb

Public Class frmproveedor
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub frmproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        cn_Conexion.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If valida_registros_vacios() = True Then
            If valida_registros_existencia() = False Then
                If Len(Trim(tbxproveedor.Text)) >= 0 And Len(Trim(tbxcontacto.Text)) >= 0 And Len(Trim(tbxcorreo.Text)) >= 0 Then
                    Call registra_datos()
                    MsgBox("Registro guardado", vbInformation, "GUARDA")
                    Call resetear_registros()
                    Exit Sub
                Else
                    MsgBox("Ingrese los datos faltantes", vbInformation, "GUARDA")
                    Exit Sub
                End If
            Else
                MsgBox("Ya existe el registro", vbInformation, "GUARDA")
                Call resetear_registros()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub resetear_registros()
        tbxproveedor.Text = ""
        tbxcontacto.Text = ""
        tbxtelefono.Text = ""
        tbxcelular.Text = ""
        tbxcorreo.Text = ""
    End Sub

    Private Sub registra_datos()
        Dim s_Sql As String

        s_Sql = "INSERT INTO cat_proveedor(proveedor, contacto, telefono, celular, correo)" _
              & "VALUES ('" & tbxproveedor.Text & "','" & tbxcontacto.Text & "','" & tbxtelefono.Text _
              & "','" & tbxcelular.Text & "','" & tbxcorreo.Text & "')"

        cn_Conexion.Open()
        Dim cm_Comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_Comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Function valida_registros_vacios() As Boolean
        valida_registros_vacios = False
        If Len(Trim(tbxproveedor.Text)) = 0 Then
            MsgBox("El proveedor esta vacio", vbInformation, "PROVEEDOR")
            tbxproveedor.Focus()
            Exit Function
        ElseIf Len(Trim(tbxcontacto.Text)) = 0 Then
            MsgBox("El nombre del contacto esta vacio", vbInformation, "PROVEEDOR")
            tbxcontacto.Focus()
            Exit Function
        ElseIf Len(Trim(tbxtelefono.Text)) = 0 Then
            MsgBox("El telefono esta vacio", vbInformation, "PROVEEDOR")
            tbxtelefono.Focus()
            Exit Function
        ElseIf Len(Trim(tbxcorreo.Text)) = 0 Then
            MsgBox("El correo esta vacio", vbInformation, "PROVEEDOR")
            tbxcorreo.Focus()
            Exit Function
        End If
        valida_registros_vacios = True
    End Function

    Function valida_registros_existencia() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        valida_registros_existencia = False

        s_Sql = "SELECT proveedor, contacto, correo FROM cat_proveedor WHERE proveedor = '" & tbxproveedor.Text & "' and contacto = '" _
              & tbxcontacto.Text & "' or contacto = '" & tbxcontacto.Text & "' and correo = '" & tbxcorreo.Text & "'"

        cn_Conexion.Open()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            valida_registros_existencia = True
        Next
        cn_Conexion.Close()
    End Function

    Private Sub tbxtelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxtelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE EL NUMERO DE TELEFONO", MsgBoxStyle.Exclamation, "PROVEEDOR")
        End If
    End Sub

    Private Sub tbxcelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxcelular.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE EL NUMERO DE CELULAR", MsgBoxStyle.Exclamation, "PROVEEDOR")
        End If
    End Sub
End Class