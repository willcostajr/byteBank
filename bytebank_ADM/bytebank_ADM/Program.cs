using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario wilson = new Funcionario();
wilson.Nome = "Wilson Souza";
wilson.Cpf = "123456789";
wilson.Salario = 2000;

Console.WriteLine(wilson.Nome);
Console.WriteLine(wilson.GetBonificacao());

Diretor filipe = new Diretor();
filipe.Nome = "Filipe Ribeiro";
filipe.Cpf = "548985458";
filipe.Salario = 5000;

Console.WriteLine(filipe.Nome);
Console.WriteLine(filipe.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(wilson);
gerenciador.Registrar(filipe);

Console.WriteLine("Total de bonificações: R$ " + gerenciador.TotalBonificacao);

Console.ReadKey();