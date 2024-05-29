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
    public partial class GradesForm : Form
    {
        private int userID;
        private int studentID;
        private StudentForm _studentForm;

     
   
            public GradesForm(StudentForm studentForm, int studentID, int userID)
            {
                InitializeComponent();
                _studentForm = studentForm;
                this.studentID = studentID;
            this.userID = userID;
            }


     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(this.userID);
            studentForm.Show();
            this.Hide();
        }

        private void LoadGrades(string courseName=null)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";
            string query = "SELECT COURSES.Name, g.Grade, g.Date " +
                           "FROM GRADES g " +
                           "JOIN COURSES ON g.CourseID = COURSES.CourseID " +
                           "WHERE g.StudentID = @StudentID";

            if (!string.IsNullOrEmpty(courseName))
            {
                query += " AND COURSES.Name LIKE @CourseName";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    if (!string.IsNullOrEmpty(courseName))
                    {
                        command.Parameters.AddWithValue("@CourseName", "%" + courseName + "%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable gradesTable = new DataTable();
                        gradesTable.Load(reader);

                        dataGridView1.DataSource = gradesTable;
                    }
                }
            }
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(this.userID);
            studentForm.Show();
            this.Hide();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string courseName = txtSearch.Text.Trim();
            LoadGrades(courseName);
        }
    }
}
