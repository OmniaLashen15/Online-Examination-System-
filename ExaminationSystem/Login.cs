using ExaminationSystem.Context2;
using Microsoft.Data.SqlClient;

namespace ExaminationSystem
{
    public partial class Login : Form
    {
        public static SqlConnection conn = new SqlConnection();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Online_Examination_System; " +
                               "Integrated Security = true ; TrustServerCertificate=true";

        }


        public Online_Examination_SystemContext context=new();
        public string name;
        public int id;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            InstructorHome Instructorhome = new InstructorHome();
            StudentHome StudentHome = new StudentHome();
             name = txtUserNameFrm1.Text;
             id = int.Parse(txtIDFrm1.Text);
            if (radioInstructor.Checked)
            {
            
                
            var instructiorName=(from  I in context.Instructors
                             select I.InsName).ToList();
            var instructorID= (from I in context.Instructors
                               select I.InsId).ToList();
            for(int i=0;i<instructiorName.Count;i++)
            {
                if (instructiorName[i].ToLower() == name.ToLower() && instructorID[i] == id)
                {
                      this.Hide();
                      Instructorhome.ShowDialog();
                     
                        break;

                }
                    else
                    {
                        lblFailed.Visible = true;

                    }
            }
                

            }
            if(radioStudent.Checked)
            {
                var studentName = (from I in context.Students
                                       select I.StFname).ToList();
                var studentID = (from I in context.Students
                                    select I.StId).ToList();
                for (int i = 0; i < studentName.Count; i++)
                {
                    if (studentName[i].ToLower() == name.ToLower() && studentID[i] == id)
                    {
                        this.Hide();
                        StudentHome.ShowDialog();
                        break;
                    }
                    else
                    {
                        lblFailed.Visible = true;
                    }
                }
            }
              

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFailed.Visible = false;
        }
    }
}