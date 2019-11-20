using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.db;

namespace WindowsFormsApp1
{
    public partial class Korisnici_admin : Form
    {
        public Korisnici_admin()
        {
            InitializeComponent();
            dgwKorisnici.AutoGenerateColumns = false;
        }

        private void Korisnici_admin_Load(object sender, EventArgs e)
        {
            dgwKorisnici.DataSource = db.DBInMemory.registrovaniKorisnici;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Registracija reg = new Registracija();
    
            if(reg.ShowDialog()  == DialogResult.OK)
            {
                MessageBox.Show("Korisnik dodan");
                dgwKorisnici.DataSource = null;
                dgwKorisnici.DataSource = db.DBInMemory.registrovaniKorisnici;
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string imePrezime = txtPretraga.Text;
            List<db.Korisnik> rezultati = new List<db.Korisnik>();
            foreach (var korisnik in db.DBInMemory.registrovaniKorisnici)
            {
                if (korisnik.Ime.ToLower().Contains(imePrezime) || korisnik.Prezime.ToLower().Contains(imePrezime))
                    rezultati.Add(korisnik);
            }
            dgwKorisnici.DataSource = null;
            dgwKorisnici.DataSource = rezultati;
        }

        private void dgwKorisnici_MouseClick(object sender, MouseEventArgs e)
        {
            /*Korisnik k = dgwKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            MessageBox.Show(k.ToString());*/
        }
    }
}
