using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606
{
    public interface IUserRepository
    {
        bool IsValidUser(string username, string password);
    }
   
    public partial class Login : Form
    {
        private IUserRepository _userRepository;
 
        public Login()
        {
            InitializeComponent();
            password_text.PasswordChar = '*';
            _userRepository = new SqlUserRepository("Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True");

        }


        private SqlConnection SqlConn = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True");

        public class SqlUserRepository : IUserRepository
        {
            private string _connectionString;

            public SqlUserRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

            public bool IsValidUser(string username, string password)
            {
                string query = "SELECT COUNT(*) FROM Customer WHERE Username = @Username AND Password = @Password";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();

                        int userCount = (int)command.ExecuteScalar();

                        return userCount > 0;
                    }
                }
            }
        }
        private void login_Btn_Click(object sender, EventArgs e)
        {
            string username = ID_text.Text;
            string password = password_text.Text;

            if (_userRepository.IsValidUser(username, password))
            {
                MessageBox.Show("Login Successful");
                Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
                this.Hide();
                employee_Dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True";

            string query = "SELECT COUNT(*) FROM Customer WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void showPass_Check_CheckedChanged(object sender, EventArgs e)
        {
            password_text.PasswordChar = showPass_Check.Checked ? '\0' : '*';
        }
    }
}
