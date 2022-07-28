Imports System.IO
Public Class Form8

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.TextBox1.Text = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim file As StreamReader
        Try
            If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                file = New StreamReader(Me.OpenFileDialog1.FileName)
                Me.TextBox1.Text = file.ReadToEnd()
                file.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim file As StreamWriter
        Try
            If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                file = New StreamWriter(Me.SaveFileDialog1.FileName)
                file.WriteLine(Me.TextBox1.Text)
                file.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If Me.ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TextBox1.ForeColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If Me.FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TextBox1.Font = Me.FontDialog1.Font
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim txt As String
        Dim ft As Font
        Dim br As Brush
        txt = Me.TextBox1.Text
        ft = Me.FontDialog1.Font

        e.Graphics.DrawString(txt, ft, Brushes.Brown, 10, 10)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub
End Class