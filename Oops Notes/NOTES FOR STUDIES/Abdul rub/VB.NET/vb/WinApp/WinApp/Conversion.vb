Public Class Conversion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        If IsNumeric(Me.TextBox1.Text) = False Then
            MessageBox.Show("Invalid Input of Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox1.Text = ""
            Me.TextBox1.Focus()

            Exit Sub
        End If
        For i = 1 To CInt(Me.TextBox1.Text)
            Call Module1.CBin(i)
        Next

    End Sub

    Private Sub Conversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
