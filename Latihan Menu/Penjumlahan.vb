Public Class Penjumlahan
    Private Sub Btn_tambah_Click(sender As Object, e As EventArgs) Handles Btn_tambah.Click
        Lb_operasi.Text = "+"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_hasil_Click(sender As Object, e As EventArgs) Handles Btn_hasil.Click
        Dim oper As String
        Dim bil1 As Int32
        Dim bil2 As Int32

        bil1 = Convert.ToInt32(Txt_bil1.Text)
        bil2 = Convert.ToInt32(Txt_bil2.Text)

        oper = Lb_operasi.Text
        Select Case oper
            Case "+"
                Txt_hasil.Text = (bil1 + bil2).ToString
            Case "-"
                Txt_hasil.Text = (bil1 - bil2).ToString
            Case "X"
                Txt_hasil.Text = (bil1 * bil2).ToString
            Case "/"
                Txt_hasil.Text = (bil1 / bil2).ToString

        End Select


    End Sub

    Private Sub Btn_bagi_Click(sender As Object, e As EventArgs) Handles Btn_bagi.Click
        Lb_operasi.Text = "/"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_kali_Click(sender As Object, e As EventArgs) Handles Btn_kali.Click
        Lb_operasi.Text = "X"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_kurang_Click(sender As Object, e As EventArgs) Handles Btn_kurang.Click
        Lb_operasi.Text = "-"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        Btn_7.Text = "7"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click

    End Sub
End Class