int[]numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe um numero inteiro: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

foreach (int item in numeros)
{
    Console.WriteLine($"O dobro de {item} é {item * 2}");
}