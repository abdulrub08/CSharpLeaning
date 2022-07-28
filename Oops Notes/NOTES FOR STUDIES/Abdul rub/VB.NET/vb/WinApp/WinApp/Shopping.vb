Public Class Shopping

    Private Sub Shopping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Computer")
        ComboBox1.Items.Add("Moblies")
        ComboBox1.Items.Add("Tablets")
        ComboBox1.Items.Add("Accesseries")
        ComboBox1.Items.Add("Books")
        ComboBox1.SelectedIndex = 0
        Dim total As Integer = 0
    End Sub

    Dim total As Integer = 0

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        ListBox3.Items.Clear()
        If (ComboBox1.SelectedIndex = 0) Then
            ListBox1.Items.Add("Monitors")
            ListBox3.Items.Add("4500")
            ListBox1.Items.Add("L.C.D")
            ListBox3.Items.Add("6000")
            ListBox1.Items.Add("NoteBook")
            ListBox3.Items.Add("45000")
            ListBox1.Items.Add("SPeaker")
            ListBox3.Items.Add("1500")
        End If
        If (ComboBox1.SelectedIndex = 1) Then
            ListBox1.Items.Add("Nokia")
            ListBox3.Items.Add("7500")
            ListBox1.Items.Add("SamSung")
            ListBox3.Items.Add("6000")
            ListBox1.Items.Add("Sony")
            ListBox3.Items.Add("12000")
            ListBox1.Items.Add("HTC")
            ListBox3.Items.Add("14500")
        End If
        If (ComboBox1.SelectedIndex = 2) Then
            ListBox1.Items.Add("Apple")
            ListBox3.Items.Add("32000")
            ListBox1.Items.Add("Sony Tab")
            ListBox3.Items.Add("31500")
            ListBox1.Items.Add("SamSung Tab")
            ListBox3.Items.Add("18000")
            ListBox1.Items.Add("HTC Tab")
            ListBox3.Items.Add("35000")
        End If
        If (ComboBox1.SelectedIndex = 3) Then
            ListBox1.Items.Add("HeadPhone")
            ListBox3.Items.Add("1500")
            ListBox1.Items.Add("Mouse")
            ListBox3.Items.Add("300")
            ListBox1.Items.Add("Usb-Modem")
            ListBox3.Items.Add("1400")
            ListBox1.Items.Add("SPeaker")
            ListBox3.Items.Add("1200")
        End If
        If (ComboBox1.SelectedIndex = 4) Then
            ListBox1.Items.Add("C++")
            ListBox3.Items.Add("300")
            ListBox1.Items.Add("Black Book")
            ListBox3.Items.Add("500")
            ListBox1.Items.Add("Ansi C")
            ListBox3.Items.Add("400")
            ListBox1.Items.Add("Java")
            ListBox3.Items.Add("600")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ListBox1.SelectedIndex > -1 And ListBox3.SelectedIndex > -1) Then
            ListBox2.Items.Add(Me.ListBox1.SelectedItem)
            ListBox4.Items.Add(Me.ListBox3.SelectedItem)

            
            total = total + ListBox3.SelectedItem
            
            TextBox1.Text = total
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex > -1 Then
            ListBox3.SetSelected(Me.ListBox1.SelectedIndex, True)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)
        ListBox4.Items.Remove(ListBox4.SelectedItem)
        

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex > -1 Then
            ListBox4.SetSelected(Me.ListBox2.SelectedIndex, True)
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.SelectedIndexChanged
        Me.ListBox2.SetSelected(Me.ListBox4.SelectedIndex, True)
    End Sub
    Dim items As String = ""
    Dim payment As String = ""

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i As Integer = 0 To ListBox2.Items.Count - 1 Step 1
            items = items & " " & (i + 1) & " - " & ListBox2.Items(i).ToString()
            For j As Integer = i To i Step 1
                items = items & " " & "Rs.:" & ListBox4.Items(j).ToString() & vbCrLf
            Next
        Next
        If RadioButton1.Checked = True Then
            payment = "Cash"
        End If
        If RadioButton2.Checked = True Then
            payment = "Cheque"
        End If
        If RadioButton3.Checked = True Then
            payment = "Credit Card"
        End If

        TextBox2.Text = items & " Grand Total : " & total & vbCrLf & " Payment Type :" & payment

    End Sub
End Class