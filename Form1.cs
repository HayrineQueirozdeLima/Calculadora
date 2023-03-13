using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btt3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btt_point_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";

        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
            
        }

        private void btt_sub_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
        }

        private void btt_mult_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
            
        }

        private void btt_divi_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
            
        }

        private void btt_Igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtResultado.Text= Convert.ToString(valor1 + valor2);
            }else if (operacao == "SUB") {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btt_C_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btt_CE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
