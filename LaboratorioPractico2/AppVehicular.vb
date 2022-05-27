Public Class AppVehicular

    Private Sub AppVehicular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sel As String
        Dim imp, km, mc, cm As Decimal
        sel = ComboBox1.Text
        mc = 30

        Decimal.TryParse(TextBox1.Text, km)
        Decimal.TryParse(TextBox2.Text, cm)


        Select Case sel
            Case "Bicicleta"
                imp = 100
                MsgBox("Importe a pagar por Bicicleta: " & Math.Round(imp, 2))

            Case "Moto"
                Try
                    imp = mc * km
                    MsgBox("Importe a pagar por Moto: " & Math.Round(imp, 2))
                    TextBox1.Text = ""
                Catch ex As Exception
                    MsgBox("Error, solo acepta valores numericos ")
                End Try

            Case "Coche"
                imp = mc * km
                MsgBox("Importe a pagar por Coche: " & Math.Round(imp, 2))
                TextBox1.Text = ""
            Case "Camion"
                imp = km * cm
                MsgBox("Importe a pagar por Camion: " & Math.Round(imp, 2))
            Case Else
                MsgBox("No existe la opcion que trata de buscar")
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Moto" Then
            Label1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = False
            TextBox2.Visible = False
        End If
        If ComboBox1.Text = "Camion" Then
            Label1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True

        End If
        If ComboBox1.Text = "Bicicleta" Then
            Label1.Visible = False
            Label2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
        If ComboBox1.Text = "Coche" Then
            Label1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = False
            TextBox2.Visible = False
        End If

    End Sub


End Class