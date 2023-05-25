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
        public Usuario CadastradoPor = new Usuario();
        public static List<Produto> produtos = new List<Produto>();

        // METHODS
        public void Cadastrar()
        {
            Console.Clear();
            Produto _produto = new Produto();
        Codigo:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- CADASTRO PRODUTO --------");
            Console.ResetColor();

            Produto codigoExistente;

            Console.WriteLine($"Informe o código do produto: ");
            _produto.Codigo = int.Parse(Console.ReadLine()!);

            codigoExistente = Produto.produtos.Find(x => x.Codigo == _produto.Codigo);
            if (codigoExistente != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O codigo informado já existe! Tente novamente");
                Console.ResetColor();
                goto Codigo;
            }

            Console.WriteLine($"Informe o nome do produto: ");
            _produto.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o valor do produto: ");
            _produto.Preco = float.Parse(Console.ReadLine()!);

            Marca marcaExistente;
            string opcao;
            do
            {
            InfMarca:
                Console.WriteLine($"Informe o código da marca: ");
                int codigoMarca = int.Parse(Console.ReadLine()!);

                marcaExistente = Marca.marcas.Find(x => x.Codigo == codigoMarca);
                if (marcaExistente != null)
                {
                    _produto.Marca = marcaExistente;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"MARCA NÃO ENCONTRADA!");
                    Console.ResetColor();
                MenuMarca:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@$"
------------- MENU -------------
[1] - Cadastrar nova marca
[2] - Informar marca existente
--------------------------------
");
                    Console.ResetColor();
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Clear();

                            Marca m = new Marca();
                            m.Cadastrar();
                            Console.Clear();
                            break;

                        case "2":
                            Console.Clear();
                            goto InfMarca;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"OPÇÃO INVÁLIDA!");
                            Console.ResetColor();
                            Console.WriteLine($"Pressione ENTER para tentar novamente.");
                            Console.ReadKey();
                            Console.Clear();
                            goto MenuMarca;
                    }
                }
            } while (marcaExistente == null);


            _produto.Usuario = new Usuario();

            produtos.Add(_produto);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto cadastrado com sucesso!");
            Console.ResetColor();


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
Marca: {item.Marca.NomeMarca.ToUpper()}
Nome do produto: {item.NomeProduto.ToUpper()}
Valor do produto: {item.Preco:C}
Data de cadastro: {item.DataCadastro}
Cadastrado por: {item.CadastradoPor.Nome}
");
            }
            Console.ResetColor();
        }
        public string Deletar()
        {
            if (produtos.Any() != false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"-------- REMOVER PRODUTOS --------");
                Console.ResetColor();

                Console.WriteLine($"Informe o codigo do produto que deseja remover: ");
                int cod = int.Parse(Console.ReadLine()!);

                Produto produtoDelete = produtos.Find(x => x.Codigo == cod);
                produtos.Remove(produtoDelete);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PRODUTO REMOVIDO COM SUCESSO!");
                Console.ResetColor();
                return "Produto removido!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"NÃO HÁ NENHUM PRODUTO PARA SER REMOVIDO.");
                Console.ResetColor();
                return "Não há nenhum produto para ser removido!";

            }


        }


    }
}
