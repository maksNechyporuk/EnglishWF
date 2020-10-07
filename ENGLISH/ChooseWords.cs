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
    public partial class ChooseWords : Form
    {
        List<NotStudiedDictionary> notStudiedList = new List<NotStudiedDictionary>();
        List<StudyDictionary> studyDictionaries = new List<StudyDictionary>();
        DirectoryInfo directory;
        int i = 0;
        public ChooseWords(List<NotStudiedDictionary> notStudieds,List<StudyDictionary> studies,DirectoryInfo info)
        {
            InitializeComponent();
            directory = info;
            notStudiedList = notStudieds;
            studyDictionaries = studies;
        }
        private void ChooseWords_Load(object sender, EventArgs e)
        {
            try {
                RandomWord();
            }
            catch
            {
                MessageBox.Show("You know all words");
                Close();
            }
        }

        private void LearnB_Click(object sender, EventArgs e)
        {
            try
            {
                StudyDictionary study = new StudyDictionary();
                study.AddWord(notStudiedList, i);
                studyDictionaries.Add(study);
                study = new StudyDictionary();
                notStudiedList.RemoveAt(i);
                label1.Text = "Select "+ (5-studyDictionaries.Count()).ToString() + " words";
                RandomWord();
            }
            catch
            {
                LearnB.Visible = false;
                LearnedB.Visible = false;
               Test test = new Test( studyDictionaries, directory);
               test.Show();

                StreamWriter writer = new StreamWriter(directory + "\\Dictionary.txt", false, System.Text.Encoding.Default);
                foreach (var item in notStudiedList)
                {
                    writer.WriteLine(item.GetWordsEng() + " - " + item.GetWordsUkr());
                }


                writer.Close();
                Close();
            }
        }

        private void LearnedB_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(directory + "\\Learned.txt", true);
                writer.WriteLine(ENGlabel.Text + " - " + UKRlabel.Text + "\n");
                writer.Close();
                notStudiedList.RemoveAt(i);
                RandomWord();
            }
            catch
            {
                MessageBox.Show("You know all words");
            }
        }
        void RandomWord()
        {

            if (studyDictionaries.Count != 5)
            {
                Random random = new Random();
                i = random.Next(0, notStudiedList.Count);
                ENGlabel.Text = notStudiedList[i].GetWordsEng();
                UKRlabel.Text = notStudiedList[i].GetWordsUkr();
            }
            else
            {
                LearnB.Visible = false;
                LearnedB.Visible = false;
                Test test = new Test(studyDictionaries, directory);
                test.Show();

                StreamWriter writer = new StreamWriter(directory + "\\Dictionary.txt", false, System.Text.Encoding.Default);
                foreach (var item in notStudiedList)
                {
                    writer.WriteLine(item.GetWordsEng() + " - " + item.GetWordsUkr());
                } 
              
             
                writer.Close();
                this.Close();

            }
        }
    }
}
