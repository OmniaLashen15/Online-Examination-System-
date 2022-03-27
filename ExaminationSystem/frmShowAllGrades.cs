using ExaminationSystem.Context2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.Entities2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace ExaminationSystem
{
    public partial class frmShowAllGrades : Form
    {
        public frmShowAllGrades()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];
        Online_Examination_SystemContext  Context= new();
        
        private void frmShowAllGrades_Load(object sender, EventArgs e)
        {

            labelStudentID.Text = ((Login)f).txtIDFrm1.Text;
            labelStudentName.Text = ((Login)f).txtUserNameFrm1.Text;
            var departments = (from S in Context.Students
                               where S.StFname == ((Login)f).txtUserNameFrm1.Text && S.StId == int.Parse(((Login)f).txtIDFrm1.Text)
                               select S.Dept.DeptName);
            labelDept.Text = departments.FirstOrDefault();


            var St_ID = int.Parse(labelStudentID.Text);
            
            DataTable dt = new DataTable();
            SqlCommand sqlcmdSP = new SqlCommand("getstudentGrade", Login.conn);
            sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdSP);
            sqlcmdSP.Parameters.AddWithValue("@StudID", St_ID);
            adapter.Fill(dt);
            dataGridViewStdGrades.DataSource = dt;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        StudentHome studentHome = new StudentHome();
           this.Hide();
          studentHome.ShowDialog();
        }
    }
}
