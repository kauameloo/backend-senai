namespace introducao_poo
{
    public class Personagem
    {
        // Atributos
        // Nome, idade, armadura e IA
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        // Métodos
        // Atacar, defender, restaurar armadura

        public void Atacar(){
            Console.WriteLine($"O personagem atacou !");
            
        }
        public void Defender(){
            Console.WriteLine($"O personagem Defendeu !");
            
        }
        public void RestaurarArmadura(){
            Console.WriteLine($"Armadura Restaurada !");
            
        }
    }
}