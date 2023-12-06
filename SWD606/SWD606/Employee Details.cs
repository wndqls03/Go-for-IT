using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SWD606
{
    public partial class Employee_Details : Form
    {
        private string _username;

        public Employee_Details(string username)
        {
            InitializeComponent();
            _username = username;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Customer WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", _username);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

            public Employee_Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add any specific handling for cell clicks if needed
        }
    }
}
