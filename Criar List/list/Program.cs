// Crie uma classe Produto
// Com as propriedades : int Código, string Nome, float Preco

// Crie um construtor vazio
// Crie um construtor completo

// criar a lista de objetos(produtos)
using list;

// CRIA LISTA
List<Produto> produtos = new List<Produto>();

// ADICIONA PRODUTOS NA LISTA
// METODO 1
produtos.Add(
    new Produto(2563, "camiseta nike", 49.9F)
);

produtos.Add(
    new Produto(1540, "calça jeans", 79.9F)
);

// METODO 2
Produto tenisNike = new Produto(1252, "tenis nike", 59.9F);
produtos.Add(tenisNike);


// IMPRIME A LISTA
Console.WriteLine($"LISTA ANTIGA:");
foreach (var item in produtos)
{
    Console.WriteLine(@$"
Index: {produtos.IndexOf(item)}
Cód: {item.Codigo}
Nome do Produto: {item.Nome.ToUpper()}
Valor do Produto: {item.Preco:C}
");
}

// LOCALIZAR PRODUTO
Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

// SETAR A POSIÇÃO EM UMA VARIAVEL
int index = produtos.IndexOf(produtoBuscado);

// SETAR O NOVO PREÇO
produtoBuscado.Preco = 199.9F;

// REMOVER O PRODUTO DA LISTAR, A PARTIR DA POSIÇÃO(INDEX)
produtos.RemoveAt(index);

// INSERIR NOVAMENTE O PRODUTO, COM O NOVO PREÇO
produtos.Insert(index, produtoBuscado);

// IMPRIMIR LISTA NOVA
Console.WriteLine($"");
Console.WriteLine($"LISTA NOVA");
foreach (var item in produtos)
{
    Console.WriteLine(@$"
Index: {produtos.IndexOf(item)}
Cód: {item.Codigo}
Nome do Produto: {item.Nome.ToUpper()}
Valor do Produto: {item.Preco:C}
");

}


