using System.Globalization;
using registro_aluno;

Aluno a = new Aluno();

Console.WriteLine($"Informe seu nome: ");
a.nome = Console.ReadLine()!;

Console.WriteLine($"Informe seu curso: ");
a.curso = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade: ");
a.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu RG: ");
a.rg = (Console.ReadLine()!);

// VERIFICAÇÃO BOLSISTA
do
{
    Console.WriteLine($"Você é bolsista? s/n");
    a.opcao = char.Parse(Console.ReadLine()!);
    switch (a.opcao)
    {
        case 's':
            a.bolsista = true;
            a.opcaoValida = true;
            break;
        case 'n':
            a.bolsista = false;
            a.opcaoValida = true;
            break;
        default:
            Console.WriteLine($"Opção invalida");
            a.opcaoValida = false;
            break;
    }
} while (a.opcaoValida == false);
// ----------

Console.WriteLine($"Informe sua média final: ");
a.media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua mensalidade: ");
a.mensalidade = float.Parse(Console.ReadLine()!);


do
{  
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

=========================================
Seja bem-vindo ao SENAI CALCULATOR!
Selecione uma das seguintes operações:

[1] - VER MÉDIA FINAL DO ALUNO
[2] - VER MENSALIDADE DO ALUNO
[0] - Sair.
==========================================

");
a.opcaoMenu = int.Parse(Console.ReadLine()!);

switch (a.opcaoMenu)
{
    case 0:  
        break;

    case 1:
        a.VerMediaFinal();
        break;

    case 2:
        a.VerMensalidade();
        break;

    default:
        Console.WriteLine($"Entrada inválida. Tente novamente");
        break;
}
} while (a.opcaoMenu != 0);

