using introducao_poo;

Personagem p1 = new Personagem();

List<Personagem> nome = new List<Personagem>();
List<Personagem> idade = new List<Personagem>();
List<Personagem> armadura = new List<Personagem>();
List<Personagem> ia = new List<Personagem>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Informe o nome do Personagem :");
    p1.nome = Console.ReadLine()!;
    Console.WriteLine($"Informe a idade do Personagem :");
    p1.idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Informe a armadura do Personagem :");
    p1.armadura = Console.ReadLine()!;
    Console.WriteLine($"Informe a IA do Personagem :");
    p1.ia = Console.ReadLine()!;

}






Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}
");

p1.Atacar();
p1.Defender();
p1.RestaurarArmadura();

