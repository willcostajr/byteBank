using FastFood;

Console.WriteLine("*** Bem vindo ao seu Sistema de pedidos online! ***");
Console.WriteLine();

Pedido pedido1 = new Pedido();
pedido1.cliente = new Cliente();

pedido1.cliente.endereco = new Endereco();

pedido1.itens = new Itens();

pedido1.itens.produto1 = new Produto();

pedido1.itens.produto2 = new Produto();

pedido1.itens.produto3 = new Produto();

pedido1.exibirInformacoes();

Console.ReadKey();