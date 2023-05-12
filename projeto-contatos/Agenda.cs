using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_contatos
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            string opcao = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"

=========================================
        ADICIONAR CONTATO

[1] - Contato Comercial
[2] - Contato Pessoal
[0] - Sair.
==========================================

");
                switch (opcao)
                {
                    case "1":
                        
                        Console.WriteLine($"Informe o nome do contato:");
                        _contato.Nome = (Console.ReadLine()!);

                        Console.WriteLine($"Informe o telefone do contato: ");
                        _contato.Telefone = (Console.ReadLine()!);

                        Console.WriteLine($"Informe o email do contato: ");
                        _contato.Email = (Console.ReadLine()!);

                        break;

                    case "2":
                        Console.WriteLine($"Informe o nome do contato:");
                        _contato.Nome = (Console.ReadLine()!);

                        Console.WriteLine($"Informe o telefone do contato: ");
                        _contato.Telefone = (Console.ReadLine()!);

                        Console.WriteLine($"Informe o email do contato: ");
                        _contato.Email = (Console.ReadLine()!);

                        break;

                    default:
                        break;
                }

            } while (opcao != "0");
        }

        public void Listar()
        {
            foreach (var item in contatos)
            {
                Console.WriteLine(@$"
                {contatos.IndexOf(item) + 1}) Nome: {item.Nome}
                Telefone: {item.Telefone}
                Email: {item.Email}
                ");

            }
        }
    }
}