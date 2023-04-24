using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_calculadora
{
    public class Calculadora
    {
        // Atributos
        public float n1, n2;
        // Métodos

        public float Somar() {
            return this.n1 + this.n2;
        }

        public float Subtrair() {
            return this.n1 - this.n2;
        }

        public float Multiplicar() {
            return this.n1 * this.n2;
        }

        public float Dividir() {
            return this.n1 / this.n2;
        }
    }
}