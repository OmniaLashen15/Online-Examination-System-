using ExaminationSystem.Context2;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmGenerateExam : Form
    {
        public frmGenerateExam()
        {
            InitializeComponent();
        }
        private void btnGenerateExam_Click(object sender, EventArgs e)
        {

            
            var course = comboBoxCourse.SelectedValue;
            var T_F = numericUpDownTF.Value;
            var MCQ = numericUpDownMCQ.Value;
            var Models = numericUpDownModels.Value; 

            DataTable dt = new DataTable();
           
            for (int i =0; i < Models; i++)
            {
                SqlCommand sqlcmdSP = new SqlCommand("Generate_Exam",Login.conn);
                sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdSP);
                sqlcmdSP.Parameters.AddWithValue("@crsName", course);
                sqlcmdSP.Parameters.AddWithValue("@n_TF", T_F);
                sqlcmdSP.Parameters.AddWithValue("@n_MCQ", MCQ);
                adapter.Fill(dt);
            }

            MessageBox.Show($"Done, You created {Models} models successfully");
        }
        Online_Examination_SystemContext context = new();

        private void frmGenerateExam_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource=(from C in context.Courses
                                       select C.CrsName).ToList();

            comboBoxCourse.DisplayMember = "Crs_Name";
         
            numericUpDownTF.ValueChanged+=(sender, e)=>numericUpDownMCQ.Value=10 - numericUpDownTF.Value;
            numericUpDownMCQ.ValueChanged += (sender, e) => numericUpDownTF.Value = 10 - numericUpDownMCQ.Value;

            this.Refresh();
        }
    }
}
