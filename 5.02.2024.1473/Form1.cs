using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._02._2024._1473
{
    public partial class Form1 : Form
    {
        Color renk = Color.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
        }  

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {

            Sekil sekil1 = new Sekil();
            sekil1.uzunkenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.kisakenar = Convert.ToInt32(txtSayi2.Text);
            sekil1.sekilCiz(btnSekil,renk);
            sekil1.mesajDegistir(btnSekil, txtMesaj.Text);


        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;

          
        }
    }
}
