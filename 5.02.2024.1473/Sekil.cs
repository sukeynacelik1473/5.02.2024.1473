using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._02._2024._1473
{
    internal class Sekil
    {
        public int uzunkenar { get; set; }
        public int kisakenar { get; set; }

        //parametre almayan ve değer döndürmeyen(void)
        public void KareYaz()
        {
            int sonuc = this.kisakenar * this.uzunkenar;
            MessageBox.Show( $"şeklin karasi :{sonuc}" );
        }
        

        public void sekilCiz(Button btn, Color renk)
        {
            btn.Width = this.uzunkenar;
            btn.Height = this.kisakenar;
            btn.BackColor = renk;
        }


        public void mesajDegistir(Button btn , string mesaj)
        {
            btn.Text= mesaj;
        } 
    }
}
