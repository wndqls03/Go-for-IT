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
    public partial class Start_page : Form
    {
        public Start_page()
        {
            //try//
            InitializeComponent();
        }

        private void emp_Btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void admin_Btn_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            this.Hide();
            administrator.ShowDialog();
            this.Close();
        }
    }
}
