using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_15;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Задание 1";

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Задание 2";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            statusStrip1.Items[1].Text = "Дата: " + now.Day + "." + now.Month + "." + now.Year;
            statusStrip1.Items[2].Text = "Время: " + now.Hour + ":" + now.Minute;
        }

        private void рассчитатьЗадание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBox1.Text, out int x))
            {
                int y = Lib_15.Task.Task1(x);
                textBox2.Text = y.ToString();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Х должен быть целым числом");
            }
        }

        private void рассчитатьЗадание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox4.Text, out int a) && Int32.TryParse(textBox5.Text, out int b))
            {
                int ab = Lib_15.Task.Task2(a, b);
                textBox3.Text = ab.ToString();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("A b должны быть целыми числами");
            }
        }
        // задание 2
        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        // задание 2
        private void чтоВводитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A b должны быть целыми числами. Программа расчитает количество отрезков B, размещенных на отрезке A без наложений.");

        }
        // задание 1
        private void сбросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        // задание 1
        private void чтоВводитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Х должен быть целым числом. Программа рассчитает значение функции y = 3·x6 – 6·x2 – 7 при данном значении x.");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 1:" +
                "\nПрограмма рассчитает значение функции y = 3·x6 – 6·x2 – 7 при данном значении x." +
                "Задание 2:" +
                "\nПрограмма расчитает количество отрезков B, размещенных на отрезке A без наложений.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
