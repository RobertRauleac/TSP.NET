using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        Interface1Client client = new Interface1Client();

        private object folderBrowserDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //insert picture
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {                
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    client.Insert(fileInfo.Name, fileInfo.Length, fileInfo.FullName, fileInfo.Extension, fileInfo.CreationTime);
                }
                catch (IOException)
                {
                }
            }
        }


        private void button2_Click(object sender, EventArgs e) //show image
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }


        private void button3_Click(object sender, EventArgs e) //clear image
        {
            pictureBox1.Image = null;
        }


        private void button4_Click(object sender, EventArgs e) //add new column
        {
            client.newCol(textBox5.Text);
            textBox5.Text = string.Empty;
        }


        private void button5_Click(object sender, EventArgs e) //delete picture
        {
            client.Delete(textBox1.Text);
            textBox1.Text = string.Empty;

        }


        private void button6_Click(object sender, EventArgs e) //update picture 
        {
            client.Update(textBox2.Text, textBox3.Text, textBox4.Text);
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }


        private void button7_Click(object sender, EventArgs e) //delete column
        {
            client.deleteCol(textBox6.Text);
            textBox6.Text = string.Empty;
        }


        private void button8_Click(object sender, EventArgs e) //insert folder
        {
            
                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog2.SelectedPath;
                    if (Directory.Exists(path))
                    {
                        foreach (String file in Directory.GetFiles(path))
                        {
                            if (File.Exists(file))
                            {
                                FileInfo fileInfo = new FileInfo(file);
                                client.Insert(fileInfo.Name, fileInfo.Length, fileInfo.FullName, fileInfo.Extension, fileInfo.CreationTime);
                            }
                        }
                    }
                }
            
        }





        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
