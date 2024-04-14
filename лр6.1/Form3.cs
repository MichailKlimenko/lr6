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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = textBox7.Text;
            string result = RemoveNonDigitsr(input);
            listView1.Items.Add("Вариант 7: " + result);
        }

        private string RemoveNonDigitsr(string input)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox6.Text;
            string result = RemoveBetweenDigitsr(input);
            listView1.Items.Add("Вариант 19: " + result);
        }

        private string RemoveBetweenDigitsr(string input)
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

            // Формируем строку без символов между первой и последней группами цифр
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i <= firstDigitIndex || i >= lastDigitIndex || char.IsDigit(input[i]))
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }
    }
}
