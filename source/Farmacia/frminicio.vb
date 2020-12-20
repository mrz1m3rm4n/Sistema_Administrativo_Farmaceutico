Imports System.Data.OleDb

Public Class frmlogin
    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        If valida_empleados() = True Then
            If valida_permisos() = True Then
                frmmenu.Show()
                Me.Close()
            Else
                MsgBox("SU USUARIO ESTA BLOQUEADO", vbInformation, "LOGIN")
                Call resetear_campos()
                tbxusuario.Focus()
            End If
        Else
            MsgBox("ACCESO DENEGADO", vbCritical, "LOGIN")
            Call resetear_campos()
            tbxusuario.Focus()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If MsgBox("¿ESTA SEGURO DE SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "MENU DE LOGIN") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnregistro_Click(sender As Object, e As EventArgs) Handles btnregistro.Click
        frmregistro.Show()
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        cn_Conexion.Close()
    End Sub

    Function valida_campos_completos() As Boolean
        valida_campos_completos = False
        If Len(Trim(tbxusuario.Text)) = 0 Then
            MsgBox("El usuario es vacio", vbInformation, "LOGIN")
            tbxusuario.Focus()
            Exit Function
        ElseIf Len(Trim(tbxcontrasena.Text)) = 0 Then
            MsgBox("La contraseña es vacia", vbInformation, "LOGIN")
            tbxcontrasena.Focus()
            Exit Function
        End If
        valida_campos_completos = True
    End Function

    Function valida_empleados() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        valida_empleados = False

        s_Sql = "SELECT nombre, contrasena FROM cat_empleado WHERE nombre = '" & tbxusuario.Text & "' and contrasena = '" & tbxcontrasena.Text & "'"
        AbrirConexion()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            valida_empleados = True
        Next

        cn_Conexion.Close()
    End Function

    Function valida_permisos() As Boolean
        Dim dt_Datos As New DataTable
        Dim ds_Datos As New DataSet
        Dim s_Sql As String

        valida_permisos = False

        s_Sql = "SELECT id_estatus, nombre, contrasena FROM cat_empleado WHERE id_estatus = 1 and nombre = '" & tbxusuario.Text & "' and contrasena = '" & tbxcontrasena.Text & "'"
        AbrirConexion()
        ds_Datos.Tables.Add(dt_Datos)
        Dim da_Datos As New OleDbDataAdapter(s_Sql, cn_Conexion)
        da_Datos.Fill(dt_Datos)
        For Each DataRow In dt_Datos.Rows
            valida_permisos = True
        Next

        cn_Conexion.Close()
    End Function

    Private Sub resetear_campos()
        tbxusuario.Text = ""
        tbxcontrasena.Text = ""
    End Sub
End Class
