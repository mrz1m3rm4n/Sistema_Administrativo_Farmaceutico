Imports System.Data.OleDb

Friend Class OleDbAdapter
    Private s_Sql As String
    Private cn_Conexion As OleDbConnection

    Public Sub New(s_Sql As String, cn_Conexion As OleDbConnection)
        Me.s_Sql = s_Sql
        Me.cn_Conexion = cn_Conexion
    End Sub
End Class
