using DesafioCriandoAPrimeiraClasse;

Console.WriteLine("===Bem vindo ao seu gerenciamento de produtos===");

produto produto1 = new produto();

produto1.nome = "Passatempo";
produto1.fabricante = "Nestlé";
produto1.codigo_barras = 8575485698;
produto1.valor_unitario = 2.49;
produto1.valor_compra = 1.74;
produto1.quantidade_estoque = 20;

Console.WriteLine(produto1.nome);
Console.WriteLine(produto1.fabricante);
Console.WriteLine(produto1.codigo_barras);
Console.WriteLine(produto1.valor_unitario);
Console.WriteLine(produto1.valor_compra);
Console.WriteLine(produto1.quantidade_estoque);

