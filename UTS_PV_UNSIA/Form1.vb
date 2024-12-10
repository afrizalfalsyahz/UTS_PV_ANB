Public Class Form1
    Private Sub cmbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbitem.SelectedIndexChanged
        If cmbitem.Text = "Coffee Arabica 100%" Then
            txtharga.Text = 7000
        ElseIf cmbitem.Text = "Coffee Blend" Then
            txtharga.Text = 7500
        ElseIf cmbitem.Text = "Coffee Bajawa" Then
            txtharga.Text = 8000
        ElseIf cmbitem.Text = "Black Tea" Then
            txtharga.Text = 5000
        End If
    End Sub

    Private Sub btnsubtotal_Click(sender As Object, e As EventArgs) Handles btnsubtotal.Click
        txtsubtotal.Text = txtharga.Text * txtjumlah.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            txtdiskon.Text = 10
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            txtdiskon.Text = 20
        End If
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = txtsubtotal.Text - (txtsubtotal.Text * txtdiskon.Text) / 100
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        cmbitem.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        txtdiskon.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False


    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            txtdiskon.Text = 0
        End If
    End Sub
End Class
