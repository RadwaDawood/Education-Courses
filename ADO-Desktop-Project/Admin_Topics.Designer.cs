namespace ADO_Desktop_Project
{
    partial class Admin_Topics
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
            this.DGV_Admin_Topics = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_instructor = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Topics)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Admin_Topics
            // 
            this.DGV_Admin_Topics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Admin_Topics.Location = new System.Drawing.Point(38, 184);
            this.DGV_Admin_Topics.Name = "DGV_Admin_Topics";
            this.DGV_Admin_Topics.Size = new System.Drawing.Size(374, 188);
            this.DGV_Admin_Topics.TabIndex = 0;
            this.DGV_Admin_Topics.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Admin_Topics_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(124, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(124, 66);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(45, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 13);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Topic ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(45, 73);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Topic Name";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(328, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(188, 131);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(48, 131);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(608, 399);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(95, 39);
            this.btn_course.TabIndex = 8;
            this.btn_course.Text = "Courses";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_instructor
            // 
            this.btn_instructor.Location = new System.Drawing.Point(422, 399);
            this.btn_instructor.Name = "btn_instructor";
            this.btn_instructor.Size = new System.Drawing.Size(95, 39);
            this.btn_instructor.TabIndex = 9;
            this.btn_instructor.Text = "Instructors";
            this.btn_instructor.UseVisualStyleBackColor = true;
            this.btn_instructor.Click += new System.EventHandler(this.btn_instructor_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(88, 399);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 39);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "LogIn";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(258, 399);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(95, 39);
            this.btn_student.TabIndex = 11;
            this.btn_student.Text = "Students";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // Admin_Topics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_instructor);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV_Admin_Topics);
            this.Name = "Admin_Topics";
            this.Text = "Admin_Topics";
            this.Load += new System.EventHandler(this.Admin_Topics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin_Topics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Admin_Topics;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_instructor;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_student;
    }
}