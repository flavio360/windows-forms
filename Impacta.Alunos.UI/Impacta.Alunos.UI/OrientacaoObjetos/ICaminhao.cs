using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    interface ICaminhao
    {
        int Id { get; set; }

        string Engatar(string modoEngate);
        string Desengatar(string removerEngate);
        

    }
}
