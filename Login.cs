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
        FileHandler fh = new FileHandler();
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
            View_Update_Delete vud = new View_Update_Delete();
            string question = "Do you want to see the list of students?\nIf not, the Apllication will close";
            string title = "See student details";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(question, title, buttons);
            if (result == DialogResult.OK)
            {
                vud.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void txtBPwsd_lgn_TextChanged(object sender, EventArgs e)
        {
            if (txtBPwsd_lgn.Text == txtBPwsd_lgn.Text)
            {

                fh.ReadingFileRightPassword(txtBPwsd_lgn.Text);
                label1.Show();
                label1.ForeColor = Color.Green;
                label1.Text = "Correct! You can proceed to login";
            }
            else
            {
                fh.ReadingFileWrongPassword(txtBPwsd_lgn.Text);
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