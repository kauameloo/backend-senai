using atividade_celular;

Celular c = new Celular();

Console.WriteLine($"Informe o modelo do seu celular: ");
c.modelo = Console.ReadLine()!;

Console.WriteLine($"Informe a cor do seu celular: ");
c.cor = Console.ReadLine();

Console.WriteLine($"Informe o tamanho do seu celular: ");
c.tamanho = float.Parse(Console.ReadLine()!);



Console.WriteLine(@$"
--- SENAI PHONE ---
1 - Ligar
2 - Desligar
");

int escolha = int.Parse(Console.ReadLine()!);

switch (escolha)
{
    case 1:
        c.Ligar();

        do
        {
            Console.WriteLine(@$"

=========================================
MENU SENAI PHONE
Selecione uma opção:

[1] - Fazer uma ligação
[2] - Mandar uma mensagem
[0] - Desligar celular
==========================================

");
            escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    c.FazerLigacao();
                    break;
                case 2:
                    c.EnviarMensagem();
                    break;
                case 0:
                    c.Desligar();
                    break;
                default:
                    Console.WriteLine($"Opção invalida");
                    break;
            }
        } while (escolha != 0);

        break;

    case 2:
        c.Desligar();
        break;

    default:
        Console.WriteLine($"Opção invalida");
        break;
}


