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
    public partial class Form1: Form
    {
        void MensagemErro()
        {
            string MsgErro = "Operação impossível";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void AtribuirOperacao(string oper)
        {
            labOper.Text = oper;
            btIgual.Enabled = true;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSoma.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSub.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btDiv.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btMult.Text);
        }

        private void numOper1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = (double)numOper1.Value; //transforma o número para double
            num2 = (double)numOper2.Value;

            if (labOper.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (labOper.Text == btSub.Text)
                resultado = num1 - num2;
            else if (labOper.Text == btDiv.Text)
            {

                if (numOper2.Text == "0")
                {
                    labResultado.Text = "Operação impossível";
                }
                else
                    resultado = num1 / num2;
            }
            else
                resultado = num1 * num2;

            labResultado.Text = resultado.ToString();
        }
    }
}
