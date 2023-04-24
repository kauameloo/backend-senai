using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace registro_aluno
{
    public class Aluno
    {
        // variaveis
        public string? nome, curso, rg;
        public int idade, opcaoMenu;
        public bool bolsista, opcaoValida;
        public float media, mensalidade, mensalidadeFinal;
        public char opcao;

        // metodos
        public void VerMediaFinal() {
            Console.WriteLine($"A média final do aluno é: {media}");
        }

        public void VerMensalidade() {
            if (bolsista == true && media >= 8)
            {
                mensalidadeFinal = mensalidade * 0.5F;
            }
            else if (bolsista == true && media > 6 && media < 8)
            {
                mensalidadeFinal = mensalidade * 0.7F;
            }
            else
            {
                mensalidadeFinal = mensalidade * 1;
            }

            Console.WriteLine($"O valor da sua mensalidade é: {mensalidadeFinal.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}