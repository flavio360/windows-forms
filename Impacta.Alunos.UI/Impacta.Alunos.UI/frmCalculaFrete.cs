using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public partial class frmCalculaFrete : Form
    {
        public frmCalculaFrete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calcular 
        /// </summary>
        private void Calcular()
        {

            decimal valor = 0;
            decimal percent = 0;

            valor = Convert.ToDecimal(txtValor.Text);


            //percentual conforme estado
            switch (comboBoxUF.Text.ToUpper())
            {
                case "AM":
                    percent = 0.6m; break;
                case "MG":
                    percent = 0.35m; break;
                case "RJ":
                    percent = 0.3m; break;
                case "SP":
                    percent = 0.2m; break;
                default:
                    percent = 0.75m; break;



            }

            //DEVOLVE NA TELA O VALOR TEXTBOX FORMATADO

            txtValor.Text = valor.ToString("N2");

            //DEVOLVE O VALOR CALCULADO

            lblFrete.Text = percent.ToString("P1");
            labelTotal.Text = (valor * (1 + percent)).ToString("c2");
         }

        private void LimparTela()
        {
            txtCliente.Clear();
            txtValor.Clear();
            comboBoxUF.SelectedIndex = 0;
            labelTotal.Text = string.Empty;
            lblFrete.Text = string.Empty;
            txtCliente.Focus();
        }

        private void frmCalculaFrete_Load(object sender, EventArgs e)
        {
            comboBoxUF.SelectedIndex = -1;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            lblFrete.Text = string.Empty;
            labelTotal.Text = string.Empty;

            if (txtCliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome é obrigatório", "Alerta",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCliente.Focus();
                return;
            }

            else if(txtValor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Valor da compra é obrigatório", " Alerta",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return;
            }
            else if (comboBoxUF.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione um estado na lista", "Alerta",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxUF.Focus();
                return;
            }

            //chamada do método
            Calcular();
        }

        private void frmCalculaFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUF.SelectedIndex != -1)
            {
                buttonCalcular.PerformClick();
            }
        }
    }
}

