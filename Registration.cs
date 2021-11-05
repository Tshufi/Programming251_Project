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
using System.IO;

namespace Programming251_Project
{
    public partial class Registration : Form
    {
        DataHandler dh = new DataHandler();
        FileHandler fh = new FileHandler();
        string fileName;

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
            
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, Multiselect = false })

            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    fileName = odf.FileName;

                    pictureBox1.Image = Image.FromFile(fileName);

                    string name = Path.GetFileName(fileName);
                    string[] name1 = name.Split('.');
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessageBox.Show(dh.InsertingStudentData(txtBNm.Text, txtBSrn.Text, txtBPswd_Reg.Text, pictureBox1.Image, DateTime.Parse(txtBDob.Text), txtBGnd.Text, int.Parse(txtBPhn.Text), txtBAddr.Text));

                }
                if (pictureBox1.Image is null)
                {
                    MessageBox.Show("Please select your image first before submitting!");
                }
            }
        }

        private void txtBPswd_Reg_TextChanged(object sender, EventArgs e)
        {
            fh.WritingToFile(txtBPswd_Reg.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnbrwsr_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, Multiselect = false }; 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                MessageBox.Show($"({fileName})");
                pictureBox1.Image = Image.FromFile(fileName);
                textBox1.Text = File.GetCreationTime(fileName).ToString();
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

        private void btnSmt_Mdl_Click(object sender, EventArgs e)
        {
            dh.InsertingModuleData(txtBMdc.Text, txtBMn.Text, txtBDesc.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Iamge Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                ImageText.Text = openfd.FileName;
                pictureBox1.Image = new Bitmap(openfd.FileName);
                pictureBox1.ImageLocation = openfd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
