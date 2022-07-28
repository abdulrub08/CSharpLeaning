Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim flag As Boolean
        Try
            flag = True
            n = Me.TextBox1.Text
            If n < 0 Then
                Throw New Exception("Negative Number ")
            End If
        Catch ex As Exception
            MessageBox.Show("Exception is " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            flag = False
        Finally
            MessageBox.Show("Finally Block")
        End Try
        If flag Then
            MessageBox.Show("Square Root " & Math.Sqrt(n))
        End If

    End Sub
End Class