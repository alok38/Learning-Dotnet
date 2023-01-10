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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Student_List_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            // Student s = new Student(1, "alok");
            List<Student> students = new List<Student>(); 
            students.Add(new Student(1,"alok"));
            students.Add(new Student(2, "blok"));
            BinaryFormatter binformatter = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Students.txt", FileMode.OpenOrCreate, FileAccess.Write);



            // binformatter.Serialize(fs, s);
            binformatter.Serialize(fs, students);
            fs.Close();
            MessageBox.Show("File Created");
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            //Student stu;
            List<Student> stu = new List<Student>();
            try
            {
                BinaryFormatter binformatter = new BinaryFormatter();
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Students.txt", FileMode.Open, FileAccess.Read);
                stu = (List<Student>)binformatter.Deserialize(fs);
                foreach (Student student in stu)
                {
                    MessageBox.Show("Data is Serialized\nStudent Details: ID :" + student.studentId + " Name :" + student.name);
                }

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlSerialize_Click(object sender, EventArgs e)
        {
            //Student s = new Student(1, "alok");
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "alok"));
            students.Add(new Student(2, "blok"));
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Students.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, students);
            fs.Close();
            MessageBox.Show("File Created");


        }

        private void btnXmlDeserialze_Click(object sender, EventArgs e)
        {
            // Student obj;
            List<Student> stu = new List<Student>();

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Students.xml", FileMode.Open, FileAccess.Read);
                stu = (List<Student>)xs.Deserialize(fs);
                fs.Close();
                foreach (Student student in stu)
                {
                    MessageBox.Show("Data is Deserialized\nStudent Details: ID :" + student.studentId + " Name :" + student.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

