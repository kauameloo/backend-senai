// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"Informe o seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe valor total gasto: ");
float totalGasto = float.Parse(Console.ReadLine()!);

if (totalGasto > salario)
{
    Console.WriteLine($"Orçamento estourado.");
}
else
{
    Console.WriteLine($"Gastos dentro do orçamento.");
}

