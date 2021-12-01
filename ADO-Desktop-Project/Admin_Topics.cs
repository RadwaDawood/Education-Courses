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
    public partial class Admin_Topics : Form
    {
        public Admin_Topics()
        {
            InitializeComponent();
        }

        private void Admin_Topics_Load(object sender, EventArgs e)
        {
            txt_id.Enabled=true;
            btn_add.Enabled=true;
            btn_update.Enabled=false;
            btn_del.Enabled=false;  

            DGV_Admin_Topics.DataSource = AdminBussLayer.GetTopicTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int rowAffect=AdminBussLayer.AddTopic(int.Parse(txt_id.Text),txt_name.Text);
            if (rowAffect > 0)
            {
                DGV_Admin_Topics.DataSource = AdminBussLayer.GetTopicTable();
                txt_id.Text = txt_name.Text = " ";
            }
        }


        private void DGV_Admin_Topics_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text=DGV_Admin_Topics.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = DGV_Admin_Topics.SelectedRows[0].Cells[1].Value.ToString();

            txt_id.Enabled = false;
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_del.Enabled = true;

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            int rowAffect = AdminBussLayer.UpdateTopic(int.Parse(txt_id.Text), txt_name.Text);
            if (rowAffect > 0)
            {
                DGV_Admin_Topics.DataSource = AdminBussLayer.GetTopicTable();
                txt_id.Text = txt_name.Text = " ";

                txt_id.Enabled = true;
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                btn_del.Enabled = false;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int rowAffect = AdminBussLayer.DeleteFromTopic(int.Parse(txt_id.Text));
            if (rowAffect > 0)
            {
                DGV_Admin_Topics.DataSource = AdminBussLayer.GetTopicTable();
                txt_id.Text = txt_name.Text = " ";

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

        private void btn_course_Click(object sender, EventArgs e)
        {
            Admin_Courses ac=new Admin_Courses();
            ac.ShowDialog();
            //this.Close();
        }
    }
}
