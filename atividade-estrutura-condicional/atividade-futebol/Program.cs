// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Informe a quantidade de gols do time A: ");
int timeA = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a quantidade de gols do time B: ");
int timeB = int.Parse(Console.ReadLine()!);

if (timeA == timeB)
{
    Console.WriteLine($"O resultado foi empate.");
}
else if (timeA > timeB)
{
    Console.WriteLine($"A vitória foi do time A.");
}
else
{
    Console.WriteLine($"A vitória foi do time B");
}

