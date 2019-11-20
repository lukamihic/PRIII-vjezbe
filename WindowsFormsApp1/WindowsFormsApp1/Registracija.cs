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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Korisnik novi = new db.Korisnik()
            {
                Ime = txtFirstName.Text,
                Prezime = txtLastName.Text,
                KorisnickoIme = txtUsername.Text,
                Lozinka = txtPassword.Text,
                Admin = cbAdmin.Checked
            };
            db.DBInMemory.registrovaniKorisnici.Add(novi);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtFirstName.Text.ToLower()}.{txtLastName.Text.ToLower()}";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtFirstName.Text.ToLower()}.{txtLastName.Text.ToLower()}";
        }
        private string GeneratePass(int charNum)
        {
            string allowedChars = "asdfghjklqwertzuioyxcvbnm,.-()!#$%&/()=?*";
            Random random = new Random();
            string newPass = string.Empty;
            for (int i = 0; i < charNum; i++)
            {
                newPass += allowedChars[random.Next(0, allowedChars.Length)];
            }
            return newPass;
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            txtPassword.Text = GeneratePass(12);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            char prazanChar = new char();
            if (txtPassword.PasswordChar == prazanChar)
                txtPassword.PasswordChar = '•';
            else
                txtPassword.PasswordChar = prazanChar;
        }
    }
}
