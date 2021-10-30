using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming251_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExt_lgn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            View_Update_Delete sf = new View_Update_Delete();
            string question = "Do you want to see the list of students?";
            string title = "See student details";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(question, title, buttons);
            if (result == DialogResult.OK)
            {
                sf.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void txtBPwsd_lgn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBCpwsd_lgn_TextChanged(object sender, EventArgs e)
        {
            if (txtBPwsd_lgn.Text == txtBCpwsd_lgn.Text)
            {
                label1.Show();
                label1.ForeColor = Color.Green;
                label1.Text = "Correct Details! You can proceed to login";
            }
            else
            {
                label1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Passwords don't match. Please Re-enter...";
            }
        }

        private void btnReg_lgn_Click(object sender, EventArgs e)
        {
            Registration sf = new Registration();
            sf.Show();
            this.Hide();
        }
    }
}
