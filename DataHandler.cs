using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Programming251_Project
{
    class DataHandler
    {
        public DataHandler() { }
        string dbConnection = "Data Source=LAPTOP-UQGNKHFE;Initial Catalog=ProjectDB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter ad;
        DataTable dt;
        public DataTable SearchData(int studentNumber)
        {
            string query = $"SELECT * FROM Students WHERE [Student Number] = ({studentNumber})";
            try
            {
                conn = new SqlConnection(dbConnection);
                ad = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            return dt;
        }

        public DataTable DisplayData()
        {
            string query = "SELECT * FROM Students";
            try
            {
                conn = new SqlConnection(dbConnection);
                ad = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        
        public string InsertingStudentData(string name, string surname, string password, Image picture, DateTime dateOfBirth, string gender, int phone, string address)
        {
            string query = $"INSERT INTO Students (Name, Surname, Password, Picture, [Date of Birth], Gender, Phone, Address)" +
                           $"VALUES({name}, {surname}, {password}, {picture}, {dateOfBirth}, {gender}, {phone}, {address})";
            conn = new SqlConnection(dbConnection);
            cmd = new SqlCommand(query, conn);
            MemoryStream ms = new MemoryStream();
            try
            {
                conn.Open();
                picture.Save(ms, ImageFormat.Jpeg);
                byte[] picArr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(picArr, 0, picArr.Length);
                cmd.Parameters.AddWithValue("Picture", picArr);
                cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return "Details of the new student saved!\nPlease note it down and keep it safe. It will be of use to" +
                   "access the school's facilities\n\nNow, please add details of Module";
        }

        public DataTable InsertingModuleData(string moduleCode, string name, string description)
        {
            string query = $"INSERT INTO ProjectDB.Modules ([Module Code], Name, Description) VALUES({moduleCode}, {name}, {description})";
            try
            {
                conn = new SqlConnection(dbConnection);
                ad = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
                MessageBox.Show("Great, All data has been saved!\nDo you want to see the list of students?\nIf not, the Apllication will close", "Question", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr! " + ex.Message);
            }
            conn.Close();
            return dt;
        }

        public DataTable DeletingData(int studentNumber)
        {
            string query = $"DELETE FROM Students WHERE [Student Number] = ({studentNumber})";
            try
            {
                conn = new SqlConnection(dbConnection);
                ad = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
                MessageBox.Show("Student has been deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            return dt;
        }

        public DataTable UpdateData(int studentNumber, string name, string surname, string password, Image picture, DateTime dateOfBirth, string gender, int phone, string address)
        {
            string query = $"UPDATE Students SET Name = {name}, Surname = {surname}, Password = {password}, Picture = {picture}, [Date of Birth] = ({dateOfBirth}), Gender = {gender}, Phone = {phone}, Address = {address} WHERE [Student Number] = {studentNumber}";
            try
            {
                conn = new SqlConnection(dbConnection);
                ad = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
                MessageBox.Show("Student has been updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            return dt;
        }
    }
}
