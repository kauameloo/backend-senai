// criar método para somar 2 numeros
static float Somar(float n1, float n2)
{
    return n1 + n2;
}

// criar método para multiplicar 2 numeros
static float Multiplicar(float n1, float n2)
{
    return n1 * n2;
}

// criar método para dividir 2 numeros
static float Dividir(float n1, float n2)
{
    return n1 / n2;
}

// criar método para subtrair 2 numeros
static float Subtrair(float n1, float n2)
{
    return n1 - n2;
}


bool opcaoCerta = true;
string opcao;
float resultado;
do
{
    Console.WriteLine(@$"Informe a operação que deseja: 
    s(somar) m(multiplicar) d(dividir) sb(subtrair)");
    opcao = (Console.ReadLine()!);

    switch (opcao)
    {
        case "s":
            opcaoCerta = true;

            Console.WriteLine($"Informe dois numeros: ");
            resultado = Somar(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));


            break;
        case "m":
            opcaoCerta = true;

            Console.WriteLine($"Informe dois numeros: ");
            resultado = Multiplicar(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
            break;
        case "d":
            opcaoCerta = true;

            Console.WriteLine($"Informe dois numeros: ");
            resultado = Dividir(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
            break;
        case "sb":
            opcaoCerta = true;

            Console.WriteLine($"Informe dois numeros: ");
            resultado = Subtrair(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
            break;
        default:
            Console.WriteLine($"Opção inválida.");
            opcaoCerta = false;
            break;
    }

} while (opcaoCerta == false);

