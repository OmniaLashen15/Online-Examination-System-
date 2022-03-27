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
    public partial class InstructorHome : Form
    {
        public InstructorHome()
        {
            InitializeComponent();
        }

        frmGenerateExam frmGenerateExam=new frmGenerateExam();
        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenerateExam.ShowDialog();
        }

        
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];
        frmExamResult result = new();

        private void InstructorHome_Load(object sender, EventArgs e)
        {
            labelInsId.Text = ((Login)f).txtIDFrm1.Text;
            labelInsName.Text = ((Login)f).txtUserNameFrm1.Text;
            this.Invalidate();
            panelCourses.Visible = false;

        }

        private void btnExamResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            result.ShowDialog();
        }

        private void btngetInstructorCourses_Click(object sender, EventArgs e)
        {
            panelCourses.Visible = true;
            DataTable dt = new DataTable();
            SqlCommand sqlcmdSP = new SqlCommand("getInstructorCourses", Login.conn);
            sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdSP);
            sqlcmdSP.Parameters.AddWithValue("@instID", int.Parse(labelInsId.Text));
            adapter.Fill(dt);

            dataGridViewCourses.DataSource = dt;
            dataGridViewCourses.AllowUserToAddRows = false;

            labelPanelInsName.Text = labelInsName.Text;
            labelPanelInsID.Text = labelInsId.Text;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCourses.Visible = false;
           
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Login)f).txtIDFrm1.Text=String.Empty;
            ((Login)f).txtUserNameFrm1.Text=String.Empty;
            ((Login)f).radioInstructor.Checked = false;
            ((Login)f).lblFailed.Visible = false;
            ((Login)f).Show();
        }
    }
}
