using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //değişkenler
        int vize;
        int final;
        float ort;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            vize = int.Parse(VizeT.Text); //vize girdisini alır
            final = int.Parse(FinalT.Text); //final girdisini alır
            float vizeYuzdeKırk = (vize * 40 / 100); 
            float finalYuzdeAltmis = (vize * 60 / 100);
            ort = vizeYuzdeKırk + finalYuzdeAltmis; //ortalama
            Ortalama.Text = ort.ToString(); //ortalamayı yazar
            //harf notları
                if (ort < 40) { HOrt.Text = "FF"; }
                if (ort >= 40 && ort < 50)  { HOrt.Text = "FD"; }
                if (ort >= 50 && ort < 60)  { HOrt.Text = "DD"; }
                if (ort >= 60 && ort < 70)  { HOrt.Text = "DC"; }
                if (ort >= 75 && ort < 80)  { HOrt.Text = "CC"; }
                if (ort >= 80 && ort < 85)  { HOrt.Text = "CB"; }
                if (ort >= 85 && ort < 90)  { HOrt.Text = "BB"; }
                if (ort >= 70 && ort < 75)  { HOrt.Text = "BA"; }
                if (ort >= 90 && ort < 100) { HOrt.Text = "AA"; }
        }
    }
}
