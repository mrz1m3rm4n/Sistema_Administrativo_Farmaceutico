Public Class frmmenu
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿ESTA SEGURO DE SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "MENU PRINCIPAL") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnregmedicamento_Click(sender As Object, e As EventArgs) Handles btnregmedicamento.Click
        frmmedicamento.Show()
        Me.Close()
    End Sub

    Private Sub btnregempleado_Click(sender As Object, e As EventArgs) Handles btnregempleado.Click
        frmregistro.Show()
        Me.Close()
    End Sub

    Private Sub btnregcliente_Click(sender As Object, e As EventArgs) Handles btnregcliente.Click
        frmcliente.Show()
        Me.Close()
    End Sub

    Private Sub btnregiproveedor_Click(sender As Object, e As EventArgs) Handles btnregiproveedor.Click
        frmproveedor.Show()
        Me.Close()
    End Sub
End Class