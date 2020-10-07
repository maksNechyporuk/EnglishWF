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
    public partial class Main : Form
    {
        List<NotStudiedDictionary> notStudiedList = new List<NotStudiedDictionary>();
        List<StudyDictionary> studyDictionaries= new List<StudyDictionary>();
        string[] c = File.ReadAllLines("Authorization.txt");
        DirectoryInfo dirInfo;
        public Main()
        {
            InitializeComponent();
            Visible = false;

        }

        private void OpenD_Click(object sender, EventArgs e)
        {
            ShowDictionary showDictionary = new ShowDictionary();
            showDictionary.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization(this,ref dirInfo);
            authorization.Show();
            this.Opacity = 0; //Add this line. 
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;

            OpenD.Enabled = false;
                OpenStudy.Enabled = false;
          
        }
        public void Reader(DirectoryInfo directory)
        {
            

            NotStudiedDictionary notStudied = new NotStudiedDictionary();
            notStudiedList.Add(notStudied);
            dirInfo = directory;
            string path = directory + "\\Dictionary.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    notStudied = notStudied.AddWord(line);
                    notStudiedList.Add(notStudied);
                    notStudied = new NotStudiedDictionary();
                }
                notStudiedList.RemoveAt(0);
            }
        }
        private void OpenStudy_Click(object sender, EventArgs e)
        {
            studyDictionaries.Clear();
            ChooseWords showDictionary = new ChooseWords(notStudiedList, studyDictionaries, dirInfo);
            showDictionary.Show();
        }
    }
}
