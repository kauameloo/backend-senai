using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_1
{
    public class Elevador
    {
        // PROPRIEDADES
        public int andar { get; set; } = 0;
        public int totalAndares { get; set; } // ANDARES CONTANDO COM O TÉRREO:
        public int capacidade { get; set; } // CAPACIDADE DE PESSOAS DENTRO DO ELEVADOR
        public int pessoas { get; set; } = 0; // QUANTIDADE DE PESSOAS DENTRO DO ELEVADOR

        // METODOS

        public void Inicializa(int capacidade, int totalAndares)
        {
            Console.WriteLine($"A capacidade do elevador é de {capacidade} pessoas e o prédio tem {totalAndares} andares.");
        }

        public void Entrar()
        {
            // para acrescentar uma pessoa no elevador(só deve acrescentar se ainda houver espaço);
            if (pessoas < capacidade)
            {
                pessoas++;
                Console.WriteLine(@$"
                Uma pessoa entrou no elevador!
                Há {pessoas} pessoas dentro do elevador
                ");
            }
            else
            {
                Console.WriteLine($"O elevador está cheio!");
            }
        }

        public void Sair()
        {
            // para remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);
            if (pessoas >= 2)
            {
                pessoas--;
                Console.WriteLine(@$"
                Uma pessoa saiu do elevador!
                Há {pessoas} pessoas dentro do elevador
                ");
            }
            else
            {
                pessoas = 0;
                Console.WriteLine($"Não há pessoas dentro do elevador.");
            }
        }
        public void Subir()
        {
            // para subir um andar (não deve subir se já estiver no último andar);
            if (andar <= totalAndares)
            {
                andar++;
                Console.WriteLine($"Você subiu um andar e agora está no {andar}º andar");
            }
            else
            {
                Console.WriteLine($"Você ja está no último andar!");
            }


        }
        public void Descer()
        {
            // para descer um andar (não deve descer se já estiver no térreo);
            if (andar >= 2)
            {
                andar--;
                Console.WriteLine($"Você desceu um andar e agora está no {andar}º andar");
            }
            else
            {
                andar = 0;
                Console.WriteLine($"Você ja está no TÉRREO");
            }

        }
    }
}