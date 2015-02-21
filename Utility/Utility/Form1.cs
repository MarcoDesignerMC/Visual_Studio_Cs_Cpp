using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public partial class Form1 : Form
    {

        char[] Out = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int[] numC;
        int next, index = 0, numeroTotale, baseNum;

        public Form1()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////
        /////////////////////////===||GRADI||===/////////////////////
        /////////////////////////////////////////////////////////////

        private void Ok1_Click(object sender, EventArgs e)
        {
            try
            {
                /////////////////////////////GIUSTI/////////////////////////////

                if (celsius.Text != "" && kelvin.Text == "" && fahrenheit.Text == "")
                {
                    double testo = Double.Parse(celsius.Text);

                    kelvin.Text = "" + (testo + 273.15);
                    fahrenheit.Text = "" + ((testo * 1.8) + 32);
                }
                else if (celsius.Text == "" && kelvin.Text != "" && fahrenheit.Text == "")
                {
                    double testo = Double.Parse(kelvin.Text);

                    celsius.Text = "" + (testo - 273.15);
                    fahrenheit.Text = "" + (((testo - 273.15) * 1.8) + 32);
                }
                else if (celsius.Text == "" && kelvin.Text == "" && fahrenheit.Text != "")
                {
                    double testo = Double.Parse(fahrenheit.Text);
                    double cel = (testo - 32) / 1.8;
                    double kel = cel + 273.15;

                    celsius.Text = "" + cel;
                    kelvin.Text = "" + kel;
                }
                /////////////////////////////SBAGLIATI/////////////////////////////

                if (celsius.Text != "" && kelvin.Text != "" && fahrenheit.Text == "")
                {
                }
                else if (celsius.Text != "" && kelvin.Text == "" && fahrenheit.Text != "")
                {
                }
                else if (celsius.Text != "" && kelvin.Text != "" && fahrenheit.Text == "")
                {
                }
                else if (celsius.Text == "" && kelvin.Text != "" && fahrenheit.Text != "")
                {
                }
                else if (celsius.Text != "" && kelvin.Text != "" && fahrenheit.Text != "")
                {
                }

                if (celsius.Text.Contains('.'))
                {
                    MessageBox.Show("It's better if you use , instead of . ", "Suggest");
                }
                if (fahrenheit.Text.Contains('.'))
                {
                    MessageBox.Show("It's better if you use , instead of . ", "Suggest");
                }
                if (kelvin.Text.Contains('.'))
                {
                    MessageBox.Show("It's better if you use , instead of . ", "Suggest");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Can't convert those simbols.", "Error");
            }
        }

        private void canc_Click(object sender, EventArgs e)
        {
            celsius.Text = "";
            kelvin.Text = "";
            fahrenheit.Text = "";
        }
        /////////////////////////////////////////////////////////////
        /////////////////////////===||BASI||===//////////////////////
        /////////////////////////////////////////////////////////////

        private void Ok2_Click(object sender, EventArgs e)
        {

            try
            {

                risultato.Text = "";
                baseNum = 0;
                string t1;
                t1 = nOrigine.Text;
                numC = new int[70];
                index = 0;
                numeroTotale = int.Parse(t1);
                baseNum = (int)baseCust.Value;

                while (numeroTotale >= 1)
                {
                    numC[index] = numeroTotale % baseNum;
                    index++;
                    numeroTotale /= baseNum;
                }

                for (index--; index >= 0; index--)
                {
                    next = numC[index];
                    risultato.Text += ("" + Out[next]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("You have to re-write numbers!", "Error");
            }

        }

        /////////////////////////////////////////////////////////////
        /////////////////////////===||VETTORI||===//////////////////////
        /////////////////////////////////////////////////////////////
        private void Ok3_Click(object sender, EventArgs e)
        {
            try{
                double Xa=0, Ya=0, Xb=0, Yb=0, cost=0;
                double Xc=0, Yc=0;
                /////////////////////
                //////CONTROLLI//////
                /////////////////////
                if (A1.Text != "") Xa = double.Parse(A1.Text);
                if (A2.Text != "") Ya = double.Parse(A2.Text);
                if (B1.Text != "") Xb = double.Parse(B1.Text);
                if (B2.Text != "") Yb = double.Parse(B2.Text);

                if (!molt.Checked && Addition.Checked)
                {
                    Xc = Xa + Xb;
                    Yc = Ya + Yb;
                    risultatoVett.Text = "Vector C = (" + Xc+ "; " + Yc + ")";

                }
                else if (molt.Checked && !Addition.Checked)
                {
                    cost = double.Parse(k.Text);
                    risultatoVett.Text = "Vector C = (" + Xa * cost + "; " + Ya * cost + ")";
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Can't convert those simbols.", "Error");
            }
        }

        private void molt_CheckedChanged(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label9.Enabled = false;
            label8.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;

            label11.Enabled = true;
            k.Enabled = true;
        }

        private void Addition_CheckedChanged(object sender, EventArgs e)
        {
            label10.Enabled = true;
            label9.Enabled = true;
            label8.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;

            label11.Enabled = false;
            k.Enabled = false;
        }

    }

}
