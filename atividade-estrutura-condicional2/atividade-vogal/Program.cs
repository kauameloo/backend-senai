// Faça um programa que verifique se uma letra digitada é vogal ou consoante.

Console.WriteLine($"Digite uma letra do alfabeto: ");
char letra = char.Parse(Console.ReadLine()!.ToLower());

if (letra == 'a' || letra == 'e'|| letra == 'i' || letra == 'o' || letra == 'u' )
{
    Console.WriteLine($"A letra escolhida foi uma vogal!");
}
else
{
    Console.WriteLine($"A letra escolhida foi uma consoante!");
}

