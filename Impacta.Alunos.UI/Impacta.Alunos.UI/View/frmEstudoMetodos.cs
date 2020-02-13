using System;
using System.Windows.Forms;

namespace Impacta.Alunos.UI.View
{
    public partial class frmEstudoMetodos : Form
    {
        public frmEstudoMetodos()
        {
            InitializeComponent();
        }

        private void frmEstudoMetodos_Load(object sender, EventArgs e)

        {
            
            comboBoxPessoa.DataSource = Enum.GetNames(typeof(Pessoas));
            comboBoxPessoa.SelectedIndex = -1;

            if (comboBoxPessoa.SelectedIndex == 0)
            {
                textBoxNome.Visible = true;
                maskedTextBoxCPF.Visible = true;
            }
            if  (comboBoxPessoa.SelectedIndex == 1)
            {
                maskedTextBoxCNPJ.Visible = true;
            }
                
            
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                bool retorno;

                Cliente cliente = new Cliente();

                retorno = cliente.ValidarCPF(maskedTextBoxCPF.Text);

                if (!retorno)
                {
                    throw new Exception("Verificar CPF");
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message );
            }


            
        }
    }
}
