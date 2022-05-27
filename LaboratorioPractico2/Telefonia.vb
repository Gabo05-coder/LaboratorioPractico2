Public Class Telefonia
    Dim numN, numNL, numI, totN, totNL, totI, numG, numTot, numTotB As Double
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            numTotB = numTot - 0.3
            TextBox6.Text = Math.Round(numTotB, 2)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numG = Val(TextBox4.Text)

        'Nacional
        numN = Val(TextBox1.Text)
        totN = numN * 0.03


        'Nacional Distanciado
        numNL = Val(TextBox2.Text)
        totNL = numNL * 0.06

        'Internacional
        numI = Val(TextBox3.Text)
        totI = numI * 0.1





        If numG = (numN + numNL + numI) Or numG = numN Or numG = numNL Or numG = numI Or numG = (numN + numNL) Or numG = (numN + numI) Or numG = (numNL + numI) Then
            numTot = totN + totNL + totI
            TextBox5.Text = Math.Round(numTot, 2)
        Else
            MsgBox("Los Valores ingresados no concuerdan, asegurese de su algebra")
        End If
    End Sub

    Private Sub Telefonia_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Enabled = True

        Else
            TextBox3.Enabled = False
        End If
    End Sub
End Class