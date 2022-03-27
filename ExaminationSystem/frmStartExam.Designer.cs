namespace ExaminationSystem
{
    partial class frmStartExam
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
            this.labelStdDepartment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStdID = new System.Windows.Forms.Label();
            this.labelStdName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewExamQuestions = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.panelGrade = new System.Windows.Forms.Panel();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamQuestions)).BeginInit();
            this.panelGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStdDepartment
            // 
            this.labelStdDepartment.AutoSize = true;
            this.labelStdDepartment.Location = new System.Drawing.Point(627, 21);
            this.labelStdDepartment.Name = "labelStdDepartment";
            this.labelStdDepartment.Size = new System.Drawing.Size(87, 20);
            this.labelStdDepartment.TabIndex = 13;
            this.labelStdDepartment.Text = "department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student ID:";
            // 
            // labelStdID
            // 
            this.labelStdID.AutoSize = true;
            this.labelStdID.Location = new System.Drawing.Point(179, 74);
            this.labelStdID.Name = "labelStdID";
            this.labelStdID.Size = new System.Drawing.Size(24, 20);
            this.labelStdID.TabIndex = 10;
            this.labelStdID.Text = "ID";
            // 
            // labelStdName
            // 
            this.labelStdName.AutoSize = true;
            this.labelStdName.Location = new System.Drawing.Point(179, 21);
            this.labelStdName.Name = "labelStdName";
            this.labelStdName.Size = new System.Drawing.Size(46, 20);
            this.labelStdName.TabIndex = 9;
            this.labelStdName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name:";
            // 
            // dataGridViewExamQuestions
            // 
            this.dataGridViewExamQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamQuestions.Location = new System.Drawing.Point(12, 152);
            this.dataGridViewExamQuestions.Name = "dataGridViewExamQuestions";
            this.dataGridViewExamQuestions.RowHeadersWidth = 51;
            this.dataGridViewExamQuestions.RowTemplate.Height = 29;
            this.dataGridViewExamQuestions.Size = new System.Drawing.Size(826, 277);
            this.dataGridViewExamQuestions.TabIndex = 16;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(716, 455);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(94, 29);
            this.btnsubmit.TabIndex = 17;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Course:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(639, 68);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(52, 20);
            this.labelCourse.TabIndex = 18;
            this.labelCourse.Text = "course";
            // 
            // panelGrade
            // 
            this.panelGrade.Controls.Add(this.buttonBack);
            this.panelGrade.Controls.Add(this.labelGrade);
            this.panelGrade.Controls.Add(this.label2);
            this.panelGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrade.Location = new System.Drawing.Point(0, 0);
            this.panelGrade.Name = "panelGrade";
            this.panelGrade.Size = new System.Drawing.Size(857, 557);
            this.panelGrade.TabIndex = 19;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(468, 82);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(48, 20);
            this.labelGrade.TabIndex = 1;
            this.labelGrade.Text = "grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(646, 474);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // frmStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 557);
            this.Controls.Add(this.panelGrade);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dataGridViewExamQuestions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStdDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStdID);
            this.Controls.Add(this.labelStdName);
            this.Controls.Add(this.label1);
            this.Name = "frmStartExam";
            this.Text = "frmStartExam";
            this.Load += new System.EventHandler(this.frmStartExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamQuestions)).EndInit();
            this.panelGrade.ResumeLayout(false);
            this.panelGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label labelStdDepartment;
        private Label label5;
        private Label label4;
        public Label labelStdID;
        public Label labelStdName;
        private Label label1;
        private DataGridView dataGridViewExamQuestions;
        private Button btnsubmit;
        private Label label7;
        private Label labelCourse;
        private Panel panelGrade;
        private Label labelGrade;
        private Label label2;
        private Button buttonBack;
    }
}