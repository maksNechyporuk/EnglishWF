using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGLISH
{
    public class StudyDictionary : Dictionary
    {

 
        public int Count { get; set; }
        public void AddWord(List<NotStudiedDictionary> notStudieds,int i)
        {
            engWord= notStudieds[i].GetWordsEng();
            ukrWord= notStudieds[i].GetWordsUkr();
            Count = 0;
        }
        public void WriteToFile(DirectoryInfo info)
        {

            StreamWriter writer = new StreamWriter(info + "\\Learned.txt", true);
            writer.WriteLine(engWord + " - " + ukrWord );
            writer.Close();

        }
      
    }
}
