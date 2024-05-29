using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectMTP
{
    public partial class ProfessorForm : Form
    {
        private int professorID;
        private String ConnectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";

        public ProfessorForm(int professorID)
        {
            InitializeComponent();
            this.professorID = professorID;
            LoadGrades();
        }

        private void LoadGrades()
        {
            string query = "SELECT GRADES.GradeID, STUDENT.Name AS Name, COURSES.Name AS CourseName, GRADES.Grade, GRADES.Date " +
                           "FROM GRADES " +
                           "JOIN STUDENT ON GRADES.StudentID = STUDENT.StudentID " +
                           "JOIN COURSES ON GRADES.CourseID = COURSES.CourseID " +
                           "WHERE GRADES.ProfessorID = @ProfessorID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfessorID", professorID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable gradesTable = new DataTable();
                        gradesTable.Load(reader);

                        dataGridViewGrades.DataSource = gradesTable;
                    }
                }
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            
        }

        private int GetStudentIDByName(string studentName)
        {
            string query = "SELECT StudentID FROM STUDENT WHERE Name = @Name";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", studentName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Student not found
        }

        private int GetCourseIDByName(string courseName)
        {
            string query = "SELECT CourseID FROM COURSES WHERE Name = @Name";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", courseName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Course not found
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGrade_Click_1(object sender, EventArgs e)
        {
            int studentID = GetStudentIDByName(txtStudentName.Text);
            if (studentID == -1)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            int courseID = GetCourseIDByName(txtCourseName.Text);
            if (courseID == -1)
            {
                MessageBox.Show("Course not found.");
                return;
            }

            int grade = int.Parse(txtGrade.Text);
            DateTime date;

            if (!DateTime.TryParse(txtDate.Text, out date))
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            string query = "INSERT INTO GRADES (StudentID, CourseID, ProfessorID, Grade, Date) " +
                           "VALUES (@StudentID, @CourseID, @ProfessorID, @Grade, @Date)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@ProfessorID", professorID);
                    command.Parameters.AddWithValue("@Grade", grade);
                    command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-ddTHH:mm:ss"));

                    command.ExecuteNonQuery();
                }
            }

            LoadGrades();
        }

        private void btnChangeGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade to update.");
                return;
            }

            // Validate the grade input
            int grade;
            if (!int.TryParse(txtGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid integer grade.");
                return;
            }

            int gradeID = (int)dataGridViewGrades.SelectedRows[0].Cells["GradeID"].Value;
            DateTime date;

            if (!DateTime.TryParse(txtDate.Text, out date))
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            string query = "UPDATE GRADES SET Grade = @Grade, Date = @Date WHERE GradeID = @GradeID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GradeID", gradeID);
                    command.Parameters.AddWithValue("@Grade", grade);
                    command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-ddTHH:mm:ss"));

                    command.ExecuteNonQuery();
                }
            }

            LoadGrades();
        }

        private void btnDeleteGrade_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            int gradeID = (int)dataGridViewGrades.SelectedRows[0].Cells["GradeID"].Value;

            string query = "DELETE FROM GRADES WHERE GradeID = @GradeID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@GradeID", gradeID);

                    command.ExecuteNonQuery();
                }
            }

            LoadGrades();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
