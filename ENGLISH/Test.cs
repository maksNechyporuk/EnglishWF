using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ENGLISH
{
    public partial class Test : Form
    {
        Funcs funcs = new Funcs();
        List<NotStudiedDictionary> notStudiedList = new List<NotStudiedDictionary>();
        List<StudyDictionary> studyDictionaries = new List<StudyDictionary>();
        DirectoryInfo directory;
        int posWord;
        int i = 0;
        int t = 0;
        string[] words;
        List<int> arr = new List<int>();
        public Test( List<StudyDictionary> studies,DirectoryInfo info)
        {
            InitializeComponent();
            directory = info;
            NotStudiedDictionary notStudied = new NotStudiedDictionary();
            notStudiedList.Add(notStudied);
            using (StreamReader sr = new StreamReader("BaseDictionary.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    notStudied = notStudied.AddWord(line);
                    notStudiedList.Add(notStudied);
                    notStudied = new NotStudiedDictionary();
                }
            }
            for (int l=0;l<studyDictionaries.Count;l++)
            {
                arr.Add(l);
            }
            studyDictionaries = studies;
            SelectWord();
            TextButton();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          CheckAnswer(button2);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            CheckAnswer(button1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAnswer(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAnswer(button4);
        }
        int RandomWord(int i)
        {
            Random random = new Random();
            Thread.Sleep(20);
            return random.Next(0, i);
        }
        void SelectWord()
        {
            if (studyDictionaries[posWord].Count>0&&i==0)
            {
                arr.RemoveAt(t);
            }
            try
            {
                i = 0;
                t = RandomWord(arr.Count);
                posWord = arr[t];
               
                SelectWords();
            }
            catch
            {
               // MessageBox.Show("sdc");
                int c = 0;
                foreach (var item in studyDictionaries)
                {
                    if(item.Count==5)
                    {
                        c++;
                    }
                }
                if (c == studyDictionaries.Count)
                {
                    foreach (var item in studyDictionaries)
                    {
                        item.WriteToFile(directory);

                    }

                    MessageBox.Show("You remember all words");
                    Swap();
                    SelectWord();
                    Close();

                }
                else
                {
                    i = -1;
                    Swap();
                    SelectWord();
                }
                }

        }
        void SelectWords()
        {
            words = new string[4];
            words[RandomWord(4)] = studyDictionaries[posWord].GetWordsUkr();
            labelWord.Text = studyDictionaries[posWord].GetWordsEng();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == null)
                {
                    words[i] = notStudiedList[RandomWord(notStudiedList.Count)].GetWordsUkr();
                    int k = 0;
                    while (true)
                    {
                        if (words[i] == words[k])
                        {
                            
                            words[i] = notStudiedList[RandomWord(notStudiedList.Count)].GetWordsUkr();
                        }
                        k++;
                        if (k == 4) break;
                    }
                }
            }
        }
        void TextButton()
        {

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    int j = RandomWord(4);
                   
                    if (words[j] != null)
                    {
                        if (i == 0)
                            button1.Text = words[j];
                        if (i == 1)
                            button2.Text = words[j];
                        if (i == 2)
                            button3.Text = words[j];
                        if (i == 3)
                            button4.Text = words[j];
                        words[j] = null;
                        break;
                    }
                }
            }
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }
        public void CheckAnswer(Button b)
        {
            if (b.Text == studyDictionaries[posWord].GetWordsUkr())
            {
                if (i == 0)
                studyDictionaries[posWord].Count++;
                b.BackColor = Color.Green;
                funcs.func();
                SelectWord();
                TextButton();
            }
            else
            {
                b.BackColor = Color.Red;
                i++;
            }
            funcs.func();
            b.BackColor = Color.White;
        }
       void Swap()
        {
            foreach (var item in studyDictionaries)
            {
                item.Swap();
            }
            foreach (var item in notStudiedList)
            {
                item.Swap();
            }
            arr.Clear();
            for (int i = 0; i < studyDictionaries.Count; i++)
            {
                arr.Add(i);
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
