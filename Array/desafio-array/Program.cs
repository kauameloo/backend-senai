// Fa;a um programa que  carregue um array de tamanho 6 com n[umeros inteiros. Calcule e imprima a quantidade de numeros impares e a quantidade de numeros pares]

int[]numeros = new int[6];
int par = 0, impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe um numero inteiro: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
{
    par++;
}
else
{
    impar++;
}
}

Console.WriteLine($"Dos numeros informados {par} numeros são pares e {impar} são impares.");
