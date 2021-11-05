using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Programming251_Project
{
    class FileHandler
    {
        string file = "passwords.txt";
        public FileHandler() { }
        
        public void WritingToFile(string password)
        {
            if (File.Exists(file) == true)
            {
                FileStream ft = new FileStream(file, FileMode.Append);
                StreamWriter sw = new StreamWriter(ft);
                sw.WriteLine(password);
                sw.Close();
                ft.Close();
            }
            else
            {
                FileStream ft = new FileStream(file, FileMode.Create);
                StreamWriter sw = new StreamWriter(ft);
                sw.WriteLine(password);
                MessageBox.Show("Password Saved!");
                sw.Close();
                ft.Close();
            }
        }
        public void ReadingFileRightPassword(string password)
        {
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
        }
        public void ReadingFileWrongPassword(string password)
        {
            MessageBox.Show("That is an invalid Password, Please Re-enter");
        }

    }
}
