using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGLISH
{
    abstract public class Dictionary
    {

        protected string engWord { get; set; }
        protected string ukrWord { get; set; }

        public void Swap()
        {
            string t = engWord;
            engWord = ukrWord;
            ukrWord = t;
        }
        public string GetWordsEng()
        {
            return engWord;
        }
        public string GetWordsUkr()
        {
            return ukrWord;
        }

    }
}
