using ExaminationSystem.Context2;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ExaminationSystem
{
    public partial class frmExamResult : Form
    {
        public frmExamResult()
        {
            InitializeComponent();
        }
        Online_Examination_SystemContext context = new();

        
       // System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["InstructorHome"];

        private void btnapply_Click(object sender, EventArgs e)
        {
            var stdID = int.Parse(textBoxStdID.Text);
            var examID = int.Parse(textBoxExamID.Text);


            DataTable dt = new DataTable();
            SqlCommand sqlcmdSP = new SqlCommand("getStudExam", Login.conn);
            sqlcmdSP.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdSP);
            sqlcmdSP.Parameters.AddWithValue("@examID", examID);
            sqlcmdSP.Parameters.AddWithValue("@studID", stdID);
            adapter.Fill(dt);

            dataGridViewResults.DataSource = dt;


            var result = (from st in context.StudExams
                          where st.StId == stdID && st.ExamId == examID
                          select st.Grade).FirstOrDefault();

            lblGradeResult.Text = result.ToString() + "/10";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            InstructorHome instructorHome= new InstructorHome();
            instructorHome.Show();
            this.Close();

        }
    }
}