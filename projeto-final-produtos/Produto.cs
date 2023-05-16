using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        DateTime DataCadastro = DateTime.Now;
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();

    }
}