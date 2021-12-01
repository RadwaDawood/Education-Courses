namespace ADO_Desktop_Project
{
    partial class Admin_Student
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
            this.DGV_students_admin = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.cb_super = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_super = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_instructor = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_topic = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_students_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_students_admin
            // 
            this.DGV_students_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_students_admin.Location = new System.Drawing.Point(12, 192);
            this.DGV_students_admin.Name = "DGV_students_admin";
            this.DGV_students_admin.Size = new System.Drawing.Size(776, 193);
            this.DGV_students_admin.TabIndex = 0;
            this.DGV_students_admin.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_students_admin_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(116, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(116, 38);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(100, 20);
            this.txt_fName.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(116, 90);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 3;
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(116, 64);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(100, 20);
            this.txt_lName.TabIndex = 4;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(387, 65);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(121, 20);
            this.txt_userName.TabIndex = 5;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(116, 116);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(387, 91);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 7;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(387, 11);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(121, 21);
            this.cb_dept.TabIndex = 8;
            // 
            // cb_super
            // 
            this.cb_super.FormattingEnabled = true;
            this.cb_super.Location = new System.Drawing.Point(387, 38);
            this.cb_super.Name = "cb_super";
            this.cb_super.Size = new System.Drawing.Size(121, 21);
            this.cb_super.TabIndex = 9;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(26, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "ID :";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(26, 45);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(63, 13);
            this.lbl_fname.TabIndex = 11;
            this.lbl_fname.Text = "First Name :";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(313, 98);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(59, 13);
            this.lbl_pass.TabIndex = 12;
            this.lbl_pass.Text = "Password :";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(313, 71);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(66, 13);
            this.lbl_userName.TabIndex = 13;
            this.lbl_userName.Text = "User Name :";
            // 
            // lbl_super
            // 
            this.lbl_super.AutoSize = true;
            this.lbl_super.Location = new System.Drawing.Point(313, 45);
            this.lbl_super.Name = "lbl_super";
            this.lbl_super.Size = new System.Drawing.Size(41, 13);
            this.lbl_super.TabIndex = 14;
            this.lbl_super.Text = "Super :";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Location = new System.Drawing.Point(313, 19);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(68, 13);
            this.lbl_dept.TabIndex = 15;
            this.lbl_dept.Text = "Department :";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(26, 123);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(32, 13);
            this.lbl_Age.TabIndex = 16;
            this.lbl_Age.Text = "Age :";
            // 
            // lbl_addr
            // 
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(26, 98);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(51, 13);
            this.lbl_addr.TabIndex = 17;
            this.lbl_addr.Text = "Address :";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(26, 71);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(64, 13);
            this.lbl_lname.TabIndex = 18;
            this.lbl_lname.Text = "Last Name :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(433, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(316, 152);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_instructor
            // 
            this.btn_instructor.Location = new System.Drawing.Point(486, 405);
            this.btn_instructor.Name = "btn_instructor";
            this.btn_instructor.Size = new System.Drawing.Size(86, 33);
            this.btn_instructor.TabIndex = 21;
            this.btn_instructor.Text = "Instructors";
            this.btn_instructor.UseVisualStyleBackColor = true;
            this.btn_instructor.Click += new System.EventHandler(this.btn_instructor_Click);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(594, 405);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(88, 33);
            this.btn_course.TabIndex = 22;
            this.btn_course.Text = "Courses";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_topic
            // 
            this.btn_topic.Location = new System.Drawing.Point(703, 405);
            this.btn_topic.Name = "btn_topic";
            this.btn_topic.Size = new System.Drawing.Size(85, 33);
            this.btn_topic.TabIndex = 23;
            this.btn_topic.Text = "Topics";
            this.btn_topic.UseVisualStyleBackColor = true;
            this.btn_topic.Click += new System.EventHandler(this.btn_topic_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(377, 405);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 33);
            this.btn_login.TabIndex = 24;
            this.btn_login.Text = "LogIn";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Admin_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_topic);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_instructor);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_addr);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lbl_super);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cb_super);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_lName);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_fName);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV_students_admin);
            this.Name = "Admin_Student";
            this.Text = "Admin_Student";
            this.Load += new System.EventHandler(this.Admin_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_students_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_students_admin;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.ComboBox cb_super;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_super;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_instructor;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_topic;
        private System.Windows.Forms.Button btn_login;
    }
}