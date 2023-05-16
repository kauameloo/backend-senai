using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_produtos
{
    public class Usuario
    {
        // PROPRIEDADES
        int Codigo { get; set; }
        string Nome { get; set; }
        string Email { get; set; }
        string Senha { get; set; }
        DateTime DataCadastro = DateTime.Now;

        // METODS
        public string Cadastrar()
        {
            Usuario user = new Usuario();
            return "Usuário cadastrado!";
        }
    }
}