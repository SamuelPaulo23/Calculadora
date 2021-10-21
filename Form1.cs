using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Calculadora
{
    public partial class Form1 : Form
    {
        //ArrayList valor  = new ArrayList();
        // ArrayList sinal = new ArrayList();
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        /*public void ConservadorDeNumeros(decimal valor1)
        {
            valor.Add(valor);

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }




        private void button5_Click(object sender, EventArgs e)
        {
            if(valor1 == 0)
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            }
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            //ConservadorDeNumeros(valor1);
            textBox1.Text = "";
            operacao = "SUBTRACAO";
            label1.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            }
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            //ConservadorDeNumeros(valor1);
            textBox1.Text = "";
            operacao = "SOMA";
            label1.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            }
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MULTIPLICACAO";
            label1.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            }
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "DIVISAO";
            label1.Text = "/";
        }


        private void button1_Click(object sender, EventArgs e)
        {

                valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                //ConservadorDeNumeros(valor2);

            if (operacao == "SOMA")
            {
                label1.Text = "";
                textBox1.Text = Convert.ToString(valor1 + valor2);
                
            }

            else if (operacao == "SUBTRACAO")
            {
                label1.Text = "";
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operacao == "MULTIPLICACAO")
            {
                label1.Text = "";
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }

            else if (operacao == "DIVISAO")
            {
                label1.Text = "";
                textBox1.Text = Convert.ToString(valor1 / valor2);
            }



           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (valor1 != 0)
            {
                textBox1.Text = Convert.ToString(valor1);
            }
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}

        
    

