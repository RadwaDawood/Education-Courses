namespace ADO_Desktop_Project
{
    partial class Login
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
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_instructors = new System.Windows.Forms.Button();
            this.btn_topics = new System.Windows.Forms.Button();
            this.lbl_afterlogin = new System.Windows.Forms.Label();
            this.lbl_Invalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(348, 48);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(132, 20);
            this.txt_userName.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(348, 91);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(132, 20);
            this.txt_password.TabIndex = 1;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(257, 54);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(66, 13);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "User Name :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(257, 98);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password :";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(348, 142);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LogIn";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_students
            // 
            this.btn_students.Location = new System.Drawing.Point(89, 293);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(90, 35);
            this.btn_students.TabIndex = 5;
            this.btn_students.Text = "Students";
            this.btn_students.UseVisualStyleBackColor = true;
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(405, 293);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(94, 35);
            this.btn_course.TabIndex = 6;
            this.btn_course.Text = "Courses";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_instructors
            // 
            this.btn_instructors.Location = new System.Drawing.Point(241, 293);
            this.btn_instructors.Name = "btn_instructors";
            this.btn_instructors.Size = new System.Drawing.Size(96, 35);
            this.btn_instructors.TabIndex = 7;
            this.btn_instructors.Text = "Instructors";
            this.btn_instructors.UseVisualStyleBackColor = true;
            this.btn_instructors.Click += new System.EventHandler(this.btn_instructors_Click);
            // 
            // btn_topics
            // 
            this.btn_topics.Location = new System.Drawing.Point(555, 293);
            this.btn_topics.Name = "btn_topics";
            this.btn_topics.Size = new System.Drawing.Size(92, 35);
            this.btn_topics.TabIndex = 8;
            this.btn_topics.Text = "Topics";
            this.btn_topics.UseVisualStyleBackColor = true;
            this.btn_topics.Click += new System.EventHandler(this.btn_topics_Click);
            // 
            // lbl_afterlogin
            // 
            this.lbl_afterlogin.AutoSize = true;
            this.lbl_afterlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afterlogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_afterlogin.Location = new System.Drawing.Point(237, 217);
            this.lbl_afterlogin.Name = "lbl_afterlogin";
            this.lbl_afterlogin.Size = new System.Drawing.Size(0, 20);
            this.lbl_afterlogin.TabIndex = 9;
            // 
            // lbl_Invalid
            // 
            this.lbl_Invalid.AutoSize = true;
            this.lbl_Invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invalid.ForeColor = System.Drawing.Color.Red;
            this.lbl_Invalid.Location = new System.Drawing.Point(271, 9);
            this.lbl_Invalid.Name = "lbl_Invalid";
            this.lbl_Invalid.Size = new System.Drawing.Size(0, 16);
            this.lbl_Invalid.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Invalid);
            this.Controls.Add(this.lbl_afterlogin);
            this.Controls.Add(this.btn_topics);
            this.Controls.Add(this.btn_instructors);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_students);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_instructors;
        private System.Windows.Forms.Button btn_topics;
        private System.Windows.Forms.Label lbl_afterlogin;
        private System.Windows.Forms.Label lbl_Invalid;
    }
}

