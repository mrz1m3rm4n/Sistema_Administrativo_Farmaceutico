Imports System.Data.OleDb

Public Class frmcliente
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        cn_Conexion.Close()
    End Sub

    Function valida_campo_vacio() As Boolean
        valida_campo_vacio = False
        If Len(Trim(tbxnombre.Text)) = 0 Then
            MsgBox("El nombre esta vacio", vbInformation, "CLIENTE")
            tbxnombre.Focus()
            Exit Function
        ElseIf Len(Trim(tbxapellidos.Text)) = 0 Then
            MsgBox("Los apellidos estan vacios", vbInformation, "CLIENTE")
            tbxapellidos.Focus()
            Exit Function
        End If
        valida_campo_vacio = True
    End Function

    Function valida_campo_existente() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        valida_campo_existente = False

        s_Sql = "SELECT nombre, apellidos FROM cat_cliente WHERE nombre = '" & tbxnombre.Text & "' and apellidos = '" & tbxapellidos.Text & "'"
        AbrirConexion()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            valida_campo_existente = True
        Next
        cn_Conexion.Close()
    End Function

    Private Sub cargar_registros()
        Dim s_Sql As String

        s_Sql = "INSERT INTO cat_cliente(nombre, apellidos, celular)" _
              & "VALUES ('" & tbxnombre.Text & "','" & tbxapellidos.Text & "','" & tbxcelular.Text & "')"

        AbrirConexion()
        Dim cm_Comando As New OleDbCommand(s_Sql, cn_Conexion)
        cm_Comando.ExecuteNonQuery()
        cn_Conexion.Close()
    End Sub

    Private Sub resetear_campos()
        tbxnombre.Text = ""
        tbxapellidos.Text = ""
        tbxcelular.Text = ""
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If valida_campo_vacio() = True Then
            If valida_campo_existente() = False Then
                If Len(Trim(tbxnombre.Text)) >= 0 And Len(Trim(tbxapellidos.Text)) >= 0 Then
                    Call cargar_registros()
                    MsgBox("Se registro exitosamente la informacion", vbInformation, "CLIENTE")
                    Call resetear_campos()
                    Exit Sub
                Else
                    MsgBox("Debe de ingresar los datos necesarios", vbInformation, "CLIENTE")
                    Exit Sub
                End If
            Else
                MsgBox("El cliente ya se encuentra registrado", vbInformation, "CLIENTE")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tbxcelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxcelular.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO SE PERMITE EL NUMERO DE CELULAR", MsgBoxStyle.Exclamation, "CLIENTE")
        End If
    End Sub
End Class