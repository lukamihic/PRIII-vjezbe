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
        public int brojac { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void PromijeniVrijednost(object dugmic)
        {
            if (dugmic is Button)
            {
                Button btn = dugmic as Button;
                if (btn.Text == "")
                {
                    if (brojac % 2 == 0)
                        btn.Text = "X";
                    else
                        btn.Text = "O";
                    brojac++;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }
    }
}
