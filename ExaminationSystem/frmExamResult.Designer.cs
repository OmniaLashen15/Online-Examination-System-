namespace ExaminationSystem
{
    partial class frmExamResult
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
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.lblGradeResult = new System.Windows.Forms.Label();
            this.textBoxStdID = new System.Windows.Forms.TextBox();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Location = new System.Drawing.Point(59, 104);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(82, 20);
            this.lblStudID.TabIndex = 1;
            this.lblStudID.Text = "Student ID:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(789, 296);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(49, 20);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(774, 461);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 31);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 25;
            this.dataGridViewResults.Size = new System.Drawing.Size(690, 357);
            this.dataGridViewResults.TabIndex = 6;
            // 
            // lblGradeResult
            // 
            this.lblGradeResult.AutoSize = true;
            this.lblGradeResult.Location = new System.Drawing.Point(789, 333);
            this.lblGradeResult.Name = "lblGradeResult";
            this.lblGradeResult.Size = new System.Drawing.Size(45, 20);
            this.lblGradeResult.TabIndex = 7;
            this.lblGradeResult.Text = "result";
            // 
            // textBoxStdID
            // 
            this.textBoxStdID.Location = new System.Drawing.Point(204, 97);
            this.textBoxStdID.Name = "textBoxStdID";
            this.textBoxStdID.Size = new System.Drawing.Size(125, 27);
            this.textBoxStdID.TabIndex = 8;
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Location = new System.Drawing.Point(669, 97);
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.Size = new System.Drawing.Size(125, 27);
            this.textBoxExamID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exam ID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(774, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.textBoxStdID);
            this.Controls.Add(this.lblGradeResult);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExamResult";
            this.Text = "frmExamResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblStudID;
        private Label lblGrade;
        private Button btnApply;
        private DataGridView dataGridViewResults;
        private Label lblGradeResult;
        private TextBox textBoxStdID;
        private TextBox textBoxExamID;
        private Label label1;
        private Button btnBack;
    }
}