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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем строку из текстового поля
            string input = textBox1.Text;
            // Количество символов между вставленными звездочками
            int n = int.Parse(textBox2.Text);

            // Создаем новую строку с учетом вставленных звездочек
            string result = InsertStars(input, n);

            listView1.Items.Add("Вариант 7: " + result);
        }

        private string InsertStars(string input, int n)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                // Добавляем символ из исходной строки
                sb.Append(c);

                // Добавляем звездочку после каждого символа, кроме последнего
                if (c != input[input.Length - 1])
                {
                    for (int i = 0; i < n; i++)
                    {
                        sb.Append('*');
                    }
                }
            }

            return sb.ToString();
        }

        private string HexToBinary(string hexString)
        {
            StringBuilder binaryStringBuilder = new StringBuilder();

            foreach (char hexChar in hexString)
            {
                string binary = Convert.ToString(Convert.ToInt32(hexChar.ToString(), 16), 2).PadLeft(4, '0');
                binaryStringBuilder.Append(binary);
            }

            return binaryStringBuilder.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string hexString = textBox5.Text;
            string binaryString = HexToBinary(hexString);
            listView1.Items.Add("Вариант 19: " + binaryString);
        } 

        private void сПосимвольнойОбработкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void безНееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
