// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int pessoas = 0, naoH = 0, naoM = 0, homem = 0, mulher = 0, simH = 0, simM = 0, sim = 0, nao = 0;
string p1 = "";
string p2 = "";
bool respostaCerta = true;

for (pessoas = 1; pessoas <= 10; pessoas++)
{

    do
    {
        Console.WriteLine($"Qual o seu gênero? masculino(m) / feminino(f)");
        p2 = Console.ReadLine()!;

        switch (p2)
        {
            case "m":
                respostaCerta = true;
                homem++;
                break;
            case "f":
                respostaCerta = true;
                mulher++;
                break;
            default:
                Console.WriteLine($"Resposta inválida, responda com (m / f)");
                respostaCerta = false;
                break;
        }

    } while (respostaCerta == false);

    do
    {
        Console.WriteLine($"Você gostou do nosso novo lançamento? sim(s) / não(n)");
        p1 = Console.ReadLine()!;

        switch (p1)
        {
            case "s":
                respostaCerta = true;
                sim++;
                if (p2 == "m")
                {
                    simH++;
                }
                else if (p2 == "f")
                {
                    simM++;
                }
                break;
            case "n":
                respostaCerta = true;
                nao++;
                if (p2 == "m")
                {
                    naoH++;
                }
                else if (p2 == "f")
                {
                    naoM++;
                }
                break;
            default:
                Console.WriteLine($"Resposta inválida, responda com (s / n)");
                respostaCerta = false;
                break;
        }
        break;
    } while (respostaCerta == false);
}


Console.WriteLine(@$"
Número de pessoas que responderam SIM: {sim}
Número de pessoas que responderam NAO: {nao}
Número de mulheres que responderam SIM: {simM}
Homens que responderam NAO entre os homens: {(100 * (homem - simH)) / homem}
");





