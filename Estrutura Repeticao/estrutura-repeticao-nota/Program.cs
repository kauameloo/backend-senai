// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.



bool notaCerta = true;
do
{
    Console.WriteLine($"Informe uma nota entre 0 e 10");
    int nota = int.Parse(Console.ReadLine()!);

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine($"Valor inválido.");
        notaCerta = false;
    }
    else
    {
        Console.WriteLine($"A nota informada foi: {nota}");
        notaCerta = true;
    }

} while (notaCerta == false);