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
    public partial class Temp : Form
    {
        delegate void SlanjePoruka(string sadrzaj);
        event SlanjePoruka SMSNotifikacije;
        public Temp()
        {
            InitializeComponent();
            
        }
        void BHTelecom(string poruka)
        {
            MessageBox.Show("BHTelecom -> " + poruka);
        }
        void HTEronet(string poruka)
        {
            MessageBox.Show("HTEronet -> "+poruka);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(SMSNotifikacije != null)
                SMSNotifikacije?.Invoke("Danas nema nastave!");
        }

        private void cbBHTelecom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBHTelecom.Checked)
                SMSNotifikacije += BHTelecom;
            else
                SMSNotifikacije -= BHTelecom;
        }

        private void cbHTEronet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHTEronet.Checked)
                SMSNotifikacije += HTEronet;
            else
                SMSNotifikacije -= HTEronet;
        }
        delegate int Kalkulacija(int broj);
        class MathUtil
        {
            public static int Calc(Kalkulacija calc, params int[] brojevi)
            {
                int suma = 0;
                for (int i = 0; i < brojevi.Length; i++)
                {
                    suma += calc(brojevi[i]);
                }
                return suma;
            }
        }
    }
}
