using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    class Aviao : Veiculo
    {
        public int QtnTripulantes { get; set; }
        public int QntSaidaEmergencia { get; set; }

        public string Decolar()
        {
            return("Decolando");
        }

        public string Aterrissar()
        {
            return ("Aterrisando");
        }

        public override string Drive()
        {
            return "Voando";    
        }

        public Aviao(String NomeModelo) : base(NomeModelo)
        {

        }

    }
}
