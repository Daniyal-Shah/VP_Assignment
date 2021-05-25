using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        List<String> images = new List<string>();
        int count=0;

        private void timerpicturebox_Tick(object sender, EventArgs e)
        {
               this.pictureBox1.Image = Image.FromFile(images[count]);
               count=(count+1)%3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlTextReader xReader = new XmlTextReader(@"C:\Users\92306\Desktop\Assignment\Paths.xml");

             while (xReader.Read())
            {
                if (xReader.NodeType== XmlNodeType.Text)
                {                    
                         Console.WriteLine(xReader.Value);
                         images.Add(""+xReader.Value);
                }
            }
            timerpicturebox.Enabled = true;

            

        }




    }
}
