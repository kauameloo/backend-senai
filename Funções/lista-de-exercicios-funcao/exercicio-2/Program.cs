﻿//2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

static float Gasolina(float litros)
{
    float precoGasolina = 5.30f, total;
    if (litros <= 20)
    {
        total = (precoGasolina * litros) * 0.97f;
    }
    else
    {
        total = (precoGasolina * litros) * 0.94f;
    }
    return total;
}

static float Alcool(float litros)
{
    float precoAlcool = 4.90f, total;
    if (litros <= 20)
    {
        total = (precoAlcool * litros) * 0.96f;
    }
    else
    {
        total = (precoAlcool * litros) * 0.94f;
    }
    return total;
}

char combustivel;
bool escolhaCerta = true;
do
{
    Console.WriteLine($"Informe qual é o tipo de combustível. Álcool(A) ou Gasolina(G):");
    combustivel = char.Parse(Console.ReadLine()!.ToUpper());
    switch (combustivel)
    {
        case 'A':
            escolhaCerta = true;
            break;
        case 'G':
            escolhaCerta = true;
            break;
        default:
            Console.WriteLine($"Entrada inválida.");
            escolhaCerta = false;
            break;
    }
} while (escolhaCerta == false);

float valorPago = 0;
float litros;
do
{
    Console.WriteLine($"Informe quantos litros você deseja abastecer: ");
    litros = float.Parse(Console.ReadLine()!);

    if (combustivel == 'G')
    {
        valorPago = Gasolina(litros);
        escolhaCerta = true;
    }
    else if (combustivel == 'A')
    {
        valorPago = Alcool(litros);
        escolhaCerta = true;
    }
    else
    {
        Console.WriteLine($"Entrada inválida.");
        escolhaCerta = false;
    }
} while (escolhaCerta == false);

Console.WriteLine($"O valor total a ser pago é de: {valorPago.ToString("C")}");