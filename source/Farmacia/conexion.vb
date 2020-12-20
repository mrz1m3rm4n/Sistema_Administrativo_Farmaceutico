Module conexion
    Public cn_Conexion As OleDb.OleDbConnection
    Public gi_Opcion As Integer
    Public gi_Clave As Integer

    Public Sub AbrirConexion()
        cn_Conexion = New OleDb.OleDbConnection
        cn_Conexion.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0;Data Source=C:\Farmacia\bd\farmacia.accdb;"
        cn_Conexion.Open()
    End Sub
End Module
