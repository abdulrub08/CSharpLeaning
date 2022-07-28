<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class byname
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
        Me.rbtbyname = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtbyname = New System.Windows.Forms.TextBox
        Me.btnsearchname = New System.Windows.Forms.Button
        Me.lblname = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtbyname
        '
        Me.rbtbyname.AutoSize = True
        Me.rbtbyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtbyname.ForeColor = System.Drawing.Color.Coral
        Me.rbtbyname.Location = New System.Drawing.Point(270, 21)
        Me.rbtbyname.Name = "rbtbyname"
        Me.rbtbyname.Size = New System.Drawing.Size(126, 29)
        Me.rbtbyname.TabIndex = 0
        Me.rbtbyname.TabStop = True
        Me.rbtbyname.Text = "BY NAME"
        Me.rbtbyname.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtbyname)
        Me.Panel1.Controls.Add(Me.btnsearchname)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Location = New System.Drawing.Point(18, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 409)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(488, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(454, 409)
        Me.DataGridView1.TabIndex = 3
        '
        'txtbyname
        '
        Me.txtbyname.Location = New System.Drawing.Point(142, 33)
        Me.txtbyname.Multiline = True
        Me.txtbyname.Name = "txtbyname"
        Me.txtbyname.Size = New System.Drawing.Size(299, 47)
        Me.txtbyname.TabIndex = 2
        '
        'btnsearchname
        '
        Me.btnsearchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchname.Location = New System.Drawing.Point(210, 164)
        Me.btnsearchname.Name = "btnsearchname"
        Me.btnsearchname.Size = New System.Drawing.Size(159, 60)
        Me.btnsearchname.TabIndex = 1
        Me.btnsearchname.Text = "Search"
        Me.btnsearchname.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(16, 42)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(68, 25)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'byname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtbyname)
        Me.Name = "byname"
        Me.Text = "byname"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtbyname As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtbyname As System.Windows.Forms.TextBox
    Friend WithEvents btnsearchname As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
