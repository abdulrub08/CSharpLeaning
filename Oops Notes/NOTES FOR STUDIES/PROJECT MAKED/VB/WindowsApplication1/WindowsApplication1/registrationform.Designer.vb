<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationform
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
        Me.lblstartdate = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lbldate = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.btnsearchdate = New System.Windows.Forms.Button
        Me.lblstudentname = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lbladdress = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmbstudentname = New System.Windows.Forms.ComboBox
        Me.GeneralqueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student3DataSet2 = New WindowsApplication1.student3DataSet2
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.lblccname = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbltda = New System.Windows.Forms.Panel
        Me.btncfeesexit = New System.Windows.Forms.Button
        Me.txtnetamountpaid = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblnap = New System.Windows.Forms.Label
        Me.lbldiscount = New System.Windows.Forms.Label
        Me.lblamount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblcoursefees = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.cmbccname = New System.Windows.Forms.ComboBox
        Me.GeneralqueryTableAdapter = New WindowsApplication1.student3DataSet2TableAdapters.generalqueryTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralqueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student3DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lbltda.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartdate.Location = New System.Drawing.Point(-2, 36)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(93, 20)
        Me.lblstartdate.TabIndex = 0
        Me.lblstartdate.Text = "Start Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(97, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(292, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(399, 36)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(73, 20)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "To Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(478, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(295, 26)
        Me.DateTimePicker2.TabIndex = 3
        '
        'btnsearchdate
        '
        Me.btnsearchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchdate.Location = New System.Drawing.Point(279, 78)
        Me.btnsearchdate.Name = "btnsearchdate"
        Me.btnsearchdate.Size = New System.Drawing.Size(100, 39)
        Me.btnsearchdate.TabIndex = 4
        Me.btnsearchdate.Text = "Search"
        Me.btnsearchdate.UseVisualStyleBackColor = True
        '
        'lblstudentname
        '
        Me.lblstudentname.AutoSize = True
        Me.lblstudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentname.Location = New System.Drawing.Point(180, 136)
        Me.lblstudentname.Name = "lblstudentname"
        Me.lblstudentname.Size = New System.Drawing.Size(124, 20)
        Me.lblstudentname.TabIndex = 5
        Me.lblstudentname.Text = "Student Name"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(12, 142)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(55, 20)
        Me.lblid.TabIndex = 7
        Me.lblid.Text = "ID No"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(126, 142)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 13)
        Me.lbl.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(503, 139)
        Me.DataGridView1.TabIndex = 9
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(4, 327)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(87, 20)
        Me.lbladdress.TabIndex = 10
        Me.lbladdress.Text = "Address *"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(103, 323)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(187, 30)
        Me.txtaddress.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Batch Time"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(100, 379)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "7 To 8 AM"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cmbstudentname
        '
        Me.cmbstudentname.DataSource = Me.GeneralqueryBindingSource
        Me.cmbstudentname.DisplayMember = "studentname"
        Me.cmbstudentname.FormattingEnabled = True
        Me.cmbstudentname.Location = New System.Drawing.Point(310, 134)
        Me.cmbstudentname.Name = "cmbstudentname"
        Me.cmbstudentname.Size = New System.Drawing.Size(183, 21)
        Me.cmbstudentname.TabIndex = 14
        Me.cmbstudentname.ValueMember = "studentname"
        '
        'GeneralqueryBindingSource
        '
        Me.GeneralqueryBindingSource.DataMember = "generalquery"
        Me.GeneralqueryBindingSource.DataSource = Me.Student3DataSet2
        '
        'Student3DataSet2
        '
        Me.Student3DataSet2.DataSetName = "student3DataSet2"
        Me.Student3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(181, 379)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "8:30 To 9:30 AM"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(295, 379)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(94, 17)
        Me.RadioButton3.TabIndex = 16
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "11:45 To 12"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(103, 412)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton4.TabIndex = 17
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "2 To 3 PM"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(193, 412)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton5.TabIndex = 18
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5 To 6 PM"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(295, 412)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton6.TabIndex = 19
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "8 To 9 PM"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'lblccname
        '
        Me.lblccname.AutoSize = True
        Me.lblccname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblccname.Location = New System.Drawing.Point(3, 448)
        Me.lblccname.Name = "lblccname"
        Me.lblccname.Size = New System.Drawing.Size(167, 17)
        Me.lblccname.TabIndex = 20
        Me.lblccname.Text = "Current College Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Fees Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltda
        '
        Me.lbltda.Controls.Add(Me.btncfeesexit)
        Me.lbltda.Controls.Add(Me.txtnetamountpaid)
        Me.lbltda.Controls.Add(Me.txtdiscount)
        Me.lbltda.Controls.Add(Me.txtamount)
        Me.lbltda.Controls.Add(Me.Label4)
        Me.lbltda.Controls.Add(Me.Label2)
        Me.lbltda.Controls.Add(Me.lblnap)
        Me.lbltda.Controls.Add(Me.lbldiscount)
        Me.lbltda.Controls.Add(Me.lblamount)
        Me.lbltda.Controls.Add(Me.Label3)
        Me.lbltda.Controls.Add(Me.lblcoursefees)
        Me.lbltda.Location = New System.Drawing.Point(143, 477)
        Me.lbltda.Name = "lbltda"
        Me.lbltda.Size = New System.Drawing.Size(311, 257)
        Me.lbltda.TabIndex = 22
        '
        'btncfeesexit
        '
        Me.btncfeesexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncfeesexit.Location = New System.Drawing.Point(217, 211)
        Me.btncfeesexit.Name = "btncfeesexit"
        Me.btncfeesexit.Size = New System.Drawing.Size(75, 23)
        Me.btncfeesexit.TabIndex = 10
        Me.btncfeesexit.Text = "Exit"
        Me.btncfeesexit.UseVisualStyleBackColor = True
        '
        'txtnetamountpaid
        '
        Me.txtnetamountpaid.Location = New System.Drawing.Point(140, 137)
        Me.txtnetamountpaid.Name = "txtnetamountpaid"
        Me.txtnetamountpaid.Size = New System.Drawing.Size(151, 20)
        Me.txtnetamountpaid.TabIndex = 9
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(140, 103)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(151, 20)
        Me.txtdiscount.TabIndex = 8
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(141, 60)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(151, 20)
        Me.txtamount.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Due Amount"
        '
        'lblnap
        '
        Me.lblnap.AutoSize = True
        Me.lblnap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnap.Location = New System.Drawing.Point(7, 145)
        Me.lblnap.Name = "lblnap"
        Me.lblnap.Size = New System.Drawing.Size(111, 13)
        Me.lblnap.TabIndex = 4
        Me.lblnap.Text = "Net Amount Paid *"
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.Location = New System.Drawing.Point(13, 103)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(57, 13)
        Me.lbldiscount.TabIndex = 3
        Me.lbldiscount.Text = "Discount"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(14, 60)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(54, 13)
        Me.lblamount.TabIndex = 2
        Me.lblamount.Text = "Amount*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 1
        '
        'lblcoursefees
        '
        Me.lblcoursefees.AutoSize = True
        Me.lblcoursefees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursefees.Location = New System.Drawing.Point(8, 21)
        Me.lblcoursefees.Name = "lblcoursefees"
        Me.lblcoursefees.Size = New System.Drawing.Size(77, 13)
        Me.lblcoursefees.TabIndex = 0
        Me.lblcoursefees.Text = "Course Fees"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(510, 78)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(433, 247)
        Me.DataGridView2.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Location = New System.Drawing.Point(510, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 128)
        Me.Panel1.TabIndex = 24
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(174, 67)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(89, 39)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(30, 67)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 39)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(298, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 34)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(174, 6)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(89, 34)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(30, 6)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 34)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cmbccname
        '
        Me.cmbccname.FormattingEnabled = True
        Me.cmbccname.Location = New System.Drawing.Point(169, 450)
        Me.cmbccname.Name = "cmbccname"
        Me.cmbccname.Size = New System.Drawing.Size(187, 21)
        Me.cmbccname.TabIndex = 25
        '
        'GeneralqueryTableAdapter
        '
        Me.GeneralqueryTableAdapter.ClearBeforeFill = True
        '
        'registrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 746)
        Me.Controls.Add(Me.cmbccname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lbltda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblccname)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.cmbstudentname)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblstudentname)
        Me.Controls.Add(Me.btnsearchdate)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblstartdate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "registrationform"
        Me.Text = "registrationform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralqueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student3DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lbltda.ResumeLayout(False)
        Me.lbltda.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsearchdate As System.Windows.Forms.Button
    Friend WithEvents lblstudentname As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbstudentname As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents lblccname As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbltda As System.Windows.Forms.Panel
    Friend WithEvents lblnap As System.Windows.Forms.Label
    Friend WithEvents lbldiscount As System.Windows.Forms.Label
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcoursefees As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btncfeesexit As System.Windows.Forms.Button
    Friend WithEvents txtnetamountpaid As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmbccname As System.Windows.Forms.ComboBox
    Friend WithEvents Student3DataSet2 As WindowsApplication1.student3DataSet2
    Friend WithEvents GeneralqueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralqueryTableAdapter As WindowsApplication1.student3DataSet2TableAdapters.generalqueryTableAdapter
End Class
