using projeto_calculadora;

Calculadora calc = new Calculadora();

bool opcaoCerta = true;
string opcao;
do
{
    Console.WriteLine(@$"
    -----------------------------
    Informe a operação que deseja: 

    SOMAR(s) 
    MULTIPLICAR(m) 
    DIVIDIR(d) 
    SUBTRAIR(sb)
    -----------------
    ");
    opcao = (Console.ReadLine()!);

    Console.WriteLine($"Informe o primeiro numero: ");
    calc.n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"Informe o segundo numero: ");
    calc.n2 = float.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case "s":
            opcaoCerta = true;
            Console.WriteLine($"O resultado da sua operação é {calc.Somar()}");
            break;

        case "m":
            opcaoCerta = true;
            Console.WriteLine($"O resultado da sua operação é {calc.Multiplicar()}");
            break;

        case "d":
            opcaoCerta = true;
            Console.WriteLine($"O resultado da sua operação é {calc.Dividir()}");
            break;
        case "sb":
            opcaoCerta = true;
            Console.WriteLine($"O resultado da sua operação é {calc.Subtrair()}");
            break;

        default:
            Console.WriteLine($"Opção inválida.");
            opcaoCerta = false;
            break;
    }

} while (opcaoCerta == false);
