using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Programming251_Project
{
    class DataHandler
    {
        string dbConnection = "Data Source=LAPTOP-UQGNKHFE;Initial Catalog=ProjectDB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        //public void SearchData(int studentNumber, string name, string surname, string password, string picture, DateTime dateOfBirth, string gender, int phone, string address)
        //{
        //    try
        //    {
        //        string query = $"SELECT * FROM ProjectDB.Students WHERE [Student Number] = ({studentNumber})";
        //        cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("[Student Number]", studentNumber);
        //        reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            name = reader["[Student Number]"].ToString();
        //            surname = reader["Surname"].ToString();
        //            password = reader[""].ToString();
        //            picture = reader[""].ToString();
        //            dateOfBirth = reader[""].ToDateTime();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error! " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
                                                                                                        //Ask mam -- What is the correct datatype to use for storing the image there
        public void InsertingStudentData(int studentNumber, string name, string surname, string password, string picture, DateTime dateOfBirth, string gender, int phone, string address)
        {
            string query = $"INSERT INTO ProjectDB.Students ([Student Number], Name, Surname, Password, Picture, [Date of Birth], Gender, Phone, Address)" +
                           $"VALUES({studentNumber}, {name}, {surname}, HASHBYTES('SHAI' '{password}'), {picture}, {dateOfBirth}, {gender}, {phone}, {address})";
                                                                      //This is an increption for the password
            conn = new SqlConnection(dbConnection);
            cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Details of a new student saved!"," Please add details of Module");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr! "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void InsertingModuleData(string moduleCode, string name, string description)
        {
            string query = $"INSERT INTO ProjectDB.Modules ([Module Code], Name, Description) VALUES({moduleCode}, {name}, {description})";
            conn = new SqlConnection(dbConnection);
            cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Great, All data has been saved!", " Please add details of Module");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeletingData(int studentNumber)
        {
            try
            {
                string query = $"DELETE FROM ProjectDB.Students WHERE [Student Number] = ({studentNumber})";
                conn = new SqlConnection(dbConnection);
                conn.Open();
                cmd = new SqlCommand();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student has been deleted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateData()
        {

        }
        public void ClearData(GroupBox control)
        {

        }
    }
}
