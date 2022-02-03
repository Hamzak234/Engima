using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, ayuzde, byuzde, cyuzde, dyuzde, toplam;
            a = Convert.ToInt16(textBox2.Text);
            b = Convert.ToInt16(textBox3.Text);
            c= Convert.ToInt16(textBox4.Text);
            d = Convert.ToInt16(textBox5.Text);
            toplam = a + b + c + d;
            ayuzde = (a  / toplam * 100);
            byuzde = (b  / toplam * 100);
            cyuzde = (c  / toplam * 100);
            dyuzde = (d  / toplam * 100);
            progressBar2.Value = Convert.ToInt16(ayuzde);
            progressBar3.Value = Convert.ToInt16(byuzde);
            progressBar4.Value = Convert.ToInt16(cyuzde);
            progressBar5.Value = Convert.ToInt16(dyuzde);

        }
    }
}
