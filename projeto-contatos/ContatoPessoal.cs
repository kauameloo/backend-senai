using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_contatos
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string CPF { get; set; }

        public bool ValidarCPF(string _cpf)
        {
            CPF = _cpf;
            if (Enumerable.Count(_cpf) <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}