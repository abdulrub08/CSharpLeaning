Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Public Class Report

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rd As New ReportDocument
        rd.Load("D:\Example\VB\WindowsApplication1\WindowsApplication1\CourseDetails.rpt")
        rd.SetDataSource(g_ds.Tables(0))
        CrystalReportViewer1.ReportSource = rd


    End Sub
End Class