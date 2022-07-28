<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllCourseDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPrintAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cmbCourseName = New System.Windows.Forms.ComboBox
        Me.DataSet1 = New WindowsApplication1.DataSet1
        Me.CourseMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseMasterTableAdapter = New WindowsApplication1.DataSet1TableAdapters.CourseMasterTableAdapter
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Show All Course Details :"
        '
        'btnPrintAll
        '
        Me.btnPrintAll.Location = New System.Drawing.Point(191, 47)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintAll.TabIndex = 1
        Me.btnPrintAll.Text = "Print All"
        Me.btnPrintAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Course Name :"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(340, 104)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbCourseName
        '
        Me.cmbCourseName.DataSource = Me.CourseMasterBindingSource
        Me.cmbCourseName.DisplayMember = "coursename"
        Me.cmbCourseName.FormattingEnabled = True
        Me.cmbCourseName.Location = New System.Drawing.Point(191, 106)
        Me.cmbCourseName.Name = "cmbCourseName"
        Me.cmbCourseName.Size = New System.Drawing.Size(121, 21)
        Me.cmbCourseName.TabIndex = 4
        Me.cmbCourseName.ValueMember = "coursename"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseMasterBindingSource
        '
        Me.CourseMasterBindingSource.DataMember = "CourseMaster"
        Me.CourseMasterBindingSource.DataSource = Me.DataSet1
        '
        'CourseMasterTableAdapter
        '
        Me.CourseMasterTableAdapter.ClearBeforeFill = True
        '
        'AllCourseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 224)
        Me.Controls.Add(Me.cmbCourseName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrintAll)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AllCourseDetails"
        Me.Text = "AllCourseDetails"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrintAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmbCourseName As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents CourseMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseMasterTableAdapter As WindowsApplication1.DataSet1TableAdapters.CourseMasterTableAdapter
End Class
