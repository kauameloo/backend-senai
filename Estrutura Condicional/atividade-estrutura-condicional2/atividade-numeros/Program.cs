// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Informe o primeiro numero: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero: ");
int n3 = int.Parse(Console.ReadLine()!);


// ESTRUTURA NUMERO MAIOR
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"O numero maior é: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"O numero maior é: {n2}");
}
else
{
    Console.WriteLine($"O numero maior é: {n3}");
}
// 


// ESTRUTURA NUMERO MENOR
if (n1 < n2 && n1 < n3)
{
    Console.WriteLine($"O numero menor é: {n1}");
}
else if (n2 < n1 && n2 < n3)
{
    Console.WriteLine($"O numero menor é: {n2}");
}
else
{
    Console.WriteLine($"O numero menor é: {n3}");
}
// 