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
    public partial class Login : Form
    {
        public Login()
        {
            //new Splash().ShowDialog();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public int pokusaji = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtUsername.Text;
            string lozinka = txtPassword.Text;
            bool pronadjen = false;
            if(!string.IsNullOrEmpty(korisnickoIme) && !string.IsNullOrEmpty(lozinka))
            {
                foreach (var korisnik in db.DBInMemory.registrovaniKorisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    {
                        MessageBox.Show($"Welcome, {korisnik}");
                        pronadjen = true;
                        Temp temp = new Temp();
                        temp.Show();
                        this.Hide();
                    }
                }
                if (!pronadjen)
                {
                    pokusaji++;
                    MessageBox.Show($"Invalid credentials! Remaining attempts: {3-pokusaji}");
                }
                if (pokusaji == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }
    }
}
