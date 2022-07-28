<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class framgeneralenq
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtstudentname = New System.Windows.Forms.TextBox
        Me.cmbcourse = New System.Windows.Forms.ComboBox
        Me.CourseMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student3DataSet = New WindowsApplication1.student3DataSet
        Me.cmbqualification = New System.Windows.Forms.ComboBox
        Me.rbtstudent = New System.Windows.Forms.RadioButton
        Me.rbtemployee = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtmobileno = New System.Windows.Forms.TextBox
        Me.txtmailid = New System.Windows.Forms.TextBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbsemester = New System.Windows.Forms.ComboBox
        Me.cmbbranch = New System.Windows.Forms.ComboBox
        Me.cmbcoursepursuing = New System.Windows.Forms.ComboBox
        Me.lblsemester = New System.Windows.Forms.Label
        Me.lblbranch = New System.Windows.Forms.Label
        Me.lblcoursepursuing = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txttotalexper = New System.Windows.Forms.TextBox
        Me.txtemployeer = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.chklreference = New System.Windows.Forms.CheckedListBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.chklbatchtime = New System.Windows.Forms.CheckedListBox
        Me.lblcoursefees = New System.Windows.Forms.Label
        Me.lblfacultyname = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.CourseMasterTableAdapter = New WindowsApplication1.student3DataSetTableAdapters.CourseMasterTableAdapter
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Fees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Faculty Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Duration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Qualification *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "C Type"
        '
        'txtstudentname
        '
        Me.txtstudentname.Location = New System.Drawing.Point(267, 26)
        Me.txtstudentname.Multiline = True
        Me.txtstudentname.Name = "txtstudentname"
        Me.txtstudentname.Size = New System.Drawing.Size(215, 26)
        Me.txtstudentname.TabIndex = 20
        '
        'cmbcourse
        '
        Me.cmbcourse.DataSource = Me.CourseMasterBindingSource
        Me.cmbcourse.DisplayMember = "coursename"
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.ItemHeight = 13
        Me.cmbcourse.Location = New System.Drawing.Point(267, 70)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(215, 21)
        Me.cmbcourse.TabIndex = 23
        Me.cmbcourse.ValueMember = "coursename"
        '
        'CourseMasterBindingSource
        '
        Me.CourseMasterBindingSource.DataMember = "CourseMaster"
        Me.CourseMasterBindingSource.DataSource = Me.Student3DataSet
        '
        'Student3DataSet
        '
        Me.Student3DataSet.DataSetName = "student3DataSet"
        Me.Student3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbqualification
        '
        Me.cmbqualification.FormattingEnabled = True
        Me.cmbqualification.Items.AddRange(New Object() {"10 th", "12 th", "Graduation", "Post graduation"})
        Me.cmbqualification.Location = New System.Drawing.Point(275, 270)
        Me.cmbqualification.Name = "cmbqualification"
        Me.cmbqualification.Size = New System.Drawing.Size(215, 21)
        Me.cmbqualification.TabIndex = 27
        '
        'rbtstudent
        '
        Me.rbtstudent.AutoSize = True
        Me.rbtstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtstudent.Location = New System.Drawing.Point(276, 309)
        Me.rbtstudent.Name = "rbtstudent"
        Me.rbtstudent.Size = New System.Drawing.Size(82, 21)
        Me.rbtstudent.TabIndex = 28
        Me.rbtstudent.TabStop = True
        Me.rbtstudent.Text = "Student"
        Me.rbtstudent.UseVisualStyleBackColor = True
        '
        'rbtemployee
        '
        Me.rbtemployee.AutoSize = True
        Me.rbtemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtemployee.Location = New System.Drawing.Point(380, 309)
        Me.rbtemployee.Name = "rbtemployee"
        Me.rbtemployee.Size = New System.Drawing.Size(96, 21)
        Me.rbtemployee.TabIndex = 29
        Me.rbtemployee.TabStop = True
        Me.rbtemployee.Text = "Employee"
        Me.rbtemployee.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mobile No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(537, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Mail Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(540, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Remark"
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(626, 15)
        Me.txtmobileno.Multiline = True
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(180, 25)
        Me.txtmobileno.TabIndex = 33
        '
        'txtmailid
        '
        Me.txtmailid.Location = New System.Drawing.Point(626, 56)
        Me.txtmailid.Multiline = True
        Me.txtmailid.Name = "txtmailid"
        Me.txtmailid.Size = New System.Drawing.Size(180, 24)
        Me.txtmailid.TabIndex = 34
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(626, 102)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(180, 23)
        Me.txtremark.TabIndex = 35
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(626, 157)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 28)
        Me.btnsave.TabIndex = 36
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(731, 155)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 29)
        Me.btnexit.TabIndex = 37
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbsemester)
        Me.Panel1.Controls.Add(Me.cmbbranch)
        Me.Panel1.Controls.Add(Me.cmbcoursepursuing)
        Me.Panel1.Controls.Add(Me.lblsemester)
        Me.Panel1.Controls.Add(Me.lblbranch)
        Me.Panel1.Controls.Add(Me.lblcoursepursuing)
        Me.Panel1.Location = New System.Drawing.Point(99, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 164)
        Me.Panel1.TabIndex = 38
        '
        'cmbsemester
        '
        Me.cmbsemester.FormattingEnabled = True
        Me.cmbsemester.Location = New System.Drawing.Point(176, 100)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.Size = New System.Drawing.Size(175, 21)
        Me.cmbsemester.TabIndex = 5
        '
        'cmbbranch
        '
        Me.cmbbranch.FormattingEnabled = True
        Me.cmbbranch.Location = New System.Drawing.Point(176, 59)
        Me.cmbbranch.Name = "cmbbranch"
        Me.cmbbranch.Size = New System.Drawing.Size(175, 21)
        Me.cmbbranch.TabIndex = 4
        '
        'cmbcoursepursuing
        '
        Me.cmbcoursepursuing.FormattingEnabled = True
        Me.cmbcoursepursuing.Items.AddRange(New Object() {"MBA", "MCA", "B.Tech"})
        Me.cmbcoursepursuing.Location = New System.Drawing.Point(176, 21)
        Me.cmbcoursepursuing.Name = "cmbcoursepursuing"
        Me.cmbcoursepursuing.Size = New System.Drawing.Size(175, 21)
        Me.cmbcoursepursuing.TabIndex = 3
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.Location = New System.Drawing.Point(58, 98)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(98, 20)
        Me.lblsemester.TabIndex = 2
        Me.lblsemester.Text = "Semester *"
        '
        'lblbranch
        '
        Me.lblbranch.AutoSize = True
        Me.lblbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.Location = New System.Drawing.Point(83, 59)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.Size = New System.Drawing.Size(66, 20)
        Me.lblbranch.TabIndex = 1
        Me.lblbranch.Text = "Branch"
        '
        'lblcoursepursuing
        '
        Me.lblcoursepursuing.AutoSize = True
        Me.lblcoursepursuing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursepursuing.Location = New System.Drawing.Point(17, 21)
        Me.lblcoursepursuing.Name = "lblcoursepursuing"
        Me.lblcoursepursuing.Size = New System.Drawing.Size(153, 20)
        Me.lblcoursepursuing.TabIndex = 0
        Me.lblcoursepursuing.Text = "Course Pursuing *"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txttotalexper)
        Me.Panel2.Controls.Add(Me.txtemployeer)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(484, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 163)
        Me.Panel2.TabIndex = 39
        '
        'txttotalexper
        '
        Me.txttotalexper.Location = New System.Drawing.Point(139, 98)
        Me.txttotalexper.Multiline = True
        Me.txttotalexper.Name = "txttotalexper"
        Me.txttotalexper.Size = New System.Drawing.Size(140, 23)
        Me.txttotalexper.TabIndex = 3
        '
        'txtemployeer
        '
        Me.txtemployeer.Location = New System.Drawing.Point(134, 27)
        Me.txtemployeer.Multiline = True
        Me.txtemployeer.Name = "txtemployeer"
        Me.txtemployeer.Size = New System.Drawing.Size(145, 27)
        Me.txtemployeer.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Total Exper."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Employeer *"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(96, 546)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 20)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Reference *"
        '
        'chklreference
        '
        Me.chklreference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklreference.FormattingEnabled = True
        Me.chklreference.Items.AddRange(New Object() {"NewsPaper", "Holding", "Friends", "Pomplets", "Others"})
        Me.chklreference.Location = New System.Drawing.Point(220, 521)
        Me.chklreference.MultiColumn = True
        Me.chklreference.Name = "chklreference"
        Me.chklreference.Size = New System.Drawing.Size(356, 67)
        Me.chklreference.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(96, 623)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Batch Time *"
        '
        'chklbatchtime
        '
        Me.chklbatchtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklbatchtime.FormattingEnabled = True
        Me.chklbatchtime.Items.AddRange(New Object() {"7 To 8 AM", "8:30 To 9:30 AM", "11:45 To 12:45 PM", "2 To 3 PM", "5 To 6 PM", "8 To 9 PM"})
        Me.chklbatchtime.Location = New System.Drawing.Point(220, 595)
        Me.chklbatchtime.MultiColumn = True
        Me.chklbatchtime.Name = "chklbatchtime"
        Me.chklbatchtime.Size = New System.Drawing.Size(356, 67)
        Me.chklbatchtime.TabIndex = 43
        '
        'lblcoursefees
        '
        Me.lblcoursefees.AutoSize = True
        Me.lblcoursefees.Location = New System.Drawing.Point(274, 119)
        Me.lblcoursefees.Name = "lblcoursefees"
        Me.lblcoursefees.Size = New System.Drawing.Size(0, 13)
        Me.lblcoursefees.TabIndex = 44
        '
        'lblfacultyname
        '
        Me.lblfacultyname.AutoSize = True
        Me.lblfacultyname.Location = New System.Drawing.Point(273, 167)
        Me.lblfacultyname.Name = "lblfacultyname"
        Me.lblfacultyname.Size = New System.Drawing.Size(0, 13)
        Me.lblfacultyname.TabIndex = 45
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblduration.Location = New System.Drawing.Point(275, 225)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 13)
        Me.lblduration.TabIndex = 46
        '
        'CourseMasterTableAdapter
        '
        Me.CourseMasterTableAdapter.ClearBeforeFill = True
        '
        'framgeneralenq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 711)
        Me.Controls.Add(Me.lblduration)
        Me.Controls.Add(Me.lblfacultyname)
        Me.Controls.Add(Me.lblcoursefees)
        Me.Controls.Add(Me.chklbatchtime)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.chklreference)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.txtmailid)
        Me.Controls.Add(Me.txtmobileno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rbtemployee)
        Me.Controls.Add(Me.rbtstudent)
        Me.Controls.Add(Me.cmbqualification)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.txtstudentname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "framgeneralenq"
        Me.Text = "Generalenquery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CourseMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstudentname As System.Windows.Forms.TextBox
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbqualification As System.Windows.Forms.ComboBox
    Friend WithEvents rbtstudent As System.Windows.Forms.RadioButton
    Friend WithEvents rbtemployee As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents txtmailid As System.Windows.Forms.TextBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents lblbranch As System.Windows.Forms.Label
    Friend WithEvents lblcoursepursuing As System.Windows.Forms.Label
    Friend WithEvents cmbsemester As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcoursepursuing As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txttotalexper As System.Windows.Forms.TextBox
    Friend WithEvents txtemployeer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chklreference As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chklbatchtime As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblcoursefees As System.Windows.Forms.Label
    Friend WithEvents lblfacultyname As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents Student3DataSet As WindowsApplication1.student3DataSet
    Friend WithEvents CourseMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseMasterTableAdapter As WindowsApplication1.student3DataSetTableAdapters.CourseMasterTableAdapter
End Class
