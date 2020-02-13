﻿using System;

using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public class PessoaBase
    {
        private bool valida;
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string LocalNascimento { get; set; }
        public string CPF { get; set; }

        public bool ValidarCPF(string txt)
        {

             txt = txt.RemoverCaracteres();

             char[] digiCPF = new char[10];

             int regressivo = 10; 
             int conta = 0;
             int soma = 0;
             string validaCPF = string.Empty;
             
             digiCPF = txt.ToCharArray();

            #region Trata o primeiro digito
            for (int i = 0 ; i < 9; i++ )
             {
                 conta = regressivo * Convert.ToInt32(digiCPF[i]-'0'); 
                 regressivo--;
                 soma = soma + conta;
             }

             conta = soma % 11;
             soma = 11 - conta;

            if (soma >= 10)
            {
                digiCPF[10] = '0';
            }
            else
            {
                digiCPF[9] = Convert.ToChar(Convert.ToString(soma));
            }
            
            #endregion


             regressivo = 11;
             soma = 0;
             conta = 0;

             for (int i = 0; i < 10; i++)
             {
                conta = regressivo * Convert.ToInt32(digiCPF[i] - '0');
                regressivo--;
                soma = soma + conta;
             }

             conta = soma % 11;
             soma = 11 - conta;

            if (soma >= 10)
            {
                digiCPF[10] = '0';
            }
            else
            {
                digiCPF[10] = Convert.ToChar(Convert.ToString(soma));
            }

            regressivo = 11;

            for (int i = 0; i < regressivo; i++)
            {
                validaCPF = validaCPF + digiCPF[i];
                
            }


             if (txt == validaCPF)
             {
                return true;
             }

            return false;
        }
    }
}





