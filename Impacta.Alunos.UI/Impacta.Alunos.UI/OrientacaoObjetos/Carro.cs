using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{

    //PARA APLICAR HERANÇA UTILIZAR " : "
    
    public class Carro : Veiculo, ICarro
    {
        #region PROPRIEDADES
        //code snippet == palavras chaves seguidos de tab + tab , exemplo, prop + tab +tab ou if + tab + tab.
        //nome propriedade letra maiuscula

        public int QtdPortas { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region METODOS
        public string Acelerar()
        {
            return "Acelerando...";
        }
        public string Brecar()
        {
            return "Parando...";
        }
        public override string Drive()
        {
            return "Dirigindo...";
        }

        public bool SalvarRegistro()
        {
            throw new NotImplementedException();
        }

        public bool DeletaRegistro()
        {
            throw new NotImplementedException();
        }
        #endregion

        //public Carro(String NomeModelo)
        //{
        //    this.Modelo = NomeModelo;
        //}


        //este metodo repassa para a base o paramentro 
        public Carro(String NomeModelo) :base(NomeModelo)
        {

        }


        #region APLICA PROPRIEDADE COMPLETA
        //private int qtdPortas;
        //public int QtdPortas
        //{
        //    get { return qtdPortas; }
        //    set { qtdPortas = value; }
        //}
        #endregion
    }
}
