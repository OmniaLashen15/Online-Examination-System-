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

namespace ExaminationSystem
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];



        Online_Examination_SystemContext context = new();
       static public string course;
        private void StudentHome_Load(object sender, EventArgs e)
        {
            labelStdID.Text = ((Login)f).txtIDFrm1.Text;
            labelStdName.Text = ((Login)f).txtUserNameFrm1.Text;
            var departments = (from S in context.Students
                                       where S.StFname == ((Login)f).txtUserNameFrm1.Text && S.StId == int.Parse(((Login)f).txtIDFrm1.Text)
                                       select S.Dept.DeptName);
            labelStdDepartment.Text = departments.FirstOrDefault();

            comboBoxCourse.DataSource = (from C in context.Courses
                                         select C.CrsName).ToList();

            comboBoxCourse.DisplayMember = "Crs_Name";

             comboBoxCourse.SelectedValueChanged+=(sender,e)=>course=comboBoxCourse.SelectedItem.ToString();

        }
        frmGenerateExam frmGenerateExam = new frmGenerateExam();
        frmStartExam frmStartExam = new frmStartExam();
        private void btnStartExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam.ShowDialog();
        }

        private void btnExamResult_Click(object sender, EventArgs e)
        {

        }
        frmShowAllGrades frm=new frmShowAllGrades();
        private void btnShowGades_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
            ((Login)f).txtIDFrm1.Text = String.Empty;
            ((Login)f).txtUserNameFrm1.Text = String.Empty;
            ((Login)f).radioStudent.Checked = false;
            ((Login)f).lblFailed.Visible = false;
            ((Login)f).Show();
        }
    }
}
