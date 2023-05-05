using ex_2;

MaquinaCafe c = new MaquinaCafe();
c.acucarDisponivel = 50;

string opcao;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
        Super CafeteiraTabajaras Plus++
[1] - Café com açucar
[2] - Café sem açucar
[0] - Sair do menu.
=============================================
");
    Console.ResetColor();

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            c.fazerCafe(c.acucarDisponivel);
            break;
        case "2":
            Console.Clear();
            c.fazerCafe();
            break;
        case "0":
            Console.WriteLine($"Saindo do menu...");
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção invalida.");
            break;
    }
} while (opcao != "0");