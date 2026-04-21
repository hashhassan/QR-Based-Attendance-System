using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Project
{
    internal class DatabaseHelper
    {
        static string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AP_Project;Data Source=DESKTOP-F8N84OK\\HASSANSQL\r\n";

        public static bool ValidateLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT COUNT(*) FROM Teachers WHERE tname = @Username AND password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; 
                }
            }
        }
        public static bool AddStudent(string studentName, string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "INSERT INTO Student (aridno, stdname,qrdata) VALUES (@AridNo,@StudentName,@QRdata)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("QRdata",aridNo);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }

        public static bool DeleteStudent(string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "DELETE FROM Student WHERE aridno = @AridNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }
        public static DataTable GetAllStudents()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Student";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable GetAllSubjects()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Subjects";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool UpdateStudent(string studentName, string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "UPDATE Student SET stdname = @StudentName WHERE aridno = @AridNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    conn.Open();
                    int rowsaffected=cmd.ExecuteNonQuery();
                    return rowsaffected > 0;
                }
            }
        }

        public static bool IsAridNoExists(string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT COUNT(*) FROM Student WHERE aridno = @AridNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; 
                }
            }
        }

        public static bool IsqrDataExists(string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT COUNT(*) FROM Student WHERE qrdata = @AridNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static DataRow GetTeacherDetails(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Teachers WHERE tname = @Username AND password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static DataRow GetStudentByAridNo(string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Student WHERE aridno = @AridNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static DataRow filterStudents(string aridno)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM Student WHERE aridno=@aridno";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@aridno", aridno);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static bool IsAttendanceMarkedToday(string aridNo, string subjectID, string teacherID)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                string query = @"SELECT COUNT(*) FROM Attendance 
                        WHERE aridno = @AridNo 
                        AND subjectID = @SubjectID 
                        AND teacherID = @TeacherID 
                        AND attendancedate = @Date";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    cmd.Parameters.AddWithValue("@Date", today);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static bool MarkAttendance(string aridNo, string subjectID, string teacherID)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                Random rnd = new Random();
                int salt= rnd.Next(100000, 1000000);
                string attendanceID = "ATD" + DateTime.Now.ToString("yyyyMMdd")+salt;
                string today = DateTime.Now.ToString("yyyy-MM-dd");

                string query = @"INSERT INTO Attendance (attendanceID, aridno, subjectID, teacherID, status, attendancedate)
                        VALUES (@AttendanceID, @AridNo, @SubjectID, @TeacherID, @Status, @Date)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    cmd.Parameters.AddWithValue("@Status", "PRESENT");
                    cmd.Parameters.AddWithValue("@Date", today);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public static bool MarkAbsent(string aridNo, string subjectID, string teacherID)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                Random rnd = new Random();
                int salt = rnd.Next(100000, 1000000);
                string attendanceID = "ATD" + DateTime.Now.ToString("yyyyMMdd") + salt;
                string today = DateTime.Now.ToString("yyyy-MM-dd");

                string query = @"INSERT INTO Attendance (attendanceID, aridno, subjectID, teacherID, status, attendancedate)
                        VALUES (@AttendanceID, @AridNo, @SubjectID, @TeacherID, @Status, @Date)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    cmd.Parameters.AddWithValue("@Status", "ABSENT");
                    cmd.Parameters.AddWithValue("@Date", today);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public static DataTable GetStudentAttendanceBySubject(string aridNo, string subjectID)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = @"SELECT 
                            a.aridno AS 'ARID No',
                            s.stdname AS 'Name',
                            t.tname AS 'Teacher',
                            a.status AS 'Status',
                            a.attendancedate AS 'Date'
                        FROM Attendance a
                        INNER JOIN Student s ON a.aridno = s.aridno
                        INNER JOIN Teachers t ON a.teacherID = t.teacherID
                        WHERE a.aridno = @AridNo AND a.subjectID = @SubjectID
                        ORDER BY a.attendancedate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable GetOverallAttendanceReport(string aridNo)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = @"
            SELECT DISTINCT
                sub.subjectID,
                sub.subjectname AS 'Subject',
                t.tname AS 'Teacher'
            FROM Attendance a
            INNER JOIN Subjects sub ON a.subjectID = sub.subjectID
            INNER JOIN Teachers t ON a.teacherID = t.teacherID
            WHERE a.aridno = @AridNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AridNo", aridNo);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);

                    resultTable.Columns.Add("Total Classes", typeof(int));
                    resultTable.Columns.Add("Presents", typeof(int));
                    resultTable.Columns.Add("Absents", typeof(int));
                    resultTable.Columns.Add("Percentage", typeof(decimal));

                    foreach (DataRow row in resultTable.Rows)
                    {
                        string subjectID = row["subjectID"].ToString();

                        string countQuery = "SELECT COUNT(*) FROM Attendance WHERE aridno = @AridNo AND subjectID = @SubjectID";
                        SqlCommand countCmd = new SqlCommand(countQuery, conn);
                        countCmd.Parameters.AddWithValue("@AridNo", aridNo);
                        countCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                        conn.Open();
                        int total = (int)countCmd.ExecuteScalar();
                        conn.Close();

                        string presentQuery = "SELECT COUNT(*) FROM Attendance WHERE aridno = @AridNo AND subjectID = @SubjectID AND status = 'Present'";
                        SqlCommand presentCmd = new SqlCommand(presentQuery, conn);
                        presentCmd.Parameters.AddWithValue("@AridNo", aridNo);
                        presentCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                        conn.Open();
                        int present = (int)presentCmd.ExecuteScalar();
                        conn.Close();

                        int absent = total - present;
                        decimal percentage = (present / (decimal)total) * 100;

                        row["Total Classes"] = total;
                        row["Presents"] = present;
                        row["Absents"] = absent;
                        row["Percentage"] = Math.Round(percentage, 2);
                    }

                    resultTable.Columns.Remove("subjectID");

                    return resultTable;
                }
            }
        }
    }
}

