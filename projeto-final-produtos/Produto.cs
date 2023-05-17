using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_produtos
{
    public class Produto
    {
        // PROPRIEDADES
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        DateTime DataCadastro = DateTime.Now;
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();
        List<Produto> produtos = new List<Produto>();

        // METHODS
        public void Cadastrar()
        {
            Produto _produto = new Produto();
            Console.WriteLine($"Informe o código do produto: ");
            _produto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome do produto: ");
            _produto.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o valor do produto: ");
            _produto.Preco = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o código da marca: ");
            int codigoMarca = int.Parse(Console.ReadLine()!);

            Marca marcaExistente = Marca.marcas.Find(x => x.Codigo == codigoMarca);
            if (marcaExistente != null)
            {
                _produto.Marca = marcaExistente;
            }
            else
            {
                Console.WriteLine($"Marca não encontrada. Cadastre uma nova ou insira uma existente");
            }

            _produto.Usuario = new Usuario();

            produtos.Add(_produto);

        }
        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- PRODUTOS CADASTRADOS --------");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in produtos)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Marca: {item.Marca.NomeMarca}
Nome do produto: {item.NomeProduto.ToUpper()}
Valor do produto: {item.Preco:C}
Data de cadastro: {item.DataCadastro}
");
            }
            Console.ResetColor();
        }
        public string Deletar()
        {
            Console.WriteLine($"Informe o codigo do produto que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Produto produtoDelete = produtos.Find(x => x.Codigo == cod);
            produtos.Remove(produtoDelete);
            return "Produto removido!";
        }


    }
}