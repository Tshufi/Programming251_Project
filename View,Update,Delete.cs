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
    public partial class View_Update_Delete : Form
    {
        public View_Update_Delete()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dh.SearchData(int.Parse(txtBStn.Text), txtBNm.Text, txtBSrn.Text, txtBPswd_Reg.Text, txtB, DateTime.Parse(txtBDob.Text), txtBGnd.Text, int.Parse(txtBPhn.Text), txtBAddr.Text);
            //if (txtBPswd_Reg != txtBCpswd_Reg)
            //{
            //    MessageBox.Show("Passwords don't match! Please re-enter");
            //}
            //if (reader.Read())
            //{
            //    studentNumber
            //}
        }
    }
}
