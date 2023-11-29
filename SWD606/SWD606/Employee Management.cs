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
    public partial class Admim_Emp_Management : Form
    {
        public Admim_Emp_Management()
        {
            InitializeComponent();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {

        }

        private void del_Btn_Click(object sender, EventArgs e)
        {

        }

        private void up_Btn_Click(object sender, EventArgs e)
        {

        }
        private void DisplayEmployData()
        {
            string query = "SELECT * FROM Customer";
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable; // Bind the DataGridView to the DataTable
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
