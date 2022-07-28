namespace UDCApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginControl1 = new LoginControl.LoginControl();
            this.moveLabel1 = new MoveLabel.MoveLabel();
            this.myNewButtonEvents1 = new UDCEvents.MyNewButtonEvents();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginControl1.ForeColor = System.Drawing.Color.Maroon;
            this.loginControl1.Location = new System.Drawing.Point(26, 44);
            this.loginControl1.Margin = new System.Windows.Forms.Padding(4);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(297, 194);
            this.loginControl1.TabIndex = 0;
            // 
            // moveLabel1
            // 
            this.moveLabel1.LBColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.moveLabel1.LFColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moveLabel1.Location = new System.Drawing.Point(4, 247);
            this.moveLabel1.LSpeed = 50;
            this.moveLabel1.LText = "Visual Studio";
            this.moveLabel1.Name = "moveLabel1";
            this.moveLabel1.Size = new System.Drawing.Size(527, 73);
            this.moveLabel1.TabIndex = 1;
            // 
            // myNewButtonEvents1
            // 
            this.myNewButtonEvents1.Location = new System.Drawing.Point(364, 67);
            this.myNewButtonEvents1.Name = "myNewButtonEvents1";
            this.myNewButtonEvents1.Size = new System.Drawing.Size(105, 39);
            this.myNewButtonEvents1.TabIndex = 2;
            this.myNewButtonEvents1.Abc += new UDCEvents.MyNewButtonEvents.Dname(this.myNewButtonEvents1_Abc);
            this.myNewButtonEvents1.Load += new System.EventHandler(this.myNewButtonEvents1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.myNewButtonEvents1);
            this.Controls.Add(this.moveLabel1);
            this.Controls.Add(this.loginControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl.LoginControl loginControl1;
        private MoveLabel.MoveLabel moveLabel1;
        private UDCEvents.MyNewButtonEvents myNewButtonEvents1;
    }
}

