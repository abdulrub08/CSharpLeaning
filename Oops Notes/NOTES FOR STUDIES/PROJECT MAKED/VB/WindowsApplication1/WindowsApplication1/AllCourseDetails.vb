Imports System.Data
Imports System.Data.SqlClient
Public Class AllCourseDetails

    Private Sub AllCourseDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.CourseMaster' table. You can move, or remove it, as needed.
        Me.CourseMasterTableAdapter.Fill(Me.DataSet1.CourseMaster)

    End Sub

    Private Sub btnPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAll.Click
        Dim sql As String
        sql = "select coursename,coursefees,facultyname,duration from coursemaster"
        g_ds = selectquery(sql)
        Report.Show()
        Me.Hide()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim sql As String
        sql = "select coursename,coursefees,facultyname,duration from coursemaster where coursename='" & cmbCourseName.SelectedValue & "'"

        g_ds = selectquery(sql)
        Report.Show()
        Me.Hide()
    End Sub
End Class