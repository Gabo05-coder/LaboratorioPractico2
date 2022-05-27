Public Class CalcMorosidad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saldo, saldoTot, saldoD As Decimal

        Try
            saldo = TextBox2.Text
            saldoD = TextBox1.Text
            If saldoD < 30 Then
                MsgBox("Los dias a ingresar debe ser superior a 30")
                TextBox1.Text = ""
            ElseIf saldoD = 30 Or saldoD <= 60 Then
                saldoTot = (saldo * 0.02) + saldo
                MsgBox("La deuda del cliente es : " & saldoTot)
                TextBox1.Text = ""
            ElseIf saldoD = 61 Or saldoD <= 90 Then
                saldoTot = (saldo * 0.05) + saldo
                MsgBox("La deuda del cliente es : " & saldoTot)
                TextBox1.Text = ""
            ElseIf saldoD = 91 Or saldoD <= 129 Then
                saldoTot = (saldo * 0.07) + saldo
                MsgBox("La deuda del cliente es : " & saldoTot)
                TextBox1.Text = ""
            ElseIf saldoD > 129 Then
                saldoTot = (saldo * 0.015) + saldo
                MsgBox("La deuda del cliente es : " & saldoTot)
                TextBox1.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Solo acepta variables numericas")
        End Try
    End Sub


End Class