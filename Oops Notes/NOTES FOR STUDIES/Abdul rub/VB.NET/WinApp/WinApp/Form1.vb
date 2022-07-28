Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 And n2
        MessageBox.Show("n1 " & n1 & " And n2 " & n2 & " = " & result)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 Or n2
        MessageBox.Show("n1 " & n1 & " Or n2 " & n2 & " = " & result)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 Xor n2
        MessageBox.Show("n1 " & n1 & " Xor n2 " & n2 & " = " & result)

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim n1, n2, result1, result2 As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result1 = Not n1
        result2 = Not n2

        MessageBox.Show("n1 " & n1 & " Not " & result1 & " n2 Not is " & result2)

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 << n2
        MessageBox.Show("n1 " & n1 & " << n2 " & n2 & " = " & result)

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 >> n2
        MessageBox.Show("n1 " & n1 & " >> n2 " & n2 & " = " & result)

    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim n1, n2, result As Integer
        n1 = Me.TextBox1.Text
        n2 = Me.TextBox2.Text
        result = n1 ^ n2
        MessageBox.Show("n1 " & n1 & " ^ n2 " & n2 & " = " & result)

    End Sub
End Class
