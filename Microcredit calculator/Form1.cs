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
            int count = 1;
            double pile_up = 0;

            while (count <= days)
            {
                double p1 = 0.009;
                double p2 = 0.007;
                double p3 = 0.006;
                
                if (count < 6)
                {
                    pile_up = pile_up + (p1 * sum);
                    stavka = stavka + p1;  
                }
          
                if ((count > 5) && (count < 11))
                {
                    pile_up = pile_up + (p2 * sum); 
                    stavka = stavka + p2;
                }
                if (count > 10)
                {
                    pile_up = pile_up + ((p3) * sum);
                    stavka = stavka + p3;
                }
                count++;

            }
            stavka = (100*stavka / days);
            textBox5.Text = Convert.ToString(stavka);
            textBox4.Text = Convert.ToString(pile_up);
            textBox3.Text = Convert.ToString(pile_up + sum);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = Convert.ToInt32(textBox1.Text);
                if (sum > 500000) MessageBox.Show("Вы не можете превысить допустимый порог в 500 тыс.", "Ошибка", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int days = Convert.ToInt32(textBox2.Text);
                if (days > 365) MessageBox.Show("Ошибка ввода даты", "Ошибка", MessageBoxButtons.OK);
            }
            catch { }

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
