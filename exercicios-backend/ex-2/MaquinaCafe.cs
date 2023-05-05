using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_2
{
    public class MaquinaCafe
    {
        // PROPRIEDADES
        public int acucarDisponivel { get; set; }
        public int acucarQuantidade { get; set; }

        // METODOS
        public void fazerCafe(float acucarDisponivel)
        {
            if (acucarDisponivel < 1)
            {
                Console.WriteLine($"Açucar indisponível.");
            }
            else
            {
                string opcao;
                do
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"
============================================
        Super CafeteiraTabajaras Plus++
[1] - Escolher quantidade de açucar
[2] - Quantidade padrão de açucar = 10g
=============================================
");
                    Console.ResetColor();

                    opcao = Console.ReadLine()!;

                    switch (opcao)
                    {
                        case "1":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@$"
==========================================================
- A quantidade de açucar disponível é: {acucarDisponivel}g
Informe, em gramas, a quantidade de açucar desejada.
==========================================================
                    ");
                            Console.ResetColor();
                            acucarQuantidade = int.Parse(Console.ReadLine()!);

                            if (acucarQuantidade > 40)
                            {
                                Console.WriteLine($"Vai com calma, diabete vem forte.");
                                Thread.Sleep(2000);
                            }
                            fazerCafe();
                            break;
                        case "2":
                            acucarQuantidade = 10;
                            fazerCafe();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"Opção inválida.");
                            break;
                    }
                } while (opcao != "1" && opcao != "2");
            }
        }
        public void fazerCafe()
        {
            Console.WriteLine($"Fazendo café.");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine($"Fazendo café..");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine($"Fazendo café...");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine($"Fazendo café....");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine($"O café ficou pronto..... com {acucarQuantidade}g de açucar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}