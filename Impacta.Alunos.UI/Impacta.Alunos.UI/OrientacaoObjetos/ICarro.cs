using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    public interface ICarro
    {
        int Id { get; set; }

        bool SalvarRegistro();
        bool DeletaRegistro(); 
    }
}
