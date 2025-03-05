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

                private void ButIgual_Click(object sender, EventArgs e)
        {
            string erro = "Erro";
            double num1, num2, resultado = 0;
            num1= (double)NumOper1.Value;
            num2= (double)NumOper2.Value;

            if(LblOper. Text == Btsoma.Text) 
                resultado = num1 + num2;
            else if (LblOper. Text == Btsubt.Text) 
                resultado = num1 - num2;
            else if (LblOper.Text == Btmult.Text)
                resultado = num1 * num2;
            else
            {
                if (NumOper2.Text != "0")
                    resultado = num1 / num2;
                else
                    LbResultado.Text = erro;
                return;
            }
            LbResultado.Text = resultado.ToString();
        }

        private void BtSeguir_Click(object sender, EventArgs e)
        {
            NumOper1.Text = LbResultado.Text;
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            NumOper1.Value = 0;
            NumOper2.Value = 0;
           LbResultado.Text = "0";
           
        }
    }
}
