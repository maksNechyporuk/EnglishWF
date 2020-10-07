using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ENGLISH
{
    public partial class ShowDictionary : Form
    {
        List<NotStudiedDictionary> notStudiedList = new List<NotStudiedDictionary>();
       
        public ShowDictionary()
        {
            InitializeComponent();
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
                notStudiedList.RemoveAt(0);
            }
        }
        private void ShowDictionary_Load(object sender, EventArgs e)
        {
           int  i = 1;
          

            foreach (var item in notStudiedList)
            {
                WordGV.Rows.Add(i, item.GetWordsEng(), item.GetWordsUkr());

                
                i++;
            }
        }
      
        private void FindButton_Click(object sender, EventArgs e)
        {
            
          
                for (int k = 0; k < WordGV.RowCount; k++)
                    {
                        WordGV.Rows[k].Selected = false;
                for (int j = 0; j < WordGV.ColumnCount; j++)
                    if (WordGV.Rows[k].Cells[j].Value != null)
                        if (WordGV.Rows[k].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            WordGV.Rows[k].Selected = true;
                            
                            WordGV.Rows[k].DefaultCellStyle.BackColor = Color.Red;
                                break;
                                }

                    }       
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

      
    }
}
