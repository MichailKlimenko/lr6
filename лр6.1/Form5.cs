using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр6._1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string input = textBox12.Text;
            char c1 = textBox13.Text[0];
            char c2 = textBox14.Text[0];

            string result = ReplaceCharacters(input, c1, c2);
            listView1.Items.Add("Вариант 7: " + result);
        }

        private string ReplaceCharacters(string input, char c1, char c2)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == c1)
                {
                    charArray[i] = c2;
                }
            }

            return new string(charArray);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = textBox11.Text;
            string substring = textBox15.Text;

            int index = FindSubstring(input, substring);

            if (index != -1)
            {
                listView1.Items.Add($"Вариант 19: Позиция первого вхождения подстроки: {index}");
            }
            else
            {
                listView1.Items.Add("Вариант 19: Подстрока не найдена");
            }
        }

        private int FindSubstring(string input, string substring)
        {
            return input.IndexOf(substring);
        }
    }
}
