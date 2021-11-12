using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox2.Text;
            string groups = textBox3.Text;
            int v = Convert.ToInt32(textBox4.Text);
            ycheniki p = new ycheniki();
            p.FIO = FIO;
            p.group = groups;
            p.ocenka = v;
            listBox1.Items.Add(p);
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Слушай я видимо тупой бот или же ты не можешь выбрать обьект?!");
            }
            else 
            {
                int k = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(k);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Слушай я видимо тупой бот или же ты не можешь выбрать обьект?!");
            }
            else 
            {
                int k = listBox1.SelectedIndex;
                ycheniki p = listBox1.Items[k] as ycheniki;
                textBox2.Text = p.FIO;
                textBox3.Text = p.group;
                textBox4.Text = p.ocenka.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            ycheniki p = listBox1.Items[k] as ycheniki;
            p.FIO = textBox2.Text;
            p.group = textBox3.Text;
            p.ocenka = Convert.ToInt32(textBox4.Text);
            listBox1.Items[k] = p;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i=0; i<listBox1.Items.Count; i++) 
            {
                ycheniki p = listBox1.Items[i] as ycheniki;
                sum += p.ocenka;
            }
            MessageBox.Show((sum*1.0/ listBox1.Items.Count).ToString());
        }
    }
}
