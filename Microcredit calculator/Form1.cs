using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Microcredit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string writePath = @"C:\Users\201911\Documents\save.txt";
        double sum;
        double days;

        private void button1_Click(object sender, EventArgs e)
        {
            
            
             
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

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("День - " + count + " | Ставка - " + p1 * 100 + "%" + " | % (накопительно) - " + pile_up + " | Сумма Выплат -" + (stavka * 10000 + sum));
                    }
                }
          
                if ((count > 5) && (count < 11))
                {
                    pile_up = pile_up + (p2 * sum); 
                    stavka = stavka + p2;

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("День - " + count + " | Ставка - " + p2 * 100 + "%" + " | % (накопительно) - " + pile_up + " | Сумма Выплат -" + (stavka * 10000 + sum));
                    }
                }
                if (count > 10)
                {
                    pile_up = pile_up + ((p3) * sum);
                    stavka = stavka + p3;

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("День - " + count + " | Ставка - " + p3 * 100 + "%" + " | % (накопительно) - " + pile_up + " | Сумма Выплат -" + (stavka * 10000 + sum));
                    }
                }
                count++;

            }
            stavka = (100*stavka / days);
            textBox5.Text = Convert.ToString(stavka);
            textBox4.Text = Convert.ToString(pile_up);
            textBox3.Text = Convert.ToString(pile_up + sum);
            Process.Start(@"C:\Users\201911\Documents\save.txt");

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
