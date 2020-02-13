using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Impacta.Alunos.UI
{
    class AutoVeiculo :ICadastro
    {
        private string caminho = string.Empty;

        public AutoVeiculo (string EnderecoArquivo)
        {
            caminho = EnderecoArquivo;
        }

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public short Ano { get; set; }
        public  string Marca { get; set; }
        public string Observacao { get; set; }
        public Combustiveis Combustivel { get; set; }
        public Cambios Cambio { get; set; }

        public void Gravar()
        {
            string titulo = @"PLACA;MODELO;COR;ANO;MARCA;COMBUSTÍVEL;CÂMBIO;OBSERVAÇÃO;USUÁRIO;DATA;HORÁRIO";

            string registro = string.Format(
                "{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                Placa, Modelo, Cor, Ano.ToString(), Marca, Combustivel.ToString(),
                Cambio.ToString(), Observacao.Replace(";",""),
                Environment.UserName,
                DateTime.Now.ToString("dd/MM/yyyy;HH:mm:ss"));

            bool flag = File.Exists(caminho);

            StreamWriter escritor = new StreamWriter(caminho, true);

            if (!flag)
            {
                escritor.WriteLine(titulo);
            }

            escritor.WriteLine(registro);

            escritor.Close();
           // throw new NotImplementedException();
        }

        //PAGINA 204
    }
}
