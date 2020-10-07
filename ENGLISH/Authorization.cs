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

namespace ENGLISH
{
    public partial class Authorization : Form
    {
        DirectoryInfo dirInfo ;
        Main main = new Main();
        public Authorization(Main m, ref DirectoryInfo dir)
        {
            InitializeComponent();

            dirInfo = dir;
            main = m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + textBox1.Text);

            try
            {
                Directory.CreateDirectory(textBox1.Text);

                StreamWriter writer = new StreamWriter("Authorization.txt");
                writer.WriteLine(textBox1.Text+'-'+textBox2.Text);
                writer.Close();
            
          
                File.Copy(@"Authorization.txt", dirInfo + "\\Authorization.txt");
                File.Copy(@"Learned.txt", dirInfo + "\\Learned.txt");

                File.Copy(@"Dictionary.txt", dirInfo + "\\Dictionary.txt");
                main.OpenD.Enabled = true;
                main.OpenStudy.Enabled = true;
                main.Reader(dirInfo);
                main.Opacity = 1000;
                main.Visible = true;
                main.ShowInTaskbar = true;
                main.ShowIcon = true;
                MessageBox.Show("You created a new account");

                Close();

            }
            catch
            {
                string line;

                using (StreamReader sr = new StreamReader(dirInfo + "\\Authorization.txt"))
                {
                    line = sr.ReadLine();
                   
                }
              
                string password=" ";
                bool c=true;
                foreach (var item in line)
                {
                    if (item == '-')
                    {
                        c = false;
                        continue;
                    }
                    if (c == false)
                    {
                        password += item;
                    }
                   

                }
                password= password.Trim();
                if (password == textBox2.Text)
                {
                    main.OpenD.Enabled = true;
                    main.OpenStudy.Enabled = true;
                   
                    MessageBox.Show("You are logged in");
                    main.Reader(dirInfo);
                    main.Visible = true;
                    main.Opacity = 1000;  
                    main.Visible = true;
                    main.ShowInTaskbar = true;
                    main.ShowIcon = true;
                    Close();

                }

                else
                    MessageBox.Show("ERROR");

            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
