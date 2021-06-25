using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcredit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            double days;
             
            double stavka = 0;

            sum = Convert.ToDouble(textBox1.Text);
            days = Convert.ToDouble(textBox2.Text);
            int i = 1;
            double pile_up = 0;

            while (i <= days)
            {
                double p1 = 0.009;
                double p2 = 0.007;
                double p3 = 0.006;

                
                if (i < 6)
                {
                    pile_up = pile_up + (p1 * sum);
                    stavka = stavka + p1;  
                }
          
                if ((i > 5) && (i < 11))
                {
                    pile_up = pile_up + (p2 * sum); 
                    stavka = stavka + p2;
                }
                if (i > 10)
                {
                    pile_up = pile_up + ((p3) * sum);
                    stavka = stavka + p3;
                }
                i++;

            }
            stavka = (100*stavka / days);
            textBox5.Text = Convert.ToString(stavka);
            textBox4.Text = Convert.ToString(pile_up);
            textBox3.Text = Convert.ToString(pile_up + sum);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox2.Text);
            if (textBox2.Text != null)
                d = int.Parse(textBox2.Text);
            if (d > 365) MessageBox.Show("Ошибка ввода даты", "Ошибка", MessageBoxButtons.OK);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
