Public Class Index
    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        PrgSaldo.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Programa Cerrado")
        Me.Close()
    End Sub

    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        CalcMorosidad.ShowDialog()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        AppVehicular.ShowDialog()
    End Sub

    Private Sub Problema4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem.Click
        Telefonia.ShowDialog()
    End Sub
End Class
