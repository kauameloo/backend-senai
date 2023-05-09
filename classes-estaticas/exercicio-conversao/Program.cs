using System.Globalization;
using exercicio_conversao;


string opcao;
do
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
            CONVERSOR DE MOEDAS

[1] - Dolar para real
[2] - Real para dolar
[0] - Encerrar sistema.
=============================================
");
    Console.ResetColor();
    opcao = Console.ReadLine()!;

    Console.Clear();

    float dinheiro;
    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Informe o valor que deseja converter: ");
            dinheiro = float.Parse(Console.ReadLine()!);

            float resultado = Conversor.DolarParaReal(dinheiro);
        System.Console.WriteLine($@"{dinheiro.ToString("C", new CultureInfo("en-US"))} convertido em reais: {resultado.ToString("C")}");
            break;
        case "2":
            Console.WriteLine($"Informe o valor que deseja converter: ");
            dinheiro = float.Parse(Console.ReadLine()!);

            float resultado2 = Conversor.RealParaDolar(dinheiro);
            System.Console.WriteLine($@"{dinheiro.ToString("C")} convertido em dólares: {resultado2.ToString("C", new CultureInfo("en-US"))}");
            break;
        case "0":
            Console.WriteLine($"Encerrando o sistema...");
            break;
        default:
            Console.WriteLine($"Opção inválida.");
            break;
    }
} while (opcao != "0");