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
        DataHandler dh = new DataHandler();
        public View_Update_Delete()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dGV.DataSource = dh.SearchData(int.Parse(textBoxSearch.Text));
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            dGV.DataSource = dh.DisplayData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dh.DeletingData(int.Parse(textBoxDel.Text));
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            dh.UpdateData(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, pictureBox1.Image, DateTime.Parse(textBox5.Text), textBox6.Text, int.Parse(textBox7.Text), textBox8.Text);
        }

        private void dGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dGV.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dGV.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox7.Text = dGV.SelectedRows[0].Cells[0].Value.ToString();
            textBox8.Text = dGV.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
