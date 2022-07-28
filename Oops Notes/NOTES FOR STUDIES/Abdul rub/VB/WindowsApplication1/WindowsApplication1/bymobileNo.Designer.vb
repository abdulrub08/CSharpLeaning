<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bymobileNo
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
        Me.rbtnymobileno = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnbymobileno = New System.Windows.Forms.Button
        Me.txtmobileno = New System.Windows.Forms.TextBox
        Me.lblbymobileno = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtnymobileno
        '
        Me.rbtnymobileno.AutoSize = True
        Me.rbtnymobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnymobileno.ForeColor = System.Drawing.Color.Coral
        Me.rbtnymobileno.Location = New System.Drawing.Point(399, 25)
        Me.rbtnymobileno.Name = "rbtnymobileno"
        Me.rbtnymobileno.Size = New System.Drawing.Size(183, 29)
        Me.rbtnymobileno.TabIndex = 0
        Me.rbtnymobileno.TabStop = True
        Me.rbtnymobileno.Text = "BY MOBILE NO"
        Me.rbtnymobileno.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnbymobileno)
        Me.Panel1.Controls.Add(Me.txtmobileno)
        Me.Panel1.Controls.Add(Me.lblbymobileno)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-2, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 185)
        Me.Panel1.TabIndex = 1
        '
        'btnbymobileno
        '
        Me.btnbymobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbymobileno.Location = New System.Drawing.Point(445, 106)
        Me.btnbymobileno.Name = "btnbymobileno"
        Me.btnbymobileno.Size = New System.Drawing.Size(102, 38)
        Me.btnbymobileno.TabIndex = 2
        Me.btnbymobileno.Text = "Search"
        Me.btnbymobileno.UseVisualStyleBackColor = True
        '
        'txtmobileno
        '
        Me.txtmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobileno.Location = New System.Drawing.Point(358, 44)
        Me.txtmobileno.Multiline = True
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(277, 31)
        Me.txtmobileno.TabIndex = 1
        '
        'lblbymobileno
        '
        Me.lblbymobileno.AutoSize = True
        Me.lblbymobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbymobileno.Location = New System.Drawing.Point(222, 55)
        Me.lblbymobileno.Name = "lblbymobileno"
        Me.lblbymobileno.Size = New System.Drawing.Size(88, 20)
        Me.lblbymobileno.TabIndex = 0
        Me.lblbymobileno.Text = "Mobile No"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(884, 269)
        Me.DataGridView1.TabIndex = 2
        '
        'bymobileNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 510)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtnymobileno)
        Me.Name = "bymobileNo"
        Me.Text = "bymobileNo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnymobileno As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblbymobileno As System.Windows.Forms.Label
    Friend WithEvents btnbymobileno As System.Windows.Forms.Button
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
