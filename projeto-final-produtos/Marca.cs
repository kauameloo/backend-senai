using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_produtos
{
    public class Marca
    {
        // PROPRIEDADES
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro = DateTime.Now;

        public static List<Marca> marcas = new List<Marca>();

        // METODOS
        // METODO CADASTRAR DANDO CONFLITO AO JÁ EXISTIR UMA MARCA, É POSSIVEL CRIAR UMA OUTRA EM CIMA DO CÓDIGO EXISTENTE ---- FIXAR
        public Marca Cadastrar()
        {
            Marca _marca = new Marca();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- CADASTRO MARCA --------");
            Console.ResetColor();
            Console.WriteLine($"Informe o código da marca: ");
            _marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome da marca: ");
            _marca.NomeMarca = Console.ReadLine()!;

            marcas.Add(_marca);
            Console.Clear();

            return _marca;
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- MARCAS CADASTRADAS --------");
            Console.ResetColor();

            if (marcas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nenhuma marca cadastrada.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Marca item in marcas)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Nome da marca: {item.NomeMarca.ToUpper()}
Data de cadastro: {item.DataCadastro}
");
            }
            Console.ResetColor();
        }

        public string Deletar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- REMOVER MARCAS --------");
            Console.ResetColor();
            Console.WriteLine($"Informe o codigo da marca que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Marca marcaDelete = marcas.Find(x => x.Codigo == cod);
            marcas.Remove(marcaDelete);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"MARCA REMOVIDA COM SUCESSO!");
            Console.ResetColor();
            return "Marca removida!";
        }
    }
}