//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));

bool nomeCerto = true;
string nome = "";
do
{
    Console.WriteLine($"Informe seu nome: ");
    nome = Console.ReadLine()!;

    if (nome == "")
    {
        nomeCerto = false;
        Console.WriteLine($"Seu nome não pode ser vazio!");
    }
    else
    {
        nomeCerto = true;
    }
} while (nomeCerto == false);



bool idadeCerta = true;
int idade = 0;
do
{
    Console.WriteLine($"Informe sua idade: ");
    idade = int.Parse(Console.ReadLine()!);

    if (idade <= 0 || idade > 100)
    {
        idadeCerta = false;
        Console.WriteLine($"Idade informada inválida.");
    }
    else
    {
        idadeCerta = true;
    }

} while (idadeCerta == false);



bool salarioCerto = true;
double salario = 0;
do
{
    Console.WriteLine($"Informe seu salário: ");
    salario = double.Parse(Console.ReadLine()!);

    if (salario <= 0)
    {
        salarioCerto = false;
        Console.WriteLine($"Salário informado inválido!");
    }
    else
    {
        salarioCerto = true;
    }
} while (salarioCerto == false);



bool civilCerto = true;
char ecivil = '0';
string nomeCivil = "";
do
{
    Console.WriteLine(@$"Informe seu estado civil: 
s = SOLTEIRO(A)
c = CASADO(A)
v = VIÚVO(A)
d = DIVORCIADO(A)
");
    ecivil = char.Parse(Console.ReadLine()!.ToLower());

    switch (ecivil)
    {
        case 's':
            nomeCivil = "Solteiro(a)";
            civilCerto = true;
            break;
        case 'c':
            nomeCivil = "Casado(a)";
            civilCerto = true;
            break;
        case 'v':
            nomeCivil = "Viúvo(a)";
            civilCerto = true;
            break;
        case 'd':
            nomeCivil = "Divorciado(a)";
            civilCerto = true;
            break;
        default:
            Console.WriteLine($"Escolha inválida!");
            civilCerto = false;
            break;
    }

} while (civilCerto == false);


Console.WriteLine(@$"
------ Dados Informados ------
Nome: {char.ToUpper(nome[0]) + nome.Substring(1)}
Idade: {idade}
Salário: {salario.ToString("C")}
Estado Civil: {nomeCivil}
------------------------------
");






