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

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products p = new Products(1, "Screw", 100, 10, 1);
            BinaryFormatter binformatter = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Products.txt", FileMode.OpenOrCreate, FileAccess.Write);



            binformatter.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("File Created");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Products prod;
            try
            {
                BinaryFormatter binformatter = new BinaryFormatter();
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Products.txt", FileMode.Open, FileAccess.Read);
                prod = (Products)binformatter.Deserialize(fs);
                MessageBox.Show("Data is Serialized\nProduct Details: ID :" + prod.ProductId + " Name :" + prod.Name + " Price :" + prod.Rate + " Stock :" + prod.Stock + " Check :" + prod.Check);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void button3_Click(object sender, EventArgs e)
        {
            Products p = new Products(1, "Product", 100, 10, 1);
            XmlSerializer xs = new XmlSerializer(typeof(Products));
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Products.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("File Created");



        }



        private void button4_Click(object sender, EventArgs e)
        {
            Products obj;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Products));
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\Products.xml", FileMode.Open, FileAccess.Read);
                obj = (Products)xs.Deserialize(fs);
                fs.Close();
                MessageBox.Show("Data is Deserialized\nProduct Details: ID :" + obj.ProductId + " Name :" + obj.Name + " Price :" + obj.Rate + " Stock :" + obj.Stock + " Check :" + obj.Check);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
