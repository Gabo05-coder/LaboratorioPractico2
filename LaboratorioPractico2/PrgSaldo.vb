Public Class PrgSaldo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hora, saldo As Decimal

        Try
            hora = TextBox1.Text
            If hora < 0 Then
                MsgBox("No se aceptan Valores negativos")
                TextBox1.Text = ""
            ElseIf hora > 0 Or hora <= 35 Then
                saldo = hora * 15.0
                MsgBox("Su saldo es " & Math.Round(saldo, 2))
                TextBox1.Text = ""
            ElseIf hora > 35 Or hora = 40 Then
            saldo = hora * 25.0
                MsgBox("Su saldo es " & Math.Round(saldo, 2))
                TextBox1.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Caracter erroneo, solo acepta números decimales")
            TextBox1.Text = ""
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class