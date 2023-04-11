string[] cars = new string [4];


// Console.WriteLine($"Informe a marca do carro 1: ");
// cars[0] = Console.ReadLine()!;

// Console.WriteLine($"Informe a marca do carro 2: ");
// cars[1] = Console.ReadLine()!;

// Console.WriteLine($"Informe a marca do carro 3: ");
// cars[2] = Console.ReadLine()!;

// Console.WriteLine($"Informe a marca do carro 4: ");
// cars[3] = Console.ReadLine()!;

for (int n = 0; n < cars.Length; n++)
{
    Console.WriteLine($"Informe o nome ou marca do {n + 1}º carro: ");
    cars[n] = Console.ReadLine()!;
}

foreach (string item in cars)
{
    System.Console.WriteLine(item);
}
