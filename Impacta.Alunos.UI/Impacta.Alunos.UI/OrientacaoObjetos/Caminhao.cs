using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Impacta.Alunos.UI
{
    class Caminhao : Veiculo, ICaminhao
    {
        public string TipoCarroceria { get; set; }
        public int ToraMaxima { get; set; } //tora = peso maximo
        public string Tipo { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Caminhao(string nomeModelo) : base(nomeModelo)
        {

        }


        public string Engatar(string modoEngate)
        {
            try
            {
                if (modoEngate == "CAÇAMBA")
                {
                    return "ENGATE INTEGRADO A CARROÇERIA, PROCESSO ANULADO";
                }
                else if (string.IsNullOrEmpty(modoEngate))
                {
                    return "VAZIO";
                }
                else
                {
                    return "ENGATE PRONTO PARA ACOMPLAR";
                }

                
            }
            catch (Exception)
            {

               
            }
            throw new NotImplementedException();
        }

        public string Desengatar(string removerEngate)
        {
            throw new NotImplementedException();
        }
    }
}
