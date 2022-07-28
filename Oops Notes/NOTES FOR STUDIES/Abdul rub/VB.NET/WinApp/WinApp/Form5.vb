Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LinkLabel1.Links.Add(0, 25, "http://wkt9/login.asp")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        If IsNumeric(Me.TextBox1.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Invalid Number")
            Exit Sub
        Else
            Me.ErrorProvider1.SetError(Me.TextBox1, "")
        End If
        n = Me.TextBox1.Text
        MessageBox.Show("Square is " & Math.Sqrt(n))

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("This Student App")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class