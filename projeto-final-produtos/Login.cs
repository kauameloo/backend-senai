using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_produtos
{
    public class Login
    {
        public bool Logado { get; set; }

        // METODOS
        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();
            string opcao;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
--------- MENU ---------
[1] - Cadastrar produto
[2] - Listar produtos
[3] - Remover produto
------------------------
[4] - Cadastrar marca
[5] - Listar marca
[6] - Remover marca
------------------------
[0] - Sair
------------------------
");
                Console.ResetColor();

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        produto.Cadastrar();
                        break;
                    case "2":
                        Console.Clear();
                        produto.Listar();
                        break;
                    case "3":
                        Console.Clear();
                        produto.Deletar();
                        break;
                    case "4":
                        Console.Clear();
                        marca.Cadastrar();
                        break;
                    case "5":
                        Console.Clear();
                        marca.Listar();
                        break;
                    case "6":
                        Console.Clear();
                        marca.Deletar();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Desligando programa...");
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"OPÇÃO INVÁLIDA!");
                        Console.ResetColor();
                        Console.WriteLine($"Pressione ENTER para tentar novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcao != "0");



        }

        public void Logar(Usuario user)
        {
            Console.Clear();
            string opcao;
            do
            {
            Menu:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
------ APLICAÇÃO SENAI ------
=============================
Escolha uma opção:
[1] Login
[2] Cadastro
[0] Sair
=============================
");
                Console.ResetColor();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"-------- LOGIN --------");
                        Console.ResetColor();

                        Console.WriteLine($"Digite seu email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine($"Digite sua senha: ");
                        string password = Console.ReadLine();

                        if (Usuario.usuarios.Any(x => x.Email == email) && Usuario.usuarios.Any(x => x.Senha == password))
                        {
                            this.Logado = true;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Login efetuado com sucesso!");
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            this.Logado = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"EMAIL OU SENHA INCORRETOS!");
                            Console.ResetColor();
                            Console.WriteLine($"Pressione ENTER para tentar novamente.");
                            Console.ReadKey();
                            Console.Clear();
                            goto Menu;
                        }


                    case "2":
                        Console.Clear();
                        user.Cadastrar();
                        Console.Clear();
                        goto Menu;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Encerrando aplicativo...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"OPÇÃO INVÁLIDA!");
                        Console.ResetColor();
                        Console.WriteLine($"Pressione ENTER para tentar novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcao != "1" && opcao != "2" && opcao != "0");

        }

        public string Deslogar()
        {
            Logado = false;
            return "Usuário deslogado.";
        }

    }
}