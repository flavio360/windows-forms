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
    public partial class frmOrientacaoObejtosVeiculo : Form
    {
        public frmOrientacaoObejtosVeiculo()
        {
            InitializeComponent();
        }

        #region BOTÃO CLICK CARRO
        private void buttonCarro_Click(object sender, EventArgs e)
        {
            //declarando e instanciando o objeto carro
            Carro carro = new Carro("JEEP");

            //Preenchendo as caracteriscas nas proproiedades
            carro.Modelo = "BMW";
            carro.Ano = 2000;
            carro.Marca = textBoxCarro.Text.Trim().ToUpper();
            carro.TipoCombustivel = "Gasolina";
            carro.QntRodas = 3;
            carro.QtdPortas = 2;

            //listando no listbox
 
            listBoxVeiculos.Items.Add(" Modelo:              " + carro.Modelo);
            listBoxVeiculos.Items.Add(" Marca:               " + carro.Marca);
            listBoxVeiculos.Items.Add(" Ano:                 " + carro.Ano);
            listBoxVeiculos.Items.Add(" Tipo Combustivel:    " + carro.TipoCombustivel);
            listBoxVeiculos.Items.Add(" Quantidade Rodas:    " + carro.QntRodas);
            listBoxVeiculos.Items.Add(" Quantidade de portas:" + carro.QtdPortas);

            //vamos fazer funcionar o carro

            MessageBox.Show(carro.LigarMotor("re re re re re re re re"));
            MessageBox.Show(carro.Acelerar());
            MessageBox.Show(carro.Brecar());
            MessageBox.Show(carro.PararMotor("RUM"));
        }
        #endregion


        #region BOTÃO CLICK AVIÃO
        private void buttonAviao_Click(object sender, EventArgs e)
        {
            Aviao aviao = new Aviao("BOING");

            aviao.Ano = 2006;
            aviao.Marca = "VARIG";
            aviao.Modelo = "776";
            aviao.TipoCombustivel = "GASOLINA";
            aviao.QtnTripulantes = 6;
            aviao.QntSaidaEmergencia = 0;
            aviao.QntRodas = 2;

        }
        #endregion


        #region BOTÃO CLICK CAMINHÃO
        private void buttonCaminhao_Click(object sender, EventArgs e)
        {

        }

        private void frmOrientacaoObejtosVeiculo_Load(object sender, EventArgs e)
        {
           // listBoxTpCarroceria.SelectedIndex = -1;
        }

        private void buttonCaminhao_Click_1(object sender, EventArgs e)
        {
            //iniciando um novo objeto
            Caminhao caminhao = new Caminhao(textBoxModelo.Text);

            //atribuindo 
            caminhao.Marca = textBoxMarca.Text.Trim().ToUpper();
            caminhao.TipoCarroceria = comboBoxTpCarroceria.Text.Trim().ToUpper();
            caminhao.TipoCombustivel = comboBoxTpCombustivel.Text.Trim().ToUpper();
            caminhao.ToraMaxima = Convert.ToInt32(textBoxToraMax.Text.Trim().ToUpper());
            caminhao.QntRodas = Convert.ToInt32(textBoxQntRodas.Text.Trim().ToUpper());
            caminhao.Tipo = textBoxTipo.Text.Trim().ToUpper();


            listBoxVeiculos.Items.Add("MODELO: " + caminhao.Modelo);
            listBoxVeiculos.Items.Add("TIPO MARCA: " + caminhao.Marca);
            listBoxVeiculos.Items.Add("TIPO COMBUSTIVEL: " + caminhao.TipoCombustivel);
            listBoxVeiculos.Items.Add("QNT RODAS: " + caminhao.QntRodas);
            listBoxVeiculos.Items.Add("TIPO: " + caminhao.Tipo);
            listBoxVeiculos.Items.Add("TORA MAXIMA:  " + caminhao.ToraMaxima);
            try
            {
                if (comboBoxTpCarroceria.Text != string.Empty)
                {
                    MessageBox.Show(caminhao.Engatar(comboBoxTpCarroceria.Text));

                }
            }
            catch (Exception)
            {

                throw ;
            }
            #endregion
        }
    }
}
