Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbjenis.Items.Add("Yamaha")
        cmbjenis.Items.Add("Honda")
        cmbjenis.Items.Add("Suzuki")
    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenis.SelectedIndexChanged
        If cmbjenis.Text = "Yamaha" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Aerox")
            cmbnama.Items.Add("Nmax")
            cmbnama.Items.Add("Gear")

        ElseIf cmbjenis.Text = "Honda" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Vario")
            cmbnama.Items.Add("Beat")
            cmbnama.Items.Add("Lexi")

        ElseIf cmbjenis.Text = "Suzuki" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Spin")
            cmbnama.Items.Add("Klx")
            cmbnama.Items.Add("Smash")


        End If
    End Sub

    Private Sub cmbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnama.SelectedIndexChanged
        If cmbnama.Text = "Aerox" Then
            txtharga.Text = 25000000
        ElseIf cmbnama.Text = "Nmax" Then
            txtharga.Text = 30000000
        ElseIf cmbnama.Text = "Gear" Then
            txtharga.Text = 14000000
        ElseIf cmbnama.Text = "Vario" Then
            txtharga.Text = 24000000
        ElseIf cmbnama.Text = "Beat" Then
            txtharga.Text = 15000000
        ElseIf cmbnama.Text = "Lexi" Then
            txtharga.Text = 23000000
        ElseIf cmbnama.Text = "Spin" Then
            txtharga.Text = 15000000
        ElseIf cmbnama.Text = "Klx" Then
            txtharga.Text = 28000000
        ElseIf cmbnama.Text = "Smash" Then
            txtharga.Text = 12000000
        End If
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
        If txttotal.Text > 15000000 Then
            txtpotongan.Text = 500000
        Else
            txtpotongan.Text = 0
        End If
        txtbayar.Text = Val(txttotal.Text) - Val(txtpotongan.Text)
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        End
    End Sub
End Class
