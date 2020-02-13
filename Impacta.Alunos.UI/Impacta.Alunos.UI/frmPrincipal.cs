using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impacta.Alunos.UI.View;

namespace Impacta.Alunos.UI
{
    public partial class frmPrincipal : Form
    {
        //quadno executa o processo de instanciação com a  palavra new, estamos tamebm
        //executando o contrutor da classe que foi instanciada. 
        //o metodo construtor é o unico metodo que tem o mesmo nome 
        //da classe e não há nenhum tipo de retorno.

        public frmPrincipal(string nome)
        {
            //inicializa os componentes visuais 
            // SE CASO PRECISAR PROGRAMAR ALGO NO METODO CONSTRUTOR
            //deve fazer após o método initializaComponente()

            InitializeComponent();

            //local inicio para programacao construtor

            tssUsuario.Text = nome.ToUpper();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDaraHora.Text = DateTime.Now.ToString();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }

        private void laboratório4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCalculaFrete().ShowDialog();
        }

        private void laboratório5Cap1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formCalculadoraTabuada().ShowDialog();
        }

        private void exemploHerançaEPolimorfismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOrientacaoObejtosVeiculo().ShowDialog();
        }

        private void laboratório7Cap1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLab7().ShowDialog();
        }

        private void laboratório8Cap2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LeituraArquivo().ShowDialog();
        }

        private void estudoMetodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEstudoMetodos().ShowDialog();
        }
    }
}
