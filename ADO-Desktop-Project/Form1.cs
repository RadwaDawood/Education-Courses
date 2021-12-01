using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_Desktop_Project
{
    public partial class Login : Form
    {
        public static DataTable studentDT;
        public static DataTable instructorDT;
        public static string InsUserName;
        public static string InsPassword;
        public Login()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            btn_course.Visible = false;
            btn_instructors.Visible = false;
            btn_students.Visible = false;
            btn_topics.Visible = false;

            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable Admin_dt = AdminBussLayer.GetAdminTable(txt_userName.Text, txt_password.Text);
            DataTable StudentLogin_dt = StudentBussLayer.GetStudentLoginTable(txt_userName.Text, txt_password.Text);
            DataTable InstructorLogin_dt = InstructorBussLayer.GetInstructorLoginTable(txt_userName.Text, txt_password.Text);


            if (Admin_dt.Rows.Count == 1) 
            {

                btn_course.Visible = true;
                btn_instructors.Visible = true;
                btn_students.Visible = true;
                btn_topics.Visible = true;
                lbl_afterlogin.Text = $"Hi {txt_userName.Text} , Which table you want to work on it?";
                txt_password.Text = txt_userName.Text = " ";

                
            }
            else if (StudentLogin_dt.Rows.Count == 1)
            {
                studentDT=StudentLogin_dt;
                
                Student_Form sf=new Student_Form();
                sf.ShowDialog();
                this.Close();

                txt_password.Text = txt_userName.Text = " ";
            }
            else if (InstructorLogin_dt.Rows.Count == 1)
            {
                instructorDT=InstructorLogin_dt;
                InsUserName = txt_userName.Text;
                InsPassword=txt_password.Text;
                Instructor_Form IF=new Instructor_Form();
                IF.ShowDialog();
                txt_password.Text = txt_userName.Text = " ";
            }
            else
            {
                // MessageBox.Show("invalid username or password");
                lbl_Invalid.Text = "* Invalid UserName or Password !";
                txt_password.Text = txt_userName.Text = " ";
            }

        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            
            Admin_Student admin_Student= new Admin_Student();
            admin_Student.ShowDialog();

            this.Close();


        }

        private void btn_instructors_Click(object sender, EventArgs e)
        {
            Admin_Instructor ai=new Admin_Instructor();
            ai.ShowDialog();
            this.Close();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            Admin_Courses ac=new Admin_Courses();
            ac.ShowDialog();

            this.Close();

        }

        private void btn_topics_Click(object sender, EventArgs e)
        {
            Admin_Topics at=new Admin_Topics();
            at.ShowDialog();
            this.Close();
        }
    }
}
