// Receber dados no console para adicionar 2 objetos em uma listar
// Exibir os dois objetos da lista no console

using atividade_list;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a marca do carro:");
    carro.Marca = Console.ReadLine()!;

    Console.WriteLine($"Informe a cor do carro: ");
    carro.Cor = Console.ReadLine()!;

    carros.Add(carro);
}

foreach (var item in carros)
{
Console.WriteLine(@$"
{carros.IndexOf(item) + 1}) Marca do carro: {item.Marca}
Cor do carro: {item.Cor}
");
}
