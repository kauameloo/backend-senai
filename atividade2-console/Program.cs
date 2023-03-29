// 2- Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.
Console.WriteLine($"Insira seu ano de nascimento: ");
int nascimento = int.Parse(Console.ReadLine());

var data = DateTime.Now;

int anos = data.Year - nascimento;
int semanas = anos * 52;

Console.WriteLine($"Sua idade é {anos} anos ou {semanas} semanas.");

