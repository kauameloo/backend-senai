// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Informe um número inteiro:");
int numero = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}