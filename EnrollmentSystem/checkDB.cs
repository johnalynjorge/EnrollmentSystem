using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace EnrollmentSystem
{
    class checkDB
    {
        static string cs = @"Data Source=DESKTOP-3K8PAME\SQLEXPRESS;Initial Catalog=EnrollmentSystemDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(cs);
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        public Boolean checkAccount(string username, string password)
        {
            sda = new SqlDataAdapter("SELECT COUNT(*) FROM tbl_user WHERE usernames = '" + username + "' and passwords = '" + password + "'", con);
            dt = new DataTable();
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
            sda = new SqlDataAdapter("SELECT * FROM tbl_course", con);
            ds = new DataSet();
            sda.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public void AddCourse(string coursecode, string coursename, double years, double sems, double rus)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_course ([Course Code], [Course Name],[Years],[Semesters],[Required Units]) VALUES (@ccode,@cname,@years,@sems,@rus)", con);
            cmd.Parameters.AddWithValue("@ccode", coursecode);
            cmd.Parameters.AddWithValue("@cname", coursename);
            cmd.Parameters.AddWithValue("@years", years);
            cmd.Parameters.AddWithValue("@sems", sems);
            cmd.Parameters.AddWithValue("@rus", rus);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfCourseExist(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_course WHERE ([Course Code] = @user)", con);
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
        public void EditCourse(string coursecode, string coursename, double years, double sems, double rus, string temp)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_course SET [Course Code] = @ccode, [Course Name] = @cname, [Years] = @years, [Semesters] = @sems, [Required Units] = @rus WHERE [Course Code] = @tcode", con);
            cmd.Parameters.AddWithValue("@ccode", coursecode);
            cmd.Parameters.AddWithValue("@cname", coursename);
            cmd.Parameters.AddWithValue("@tcode", temp);
            cmd.Parameters.AddWithValue("@years", years);
            cmd.Parameters.AddWithValue("@sems", sems);
            cmd.Parameters.AddWithValue("@rus", rus);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteCourse(string coursec)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_course WHERE [Course Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", coursec);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchCourse(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_course WHERE [Course Code] LIKE '%" + sc + "%' OR [Course Name] LIKE '%" + sc + "%' OR [Years] LIKE '%" + sc + "%'" +
                " OR [Semesters] LIKE '%" + sc + "%' OR [Required Units] LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public DataTable FillCourse()
        {
            sda = new SqlDataAdapter("SELECT [Course code] FROM tbl_course", con);
            ds = new DataSet();
            sda.Fill(ds, "Courses");
            con.Close();
            return ds.Tables["Courses"];
        }
        public Boolean IfCurrCodeExist(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_curriculum WHERE ([Curriculum Code] = @code)", con);
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
        public void CreateCurr(string currc)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_curriculum ([Curriculum Code]) VALUES (@cur)", con);
            cmd.Parameters.AddWithValue("@cur", currc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DisplayCurr()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_curriculum", con);
            ds = new DataSet();
            sda.Fill(ds, "Curr");
            con.Close();
            return ds.Tables["Curr"];
        }
        public void DeleteCurr(string cc)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_curriculum WHERE [Curriculum Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", cc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchCurr(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_curriculum WHERE [Curriculum Code] LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Curr");
            con.Close();
            return ds.Tables["Curr"];
        }
        public void editcurr(string curr, double units)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_curriculum SET [Total Units] = @units WHERE [Curriculum Code] = @curr", con);
            cmd.Parameters.AddWithValue("@units", units);
            cmd.Parameters.AddWithValue("@curr", curr);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfInsCodeExist(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_faculty WHERE ([InstructorID] = @code)", con);
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
        public DataTable DisplayFaculty()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_faculty", con);
            ds = new DataSet();
            sda.Fill(ds, "Faculty");
            con.Close();
            return ds.Tables["Faculty"];
        }
        public void Addfaculty(string id, string first, string last, string num, string dep)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_faculty ([InstructorID], [First Name], [Last Name], [Contact Num], [Department]) " +
                "VALUES (@id,@first,@last,@num,@dep)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@first", first);
            cmd.Parameters.AddWithValue("@last", last);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@dep", dep);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchFaculty(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_faculty WHERE [InstructorID] LIKE '%" + sc + "%' OR [First Name] LIKE '%" + sc + "%' " +
                "OR [Last Name] LIKE '%" + sc + "%' OR [Contact Num] LIKE '%" + sc + "%' OR [Department] LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Faculty");
            con.Close();
            return ds.Tables["Faculty"];
        }
        public void DeleteFaculty(string cc)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_faculty WHERE [InstructorID] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", cc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Editfaculty(string id, string first, string last, string num, string dep)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_faculty SET [First Name] = @first, [Last Name] = @last, [Contact Num] = @num, [Department] = @dep " +
                "WHERE [InstructorID] = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@first", first);
            cmd.Parameters.AddWithValue("@last", last);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@dep", dep);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfSubCodeExist(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_subject WHERE ([Subject Code] = @code)", con);
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
        public void AddSubject(string sc, string sn, double u, string cat)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_subject ([Subject Code], [Subject Name], [Units], [Category]) " +
                "VALUES (@sc,@sn,@u,@cat)", con);
            cmd.Parameters.AddWithValue("@sc", sc);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DisplaySubjects()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_subject", con);
            ds = new DataSet();
            sda.Fill(ds, "Subject");
            con.Close();
            return ds.Tables["Subject"];
        }
        public void DeleteSubject(string cc)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_subject WHERE [Subject Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", cc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditSubject(string sc, string sn, double u)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_subject SET [Subject Name] = @sn, [Units] = @u " +
                "WHERE [Subject Code] = @sc", con);
            cmd.Parameters.AddWithValue("@sc", sc);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@u", u);
            //cmd.Parameters.AddWithValue("@cat", cat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchSubject(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_subject WHERE [Subject Code] LIKE '%" + sc + "%' OR [Subject Name] LIKE '%" + sc + "%' " +
                "OR [Units] LIKE '%" + sc + "%' OR [Category] LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Subject");
            con.Close();
            return ds.Tables["Subject"];
        }
        public DataTable DisplayCurrSub(string code)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_curriculum_subject WHERE  [Curriculum Code] = '" + code + "'", con);
            ds = new DataSet();
            sda.Fill(ds, "CurrSub");
            con.Close();
            return ds.Tables["CurrSub"];
        }
        public Array returnCurr(string code)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_curriculum WHERE [Curriculum Code] = '" + code + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            string[] array;
            array = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return array;

        }
        public void AddCurrSub(string cc, string course, string sub, string yl, string sem)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_curriculum_subject ([Curriculum Code], [Course Code], [Subject Code], [Year Level], [Semester] ) " +
                "VALUES (@cc,@course,@sub,@yl,@sem)", con);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@sub", sub);
            cmd.Parameters.AddWithValue("@yl", yl);
            cmd.Parameters.AddWithValue("@sem", sem);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveSubCurr(string cc, string sc, string course)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_curriculum_subject WHERE [Subject Code] = @scode AND [Curriculum Code] = @ccode AND [Course Code] = @course", con);
            cmd.Parameters.AddWithValue("@ccode", cc);
            cmd.Parameters.AddWithValue("@scode", sc);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditCurrUnits(string cc, double u)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_curriculum SET [Total Units] = @u " +
                "WHERE [Curriculum Code] = @cc", con);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@u", u);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfSubCurrExist(string ccode, string scode)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_curriculum_subject WHERE [Subject Code] = @scode AND [Curriculum Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@scode", scode);
            cmd.Parameters.AddWithValue("@ccode", ccode);
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
        public DataTable SearchCurrSub(string sc, string curr)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_curriculum_subject " +
                "WHERE  [Curriculum Code] = '" + curr + "' AND  ([Subject Code] LIKE '%" + sc + "%' OR [Curriculum Code] LIKE '%" + sc + "%' OR [Course Code] LIKE '%" + sc + "%' OR  [Year Level] LIKE '%" + sc + "%' OR [Semester] LIKE '%" + sc + "%')", con);
            ds = new DataSet();
            sda.Fill(ds, "CurrSub");
            con.Close();
            return ds.Tables["CurrSub"];
        }
        public DataTable DisplaySections()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_section", con);
            ds = new DataSet();
            sda.Fill(ds, "Section");
            con.Close();
            return ds.Tables["Section"];
        }
        public Boolean IfSectionExist(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_section WHERE ([Section Code] = @user)", con);
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
        public void AddSection(string sc, string cc,string course, string yl, string sem, int num)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_section ([Section Code], [Curriculum Code], [Course Code], [Year Level], [Semester], [Number of Students]) " +
                "VALUES (@sc,@cc, @course, @yl, @sem, @num)", con);
            cmd.Parameters.AddWithValue("@sc", sc);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@yl", yl);
            cmd.Parameters.AddWithValue("@sem", sem);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteSection(string cc)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_section WHERE [Section Code] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", cc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchSection(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_section WHERE [Section Code] LIKE '%" + sc + "%' OR [Curriculum Code] LIKE '%" + sc + "%' OR  [Course Code] LIKE '%" + sc + "%'" +
                "OR  [Year Level] LIKE '%" + sc + "%' OR  [Semester] LIKE '%" + sc + "%' OR [Number of Students] LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Section");
            con.Close();
            return ds.Tables["Section"];
        }
        public DataTable FillSection()
        {
            sda = new SqlDataAdapter("SELECT [Section Code] FROM tbl_section", con);
            ds = new DataSet();
            sda.Fill(ds, "Section");
            con.Close();
            return ds.Tables["Section"];
        }
        public DataTable FillCurriculum()
        {
            sda = new SqlDataAdapter("SELECT [Curriculum Code] FROM tbl_curriculum", con);
            ds = new DataSet();
            sda.Fill(ds, "Curr");
            con.Close();
            return ds.Tables["Curr"];
        }
        public DataTable FillSubject(string section)
        {
            sda = new SqlDataAdapter("SELECT CS.[Subject Code] FROM tbl_curriculum_subject CS  JOIN tbl_section S ON CS.[Course Code] = S.[Course Code] JOIN tbl_curriculum C ON CS.[Curriculum Code] = C.[Curriculum Code] WHERE CS.[Year level] = S.[Year Level] AND CS.Semester = S.[Semester] AND S.[Section Code] = '" +section  +"'", con);
            ds = new DataSet();
            sda.Fill(ds, "Subjects");
            con.Close();
            return ds.Tables["Subjects"];
        }
        public string returnSubjectName(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT [Subject Name] FROM tbl_subject WHERE [Subject Code] = '" + code + "'", con);
            string name = (string)cmd.ExecuteScalar();
            con.Close();
            return name;
        }
        public DataTable FillInstructor()
        {
            sda = new SqlDataAdapter("SELECT [InstructorID] FROM tbl_faculty", con);
            ds = new DataSet();
            sda.Fill(ds, "Faculty");
            con.Close();
            return ds.Tables["Faculty"];
        }
        public Array returnInstructor(string code)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_faculty WHERE [InstructorID] = '" + code + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            string[] array;
            array = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return array;

        }
        public DataTable DisplaySched(string section)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_schedule WHERE [Section Code] = '" + section + "'", con);
            ds = new DataSet();
            sda.Fill(ds, "schedule");
            con.Close();
            return ds.Tables["schedule"];
        }
        public void AddSchedule(string section, string subject, string ins, string day, string start, string end, string room, string type)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_schedule ([Section Code], [Subject Code], [InstructorID], [Day], [Start Time], [End Time], [Room], [Type]) " +
                "VALUES (@section,@subject,@ins,@day,@start,@end,@room,@type)", con);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@ins", ins);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@room", room);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable FillSchoolYear()
        {
            sda = new SqlDataAdapter("SELECT [Curriculum Code] FROM tbl_curriculum", con);
            ds = new DataSet();
            sda.Fill(ds, "Curr");
            con.Close();
            return ds.Tables["Curr"];
        }
        public string returnCurrSum(string code, string course)
        {
            con.Open();
            cmd = new SqlCommand("SELECT ISNULL(SUM(S.[Units]),0) FROM[tbl_curriculum_subject] CS JOIN tbl_subject S ON CS.[Subject Code] = S.[Subject Code] WHERE CS.[Curriculum Code] = '" + code + "' AND CS.[Course Code] = '" + course + "'", con);
            string sum = cmd.ExecuteScalar().ToString();
            con.Close();
            return sum;
        }
        public string returnCourseUnits(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT [Required Units] FROM tbl_course WHERE [Course Code] = '" + code + "'", con);
            string units = cmd.ExecuteScalar().ToString();
            con.Close();
            return units;
        }
        public Boolean IfScheduleExist(string sec, string sub, string type)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_schedule WHERE ([Section Code] = @section AND [Subject Code] = @subject AND [Type] = @type)", con);
            cmd.Parameters.AddWithValue("@section", sec);
            cmd.Parameters.AddWithValue("@subject", sub);
            cmd.Parameters.AddWithValue("@type", type);
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
        public void DeleteSched(string sec, string sub, string type)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_schedule WHERE [Section Code] = @sec AND [Subject Code] = @sub AND [Type] = @type", con);
            cmd.Parameters.AddWithValue("@sec", sec);
            cmd.Parameters.AddWithValue("@sub", sub);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditSchedule(string section, string subject, string ins, string day, string start, string end, string room, string type)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_schedule SET [InstructorID] = @ins, [Day] = @day, [Start Time] = @start, [End Time] = @end, [Room] = @room" +
                " WHERE [Section Code] = @section AND [Subject Code] = @subject AND [Type] = @type", con);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@ins", ins);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@room", room);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DisplayStudents()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_student", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public DataTable DisplayStudentA()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_archive", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public Boolean IfStudentMain(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_student WHERE ([StudentID] = @user)", con);
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
        public Boolean IfStudentArchive(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_archive WHERE ([StudentID] = @user)", con);
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
        public void AddStudentMain(string id, string last, string first, string middle, string schoolyear, string level, string sem, string status, string course, int age, string gender,
            string number, string email, string birth,string address)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_student ([StudentID], [Last Name], [First Name], [Middle Name], [School Year], [Year Level], [Semester], [Status],[Course Code],[Age],[Gender],[Mobile Number],[Email],[Birthdate],[Address]) " +
                "VALUES (@id,@last,@first,@middle,@school,@year,@sem,@status,@course,@age,@gender,@num,@email,@birth,@address)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@last", last);
            cmd.Parameters.AddWithValue("@first", first);
            cmd.Parameters.AddWithValue("@middle", middle);
            cmd.Parameters.AddWithValue("@school", schoolyear);
            cmd.Parameters.AddWithValue("@year", level);
            cmd.Parameters.AddWithValue("@sem", sem);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@num", number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteStudentMain(string coursec)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_student WHERE [StudentID] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", coursec);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddStudentArchive(string id)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_archive ([StudentID], [Last Name], [First Name], [Middle Name], [School Year], [Year Level], [Semester], [Status],[Course Code],[Age],[Gender],[Mobile Number],[Email],[Birthdate],[Address]) " +
                "SELECT [StudentID], [Last Name], [First Name], [Middle Name], [School Year], [Year Level], [Semester], [Status],[Course Code],[Age],[Gender],[Mobile Number],[Email],[Birthdate],[Address] FROM tbl_student WHERE [StudentID] = @id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RestoreStudent(string id)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_student ([StudentID], [Last Name], [First Name], [Middle Name], [School Year], [Year Level], [Semester], [Status],[Course Code],[Age],[Gender],[Mobile Number],[Email],[Birthdate],[Address]) " +
                "SELECT [StudentID], [Last Name], [First Name], [Middle Name], [School Year], [Year Level], [Semester], [Status],[Course Code],[Age],[Gender],[Mobile Number],[Email],[Birthdate],[Address] FROM tbl_archive WHERE [StudentID] = @id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteStudentArchive(string coursec)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_archive WHERE [StudentID] = @ccode", con);
            cmd.Parameters.AddWithValue("@ccode", coursec);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public DataTable SearchStudent(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_student WHERE CONCAT([StudentID]+[Last Name]+[First Name]+[Middle Name]+[School Year]+[Year Level]+[Semester]+[Status]+[Course Code],[Age], [Gender]+[Mobile Number]+[Email]+[Birthdate]+[Address]) LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public DataTable SearchStudentArchive(string sc)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_archive WHERE CONCAT([StudentID]+[Last Name]+[First Name]+[Middle Name]+[School Year]+[Year Level]+[Semester]+[Status]+[Course Code],[Age], [Gender]+[Mobile Number]+[Email]+[Birthdate]+[Address]) LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public Array returnSection(string code)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_section WHERE [Section Code] = '" + code + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            string[] array;
            array = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return array;

        }
        public DataTable DisplayStudentS(string schoolyear, string course, string yearlevel, string sem)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT [StudentID],[Last Name],[First Name] FROM tbl_student WHERE [School year] = '" + schoolyear + "' AND [Course Code] = '" + course + "' " +
                "AND [Year Level] = '" + yearlevel + "' AND [Semester] = '" + sem + "' AND [Status] = 'Regular' ", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public DataTable SearchStudentSec (string sc, string schoolyear, string course, string yearlevel, string sem)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT [StudentID],[Last Name],[First Name] FROM tbl_student WHERE CONCAT([StudentID],[Last Name],[First Name],[Middle Name]) LIKE '%" + sc + "%' AND [School year] = '" + schoolyear + "' AND [Course Code] = '" + course + "' " +
                "AND [Year Level] = '" + yearlevel + "' AND [Semester] = '" + sem + "'", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public DataTable DisplayAddedStudents(string section)
        {
            sda = new SqlDataAdapter("SELECT S.[StudentID],S.[Last Name],S.[First Name] FROM tbl_section_student SS JOIN tbl_student S ON SS.[StudentID] = S.[StudentID] WHERE SS.[Section Code] = '" + section + "'", con);
            ds = new DataSet();
            sda.Fill(ds, "Added");
            con.Close();
            return ds.Tables["Added"];
        }
        public void AddStudentSection(string section, string id)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_section_student ([Section Code], [StudentID]) " +
                "VALUES (@section,@id)", con);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfStudentAlreadyInSection(string id)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_section_student WHERE ([StudentID] = @id)", con);
            cmd.Parameters.AddWithValue("@id", id);
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
        public void EditNumStudents(string section, int num)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_section SET [Number of Students] = @num WHERE [Section Code] = @section", con);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveFromSection(string section, string id)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_section_student WHERE [Section Code] = @section AND [StudentID] = @id", con);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SearchAddedStudents(string section, string sc)
        {
            sda = new SqlDataAdapter("SELECT S.[StudentID],S.[Last Name],S.[First Name] FROM tbl_section_student SS JOIN tbl_student S ON SS.[StudentID] = S.[StudentID] WHERE SS.[Section Code] = '" + section + "' AND " +
                " CONCAT(S.[StudentID],S.[Last Name],S.[First Name] ) LIKE '%" + sc + "%'", con);
            ds = new DataSet();
            sda.Fill(ds, "Subjects");
            con.Close();
            return ds.Tables["Subjects"];
        }
        public DataTable FillIrregular()
        {
            sda = new SqlDataAdapter("SELECT [StudentID] FROM tbl_student WHERE [Status] = 'Irregular'", con);
            ds = new DataSet();
            sda.Fill(ds, "Student");
            con.Close();
            return ds.Tables["Student"];
        }
        public Array returnStudentName(string code)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT [First Name], [Last Name] FROM tbl_student WHERE [StudentID] = '" + code + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            string[] array;
            array = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return array;

        }
        public DataTable FillAllSubjects()
        {
            sda = new SqlDataAdapter("SELECT [Subject Code] FROM tbl_subject", con);
            ds = new DataSet();
            sda.Fill(ds, "Subject");
            con.Close();
            return ds.Tables["Subject"];
        }
        public DataTable DisplaySched()
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_schedule" , con);
            ds = new DataSet();
            sda.Fill(ds, "schedule");
            con.Close();
            return ds.Tables["schedule"];
        }
        public void AddIrregSched(string student, string section, string subject, string type)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_irregularsched ([StudentID], [Section Code], [Subject Code], [Type]) " +
                "VALUES (@id,@sec, @sub, @type)", con);
            cmd.Parameters.AddWithValue("@id", student);
            cmd.Parameters.AddWithValue("@sec", section);
            cmd.Parameters.AddWithValue("@sub", subject);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DisplayIrregSched(string ID)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_irregularsched WHERE [StudentID] = '" + ID + "'", con);
            ds = new DataSet();
            sda.Fill(ds, "schedule");
            con.Close();
            return ds.Tables["schedule"];
        }
        public Array returnSchedule(string sectiom, string subject, string type)
        {
            con.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_schedule WHERE [Section Code] = '" + sectiom + "' AND [Subject Code] = '" + subject + "' AND " +
                " [Type] = '" + type + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            string[] array;
            array = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return array;

        }
        public void DeleteIrregSched(string student, string sub, string type)
        {
            con.Open();
            cmd = new SqlCommand("DELETE tbl_irregularsched WHERE [StudentID] = @st AND [Subject Code] = @sub AND [Type] = @type", con);
            cmd.Parameters.AddWithValue("@st", student);
            cmd.Parameters.AddWithValue("@sub", sub);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Boolean IfIrregSchedExist(string student, string sub, string type)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_irregularsched WHERE ([StudentID] = @student AND [Subject Code] = @subject AND [Type] = @type)", con);
            cmd.Parameters.AddWithValue("@student", student);
            cmd.Parameters.AddWithValue("@subject", sub);
            cmd.Parameters.AddWithValue("@type", type);
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
    }
}
