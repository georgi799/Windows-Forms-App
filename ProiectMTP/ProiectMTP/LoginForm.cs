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
    public partial class LoginForm : Form
    {

        private String ConnectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";

            // Validate inputs
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select your role.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Autentificarea utilizatorului în baza de date 'users'
            using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT UserID FROM USERI WHERE Username=@Username AND Password=@Password AND Role=@Role";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);


                        if (role == "student")
                        {
                            StudentForm studentForm = new StudentForm(userID);
                            studentForm.Show();
                        }
                        else if (role == "professor")
                        {
                            int professorID = GetProfessorIDFromUserID(userID);
                            ProfessorForm professorForm = new ProfessorForm(professorID);
                            professorForm.Show();
                        }
                        this.Hide();

                    }
                        else
                        {
                            MessageBox.Show("Nume de utilizator, parolă sau rol incorecte. Te rog să încerci din nou.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la conectare: " + ex.Message);
                    }

                
                }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private int GetProfessorIDFromUserID(int userID)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Users;Integrated Security=True";
            string query = "SELECT ProfessorID FROM PROFESSOR WHERE UserID = @UserID";

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

        private void checkbxPs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxPs.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Show the password
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Hide the password
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
            
