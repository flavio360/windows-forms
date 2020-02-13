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
    public partial class formCalculadoraTabuada : Form
    {
        public formCalculadoraTabuada()
        {
            InitializeComponent();
        }

        //Definir o método CalcularTabuada()

        private void CalcularTabuada()
        {
            listBoxResultado.Items.Clear();

            int tabuada = Convert.ToInt32(textBoxTabuada.Text);

            for (int i = 0; i <= 10; i++)
            {
                listBoxResultado.Items
                    .Add(tabuada + " X " + i + " = " +
                    (tabuada * i).ToString("#,##0"));
            }

            textBoxTabuada.Focus();
            textBoxTabuada.SelectAll();
        }


        //Metodo Limpartela

        private void LimparTela()
        {
            textBoxTabuada.Clear();
            listBoxResultado.Items.Clear();
            textBoxTabuada.Focus();
        }

        private void textBoxTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas numeros
            if (
                e.KeyChar >= '0' && e.KeyChar <= '9'  ||
                e.KeyChar == '\b' || e.KeyChar =='\r'
                )
            {
                //pressiona enter e cchama o metodo
                if (e.KeyChar == '\r')
                {
                    CalcularTabuada();
                    listBoxResultado.Focus();
                }
            }
            //anula a tecla digitada
            else
            {
                e.KeyChar = '\0';
            }
        }

        private void CalculadoraTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }

        private void listBoxResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }
    }
}
