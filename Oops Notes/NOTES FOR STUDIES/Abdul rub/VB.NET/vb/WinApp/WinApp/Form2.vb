Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d As Date
        d = Me.TextBox1.Text
        Select Case d.DayOfWeek
            Case DayOfWeek.Monday
                MessageBox.Show("Monday")
            Case DayOfWeek.Tuesday
                MessageBox.Show("Tuesday")
            Case DayOfWeek.Wednesday
                MessageBox.Show("Wedensday")
            Case DayOfWeek.Thursday
                MessageBox.Show("Thursday")
            Case DayOfWeek.Friday
                MessageBox.Show("Friday")
            Case DayOfWeek.Saturday
                MessageBox.Show("Saturday")
            Case DayOfWeek.Sunday
                MessageBox.Show("Sunday")
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not IsDate(Me.TextBox1.Text) Then
            MessageBox.Show("Invalid Date Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim d As Date
        d = Me.TextBox1.Text
        d = d.AddDays(CInt(Me.TextBox2.Text))
        MessageBox.Show("Date is " & d.ToString())
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9 Then
            Me.TextBox2.ReadOnly = True
        End If
    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        Me.TextBox2.ReadOnly = False
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class