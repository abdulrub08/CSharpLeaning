Imports System.Data.SqlClient
Imports System.Data
Public Class framgeneralenq
    Private Sub rbtstudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtstudent.CheckedChanged
        If rbtstudent.Checked Then
            Panel1.Visible = True
            Panel2.Visible = False
            type = rbtstudent.Text
           
        End If
    End Sub
    Private Sub rbtemployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtemployee.CheckedChanged
        If rbtemployee.Checked Then
            Panel1.Visible = False
            Panel2.Visible = True
            type = rbtemployee.Text


        End If
    End Sub
    Private Sub cmbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcourse.SelectedIndexChanged
        Dim sql As String
        Dim cnn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=student3;Data Source=vikas\SQLEXPRESS")
        sql = "select coursefees,facultyname,duration from CourseMaster where coursename='" & cmbcourse.SelectedValue & "'"

        Dim da As New SqlDataAdapter(sql, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "a")
        Dim dt As DataTable
        dt = ds.Tables("a")
        For Each col As DataColumn In dt.Columns
            For Each row As DataRow In dt.Rows
                lblcoursefees.Text = row(0).ToString()
                lblfacultyname.Text = row(1).ToString()
                lblduration.Text = row(2).ToString()

            Next

        Next

    End Sub
    Private Sub framgeneralenq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student3DataSet.CourseMaster' table. You can move, or remove it, as needed.
        Me.CourseMasterTableAdapter.Fill(Me.Student3DataSet.CourseMaster)
        rbtstudent.Checked = True
        Panel1.Visible = True
        Panel2.Visible = False

    End Sub
    Public Sub clrallct1()
        Dim i As Integer
        For i = 0 To chklreference.Items.Count - 1
            chklreference.SetItemChecked(i, False)
        Next
        Dim j As Integer
        For j = 0 To chklbatchtime.Items.Count - 1
            chklbatchtime.SetItemChecked(j, False)


        Next
    End Sub
    Private Sub cmbcoursepersuing_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcoursepursuing.SelectedIndexChanged

        cmbbranch.Items.Clear()
        cmbsemester.Items.Clear()

        Dim a As Integer

        a = cmbcoursepursuing.SelectedIndex
        lblbranch.Text = "Branch"


        If a = 0 Then
            cmbbranch.Visible = True
            lblbranch.Visible = True

            cmbbranch.Items.Add("HR")
            cmbbranch.Items.Add("Marketting")
            cmbbranch.Items.Add("It")
            lblbranch.Text = "Specialization"


        End If
        If a = 1 Then
            cmbbranch.Visible = False
            lblbranch.Visible = False
        End If
        If a = 1 Then
            cmbbranch.Visible = False
            lblbranch.Visible = False
            
        End If

        If a = 2 Then
            cmbbranch.Visible = True
            lblbranch.Visible = True

            cmbbranch.Items.Add("CS")
            cmbbranch.Items.Add("IT")
            cmbbranch.Items.Add("Mechanical")
            cmbbranch.Items.Add("Mechanical")


        End If

        If a = 0 Then
            cmbbranch.Visible = True
            lblbranch.Visible = True

            cmbsemester.Items.Add("1st")
            cmbsemester.Items.Add("2nd")
            cmbsemester.Items.Add("3rd")
            cmbsemester.Items.Add("4th")

        End If

        If a = 1 Then
            cmbbranch.Visible = False
            lblbranch.Visible = False
            cmbsemester.Items.Add("1st")
            cmbsemester.Items.Add("2nd")
            cmbsemester.Items.Add("3rd")
            cmbsemester.Items.Add("4th")
            cmbsemester.Items.Add("5th")
            cmbsemester.Items.Add("6th")
         
        End If

        If a = 2 Then
            cmbbranch.Visible = True
            lblbranch.Visible = True

            cmbsemester.Items.Add("1st")
            cmbsemester.Items.Add("2st")
            cmbsemester.Items.Add("3rd")
            cmbsemester.Items.Add("4th")
            cmbsemester.Items.Add("5th")
            cmbsemester.Items.Add("6th")
            cmbsemester.Items.Add("7th")
            cmbsemester.Items.Add("8th")

        End If

    End Sub
    Public ref As String
    Public type As String
    Private Sub chklreferences_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklreference.SelectedIndexChanged


    End Sub
    Public time As String
    Private Sub chklbatchtime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklbatchtime.SelectedIndexChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim mobno As String
        If txtstudentname.Text = "" Then
            MessageBox.Show("Enter the student name")
            Exit Sub
        End If

        If cmbqualification.SelectedIndex < 0 Then
            MessageBox.Show("Please select the qualification")
            Exit Sub
        End If

        If Panel1.Visible = True Then

            If cmbcoursepursuing.SelectedIndex < 0 Then
                MessageBox.Show("Please select the appearing Qualification")
                Exit Sub
            End If
            If cmbcoursepursuing.SelectedIndex = 0 Or cmbcoursepursuing.SelectedIndex = 2 Then
                If cmbbranch.SelectedIndex < 0 Then
                    MessageBox.Show("Please select the Branch or Specilization")
                    Exit Sub
                End If
            End If
            If cmbsemester.SelectedIndex < 0 Then
                MessageBox.Show("Please select the Semester")
                Exit Sub
            End If

        Else
            If txtemployeer.Text = "" Then
                MessageBox.Show("Enter the Employer")
                Exit Sub
            End If
            If txttotalexper.Text = "" Then
                MessageBox.Show("Enter the Experience")
                Exit Sub
            End If
        End If

        mobno = txtmobileno.Text
        If mobno.Length = 10 Then
        Else
            MessageBox.Show("Mobile no is not valid.")
            Exit Sub
        End If
        Dim email As String
        email = txtmailid.Text
        If email.Contains("@") = False Or email.Contains(".") = False Then
            MessageBox.Show("Email is not valid")
            Exit Sub
        End If


        Dim sql As String
        ref = ""
        Dim branch, cpur, sem As String
        If Panel2.Visible = False Then
            If cmbcoursepursuing.SelectedIndex = 1 Then
                branch = ""
            Else
                branch = cmbbranch.SelectedItem.ToString()
            End If
        Else
            branch = ""
            cpur = ""
            sem = ""
        End If
        Dim i As Integer
        For i = 0 To chklreference.Items.Count - 1
            If chklreference.GetItemChecked(i) = True Then
                If ref = "" Then
                    ref = chklreference.Items(i).ToString()
                Else
                    ref = ref + "," + chklreference.Items(i).ToString()

                End If
            End If
        Next
        time = ""
        Dim j As Integer
        For j = 0 To chklbatchtime.Items.Count - 1
            If chklbatchtime.GetItemChecked(j) = True Then
                If time = "" Then
                    time = chklbatchtime.Items(j).ToString()
                Else
                    time = time + "," + chklbatchtime.Items(j).ToString()

                End If

            End If
        Next
        sql = "insert into generalquery(studentname,course,coursefees,facultyname,duration,qualification,ctype,coursepursuing,branch,semester,employer,totalexpr,reference,batchtime,mobileno,mailid,remark,entryperson,entrydate)values('" & txtstudentname.Text & "' , '" & cmbcourse.SelectedValue & "' , '" & lblcoursefees.Text & "','" & lblfacultyname.Text & "' , '" & lblduration.Text & "' ,'" & cmbqualification.SelectedItem.ToString() & "','" & type & "','" & cpur & "','" & branch & "','" & sem & "','" & txtemployeer.Text & "','" & txttotalexper.Text & "','" & ref & "','" & time & "','" & txtmobileno.Text & "','" & txtmailid.Text & "','" & txtremark.Text & "','" & g_loginname & "','" & g_Cdate & "')"
        Dim k As Integer
        k = 0
        k = ExecuteQuery(sql)
        If k = 0 Then
            MessageBox.Show("Data not Saved")
        Else
            MessageBox.Show("Data is saved")
            Clrct1(Me)
            clrallct1()
        End If

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtstudentname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentname.TextChanged

    End Sub
End Class


