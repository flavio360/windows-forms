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
    public partial class frmLogin : Form
    {

        //para fechar as classes CTRL + M + O para abrir CTRL + M + L
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //fechar frm de login

            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() != string.Empty)
            {
                //executa validação de senha
                if (txtSenha.Text != string.Empty)
                {
                    if (txtUsuario.Text == "flopes" && txtSenha.Text == "1a")
                    {
                        MessageBox.Show("WELCOME TO HELL");

                        //esconde o frm
                        this.Hide();

                        //estancia a classe no novo objeto

                        new frmPrincipal(txtUsuario.Text).Show();
                    }
                    else
                        MessageBox.Show("USUÁRIO OU SENHA INVÁLIDOS");
                    LimparCampos();

                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("DIGITE A SENHA");
                    txtSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("DIGITE UM USUÁRIO");
                //FOCO CAMPO
                txtUsuario.Focus();
            }

        }

        private void LimparCampos()
        {
            //forma 1 
            //txtSenha.Text = "";
            //txtUsuario.Text = "";

            txtSenha.Clear();
            txtUsuario.Clear();

            //txtSenha.Text = string.Empty;
            //txtUsuario.Text = string.Empty;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            MudaCorFundo(txtUsuario);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            MudaCorFundo(txtUsuario);
        }

        /// <summary>
        /// metodo que muda o background do txtbox
        /// </summary>
        /// <param name="txt">sera utilizado como referencia para troca a cor de fund odeste controle</param>
        private void MudaCorFundo(TextBox txt)
        {
            if (txt.BackColor != Color.LightYellow)
            {
                txt.BackColor = Color.LightYellow;
            }
            else
            {
                txt.BackColor = Color.Empty;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            MudaCorFundo(txtSenha); 
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            MudaCorFundo(txtSenha);
        }
    }
}
