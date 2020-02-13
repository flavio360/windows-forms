using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    class RemoverCaracteresEspeciais
    {
        public  RemoverCaracteresEspeciais(string text)
        {
            text.Replace(",", "").Replace("-", "");
        }
    }
}
