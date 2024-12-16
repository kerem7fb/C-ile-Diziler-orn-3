using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[10];
        Random rast = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = sayilar.Sum().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rast.Next(0, 100);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = sayilar.First().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = sayilar.Last().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = sayilar.Average().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox8.Text = sayilar.Min().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = sayilar.Max().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = sayilar.Length.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox4.Text = sayilar.Rank.ToString();
        }
    }
}
