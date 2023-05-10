using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_list
{
    public class Carro
    {
        // PROPRIEDADES
        public string Marca { get; set;}
        public string Cor { get; set;}

        // CONSTRUTORES
        public Carro() {}

        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }
    }
}