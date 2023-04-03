// Faça um programa para uma quitanda que receba o peso em kg de um alimento e calcule
//  o valor da compra
//  pré-definir o valor do kg do produto.
const float preco = 10;

Console.WriteLine($"Insira o peso do alimento: ");
float peso = float.Parse(Console.ReadLine());

float precoFinal = preco * peso;

Console.WriteLine($"O preço do produto é: {precoFinal.ToString("C")}");
