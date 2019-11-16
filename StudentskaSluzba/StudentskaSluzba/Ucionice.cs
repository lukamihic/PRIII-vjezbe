using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class Ucionice : Form
    {
        public Ucionice()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Baza.AddUcionica(new Ucionica() { Naziv = txtNaziv.Text, Zauzeto = cbZauzet.Checked });
            MessageBox.Show($"{txtNaziv.Text} je dodana!");
        }
    }
}
