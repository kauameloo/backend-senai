using ex_1;

Elevador e = new Elevador();

e.totalAndares = 9;
e.capacidade = 5;

e.Inicializa(e.capacidade, e.totalAndares);

string opcao;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
                ELEVADOR
[1] - Subir.
[2] - Descer.
[3] - Entrar no elevador.
[4] - Sair do elevador.
[0] - Sair do menu.
=============================================
");
    Console.ResetColor();

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            e.Subir();
            break;
        case "2":
            Console.Clear();
            e.Descer();
            break;
        case "3":
            Console.Clear();
            e.Entrar();
            break;
        case "4":
            Console.Clear();
            e.Sair();
            break;
        case "0":
            Console.WriteLine($"Saindo do menu...");
            break;
        default:
            Console.WriteLine($"Opção invalida.");
            break;
    }
} while (opcao != "0");



