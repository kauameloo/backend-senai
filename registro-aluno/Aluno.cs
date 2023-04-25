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
        // imprime a média final do aluno
        public void VerMediaFinal() {
            Console.WriteLine($"A média final do aluno é: {this.media}");
        }

        // verifica valor de desconto e imprime valor final da mensalidade
        public void VerMensalidade() {
            if (this.bolsista == true && this.media >= 8)
            {
                this.mensalidadeFinal = this.mensalidade * 0.5F;
            }
            else if (this.bolsista == true && this.media > 6)
            {
                this.mensalidadeFinal = this.mensalidade * 0.7F;
            }
            else
            {
                this.mensalidadeFinal = this.mensalidade;
            }

            Console.WriteLine($"O valor da sua mensalidade é: {this.mensalidadeFinal.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}