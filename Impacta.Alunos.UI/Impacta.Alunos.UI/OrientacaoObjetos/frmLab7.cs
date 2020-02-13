using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Impacta.Alunos.UI
{
    public partial class frmLab7 : Form
    {
        public frmLab7()
        {
            InitializeComponent();
        }

        private void frmLab7_Load(object sender, EventArgs e)
        {
            comboBoxCambio.DataSource = Enum.GetNames(typeof(Cambios));
            comboBoxCambio.SelectedIndex = -1;

            comboBoxCombustivel.DataSource = Enum.GetNames(typeof(Combustiveis));
            comboBoxCombustivel.SelectedIndex = -1;

            comboBoxMarca.DataSource = Enum.GetNames(typeof(Marcas));
            comboBoxMarca.SelectedIndex = -1;

            comboBoxMarca.Items.Clear();

            //System.IO.StreamReader leitor =
            //       new System.IO.StreamReader(@"C:\Marcas.txt");
            //while (!leitor.EndOfStream)
            //{
            //    comboBoxMarca.Items.Add(leitor.ReadLine());
            //}
            //leitor.Close();

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //CRIAR NOVO OBJETO
                AutoVeiculo carro = new AutoVeiculo(
                    @"C:\Veiculo.txt");

                carro.Placa = textBoxPlaca.ValidarVazio().ValidarPlaca();
                carro.Marca = comboBoxMarca.ValidarCombo();
                carro.Cor = textBoxCor.ValidarVazio();
                carro.Modelo = textBoxModelo.ValidarVazio();
                carro.Ano = textBoxAno.ValidarInt16().ValidarAno();
                carro.Observacao = textBoxObservacao.ValidarVazio();
                carro.Combustivel = (Combustiveis)comboBoxCombustivel.ValidarComboEnum();

                //Fazendo CAST
                carro.Cambio = (Cambios)comboBoxCambio.ValidarComboEnum();
                //Chamar o método gravar do veículo
                carro.Gravar();
                //Avisar o usuário
                MessageBox.Show("Veículo gravado com sucesso!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.LimparTela();
                textBoxPlaca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxObservacao_TextChanged(object sender, EventArgs e)
        {
            try
            {

                labelContaCaractere.Text =
                    "Restante: " +
                    (300 - textBoxObservacao.TextLength).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLab7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Passar a propriedade KeyPreview do formulário para TRUE
            if (e.KeyChar == 27)
            {
                this.LimparTela();
            }
        }
    }
}
