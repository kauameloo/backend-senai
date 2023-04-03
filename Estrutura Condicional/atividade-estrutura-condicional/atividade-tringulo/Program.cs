// Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno. 
// Sendo que:    
// − Triângulo Equilátero: possui os 3 lados iguais.
// − Triângulo Isóscele: possui 2 lados iguais.
// − Triângulo Escaleno: possui 3 lados diferentes.

Console.WriteLine($"Informe o lado A do triangulo: ");
float ladoA = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o lado B do triangulo: ");
float ladoB = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o lado C do triangulo: ");
float ladoC = float.Parse(Console.ReadLine()!);


if (ladoA == ladoB && ladoA == ladoC)
{
    Console.WriteLine($"O triangulo é equilátero.");
}
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC )
{
    Console.WriteLine($"O triangulo é isósceles.");
}
else
{
    Console.WriteLine($"O triangulo é escaleno.");
}


