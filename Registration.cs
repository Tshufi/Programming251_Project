using Programming251_Project.Properties;
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
    public partial class Registration : Form
    {
        DataHandler dh = new DataHandler();
        public Registration()
        {
            InitializeComponent();
        }

        private void btnExt_Reg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBCpswd_Reg_TextChanged(object sender, EventArgs e)
        {
            if (txtBPswd_Reg.Text == txtBCpswd_Reg.Text)
            {
                label1.Show();
                label1.ForeColor = Color.Green;
                label1.Text = "Password correct! You can continue...";
            }
            else
            {
                label1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Passwords don't match. Please Re-enter...";
            }
        }

        private void btnSmt_St_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                MessageBox.Show("Please select your image first before submitting!");
            }
            else
            {
                dh.InsertingStudentData(int.Parse(txtBStn.Text), txtBNm.Text, txtBSrn.Text, txtBPswd_Reg.Text, pictureBox1.ImageLocation, DateTime.Parse(txtBDob.Text), txtBGnd.Text, int.Parse(txtBPhn.Text), rTBAddr.Text);
            }
        }

        private void txtBPswd_Reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnbrwsr_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        
        private void btnClr_St_Reg_Click(object sender, EventArgs e)
        {
            foreach (Control c in gBStd.Controls)
            {
                if(c is TextBox)
                {
                    label1.Hide();
                    gBStd.Text = string.Empty;
                    pictureBox1.Image = null;
                    c.ResetText();
                }
            }
        }

        private void btnClr_Mdl_Reg_Click(object sender, EventArgs e)
        {
            foreach (Control c in gBMds.Controls)
            {
                if (c is TextBox)
                {
                    gBStd.Text = string.Empty;
                    c.ResetText();
                }
            }
        }
    }
}
