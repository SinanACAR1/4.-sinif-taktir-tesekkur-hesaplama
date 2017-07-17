using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lise_Taktir_Teşekkür_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double türkçe, mat, sosyal, fen, yabancıdil, din, görsel, muzik, fizikietkinlik, trafikg, insakhak;
                double türkçesaat, matsaat, sosyalsaat, fensaat, yabacıdilsaat, dinsaat, görselsaat, muziksaat, fizikietkinliksaat, trafikgsaat, insanhaksaat;
                double derssonuc, saatsonuc, sonuc;

                türkçe = Convert.ToDouble(textBox1.Text);
                mat = Convert.ToDouble(textBox2.Text);
                sosyal = Convert.ToDouble(textBox3.Text);
                fen = Convert.ToDouble(textBox4.Text);
                yabancıdil = Convert.ToDouble(textBox9.Text);
                din = Convert.ToDouble(textBox10.Text);
                görsel = Convert.ToDouble(textBox11.Text);
                muzik = Convert.ToDouble(textBox12.Text);
                fizikietkinlik = Convert.ToDouble(textBox17.Text);
                trafikg = Convert.ToDouble(textBox18.Text);
                insakhak = Convert.ToDouble(textBox19.Text);

                türkçesaat = 8;
                matsaat = 5;
                fensaat = 3;
                sosyalsaat = 3;
                yabacıdilsaat = 2;
                dinsaat = 2;
                görselsaat = 1;
                muziksaat = 1;
                fizikietkinliksaat = 2;
                trafikgsaat = 1;
                insanhaksaat = 2;

                türkçe = türkçe * türkçesaat;
                mat = mat * matsaat;
                sosyal = sosyal * sosyalsaat;
                fen = fen * fensaat;
                yabancıdil = yabancıdil * yabacıdilsaat;
                din = din * dinsaat;
                görsel = görsel * görselsaat;
                muzik = muzik * muziksaat;
                fizikietkinlik = fizikietkinlik * fizikietkinliksaat;
                trafikg = trafikg * trafikgsaat;
                insakhak = insakhak * insanhaksaat;

                derssonuc = türkçe + mat + sosyal + fen + yabancıdil + din + görsel + muzik + fizikietkinlik + trafikg + insakhak;
                saatsonuc = türkçesaat + matsaat + sosyalsaat + fensaat + yabacıdilsaat + dinsaat + görselsaat + muziksaat + fizikietkinliksaat + trafikgsaat + insanhaksaat;
                sonuc = derssonuc / saatsonuc;
                lblortalama.Text = sonuc.ToString();
                if (sonuc > 70 && sonuc < 80)
                { lblbelge.Text = "Tebrikler Teşekkür Belgesi Alıyorsunuz."; }
                if (sonuc > 80)
                { lblbelge.Text = "Tebrikler Taktir Belgesi Alıyorsunuz."; }
            }
            catch
            { }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            lblbelge.Text = "";
            lblortalama.Text = "0";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox2.Undo();
            textBox3.Undo();
            textBox4.Undo();
            textBox9.Undo();
            textBox10.Undo();
            textBox11.Undo();
            textBox12.Undo();
            textBox17.Undo();
            textBox18.Undo();
            textBox19.Undo();
        }
    }
}
