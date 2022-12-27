
namespace FastFood
{
    public class Pedido
    {
        public Cliente cliente;
        public int numeroPedido;
        public double valorPedido;
        public Itens itens;
        

        public bool exibirInformacoes()
        {
            //método para exibir informações do pedido
            Console.WriteLine();
            Console.WriteLine("== Informações do pedido ==");
            Console.WriteLine();
            Console.WriteLine("Número do pedido: " + numeroPedido);
            if (cliente != null)
            {
                Console.WriteLine("Cliente: " + cliente.nome);
                Console.WriteLine("CPF: " + cliente.cpf);
                Console.WriteLine("e-mail: " + cliente.email);
                Console.WriteLine("Endereço: Rua/Avenida {0}, número {1}, \nbairro {2}, cidade {3}" +
                    ", cep {4}", cliente.endereco.rua, cliente.endereco.numero, cliente.endereco.bairro,
                    cliente.endereco.cidade, cliente.endereco.cep);
            }
            else
                Console.WriteLine("Campo cliente está nulo.");
            Console.WriteLine();
            if (itens != null)
            {
                Console.WriteLine("* Itens pedidos *");
                Console.WriteLine();
                Console.WriteLine("Item 1: " + itens.produto1.descricao);
                Console.WriteLine("Código do produto: " + itens.produto1.codigoProduto);
                Console.WriteLine("Quantidade: " + itens.produto1.quantidade);
                Console.WriteLine("Valor Total: R$ " + itens.produto1.valorUnitario * itens.produto1.quantidade);
                Console.WriteLine();
                Console.WriteLine("Item 2: " + itens.produto2.descricao);
                Console.WriteLine("Código do produto: " + itens.produto2.codigoProduto);
                Console.WriteLine("Quantidade: " + itens.produto2.quantidade);
                Console.WriteLine("Valor Total: R$ " + itens.produto2.valorUnitario * itens.produto2.quantidade);
                Console.WriteLine();
                Console.WriteLine("Item 3: " + itens.produto3.descricao);
                Console.WriteLine("Código do produto: " + itens.produto3.codigoProduto);
                Console.WriteLine("Quantidade: " + itens.produto3.quantidade);
                Console.WriteLine("Valor Total: R$ " + itens.produto3.valorUnitario * itens.produto3.quantidade);
                Console.WriteLine();
                valorPedido = itens.produto1.valorUnitario * itens.produto1.quantidade +
                    itens.produto2.valorUnitario * itens.produto2.quantidade +
                    itens.produto3.valorUnitario * itens.produto3.quantidade;
                Console.WriteLine("==========================================");
                Console.WriteLine("Valor total do pedido: R$ " + valorPedido);
            }
            else
                Console.WriteLine("Campo itens está nulo.");

            return true;
        }
    }
}
