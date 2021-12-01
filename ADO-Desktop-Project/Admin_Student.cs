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
    public partial class Admin_Student : Form
    {
        public Admin_Student()
        {
            InitializeComponent();
        }

        private void Admin_Student_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            btn_add.Enabled = true;
            btn_del.Enabled = false;

            DGV_students_admin.DataSource = AdminBussLayer.GetStudentTable();

            //department dropdown list
            DataTable dt = new DataTable();
            dt = AdminBussLayer.GetDeptForStudent();
            DataRow dr = dt.NewRow();
            foreach (DataRow item in dt.Rows)
            {
                cb_dept.DisplayMember = "dept_name";
                cb_dept.ValueMember = "dept_id";
                cb_dept.DataSource = dt;
            }

            //Supervisor dropdown list
            DataTable dt_super = new DataTable();
            dt_super = AdminBussLayer.GetSuperForStudent();
            DataRow dr_super = dt.NewRow();
            foreach (DataRow item in dt_super.Rows)
            {
                cb_super.DisplayMember = "Full Name";
                cb_super.ValueMember = "student_Id";
                cb_super.DataSource = dt_super;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int rowaffect = AdminBussLayer.AddStudent(int.Parse(txt_id.Text), txt_fName.Text, txt_lName.Text, txt_address.Text, int.Parse(txt_age.Text), (int)cb_dept.SelectedValue, (int)cb_super.SelectedValue , txt_userName.Text , txt_password.Text);
            if (rowaffect > 0)
            {
                DGV_students_admin.DataSource = AdminBussLayer.GetStudentTable();
                txt_id.Text = txt_fName.Text = txt_lName.Text = txt_age.Text = txt_address.Text=txt_userName.Text=txt_password.Text= " ";
            }
        }


        private void DGV_students_admin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = DGV_students_admin.SelectedRows[0].Cells[0].Value.ToString();
            txt_fName.Text = DGV_students_admin.SelectedRows[0].Cells[1].Value.ToString();
            txt_lName.Text = DGV_students_admin.SelectedRows[0].Cells[2].Value.ToString();
            txt_address.Text = DGV_students_admin.SelectedRows[0].Cells[3].Value.ToString();
            txt_age.Text = DGV_students_admin.SelectedRows[0].Cells[4].Value.ToString();
            cb_dept.SelectedValue = DGV_students_admin.SelectedRows[0].Cells[5].Value;
            cb_super.SelectedValue = DGV_students_admin.SelectedRows[0].Cells[6].Value;
            txt_userName.Text=DGV_students_admin.SelectedRows[0].Cells[7].Value.ToString();
            txt_password.Text=DGV_students_admin.SelectedRows[0].Cells[8].Value.ToString();
            
            txt_id.Enabled = true;
            btn_add.Enabled = false;
            btn_del.Enabled = true;
            
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            int rowaffect = AdminBussLayer.deleteFromStudent(int.Parse(txt_id.Text));
            if (rowaffect > 0)
            {
                DGV_students_admin.DataSource = AdminBussLayer.GetStudentTable();
                txt_id.Text = txt_fName.Text = txt_lName.Text = txt_age.Text = txt_address.Text = txt_userName.Text = txt_password.Text = " ";
                txt_id.Enabled = true;
                btn_add.Enabled = true;
                btn_del.Enabled = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.ShowDialog();
           // this.Close();
        }

        private void btn_instructor_Click(object sender, EventArgs e)
        {
            Admin_Instructor ai=new Admin_Instructor();
            ai.ShowDialog();
           // this.Close();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            Admin_Courses ac=new Admin_Courses();
            ac.ShowDialog();
           // this.Close();
        }

        private void btn_topic_Click(object sender, EventArgs e)
        {
            Admin_Topics at=new Admin_Topics();
            at.ShowDialog();
           // this.Close();
        }
    }
}
