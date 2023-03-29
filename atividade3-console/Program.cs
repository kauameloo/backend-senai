// Faça um programa que receba 5 notas de um aluno e calcule a média aritmética. 
//  Imprimir a resposta no console.
Console.WriteLine($"Insira a primeira nota: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a segunda nota: ");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a terceira nota: ");
float n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a quarta nota: ");
float n4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a quinta nota: ");
float n5 = float.Parse(Console.ReadLine());


float media = (n1 + n2 + n3 + n4 + n5) / 5;

Console.WriteLine($"A sua média é: {media}");