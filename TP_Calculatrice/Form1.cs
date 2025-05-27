using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 8;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = txtvaleur.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtvaleur.Text = "";
        }
        int operation;
        float valeur1;
        float valeur2;

        private void button14_Click(object sender, EventArgs e)
        {
            operation = 1;
            string a = txtvaleur.Text;
            float.TryParse(a, out valeur1);
            txtvaleur.Text = ""; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                string b = txtvaleur.Text;
                float.TryParse (b, out valeur2);
                float a = valeur1 - valeur2;
                txtvaleur.Text = ("" + a);
            } else if (operation == 2)
            {
                string b = txtvaleur.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 + valeur2;
                txtvaleur.Text = ("" + a);
            }
            else if (operation == 3)
            {
                string b = txtvaleur.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 * valeur2;
                txtvaleur.Text = ("" + a);
            }
            else if (operation == 4)
            {
                string b = txtvaleur.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 / valeur2;
                txtvaleur.Text = ("" + a);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = 2;
            string a = txtvaleur.Text;
            float.TryParse(a, out valeur1);
            txtvaleur.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = 3;
            string a = txtvaleur.Text;
            float.TryParse(a, out valeur1);
            txtvaleur.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = 4;
            string a = txtvaleur.Text;
            float.TryParse(a, out valeur1);
            txtvaleur.Text = "";
        }
    }
}
