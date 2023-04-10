int f;
int numeroAnterior = 0;
int numeroAtual = 1;


for (int i = 0; i < 20; i++)
{
    f = numeroAnterior + numeroAtual;
    Console.WriteLine(f);
    numeroAnterior = numeroAtual;
    numeroAtual = f;
}