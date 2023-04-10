// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int h = 0, m = 0, idade = 0, idadeH = 0, idadeM = 0;
string genero = "";
float peso = 0;
bool respostaCerta = true;

for (int pessoas = 1; pessoas <= 3; pessoas++)
{
    do
    {
        Console.WriteLine($"Qual o seu gênero? masculino(m) / feminino(f)");
        genero = Console.ReadLine()!;

        switch (genero)
        {
            case "m":
                respostaCerta = true;
                h++;
                break;
            case "f":
                respostaCerta = true;
                m++;
                break;
            default:
                Console.WriteLine($"Resposta inválida, responda com (m / f)");
                respostaCerta = false;
                break;
        }
    } while (respostaCerta == false);

    do
    {
        Console.WriteLine($"Informe a sua idade: ");
        idade = int.Parse(Console.ReadLine()!);

        if (idade < 0 || idade > 100)
        {
            respostaCerta = false;
            Console.WriteLine($"Idade inserida é invalida.");
        }
        else
        {
            respostaCerta = true;
        }

        if (genero == "m")
        {
            idadeM += idade;
        }
        else if (genero == "h")
        {
            idadeH += idade;
        }

    } while (respostaCerta == false);

    do
    {
        Console.WriteLine($"Informe o seu peso: ");
        peso = float.Parse(Console.ReadLine()!);

        if (peso <= 0)
        {
            respostaCerta = false;
            Console.WriteLine($"Peso inválido");
        }
        else
        {
            respostaCerta = true;
        }
    } while (respostaCerta == false);
}


// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
Console.WriteLine(@$"
O total de homens: {h}
O total de mulheres: {m}
");

if(h == 0)
{
    Console.WriteLine($"A média de idade dos homens é: 0");
}
else
{
    Console.WriteLine($"A média de idade dos homens é: {idadeH/h}");
}

if(m == 0)
{
    Console.WriteLine($"A média de idade das mulheres é: 0");
}
else
{
    Console.WriteLine($"A média de idade das mulheres é: {idadeM/m}");
}