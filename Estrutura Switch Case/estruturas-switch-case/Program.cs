Console.WriteLine($"Informe o número correspondente ao dia da semana - exemplo 2 para segunda");

int diaDaSemana = int.Parse(Console.ReadLine()!);

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine($"DOMINGOU");
        break;
    case 2:
        Console.WriteLine($"SEGUNDOU");
        break;
    case 3:
        Console.WriteLine($"TERÇOU");
        break;
    case 4:
        Console.WriteLine($"QUARTOU");
        break;
    case 5:
        Console.WriteLine($"QUINTOU");
        break;
    case 6:
        Console.WriteLine($"SEXTOU");
        break;
    case 7:
        Console.WriteLine($"SABADOU");
        break;

    default:
        Console.WriteLine($"O dia informado não corresponde com nenhum dia da semana.");
        break;
}

