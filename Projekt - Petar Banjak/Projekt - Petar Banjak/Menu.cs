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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //izlaz iz formi
        }

        private void impuls_Click(object sender, EventArgs e)
        {
            new Impuls().Show();
            //otvaranje nove forme "Impuls"
        }

        private void valnaDuljina_Click(object sender, EventArgs e)
        {
            new Valna_duljina().Show();
            //otvaranje nove forme "Valna duljina"
        }
    }
}
