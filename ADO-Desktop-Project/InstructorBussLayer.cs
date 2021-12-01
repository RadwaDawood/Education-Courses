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
    internal class InstructorBussLayer
    {
        //Select Instructor Login Table
        public static DataTable GetInstructorLoginTable(string userName, string password)
        {
            return DBLayer.Select(new SqlCommand($"select * from instructor where userName='{userName}' and password='{password}'"));
        }

        #region instructor form
        //select instructor courses
        public static DataTable GetInstructorCourse(int id)
        {
            return DBLayer.Select(new SqlCommand($"select c.Crs_Name as [Your Courses] from Instructor i inner join Ins_Course ic on i.Ins_Id=ic.Ins_Id  inner join Course c on c.Crs_Id=ic.Crs_Id where i.Ins_Id={id}"));
        }

        //select student per instructor courses
        public static DataTable GetStudentPerCourse(int id)
        {
            return DBLayer.Select(new SqlCommand($"select c.Crs_Name as [Your Courses] , s.St_Fname +' '+s.St_Lname as [Student Name] from Instructor i inner join Ins_Course ic on i.Ins_Id=ic.Ins_Id   inner join Course c  on c.Crs_Id=ic.Crs_Id  inner join Stud_Course sc on sc.Crs_Id=c.Crs_Id inner join Student s on s.St_Id=sc.St_Id where i.Ins_Id={id}"));
        }

        //Edit Instructor Profile
        public static int UpdateInstructorProfile(int id , string userName,string password)
        {
            return DBLayer.DML(new SqlCommand($" update instructor set userName='{userName}', password='{password}' where ins_id={id}"));
        }
        #endregion
    }
}
