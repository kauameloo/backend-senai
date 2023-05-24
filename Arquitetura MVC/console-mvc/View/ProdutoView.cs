using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using console_mvc.Model;

namespace console_mvc.View
{
    public class ProdutoView
    {
        // método para exibir os dados da lista no console

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:C}");


            }
        }
    }
}