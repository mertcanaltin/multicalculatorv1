using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//mertcanaltin 
//lastcodemaster
namespace ryDortIslemMulti
{
    public partial class dortIslemAnaForm : Form
    {
        //1. yöntem
        public bolForm bolme;
        public carpForm carp;
        public cikarForm cikar;
        public toplaForm topla;
        public dortIslemAnaForm()
        {
            InitializeComponent();
            baslat(); //cağırdım ve nesne haline getirdim   
        }
        private void baslat()
        {
            //2.aşama
            bolme = new bolForm();
            carp = new carpForm();
            cikar = new cikarForm();
            topla = new toplaForm();


            //4.işlem
            //bolme formundan a form diye bir çağrı gelirse bu sensin ana gorm
            //her forma veri aktarabiliriz değişken public olmak zorundadır 
            bolme.aform = this;
            carp.aform = this;
            cikar.aform = this;
            topla.aform = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            topla.ShowDialog();
           //toplaForm toplama = new toplaForm();
           // toplama.Show();
        }

        private void buttonCikarma_Click(object sender, EventArgs e)
        {
            cikar.ShowDialog();
          //cikarForm cikar = new cikarForm();
          //  cikar.Show();
        }

        private void buttonCarpma_Click(object sender, EventArgs e)
        {
            carp.ShowDialog();
           //carpForm carp = new carpForm();
           // carp.Show();
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            bolme.ShowDialog();

           // bolForm bol = new bolForm();
           //bol.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle", "bilgi");
            Application.Exit();
        }

        private void dortIslemAnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
