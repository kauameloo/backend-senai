// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).



// LOGIN
static bool Login(int senhaInformada)
{
    const int senha = 123456;
    bool senhaCerta;
    if (senhaInformada == senha)
    {
        senhaCerta = true;
    }
    else
    {
        senhaCerta = false;
    }
    return senhaCerta;
}

int senhaInformada;
do
{
    Console.WriteLine($"Insira a senha para acessar o menu:");
    senhaInformada = int.Parse(Console.ReadLine()!);

} while (Login(senhaInformada) == false);

Console.WriteLine($"Acesso Liberado");




// SISTEMA
Console.WriteLine(@$"
-- MENU AGÊNCIA TURISMO --
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
--------------------------");
Console.WriteLine($"Informe o serviço que deseja: ");
int opcao = int.Parse(Console.ReadLine()!);

switch (opcao)
{
    case 1:
        break;
    case 2:
        break;
    case 0:
        break;
    default:
    Console.WriteLine($"Informe uma opção válida.");
        break;
}




