Public Class Form3

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Cut"
                Me.TextBox1.Cut()
                Me.StatusStrip1.Items(1).Text = "Cut Action"
            Case "Copy"
                Me.TextBox1.Copy()
                Me.StatusStrip1.Items(1).Text = "Copy Action"
            Case "Paste"
                Me.TextBox1.Paste()
                Me.StatusStrip1.Items(1).Text = "Paste Action"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.StatusStrip1.Items(0).Text = TimeOfDay
    End Sub
End Class