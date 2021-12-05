using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem
{
    class checkDB
    {
        static string cs = @"Data Source=DESKTOP-3K8PAME\SQLEXPRESS;Initial Catalog=EnrollmentSystemDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(cs);
        public Boolean checkAccount(string username, string password)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tbl_user WHERE usernames = '" + username + "' and passwords = '" + password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable DisplayCourse()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_course", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public void AddCourse(string coursecode, string coursename)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_course ([Course Code], [Course Name]) VALUES (@ccode,@cname)", con);
            cmd.Parameters.AddWithValue("@ccode", coursecode);
            cmd.Parameters.AddWithValue("@cname", coursename);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfCourseExist(string code)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_course WHERE ([Course Code] = @user)", con);
            cmd.Parameters.AddWithValue("@user", code);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public void EditCourse(string coursecode, string coursename, string temp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_course SET [Course Code] = @ccode, [Course Name] = @cname WHERE [Course Code] = @tcode", con);
            cmd.Parameters.AddWithValue("@ccode", coursecode);
            cmd.Parameters.AddWithValue("@cname", coursename);
            cmd.Parameters.AddWithValue("@tcode", temp);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteCourse(string coursec)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE tbl_course WHERE [Course Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", coursec);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchCourse(string sc)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_course WHERE [Course Code] LIKE '%" + sc + "%' OR [Course Name] LIKE '%" + sc + "%'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public DataTable FillCourseStudentAdd()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT [Course code] FROM tbl_course", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public Boolean IfCurrCodeExist(string code)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_curriculums WHERE ([Curriculum Code] = @code)", con);
            cmd.Parameters.AddWithValue("@code", code);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public void CreateCurr(string currc, string ccode, string yl, string sem)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_curriculums ([Curriculum Code], [Course Code], [Year Level], [Semester]) VALUES (@cur,@course,@yl,@sem)", con);
            cmd.Parameters.AddWithValue("@cur", currc);
            cmd.Parameters.AddWithValue("@course", ccode);
            cmd.Parameters.AddWithValue("@yl", yl);
            cmd.Parameters.AddWithValue("@sem", sem);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
