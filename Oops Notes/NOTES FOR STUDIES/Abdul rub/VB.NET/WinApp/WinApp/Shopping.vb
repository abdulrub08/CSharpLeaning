Public Class Shopping

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.products.SelectedIndex > -1 Then
            Me.purchase.Items.Add(Me.products.SelectedItem)
            Me.purchase_price.Items.Add(Me.products_price.SelectedItem)
            Call CalGrandTotal()
        End If
    End Sub
    Private Sub CalGrandTotal()
        Dim i, sum As Integer
        sum = 0
        For i = 0 To Me.purchase.Items.Count - 1
            sum = sum + CInt(Me.purchase_price.Items.Item(i))
        Next
        Me.TextBox1.Text = sum
    End Sub

    Private Sub Shopping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Add("Electronics")
        Me.ComboBox1.Items.Add("Computers")
        Me.ComboBox1.Items.Add("Books")
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedIndex > -1 Then
            Me.products.Items.Clear()
            Me.products_price.Items.Clear()
            If Me.ComboBox1.Text = "Electronics" Then
                Me.products.Items.Add("LCD")
                Me.products_price.Items.Add("32000")
                Me.products.Items.Add("LED")
                Me.products_price.Items.Add("42000")
                Me.products.Items.Add("DVD")
                Me.products_price.Items.Add("3000")
            ElseIf Me.ComboBox1.Text = "Computers" Then
                Me.products.Items.Add("Monitors")
                Me.products_price.Items.Add("5000")
                Me.products.Items.Add("Keyboards")
                Me.products_price.Items.Add("400")
                Me.products.Items.Add("Mouse")
                Me.products_price.Items.Add("300")
            ElseIf Me.ComboBox1.Text = "Books" Then
                Me.products.Items.Add("Let Us C")
                Me.products_price.Items.Add("200")
                Me.products.Items.Add("Mastering in Java")
                Me.products_price.Items.Add("300")
                Me.products.Items.Add("Complete Reference in .NET")
                Me.products_price.Items.Add("500")

            End If
        End If
    End Sub

    Private Sub products_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles products.SelectedIndexChanged
        If Me.products.SelectedIndex > -1 Then
            Me.products_price.SetSelected(Me.products.SelectedIndex, True)
        End If
    End Sub

    Private Sub purchase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchase.SelectedIndexChanged
        If Me.purchase.SelectedIndex > -1 Then
            Me.purchase_price.SetSelected(Me.purchase.SelectedIndex, True)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.purchase.SelectedIndex > -1 Then
            Me.purchase_price.Items.RemoveAt(Me.purchase_price.SelectedIndex)
            Me.purchase.Items.RemoveAt(Me.purchase.SelectedIndex)
            Call CalGrandTotal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.purchase.Items.Count = 0 Then
            MessageBox.Show("No Product Purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To Me.purchase.Items.Count - 1
            Me.TextBox2.AppendText("Product No. " & (i + 1) & " is " & Me.purchase.Items.Item(i) & " At Rs " & Me.purchase_price.Items.Item(i) & vbCrLf)
        Next
        Me.TextBox2.AppendText("Grand Total is " & Me.TextBox1.Text & vbCrLf)
        If Me.RadioButton1.Checked Then
            Me.TextBox2.AppendText("Payment Mode is Cash")
        ElseIf Me.RadioButton2.Checked Then
            Me.TextBox2.AppendText("Payment Mode is Cheque")
        ElseIf Me.RadioButton3.Checked Then
            Me.TextBox2.AppendText("Payment Mode is Credit Card")

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class