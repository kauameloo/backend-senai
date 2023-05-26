using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fixaçao_mvc.Controller;
using fixaçao_mvc.Model;

namespace fixaçao_mvc.View
{
    public class EventoView
    {

        public EventoModel Cadastrar()
        {
            EventoModel novoEvento = new EventoModel();

            Console.WriteLine($"Informe o nome do evento: ");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a descrição do evento: ");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data do evento (dd/mm/aaa): ");
            novoEvento.Data = DateTime.Parse(Console.ReadLine());

            return novoEvento;
        }

        public void Listar(List<EventoModel> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data.ToShortDateString()}");
            }
        }

        public string DeletarProduto()
        {
            Console.WriteLine($"Informe o nome do evento: ");
            string nome = Console.ReadLine();

            return nome;
        }


        public void Menu()
        {
            EventoController controller = new EventoController();
            string opcao = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"

=========================================
            SENAI EVENTOS

[1] - Cadastrar Eventos
[2] - Remover Eventos
[3] - Listar Eventos
[0] - Sair.
==========================================

");
                Console.ResetColor();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        controller.CadastrarEvento();
                        break;

                    case "2":
                        controller.RemoverEvento();
                        break;
                    case "3":
                        controller.ListarEvento();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine($"Opção inválida.");

                        break;
                }

            } while (opcao != "0");
        }
    }
}