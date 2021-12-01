using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Desktop_Project
{
    public partial class Instructor_Form : Form
    {
        public Instructor_Form()
        {
            InitializeComponent();
        }
        public int ins_id;
        public string userName;
        public string password;
        private void Instructor_Form_Load(object sender, EventArgs e)
        {
            DataTable ins_dt = Login.instructorDT;
            ins_id = (int) ins_dt.Rows[0][0];

            txt_userName.Text = Login.InsUserName;
            txt_Password.Text = Login.InsPassword;

            DGV_InstructorCourses.DataSource = InstructorBussLayer.GetInstructorCourse(ins_id);

            DGV_StudentPerCourses.DataSource=InstructorBussLayer.GetStudentPerCourse(ins_id);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = InstructorBussLayer.UpdateInstructorProfile(ins_id, txt_userName.Text, txt_Password.Text);
                if (RowAffect > 0)
                {
                    lbl_updateStatus.Text = "Updated Done !";
                }
            }
            catch
            {
                lbl_updateStatus.Text = "Something Wrong !";
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
