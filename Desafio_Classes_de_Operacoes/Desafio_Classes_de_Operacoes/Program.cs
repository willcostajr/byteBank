
using Desafio_Classes_de_Operacoes.basicas;

int opcao;
double a, b;
var x = 0;
while (x == 0)
{
    Console.Write("Informe o primeiro valor: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    b = double.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Escolha a operação desejada: " +
        "\n[1] Somar" +
        "\n[2] Subtrair" +
        "\n[3] Multiplicar" +
        "\n[4] Dividir");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Soma soma = new Soma();
            Console.WriteLine("{0} + {1} = {2}", a, b, soma.Somar(a, b));
            break;
        case 2:
            Subtracao subtracao = new Subtracao();
            Console.WriteLine("{0} - {1} = {2}", a, b, subtracao.Subtrair(a, b));
            break;
        case 3:
            Multiplicacao multiplicacao = new Multiplicacao();
            Console.WriteLine("{0} * {1} = {2}", a, b, multiplicacao.Multiplicar(a, b));
            break;
        case 4:
            Divisao divisao = new Divisao();
            Console.WriteLine("{0} / {1} = {2}", a, b, divisao.Dividir(a, b));
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Deseja realizar outra operação? \n[0] Sim [1] Não");
    x = int.Parse(Console.ReadLine());

}
Console.ReadKey();
