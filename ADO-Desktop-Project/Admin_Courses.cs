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
    public partial class Admin_Courses : Form
    {
        public Admin_Courses()
        {
            InitializeComponent();
        }

        private void Admin_Courses_Load(object sender, EventArgs e)
        {
            txt_id.Enabled= true;
            btn_add.Enabled= true;
            btn_update.Enabled = false;
            btn_del.Enabled= false;

            DGV_Admin_Courses.DataSource = AdminBussLayer.GetCourseTable();

            //Topics DropDown List
            DataTable dt=new DataTable();
            dt = AdminBussLayer.GetTopicTable();
            foreach(DataRow dr in dt.Rows)
            {
                cb_topId.DisplayMember = "Top_name";
                cb_topId.ValueMember = "top_id";
                cb_topId.DataSource = dt;
            }  

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int RowAffect = AdminBussLayer.AddCourse(int.Parse(txt_id.Text),txt_name.Text,int.Parse(txt_duration.Text),(int) cb_topId.SelectedValue);
            if(RowAffect >0)
            {
                DGV_Admin_Courses.DataSource = AdminBussLayer.GetCourseTable();
                txt_id.Text=txt_name.Text=txt_duration.Text=" ";
            }
        }

        private void DGV_Admin_Courses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text=DGV_Admin_Courses.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text=DGV_Admin_Courses.SelectedRows[0].Cells[1].Value.ToString();
            txt_duration.Text= DGV_Admin_Courses.SelectedRows[0].Cells[2].Value.ToString();
            cb_topId.SelectedValue= DGV_Admin_Courses.SelectedRows[0].Cells[3].Value;

            txt_id.Enabled = false;
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_del.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int RowAffect = AdminBussLayer.UpdateCourse(int.Parse(txt_id.Text), txt_name.Text, int.Parse(txt_duration.Text), (int)cb_topId.SelectedValue);
            if (RowAffect > 0)
            {
                DGV_Admin_Courses.DataSource = AdminBussLayer.GetCourseTable();
                txt_id.Text = txt_name.Text = txt_duration.Text = " ";

                txt_id.Enabled = true;
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_del.Enabled = false;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int RowAffect = AdminBussLayer.DeleteFromCourse(int.Parse(txt_id.Text));
            if (RowAffect > 0)
            {
                DGV_Admin_Courses.DataSource = AdminBussLayer.GetCourseTable();
                txt_id.Text = txt_name.Text = txt_duration.Text = " ";

                txt_id.Enabled = true;
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_del.Enabled = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.ShowDialog();
            //this.Close();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Admin_Student AS=new Admin_Student();
            AS.ShowDialog();
            //this.Close();
        }

        private void btn_instructor_Click(object sender, EventArgs e)
        {
            Admin_Instructor ai=new Admin_Instructor();
            ai.ShowDialog();
            //this.Close();
        }

        private void btn_topic_Click(object sender, EventArgs e)
        {
            Admin_Topics at=new Admin_Topics();
            at.ShowDialog();
            //this.Close();
        }
    }
}
