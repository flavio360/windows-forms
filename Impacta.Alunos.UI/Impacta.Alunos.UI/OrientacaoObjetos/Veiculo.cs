using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    public class Veiculo  //clase base ou classe pai. serve de modelo para as demais.
    {
        //especializacao e generalizacao
        //generalizacao , tudo que for comum entre os obejtos deve ficar em uma classe base.(classe pai)
        //especializacao = o que é esclusivo da classe
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int QntRodas { get; set; }
        public string TipoCombustivel { get; set; }
        public int Ano { get; set; }

        //CODE SNIPT PARA CONSTRUTOR : CTOR + TAB + TAB
        public Veiculo(string Modelo)
        {
            //sempre que for usar this esta informando 
            //ao .net que esta referenciando algo definido
            //dentro da sua classe.
            this.Modelo = Modelo;
        }


        public string LigarMotor(string ruidoAfazerAoIniciar)
        {
            return string.Format("Ligando o motor: {0}", ruidoAfazerAoIniciar);
        }

        public string PararMotor(string ruidoAfazerAoParar)
        {
            return string.Format("Desligando o motor: {0}", ruidoAfazerAoParar);
        }

        public virtual string Drive()
        {
            return ("Implementação Padrão do metodo Drive");
        }

    }
}
