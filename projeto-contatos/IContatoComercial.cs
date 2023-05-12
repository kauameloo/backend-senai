using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_contatos
{
    public interface IContatoComercial
    {
        bool ValidarCNPJ(string _cnpj);
        
    }
}