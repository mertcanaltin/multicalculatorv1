using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryDortIslemMulti
{
    public partial class carpForm : Form
    {
        public dortIslemAnaForm aform;
        public carpForm()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tbSayi1.Text);
            double sayi2 = Convert.ToDouble(tbSayi2.Text);

            double sonuc = sayi1 * sayi2;

            tbSonuc.Text = sonuc.ToString();
            aform.lblİslem.Text = sayi1.ToString() + " + " + sayi2.ToString() + " =" + tbSonuc.Text;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
