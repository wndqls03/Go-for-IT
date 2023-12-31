﻿using System;
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
        string empID;
        string empName;
        int age;
        string username;
        string password;
        string address;
        string gender;
        string contactNumber;
        decimal salary;
        string position;
        string leaveStatus;

        public Admim_Emp_Management()
        {
            InitializeComponent();
            DisplayEmployeeData();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                empID = empID_Text.Text;
                empName = empName_Text.Text;
                age = Convert.ToInt32(age_Text.Text);
                username = userNa_Text.Text;
                password = pass_Text.Text;
                address = address_Text.Text;
                gender = gen_Combo.Text;
                contactNumber = num_Text.Text;
                salary = Convert.ToDecimal(sal_Text.Text);
                position = posi_Combo.Text;
                leaveStatus = status_Combo.Text;

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
            try
            {
                empID = empID_Text.Text;

                string query = "DELETE FROM Customer WHERE EmployeeID = @EmployeeID";

                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", empID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.");
                            DisplayEmployeeData(); // Refresh the DataGridView after deletion
                        }
                        else
                        {
                            MessageBox.Show("No employee found with this Employee ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void up_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                empID = empID_Text.Text;
                empName = empName_Text.Text;
                age = Convert.ToInt32(age_Text.Text);
                username = userNa_Text.Text;
                password = pass_Text.Text;
                address = address_Text.Text;
                gender = gen_Combo.Text;
                contactNumber = num_Text.Text;
                salary = Convert.ToDecimal(sal_Text.Text);
                position = posi_Combo.Text;
                leaveStatus = status_Combo.Text;

                if (string.IsNullOrWhiteSpace(position))  // Check if position is null or empty
                {
                    MessageBox.Show("Please select a position.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(leaveStatus))  // Check if leave status is null or empty
                {
                    MessageBox.Show("Please select a leave status.");
                    return;
                }

                string query = "UPDATE Customer SET EmployeeName = @EmployeeName, Age = @Age, Username = @Username, " +
                               "Password = @Password, Address = @Address, Gender = @Gender, ContactNumber = @ContactNumber, " +
                               "Salary = @Salary, Position = @Position, LeaveStatus = @LeaveStatus WHERE EmployeeID = @EmployeeID";

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
                            MessageBox.Show("Employee details updated successfully.");
                            DisplayEmployeeData(); // Refresh the DataGridView after update
                        }
                        else
                        {
                            MessageBox.Show("No employee found with this Employee ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
    
        private void exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

