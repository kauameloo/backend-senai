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
        public static Marca Cadastrar()
        {
            Marca _marca = new Marca();
            Console.WriteLine($"Informe o código da marca: ");
            _marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome da marca: ");
            _marca.NomeMarca = Console.ReadLine()!;

            marcas.Add(_marca);

            return _marca;
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- MARCAS CADASTRADAS --------");
            Console.ResetColor();

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
            Console.WriteLine($"Informe o codigo da marca que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Marca marcaDelete = marcas.Find(x => x.Codigo == cod);
            marcas.Remove(marcaDelete);
            return "Marca removida!";
        }

        public static explicit operator int(Marca v)
        {
            throw new NotImplementedException();
        }
    }
}