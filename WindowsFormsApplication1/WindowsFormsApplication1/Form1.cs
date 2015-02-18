using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int num = 0;
        int click = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Timer";
            label3.Text = "" + num;
            endB.Enabled = false;
            pauseB.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           if (num >= 0 && num < 20)
            {
                num++;
            }
            else if (num >= 20 && num < 50)
            {
                num += 5;
            }
           else if (num >= 50 && num < 100)
           {
               num += 10;
           }
           else
           {
               num += 50;
           }
           label3.Text = "" + num;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (num >= 0 && num < 20)
            {
                num--;
            }
            else if (num >= 20 && num < 50)
            {
                num -= 5;
            }
            else if (num >= 50 && num < 100)
            {
                num -= 10;

            }
            else
            {
                num -= 50;
            }
            label3.Text = "" + num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (num > 0)
            {
                button3.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                pauseB.Enabled = true;
                endB.Enabled = true;

                num--;
                label3.Text = "" + num;
            }
            else
            {
                timer.Stop();
                button3.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                pauseB.Enabled = false;
                endB.Enabled = false;

                label3.Text = "END";
            }
        }

        private void pauseB_Click(object sender, EventArgs e)
        {
            
            click++;

            Console.WriteLine("" + click);
            
            if(click%2 == 0){
                pauseB.Text = "PAUSE";
                timer.Start();
            }else{
                pauseB.Text = "START";
                timer.Stop();
                endB.Enabled = true;
                button3.Enabled = false;
                label2.Enabled = true;
                label1.Enabled = true;
            }
        }

        private void endB_Click(object sender, EventArgs e)
        {
            num = 0;
            pauseB.Enabled = false;
            endB.Enabled = false;
            button3.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Text = "" + num;

        }
    }
}
