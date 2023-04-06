// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.


bool infoCerta = true;
do
{
    Console.WriteLine($"Informe o usuário: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine($"Informe sua senha: ");
    string senha = Console.ReadLine()!;

    if (nome == senha)
    {
        Console.WriteLine($"Sua senha não pode ser igual ao seu usuário.");
        infoCerta = false;
    }
    else
    {
        Console.WriteLine($"Informações registradas.");
        infoCerta = true;
    }
} while (infoCerta == false);

