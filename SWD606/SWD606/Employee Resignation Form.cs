using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606
{
    public partial class Employee_Resignation_Form : Form
    {
        public Employee_Resignation_Form()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Resignation_Form_Load(object sender, EventArgs e)
        {

        }

        private void view_Btn_Click(object sender, EventArgs e)
        {
            ReloadPage();
            MessageBox.Show("Resignation request successfully sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReloadPage()
        {
            ClearTextBoxes();
            ResetCheckBox();
            // Perform other actions if needed
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }

        private void ResetCheckBox()
        {
            checkBox1.Checked = false;
            // Reset other checkboxes if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
