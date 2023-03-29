// 1- Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos. 
// Imprima o resultado no console.
Console.WriteLine($"Insira a sua idade: ");
int idade = int.Parse(Console.ReadLine());

int meses = 12 * idade;
int dias = 365 * idade;
int horas = 8766 * idade;
int minutos = 525960 * idade; 

Console.WriteLine($"Sua idade é: {idade} anos, {meses} meses, {dias} dias, {horas} horas ou {minutos} minutos.");
