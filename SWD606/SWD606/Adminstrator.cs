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
using static SWD606.Login;

namespace SWD606
{
    public interface UserRepository
    {
        bool ValidUser(string username, string password);
    }
    public partial class Administrator : Form
    {
        private UserRepository _userRepository;

        public Administrator()
        {
            InitializeComponent();
            adminpass_Text.PasswordChar = '*';
            _userRepository = new SqlUserRepository("Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True");
        }
        
        private SqlConnection SqlConn = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True");

        public class SqlUserRepository : UserRepository
        {
            private string _connectionString;

            public SqlUserRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

            public bool ValidUser(string username, string password)
            {
                string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";

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
        private void access_Btn_Click(object sender, EventArgs e)
        {
            string username = adminid_Text.Text;
            string password = adminpass_Text.Text;

            if (_userRepository.ValidUser(username, password))
            {
                MessageBox.Show("Login Successful");
                
                Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
                this.Hide();
                adminDashboardForm.Showdialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool ValidUser(string username, string password)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True";

            string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";

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
            adminpass_Text.PasswordChar = showPass_Check.Checked ? '\0' : '*';

        }
    }
}
