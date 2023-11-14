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
    public partial class Valna_duljina : Form
    {
        public Valna_duljina()
        {
            InitializeComponent();
        }

        private void izracunajValnu_Click(object sender, EventArgs e)
        {

            double v = Convert.ToDouble(brzina2.Text);
            double f = Convert.ToDouble(frekvencija.Text);
            //spremanje vrijednosti u varijable v i f

            double rez2 = v / f;
            //spremanje rezultata operacije

            double roundedRez2 = Math.Round(rez2, 2);
            //zaokruživanje rezultata na 2 decimale

            rezultatValna.Text = roundedRez2.ToString();
            //zapisivanje rezultata u label-u


        }

        private void back2_Click(object sender, EventArgs e)
        {
            Close();
            //zatvaranje forme
        }
    }
}
