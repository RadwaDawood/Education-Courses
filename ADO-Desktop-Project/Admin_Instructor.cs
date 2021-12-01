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
    public partial class Admin_Instructor : Form
    {
        public Admin_Instructor()
        {
            InitializeComponent();
        }

        private void Admin_Instructor_Load(object sender, EventArgs e)
        {
            txt_id.Enabled= true;
            btn_add.Enabled= true;
            btn_del.Enabled= false;
            DGV_Admin_Instructors.DataSource = AdminBussLayer.GetInstructorTable();

            //department dropdown list
            DataTable dt = new DataTable();
            dt = AdminBussLayer.GetDeptForInstructor();
            DataRow dr = dt.NewRow();
            foreach (DataRow item in dt.Rows)
            {
                cb_dept.DisplayMember = "dept_name";
                cb_dept.ValueMember = "dept_id";
                cb_dept.DataSource = dt;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int rowAffect = AdminBussLayer.AddInstructor(int.Parse(txt_id.Text), txt_name.Text, txt_degree.Text, int.Parse(txt_salary.Text), (int)cb_dept.SelectedValue, txt_userName.Text, txt_password.Text);
            if (rowAffect > 0)
            {
                DGV_Admin_Instructors.DataSource = AdminBussLayer.GetInstructorTable();
                txt_id.Text = txt_name.Text=txt_degree.Text=txt_salary.Text=txt_userName.Text=txt_password.Text=" ";
            }
        }

        private void DGV_Admin_Instructors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text=DGV_Admin_Instructors.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = DGV_Admin_Instructors.SelectedRows[0].Cells[1].Value.ToString();
            txt_degree.Text = DGV_Admin_Instructors.SelectedRows[0].Cells[2].Value.ToString();
            txt_salary.Text = DGV_Admin_Instructors.SelectedRows[0].Cells[3].Value.ToString();
            cb_dept.SelectedValue = DGV_Admin_Instructors.SelectedRows[0].Cells[4].Value;
            txt_userName.Text = DGV_Admin_Instructors.SelectedRows[0].Cells[5].Value.ToString();
            txt_password.Text = DGV_Admin_Instructors.SelectedRows[0].Cells[6].Value.ToString();

            txt_id.Enabled = false;
            btn_add.Enabled = false;
            btn_del.Enabled = true;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int rowAffect = AdminBussLayer.DeleteFromInstructor(int.Parse(txt_id.Text));
            if (rowAffect > 0)
            {
                DGV_Admin_Instructors.DataSource = AdminBussLayer.GetInstructorTable();
                txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = txt_userName.Text = txt_password.Text = " ";
                txt_id.Enabled = true;
                btn_add.Enabled = true;
                btn_del.Enabled = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            // this.Close();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Admin_Student AS = new Admin_Student();
            AS.ShowDialog();
            // this.Close();

        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            Admin_Courses ac = new Admin_Courses();
            ac.ShowDialog();
            // this.Close();
        }

        private void btn_topic_Click(object sender, EventArgs e)
        {
            Admin_Topics at = new Admin_Topics();
            at.ShowDialog();
            // this.Close();
        }
    }
}
