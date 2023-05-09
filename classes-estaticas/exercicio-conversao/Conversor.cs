using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_conversao
{
    public class Conversor
    {
        public static float valor { get; set;}

        // METODOS

        public static float DolarParaReal(float dolar) {

            valor = dolar;
            float real = valor * 4.99f;
            return real;
        }
        public static float RealParaDolar(float real) {

            valor = real;
            float dolar = valor * 0.2f;
            return dolar;
        }
    }
}