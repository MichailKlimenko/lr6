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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = textBox10.Text;
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxDigitsCount = 0;
            string wordWithMaxDigits = "";

            foreach (string word in words)
            {
                int digitsCount = word.Count(char.IsDigit);
                if (digitsCount > maxDigitsCount)
                {
                    maxDigitsCount = digitsCount;
                    wordWithMaxDigits = word;
                }
            }

            listView1.Items.Add($"Вариант 7: Слово(-а) с максимальным количеством цифр: {wordWithMaxDigits}, количество цифр: {maxDigitsCount}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string input = textBox8.Text;
            int k = int.Parse(textBox9.Text);

            string result = RemoveKthCharacter(input, k);
            listView1.Items.Add("Вариант 19: " + result);
        }

        private string RemoveKthCharacter(string input, int k)
        {
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] modifiedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (k <= words[i].Length && k > 0)
                {
                    modifiedWords[i] = words[i].Remove(k - 1, 1);
                }
                else
                {
                    modifiedWords[i] = words[i];
                }
            }

            return string.Join(" ", modifiedWords);
        }
    }
}
