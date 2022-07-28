Public Class Form4

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        MessageBox.Show(e.Node.FullPath)
    End Sub
End Class