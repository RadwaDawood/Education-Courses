namespace ADO_Desktop_Project
{
    partial class Admin_Courses
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
            this.DGV_Admin_Courses = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.cb_topId = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_topic = new System.Windows.Forms.Button();
            this.btn_instructor = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Admin_Courses
            // 
            this.DGV_Admin_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Admin_Courses.Location = new System.Drawing.Point(12, 224);
            this.DGV_Admin_Courses.Name = "DGV_Admin_Courses";
            this.DGV_Admin_Courses.Size = new System.Drawing.Size(519, 170);
            this.DGV_Admin_Courses.TabIndex = 0;
            this.DGV_Admin_Courses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Admin_Courses_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(135, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(135, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(135, 85);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(121, 20);
            this.txt_duration.TabIndex = 3;
            // 
            // cb_topId
            // 
            this.cb_topId.FormattingEnabled = true;
            this.cb_topId.Location = new System.Drawing.Point(135, 125);
            this.cb_topId.Name = "cb_topId";
            this.cb_topId.Size = new System.Drawing.Size(121, 21);
            this.cb_topId.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(29, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(60, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Course ID :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(29, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(77, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Course Name :";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(29, 92);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(89, 13);
            this.lbl_duration.TabIndex = 7;
            this.lbl_duration.Text = "Course Duration :";
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.Location = new System.Drawing.Point(29, 133);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(45, 13);
            this.lbl_topic.TabIndex = 8;
            this.lbl_topic.Text = "Topics :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(181, 177);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(100, 177);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(19, 177);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_topic
            // 
            this.btn_topic.Location = new System.Drawing.Point(590, 403);
            this.btn_topic.Name = "btn_topic";
            this.btn_topic.Size = new System.Drawing.Size(87, 35);
            this.btn_topic.TabIndex = 12;
            this.btn_topic.Text = "Topics";
            this.btn_topic.UseVisualStyleBackColor = true;
            this.btn_topic.Click += new System.EventHandler(this.btn_topic_Click);
            // 
            // btn_instructor
            // 
            this.btn_instructor.Location = new System.Drawing.Point(441, 403);
            this.btn_instructor.Name = "btn_instructor";
            this.btn_instructor.Size = new System.Drawing.Size(90, 35);
            this.btn_instructor.TabIndex = 13;
            this.btn_instructor.Text = "Instructors";
            this.btn_instructor.UseVisualStyleBackColor = true;
            this.btn_instructor.Click += new System.EventHandler(this.btn_instructor_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(262, 403);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(90, 35);
            this.btn_student.TabIndex = 14;
            this.btn_student.Text = "Students";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(83, 403);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 35);
            this.btn_login.TabIndex = 15;
            this.btn_login.Text = "LogIn";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Admin_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_instructor);
            this.Controls.Add(this.btn_topic);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cb_topId);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV_Admin_Courses);
            this.Name = "Admin_Courses";
            this.Text = "Admin_Courses";
            this.Load += new System.EventHandler(this.Admin_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Admin_Courses;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.ComboBox cb_topId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_topic;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_topic;
        private System.Windows.Forms.Button btn_instructor;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_login;
    }
}