// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Informe o dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o mês do seu aniversario: ");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o ano do seu aniversário: ");
int ano = int.Parse(Console.ReadLine()!);

if (dia > 31)
{
    Console.WriteLine($"A data é invalida. Os meses possuem apenas 31 dias.");
    
}

else if (mes > 12) {
    Console.WriteLine($"A data é invalida. Existem apenas doze meses.");
}

else if (ano > 2013) {
    Console.WriteLine($"A data é invalida. Estamos no ano de 2013.");
}

else {
    Console.WriteLine($"A data informada é valida.");
    
}





