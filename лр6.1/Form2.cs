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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            string result = RemoveNonDigits(input);
            listView1.Items.Add("Вариант 7: " + result);
        }

        private string RemoveNonDigits(string input)
        {
            string result = new string(input.Where(char.IsDigit).ToArray());
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = textBox4.Text;
            string result = RemoveBetweenDigits(input);
            listView1.Items.Add("Вариант 19: " + result);
        }

        private string RemoveBetweenDigits(string input)
        {
            int firstDigitIndex = -1;
            int lastDigitIndex = -1;

            // Находим индекс первой цифры
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    firstDigitIndex = i;
                    break;
                }
            }

            // Находим индекс последней цифры
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    lastDigitIndex = i;
                    break;
                }
            }

            // Если не найдены цифры, возвращаем исходную строку
            if (firstDigitIndex == -1 || lastDigitIndex == -1)
                return input;

            // Возвращаем строку без символов между первой и последней группами цифр
            return input.Substring(0, firstDigitIndex + 1) + input.Substring(lastDigitIndex);
        }
    }
}
