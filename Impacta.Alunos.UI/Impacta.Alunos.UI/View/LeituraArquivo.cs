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

namespace Impacta.Alunos.UI.View
{
    public partial class LeituraArquivo : Form
    {
        public LeituraArquivo()
        {
            InitializeComponent();
        }

        private void buttonLer_Click(object sender, EventArgs e)
        {
            listBoxDadosLeitura.Items.Clear();

            string endereco = @"c:\Clientes.txt";
            try
            {
                ExisteDiretorio(endereco);


                string[] dados = new string[4];

                StreamReader leitor = CriaObjStremReader(endereco);

                CriaLinhaDelimitacao(500);

                dados = LerDados(dados, leitor);

                leitor.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        private string[] LerDados(string[] dados, StreamReader leitor, string tipoArquivo = "Clientes")
        {
     
            while (!leitor.EndOfStream)
            {
                dados = leitor.ReadLine().Split(';');
                

                if (tipoArquivo == "Clientes")
                {
                    for (int i = 0; i < dados.Length; i++)
                    {
                        listBoxDadosLeitura.Items.Add
                    (
                    dados[i].PadRight(15));
                    }
                }
                else
                {
                    string lista = string.Empty;

                    for (int i = 0; i < dados.Length; i++)
                    {
                        lista = lista +  dados[i].PadRight(15);
                    }
                        listBoxDadosLeitura.Items.Add(lista);

                    //listBoxDadosLeitura.Items.Add
                    //(
                    //dados[0].PadRight(9) +
                    //dados[1].PadRight(40) +
                    //dados[2].PadRight(12) +
                    //dados[3].PadRight(40) +
                    //dados[4].PadRight(12) +
                    //dados[5].PadRight(20) +
                    //dados[6].PadRight(22) +
                    //dados[7].PadRight(150) +
                    //dados[8].PadRight(20) +
                    //dados[9].PadRight(20) +
                    //dados[10].PadRight(10)
                    // );
                }
            }

            return dados;
        }

        #region METODOS DE EXTENSÃO
        //metodo
        private void CriaLinhaDelimitacao(int tamanho)
        {
            listBoxDadosLeitura.Items.Add(new string('-', tamanho));

        }
        //metodo
        private static StreamReader CriaObjStremReader(string endereco)
        {
            return new StreamReader(endereco);
        }
        //metodo
        private static void ExisteDiretorio(string endereco)
        {
            if (!System.IO.File.Exists(endereco))
            {
                throw new Exception("Arquivo não existe !!");
            }
        }
        #endregion



        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDadosLeitura.Items.Clear();

            string endereco = @"c:\Veiculo.txt";
            try
            {
                ExisteDiretorio(endereco);


                string[] dados = new string[11];

                StreamReader leitor = CriaObjStremReader(endereco);

                CriaLinhaDelimitacao(500);

                dados = LerDados(dados, leitor,"Veiculo");

                leitor.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
