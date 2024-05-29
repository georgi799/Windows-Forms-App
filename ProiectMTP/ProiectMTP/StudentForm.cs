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
    public partial class StudentForm : Form
    {
        private int userID;
        private String ConnectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";

        public StudentForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            DisplayCourses(1, false);
            LoadStudentDetails();
            
        }
        bool menuExpand = false;
        private void LoadStudentDetails()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Name, StudyYear, Department FROM STUDENT WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblName.Text = reader["Name"].ToString();
                        lblStudyYear.Text = reader["StudyYear"].ToString();
                        lblDepartment.Text = reader["Department"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No student details found for the logged-in user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void meniuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                submenu.Height += 10;
                if (submenu.Height >= 108)
                {
                    meniuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                submenu.Height -= 10;
                if (submenu.Height <= 41)
                {
                    meniuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            meniuTransition.Start();
        }
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 49)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

       

        private void submenu_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

       
        private void DisplayCourses(int semID, bool show)
        {
            // Clear existing nodes
            treeViewCourses.Nodes.Clear();
            treeViewCourses.Visible = show;


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CourseID, Name FROM COURSES WHERE SemID = @SemID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SemID", semID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int courseID = Convert.ToInt32(reader["CourseID"]);
                        string courseName = reader["Name"].ToString();

                        // Add course as a node to the treeViewCourses
                        TreeNode courseNode = new TreeNode(courseName);
                        courseNode.Tag = courseID; // Store courseID in the Tag property
                        treeViewCourses.Nodes.Add(courseNode);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving courses: " + ex.Message);
                }
            }
        }

        
        private void DisplayStudentDetails(bool show)
        {
            lblName.Visible = show;
            lblStudyYear.Visible = show;
            lblDepartment.Visible = show;
            label2.Visible = show;
            label3.Visible = show;
            label4.Visible = show;
            label5.Visible = show;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayStudentDetails(false);
            DisplayCourses(1,true);
            

        }

        private void ongSem_Click(object sender, EventArgs e)
        {
            DisplayStudentDetails(false);
            DisplayCourses(2,true);
        }

        private void btnAbt_Click(object sender, EventArgs e)
        {
            DisplayStudentDetails(true);
            DisplayCourses(1, false);
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm(this.userID);
            assignmentForm.Show();
            this.Hide();
        }

        private int GetStudentIDFromUserID(int userID)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";
            string query = "SELECT StudentID FROM STUDENT WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }

            return -1; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int studentID = GetStudentIDFromUserID(this.userID);
            GradesForm gradesForm = new GradesForm(this,this.userID,studentID);
            gradesForm.Show();
            this.Hide();
        }
       
    }
}
