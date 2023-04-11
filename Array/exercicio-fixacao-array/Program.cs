// exercicio de fixação
// escreva um programa que receba e imprima o nome e idade de 5 pessoas
// personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

// exemplo de exibição

// 1) nome: Carlos
// idade: 36 anos

// 2) nome: Eduardo
// idade: 40 anos

// 3) nome: Allan
// idade: 30 anos

string[] nome = new string[5];
int[] idade = new int[5];
int cont = 1;

for (int p = 0; p < nome.Length; p++)
{
    Console.WriteLine($"Informe o {p + 1}º nome: ");
    nome[p] = Console.ReadLine()!;

    Console.WriteLine($"Informe a {p + 1}º idade: ");
    idade[p] = int.Parse(Console.ReadLine()!);
}

for (int p = 0; p < nome.Length; p++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"{cont++}) nome: {nome[p]}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idade[p]} \n");
    Console.ResetColor();

}
