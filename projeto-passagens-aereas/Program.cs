// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

using System.Globalization;

class Program
{
    // DEFINIDA ARRAYS E VARIAVEIS GLOBAIS
    static string[] nome = new string[5];
    static string[] origem = new string[5];
    static string[] destino = new string[5];
    static DateTime[] data = new DateTime[5];

    static int passagens = 0;



    // FUNÇÕES
    // FUNÇÃO DE LOGIN
    static bool Login(int senhaInformada)
    {
        const int senha = 123456;
        bool senhaCerta;
        if (senhaInformada == senha)
        {
            senhaCerta = true;
        }
        else
        {
            System.Console.WriteLine($"Senha incorreta, insira novamente.");
            senhaCerta = false;
        }
        return senhaCerta;
    }

    // FUNÇÃO CADASTRO
    static void Cadastro()
    {
        bool aceitoCadastro = true;
        do
        {
            System.Console.WriteLine(@$"Informe o nome do(a) {passagens + 1}º passageiro(a):");
            nome[passagens] = Console.ReadLine()!;

            System.Console.WriteLine(@$"Informe a origem do(a) {passagens + 1}º passageiro(a):");
            origem[passagens] = Console.ReadLine()!;

            System.Console.WriteLine(@$"Informe o destino do(a) {passagens + 1}º passageiro(a):");
            destino[passagens] = Console.ReadLine()!;


            System.Console.WriteLine(@$"Informe a data do voo (Ex > 12/04/2023):");
            string dataString = Console.ReadLine()!;
            data[passagens] = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            passagens++;

            Console.WriteLine($"Deseja cadastrar outra passagem? S/N ");
            char novoCadastro = char.Parse(Console.ReadLine()!.ToLower());
            switch (novoCadastro)
            {
                case 's':
                    aceitoCadastro = true;
                    break;

                case 'n':
                    aceitoCadastro = false;
                    break;

                default:
                    System.Console.WriteLine($"Opção inválida.");
                    break;
            }
        } while (aceitoCadastro == true && passagens < 5);

    }

    // FUNÇÃO DE LISTAR PASSAGEM
    static void ListarPassagem()
    {
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine(@$"
    --- {i + 1}º PASSAGEIRO ---
    nome: {nome[i]}
    origem: {origem[i]}
    destino: {destino[i]}
    data do voo: {data[i].ToString("dd/MM/yyyy")}
    ---------------------------
    ");
        }
    }

    // PROGRAMA PRINCIPAL
    static void Main(string[] args)
    {
        int senhaInformada;
        do
        {
            Console.WriteLine($"Insira a senha para acessar o menu:");
            senhaInformada = int.Parse(Console.ReadLine()!);

        } while (Login(senhaInformada) == false);

        Console.WriteLine($"Acesso Liberado");

        // MENU DO SISTEMA
        int opcao = 1;
        while (opcao != 0 && opcao != 2)
        {
            Console.WriteLine(@$"
-- MENU AGÊNCIA TURISMO --
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
--------------------------");

            Console.WriteLine($"Informe o serviço que deseja: ");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                // CADASTRO DE PASSAGEM
                case 1:
                    Cadastro();
                    break;

                // LISTAR PASSAGENS
                case 2:
                    ListarPassagem();
                    break;

                // SAIR DO MENU
                case 0:
                    System.Console.WriteLine($"Você saiu do menu.");
                    break;

                // OPÇÃO INVÁLIDA
                default:
                    Console.WriteLine($"Informe uma opção válida.");
                    break;
            }
        }
    }
}