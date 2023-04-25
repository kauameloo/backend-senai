
namespace atividade_celular
{
    public class Celular
    {
        // variaveis
        // cor, modelo, tamanho, ligado(booleano).
        public string? cor, modelo;
        public float tamanho;
        public bool ligado;

        // metodos
        // ligar, desligar, fazer ligação, enviar mensagem

        public void Ligar()
        {
            ligado = true;
            Console.WriteLine($"Ligando......");
            Console.WriteLine($"Seu celular está ligado");
        }

        public void Desligar()
        {
            ligado = false;
            Console.WriteLine($"Desligando.....");
            Console.WriteLine($"Seu celular está desligado");
        }
        public void FazerLigacao()
        {
            Console.WriteLine($"Informe o numero que deseja efetuar a ligação: ");
            string contato = (Console.ReadLine()!);

            Console.WriteLine($"Ligando para {contato}");
        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"Informe o numero que deseja mandar a mensagem: ");
            string contato = (Console.ReadLine()!);

            Console.WriteLine($"Digite a mensagem: ");
            string mensagem = (Console.ReadLine()!);

            Console.WriteLine($"Mensagem enviada para {contato}");
        }
    }
}