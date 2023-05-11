using projeto_produto_interface;

Carrinho c = new Carrinho();

// Produto p = new Produto();
// Console.WriteLine($"Código do produto: ");
// p.Codigo = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Nome do Produto: ");
// p.Nome = Console.ReadLine()!;

// Console.WriteLine($"Valor do produto: ");
// p.Preco = float.Parse(Console.ReadLine()!);

Produto p1 = new Produto(1, "GTA 5", 52.00F);
Produto p2 = new Produto(2, "Detroit Become Human", 120.5F);
Produto p3 = new Produto(3, "Forza", 100F);

c.Adicionar(p1);
c.Adicionar(p2);
c.Adicionar(p3);

c.Listar();
c.TotalCarrinho();

Console.WriteLine($"----------------------------");

Console.WriteLine($"Após a remoção de um item");
Console.WriteLine($"----------------------------");

c.Remover(p3);

c.Listar();
c.TotalCarrinho();

Console.WriteLine($"-------------------------");
Console.WriteLine($"Agora vamos atualizar um objeto: ");
Console.WriteLine($"-------------------------");

// criar objeto com dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "fifa 2023";
_novoProduto.Preco = 300f;

c.Atualizar(1, _novoProduto);

c.Listar();
c.TotalCarrinho();

