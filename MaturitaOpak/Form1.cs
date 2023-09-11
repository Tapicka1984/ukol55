using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaturitaOpak
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<int> neco = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                int N = int.Parse(textBox1.Text);
                Random rng = new Random();
                neco.Clear();
                listBox1.Items.Clear();
                for (int x = 0; x < N; x++)
                {
                    int cislo = rng.Next(-6, 100);
                    neco.Add(cislo);
                }
                vypis(neco);
            }
        }

        void vypis(List<int> neco)
        {
            foreach (int i in neco)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            smazani(neco);
        }

        void smazani(List<int> neco)
        {
            foreach(int cislo in neco)
            {
                if((cislo == 6)|| (cislo == 28))
                {
                    neco.Remove(cislo);
                }
            }
            int max = 0;
            vypis(neco, max);
        }

        void vypis(List<int> neco, int max)
        {
            foreach (int i in neco)
            {
                listBox2.Items.Add(i);
            }
            foreach (int X in neco)
            {
                if(X > max)
                {
                    max = X;
                }
            }
            MessageBox.Show("nejvetsi cislo je " + max);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            neco.Sort();
            vypis3(neco);
        }

        void vypis3(List<int> neco)
        {
            foreach(int X in neco)
            {
                listBox3.Items.Add(X);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pocet_cisel = 0;
            int soucet = 0;
            foreach(int Y in neco)
            {
                pocet_cisel++;
                soucet =+ Y;
            }
            MessageBox.Show("Aritmeticky prumer cisel je:" + soucet / pocet_cisel);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
