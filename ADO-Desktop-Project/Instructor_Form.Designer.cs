namespace ADO_Desktop_Project
{
    partial class Instructor_Form
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
            this.DGV_InstructorCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_StudentPerCourses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_updateStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InstructorCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StudentPerCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_InstructorCourses
            // 
            this.DGV_InstructorCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InstructorCourses.Location = new System.Drawing.Point(12, 49);
            this.DGV_InstructorCourses.Name = "DGV_InstructorCourses";
            this.DGV_InstructorCourses.Size = new System.Drawing.Size(166, 150);
            this.DGV_InstructorCourses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Courses :";
            // 
            // DGV_StudentPerCourses
            // 
            this.DGV_StudentPerCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_StudentPerCourses.Location = new System.Drawing.Point(12, 276);
            this.DGV_StudentPerCourses.Name = "DGV_StudentPerCourses";
            this.DGV_StudentPerCourses.Size = new System.Drawing.Size(255, 162);
            this.DGV_StudentPerCourses.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Per Your Courses :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edit Your Profile :";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(601, 49);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(120, 20);
            this.txt_userName.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(601, 95);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(120, 20);
            this.txt_Password.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password :";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(601, 145);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(670, 388);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(109, 50);
            this.btn_logOut.TabIndex = 10;
            this.btn_logOut.Text = "LogOut";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_updateStatus
            // 
            this.lbl_updateStatus.AutoSize = true;
            this.lbl_updateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_updateStatus.Location = new System.Drawing.Point(472, 145);
            this.lbl_updateStatus.Name = "lbl_updateStatus";
            this.lbl_updateStatus.Size = new System.Drawing.Size(0, 16);
            this.lbl_updateStatus.TabIndex = 11;
            // 
            // Instructor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_updateStatus);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_StudentPerCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_InstructorCourses);
            this.Name = "Instructor_Form";
            this.Text = "Instructor_Form";
            this.Load += new System.EventHandler(this.Instructor_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InstructorCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StudentPerCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_InstructorCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_StudentPerCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label lbl_updateStatus;
    }
}