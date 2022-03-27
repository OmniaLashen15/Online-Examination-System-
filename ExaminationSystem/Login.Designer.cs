namespace ExaminationSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserNameFrm1 = new System.Windows.Forms.TextBox();
            this.txtIDFrm1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioInstructor = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.lblFailed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserNameFrm1
            // 
            this.txtUserNameFrm1.Location = new System.Drawing.Point(311, 105);
            this.txtUserNameFrm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserNameFrm1.Name = "txtUserNameFrm1";
            this.txtUserNameFrm1.Size = new System.Drawing.Size(163, 27);
            this.txtUserNameFrm1.TabIndex = 0;
            // 
            // txtIDFrm1
            // 
            this.txtIDFrm1.Location = new System.Drawing.Point(311, 163);
            this.txtIDFrm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDFrm1.Name = "txtIDFrm1";
            this.txtIDFrm1.Size = new System.Drawing.Size(163, 27);
            this.txtIDFrm1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your ID";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(339, 345);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 31);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radioInstructor
            // 
            this.radioInstructor.AutoSize = true;
            this.radioInstructor.Location = new System.Drawing.Point(250, 248);
            this.radioInstructor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioInstructor.Name = "radioInstructor";
            this.radioInstructor.Size = new System.Drawing.Size(112, 24);
            this.radioInstructor.TabIndex = 7;
            this.radioInstructor.TabStop = true;
            this.radioInstructor.Text = "As Instructor";
            this.radioInstructor.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(421, 248);
            this.radioStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(101, 24);
            this.radioStudent.TabIndex = 8;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "As Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.ForeColor = System.Drawing.Color.Red;
            this.lblFailed.Location = new System.Drawing.Point(285, 444);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(203, 20);
            this.lblFailed.TabIndex = 9;
            this.lblFailed.Text = "Login failed ,please try again.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.radioStudent);
            this.Controls.Add(this.radioInstructor);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDFrm1);
            this.Controls.Add(this.txtUserNameFrm1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnLogin;
        public TextBox txtUserNameFrm1;
        public TextBox txtIDFrm1;
        public RadioButton radioInstructor;
        public RadioButton radioStudent;
        public Label lblFailed;
    }
}