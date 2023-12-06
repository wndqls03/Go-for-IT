    using System.Windows.Forms;
    using System;

    namespace SWD606
    {
        public partial class Employee_Dashboard : Form
        {
        private string _username;

        public Employee_Dashboard(string username)
        {
            InitializeComponent();
            _username = username;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                // Handle cell click event if needed
            }

            private void Employee_Dashboard_Load(object sender, EventArgs e)
            {
                // Perform actions when the form loads if needed
            }

        private void mydetails_btn_Click(object sender, EventArgs e)
        {
            Employee_Details employeeDetailsForm = new Employee_Details(_username);
            employeeDetailsForm.ShowDialog();
        }

        private void yearlyholidaylist_btn_Click(object sender, EventArgs e)
        {
            Employee_Yearly_Hoilday_List yearlyHolidayListForm = new Employee_Yearly_Hoilday_List();
            yearlyHolidayListForm.ShowDialog();
        }

        private void resigning_btn_Click(object sender, EventArgs e)
        {
            Employee_Resignation_Form employee_Resignation_Form = new Employee_Resignation_Form();
            employee_Resignation_Form.ShowDialog();
        }

        private void grievances_btn_Click(object sender, EventArgs e)
        {
            Employee_Grievances employee_Grievances = new Employee_Grievances();
            employee_Grievances.ShowDialog();
        }
    }
    }
