<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bycourse
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
        Me.rbtcourse = New System.Windows.Forms.RadioButton
        Me.lblcoursename = New System.Windows.Forms.Label
        Me.cmbcourse = New System.Windows.Forms.ComboBox
        Me.CourseMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student3DataSet1 = New WindowsApplication1.student3DataSet1
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnbycoursesearch = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CourseMasterTableAdapter = New WindowsApplication1.student3DataSet1TableAdapters.CourseMasterTableAdapter
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtcourse
        '
        Me.rbtcourse.AutoSize = True
        Me.rbtcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtcourse.ForeColor = System.Drawing.Color.Coral
        Me.rbtcourse.Location = New System.Drawing.Point(410, 12)
        Me.rbtcourse.Name = "rbtcourse"
        Me.rbtcourse.Size = New System.Drawing.Size(155, 29)
        Me.rbtcourse.TabIndex = 0
        Me.rbtcourse.TabStop = True
        Me.rbtcourse.Text = "BY COURSE"
        Me.rbtcourse.UseVisualStyleBackColor = True
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.Location = New System.Drawing.Point(202, 29)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(117, 20)
        Me.lblcoursename.TabIndex = 1
        Me.lblcoursename.Text = "Course Name"
        '
        'cmbcourse
        '
        Me.cmbcourse.DataSource = Me.CourseMasterBindingSource
        Me.cmbcourse.DisplayMember = "coursename"
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Location = New System.Drawing.Point(342, 28)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(255, 21)
        Me.cmbcourse.TabIndex = 2
        Me.cmbcourse.ValueMember = "coursename"
        '
        'CourseMasterBindingSource
        '
        Me.CourseMasterBindingSource.DataMember = "CourseMaster"
        Me.CourseMasterBindingSource.DataSource = Me.Student3DataSet1
        '
        'Student3DataSet1
        '
        Me.Student3DataSet1.DataSetName = "student3DataSet1"
        Me.Student3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnbycoursesearch)
        Me.Panel1.Controls.Add(Me.cmbcourse)
        Me.Panel1.Controls.Add(Me.lblcoursename)
        Me.Panel1.Location = New System.Drawing.Point(59, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 166)
        Me.Panel1.TabIndex = 3
        '
        'btnbycoursesearch
        '
        Me.btnbycoursesearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbycoursesearch.Location = New System.Drawing.Point(380, 73)
        Me.btnbycoursesearch.Name = "btnbycoursesearch"
        Me.btnbycoursesearch.Size = New System.Drawing.Size(114, 40)
        Me.btnbycoursesearch.TabIndex = 3
        Me.btnbycoursesearch.Text = "Search"
        Me.btnbycoursesearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(59, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(818, 220)
        Me.DataGridView1.TabIndex = 4
        '
        'CourseMasterTableAdapter
        '
        Me.CourseMasterTableAdapter.ClearBeforeFill = True
        '
        'bycourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 467)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtcourse)
        Me.Name = "bycourse"
        Me.Text = "bycourse"
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtcourse As System.Windows.Forms.RadioButton
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnbycoursesearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Student3DataSet1 As WindowsApplication1.student3DataSet1
    Friend WithEvents CourseMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseMasterTableAdapter As WindowsApplication1.student3DataSet1TableAdapters.CourseMasterTableAdapter
End Class
