namespace ADO_Desktop_Project
{
    partial class Admin_Instructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Admin_Instructors = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_degree = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.cb_ins_dept = new System.Windows.Forms.Label();
            this.lbl_insUserName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_topic = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Admin_Instructors
            // 
            this.DGV_Admin_Instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Admin_Instructors.Location = new System.Drawing.Point(12, 230);
            this.DGV_Admin_Instructors.Name = "DGV_Admin_Instructors";
            this.DGV_Admin_Instructors.Size = new System.Drawing.Size(776, 174);
            this.DGV_Admin_Instructors.TabIndex = 0;
            this.DGV_Admin_Instructors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Admin_Instructors_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(138, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(138, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(138, 115);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(121, 20);
            this.txt_salary.TabIndex = 3;
            // 
            // txt_degree
            // 
            this.txt_degree.Location = new System.Drawing.Point(138, 80);
            this.txt_degree.Name = "txt_degree";
            this.txt_degree.Size = new System.Drawing.Size(121, 20);
            this.txt_degree.TabIndex = 4;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(413, 49);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(121, 20);
            this.txt_userName.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(413, 84);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 6;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(413, 11);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(121, 21);
            this.cb_dept.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(32, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(32, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Location = new System.Drawing.Point(32, 87);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(48, 13);
            this.lbl_degree.TabIndex = 10;
            this.lbl_degree.Text = "Degree :";
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(32, 122);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(42, 13);
            this.lbl_salary.TabIndex = 11;
            this.lbl_salary.Text = "Salary :";
            // 
            // cb_ins_dept
            // 
            this.cb_ins_dept.AutoSize = true;
            this.cb_ins_dept.Location = new System.Drawing.Point(329, 19);
            this.cb_ins_dept.Name = "cb_ins_dept";
            this.cb_ins_dept.Size = new System.Drawing.Size(68, 13);
            this.cb_ins_dept.TabIndex = 12;
            this.cb_ins_dept.Text = "Department :";
            // 
            // lbl_insUserName
            // 
            this.lbl_insUserName.AutoSize = true;
            this.lbl_insUserName.Location = new System.Drawing.Point(329, 56);
            this.lbl_insUserName.Name = "lbl_insUserName";
            this.lbl_insUserName.Size = new System.Drawing.Size(66, 13);
            this.lbl_insUserName.TabIndex = 13;
            this.lbl_insUserName.Text = "User Name :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(329, 91);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 13);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(158, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(12, 169);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(103, 23);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_topic
            // 
            this.btn_topic.Location = new System.Drawing.Point(693, 410);
            this.btn_topic.Name = "btn_topic";
            this.btn_topic.Size = new System.Drawing.Size(95, 28);
            this.btn_topic.TabIndex = 17;
            this.btn_topic.Text = "Topics";
            this.btn_topic.UseVisualStyleBackColor = true;
            this.btn_topic.Click += new System.EventHandler(this.btn_topic_Click);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(577, 410);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(95, 28);
            this.btn_course.TabIndex = 18;
            this.btn_course.Text = "Courses";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(458, 410);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(95, 28);
            this.btn_student.TabIndex = 19;
            this.btn_student.Text = "Students";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(332, 410);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 28);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "LogIn";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Admin_Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_topic);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_insUserName);
            this.Controls.Add(this.cb_ins_dept);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_degree);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_degree);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV_Admin_Instructors);
            this.Name = "Admin_Instructor";
            this.Text = "Admin_Instructor";
            this.Load += new System.EventHandler(this.Admin_Instructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Admin_Instructors;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_degree;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label cb_ins_dept;
        private System.Windows.Forms.Label lbl_insUserName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_topic;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_login;
    }
}