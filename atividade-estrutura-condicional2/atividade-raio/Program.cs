// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Informe o raio da circunferência: ");
double r = double.Parse(Console.ReadLine()!);

double d = 2 * r;
double c = 2 * Math.PI * r;
double a = Math.PI * Math.Pow(r,2);


Console.WriteLine(@$"
------------------------------------
A partir do raio da circunferência /
foi calculado os seguintes valores /
                                   /
Diâmetro: {Math.Round(d,2)}
Comprimento: {Math.Round(c,2)}
Área: {Math.Round(a,2)}
------------------------------------
");
