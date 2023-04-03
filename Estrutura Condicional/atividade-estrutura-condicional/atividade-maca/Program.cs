// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

Console.WriteLine($"Informe a quantidade de maçãs desejada: ");
int quantidadeMaca = int.Parse(Console.ReadLine()!);

if (quantidadeMaca < 12)
{
    Console.WriteLine($"O valor total da compra é: {(quantidadeMaca * 0.30).ToString("C")}");
}
else
{
    Console.WriteLine($"O valor total da compra é: {(quantidadeMaca * 0.25).ToString("C")}");
    
}
