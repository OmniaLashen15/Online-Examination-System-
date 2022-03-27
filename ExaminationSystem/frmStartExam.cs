using ExaminationSystem.Context2;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmStartExam : Form
    {
        public frmStartExam()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];



        Online_Examination_SystemContext context = new();
            string[] actualAnwers = new string[10];
        List<string> answers = new List<string>();
          public  int ExamId;
        private void frmStartExam_Load(object sender, EventArgs e)
        {
           panelGrade.Visible = false;
            labelStdID.Text = ((Login)f).txtIDFrm1.Text;
            labelStdName.Text = ((Login)f).txtUserNameFrm1.Text;
            var departments = (from S in context.Students
                               where S.StFname == ((Login)f).txtUserNameFrm1.Text && S.StId == int.Parse(((Login)f).txtIDFrm1.Text)
                               select S.Dept.DeptName);
            labelStdDepartment.Text = departments.FirstOrDefault();

            labelCourse.Text =StudentHome.course;
    
            List<string>options=new List<string>() {"A","B","C","D"};
  
         

            var cmd = new SqlCommand("SelectExamQuestions",Login.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            var p1 = cmd.Parameters.Add("@eid", SqlDbType.Int);
            p1.Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@courseName", labelCourse.Text);


            var dt = new DataTable();
            Login.conn.Open();
            using (var rdr = cmd.ExecuteReader())
            {
                dt.Load(rdr);
                 ExamId = (int)p1.Value;
            }
            Login.conn.Close();
            DataGridViewComboBoxColumn Dc = new DataGridViewComboBoxColumn();
            Dc.DataSource = options;
            Dc.HeaderText = "Answers";
            
            dataGridViewExamQuestions.DataSource = dt;
            dataGridViewExamQuestions.AllowUserToAddRows = false;
            dataGridViewExamQuestions.Columns.Add(Dc);
            this.Invalidate();

            //Trace.WriteLine(id);

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            for(int i=0;i<10;i++)
            {
                answers.Add(dataGridViewExamQuestions.Rows[i].Cells[5].Value.ToString());
               // Trace.WriteLine(answers[i]);
            }
            for(int i=0;i<10;i++)
            {
                if(answers[i]=="A")
                {
                    actualAnwers[i] = dataGridViewExamQuestions.Rows[i].Cells[1].Value.ToString();
                }
                else if (answers[i]=="B")
                {
                    actualAnwers[i] = dataGridViewExamQuestions.Rows[i].Cells[2].Value.ToString();

                }
                else if (answers[i] == "C")
                {
                    actualAnwers[i] = dataGridViewExamQuestions.Rows[i].Cells[3].Value.ToString();

                }
                else if (answers[i] == "D")
                {
                    actualAnwers[i] = dataGridViewExamQuestions.Rows[i].Cells[4].Value.ToString();

                }
                //Trace.WriteLine(actualAnwers[i]);

            }
            DataTable dt = new DataTable();
            
            SqlCommand sqlcmdSP = new SqlCommand("set_Student_Answers", Login.conn);
            sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdSP);
            sqlcmdSP.Parameters.AddWithValue("@examID", ExamId);
            sqlcmdSP.Parameters.AddWithValue("@studID", int.Parse(labelStdID.Text));
           for(int i=0;i<10;i++)
            {
                sqlcmdSP.Parameters.AddWithValue($"@ans{i+1}", actualAnwers[i]);

            }

            adapter.Fill(dt);

            sqlcmdSP = new SqlCommand("Exam_Correction",Login.conn);
            sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(sqlcmdSP);
            sqlcmdSP.Parameters.AddWithValue("@examID", ExamId);
            sqlcmdSP.Parameters.AddWithValue("@studID", int.Parse(labelStdID.Text));
            adapter.Fill(dt);


            var result =(from st in context.StudExams
                        where st.StId== int.Parse(labelStdID.Text) && st.ExamId== ExamId
                        select st.Grade).FirstOrDefault();

            panelGrade.Visible = true;
            labelGrade.Text = result.ToString()+"/10";

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            this.Hide();
            studentHome.Show();

        }
    }
}
