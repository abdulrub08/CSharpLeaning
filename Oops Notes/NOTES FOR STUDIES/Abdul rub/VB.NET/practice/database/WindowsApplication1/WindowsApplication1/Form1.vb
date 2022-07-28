Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter.Fill(Me.EmployeeDataSet.emp)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.EmpBindingSource.Position < Me.EmpBindingSource.Count - 1 Then
            Me.EmpBindingSource.MoveNext()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.EmpBindingSource.Position > 0 Then
            Me.EmpBindingSource.MovePrevious()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.EmpBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.EmpBindingSource.MoveLast()
    End Sub
End Class
