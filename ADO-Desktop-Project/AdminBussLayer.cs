using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_Desktop_Project
{
    internal class AdminBussLayer
    {
         //Select Admin Table
         public static DataTable GetAdminTable(string userName,string password)
        {
            return DBLayer.Select(new SqlCommand($"select * from AdminTable where userName='{userName}' and password='{password}'"));
        }


        #region Student Table
        //select student table
        public static DataTable GetStudentTable()
        {
            return DBLayer.Select(new SqlCommand("select * from student"));
        }
        public static DataTable GetDeptForStudent()
        {
            SqlCommand selcmd = new SqlCommand("select * from department");
            return DBLayer.Select(selcmd);
        }
        public static DataTable GetSuperForStudent()
        {
            SqlCommand super_cmd = new SqlCommand("select s.st_id student_Id ,s.st_fname+' '+s.st_lname [Full Name] ,su.St_super supervisor_Id from student s inner join student su on su.st_id = s.St_Id");
            return DBLayer.Select(super_cmd);
        }

        //insert into table student
        public static int AddStudent(int id, string fname, string lname, string address, int? age, int? dept_id, int? super,string userName,string password)
        {
            return DBLayer.DML(new SqlCommand($"insert into student values ({id},'{fname}','{lname}','{address}',{age},{dept_id},{super} , '{userName}','{password}')"));
        }

        //delete from student
        public static int deleteFromStudent(int id)
        {
            return DBLayer.DML(new SqlCommand($"delete from student where st_id={id}"));
        }
        #endregion

        #region Instructor Table
        // select instructor table
        public static DataTable GetInstructorTable()
        {
            return DBLayer.Select(new SqlCommand("select * from instructor"));
        }
        public static DataTable GetDeptForInstructor()
        {
            return DBLayer.Select(new SqlCommand("select * from department"));
        }
        
        //Insert into instructor table
        public static int AddInstructor(int id,string name, string degree,int? salary,int? dept_id,string userName,string password)
        {
            return DBLayer.DML(new SqlCommand($"insert into instructor values({id},'{name}','{degree}',{salary},{dept_id},'{userName}','{password}')"));
        } 

        //delete from instructor
        public static int DeleteFromInstructor(int id)
        {
            int cmd =DBLayer.DML(new SqlCommand($"delete from ins_course where ins_id={id}"));
            return DBLayer.DML(new SqlCommand($"delete from instructor where ins_id={id}"));
        }
        #endregion

        #region Topic Table

        //select topic table
        public static DataTable GetTopicTable()
        {
            return DBLayer.Select(new SqlCommand("select * from topic"));
        }

        //add to topic
        public static int AddTopic(int id,string name)
        {
            return DBLayer.DML(new SqlCommand($"insert into topic values ({id},'{name}')"));
        }

        //update topic
        public static int UpdateTopic(int id,string name)
        {
            return DBLayer.DML(new SqlCommand($"update topic set top_name='{name}' where top_id={id}"));
        }

        //delete topic
        public static int DeleteFromTopic(int id)
        {
            int cmd = DBLayer.DML(new SqlCommand($"delete from course where top_id={id}"));
            return DBLayer.DML(new SqlCommand($"delete from topic where top_id={id}"));
        }
        #endregion

        #region Course Table
        //select course table
        public static DataTable GetCourseTable()
        {
            return DBLayer.Select(new SqlCommand("select * from course"));
        }

        //add to course
        public static int AddCourse(int id,string name,int? duration,int? top_id)
        {
            return DBLayer.DML(new SqlCommand($"insert into course values ({id},'{name}',{duration},{top_id})"));
        }

        //Update table
        public static int UpdateCourse(int id, string name, int? duration, int? top_id)
        {
            return DBLayer.DML(new SqlCommand($"update course set crs_name='{name}' , crs_duration={duration} , top_id={top_id} where crs_id={id}"));
        }

        //delete from course
        public static int DeleteFromCourse(int id)
        {
            return DBLayer.DML(new SqlCommand($"delete from course where crs_id={id}"));
        }
        #endregion

    }
}
