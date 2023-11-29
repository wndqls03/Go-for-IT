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
            DisplayEmployeeData();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string empID = empID_Text.Text;
                string empName = empName_Text.Text;
                int age = Convert.ToInt32(age_Text.Text);
                string username = userNa_Text.Text;
                string password = pass_Text.Text;
                string address = address_Text.Text;
                string gender = gen_Text.Text;
                string contactNumber = num_Text.Text;
                decimal salary = Convert.ToDecimal(sal_Text.Text);
                string position = posi_List.SelectedItem != null ? posi_List.SelectedItem.ToString() : "";
                string leaveStatus = status_List.SelectedItem != null ? status_List.SelectedItem.ToString() : "";

                string query = "INSERT INTO Customer (EmployeeID, EmployeeName, Age, Username, Password, Address, Gender, ContactNumber, Salary, Position, LeaveStatus) " +
                               "VALUES (@EmployeeID, @EmployeeName, @Age, @Username, @Password, @Address, @Gender, @ContactNumber, @Salary, @Position, @LeaveStatus)";

                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", empID);
                        command.Parameters.AddWithValue("@EmployeeName", empName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@LeaveStatus", leaveStatus);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully.");
                            DisplayEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void del_Btn_Click(object sender, EventArgs e)
        {

        }

        private void up_Btn_Click(object sender, EventArgs e)
        {

        }
        private void DisplayEmployeeData() // Renamed the method for clarity
        {
            string query = "SELECT * FROM Customer";
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30";
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

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
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

