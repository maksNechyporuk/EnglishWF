using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGLISH
{
  public   class NotStudiedDictionary : Dictionary
    {
      
        public NotStudiedDictionary AddWord(string words)
        {
            bool c = true;
            words = words.Trim();
            foreach (var item in words)
            {
                if (item == '-')
                {
                    c = false;
                    continue;
                }
                if (c == true)
                {
                    engWord += item;
                }
                else
                {
                    ukrWord += item;
                }

            }
            return this;
        }
       
    }
}
