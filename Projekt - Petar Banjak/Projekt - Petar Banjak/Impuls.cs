using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___Petar_Banjak
{
    public partial class Impuls : Form
    {
        public Impuls()
        {
            InitializeComponent();
        }

        private void izracunajImpuls_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(masa.Text);
            double v = Convert.ToDouble(brzina.Text);
            //spremanje vrijednosti u varijable v i m

            double rez = m * v;
            //spremanje rezultata operacije

            double roundedRez = Math.Round(rez, 2);
            //zaokruživanje rezultata na 2 decimale

            rezultatImpuls.Text = roundedRez.ToString();
            //zapisivanje rezultata u obliku teksta

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
            //zatvaranje forme
        }

       
    }
}
