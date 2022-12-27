using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem vindo ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Wilson Souza";
//conta1.conta = "12345-x";
//conta1.numero_agencia = 785;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100.0;
//conta1.verificador = true;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Filipe Ribeiro";
//conta2.conta = "1547-x";
//conta2.numero_agencia = 785;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 225.5;
//conta2.verificador = true;

//ContaCorrente conta3 = new ContaCorrente();


//Console.WriteLine();
//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da Agência: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agência " + conta1.nome_agencia);
//Console.WriteLine("Saldo: R$ " + conta1.saldo);
//Console.WriteLine("Verificador: " + conta1.verificador);

//Console.WriteLine();
//Console.WriteLine("Titular: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Número da Agência: " + conta2.numero_agencia);
//Console.WriteLine("Nome da Agência " + conta2.nome_agencia);
//Console.WriteLine("Saldo: R$ " + conta2.saldo);
//Console.WriteLine("Verificador: " + conta2.verificador);

//Console.WriteLine();
//Console.WriteLine("Titular: " + conta3.titular);
//Console.WriteLine("Conta: " + conta3.conta);
//Console.WriteLine("Número da Agência: " + conta3.numero_agencia);
//Console.WriteLine("Nome da Agência " + conta3.nome_agencia);
//Console.WriteLine("Saldo: R$ " + conta3.saldo);
//Console.WriteLine("Verificador: " + conta3.verificador);

//Console.WriteLine("Saldo do Wilson pré-saque: R$ " + conta1.saldo);
//bool saque = conta1.Sacar(20);
//Console.WriteLine("O saque ocorreu com sucesso? " + saque);
//Console.WriteLine("Saldo do Wilson pós-saque: R$ " + conta1.saldo);
//conta1.Depositar(40);
//Console.WriteLine("Saldo do Wilson pós-depósito: R$ " + conta1.saldo);
//Console.WriteLine();
//Console.WriteLine("Saldo do Wilson pré-transferência: R$ " + conta1.saldo);
//Console.WriteLine("Saldo do Filipen pré-transferência: R$ " + conta2.saldo);
//Console.WriteLine();
//bool transferencia = conta1.Transferir(10, conta2);
//Console.WriteLine("A transferência ocorreu com sucesso? " + transferencia);
//Console.WriteLine();
//Console.WriteLine("Saldo do Wilson pós-transferência: R$ " + conta1.saldo);
//Console.WriteLine("Saldo do Filipen pós-transferência: R$ " + conta2.saldo);

//conta1.exibirInformacoes();
//Console.WriteLine();
//conta2.exibirInformacoes();

//Cliente cliente1 = new Cliente();
//cliente1.nome = "Wilson Souza Costa Júnior";
//cliente1.cpf = "025485954";
//cliente1.profissao = "Programador C#";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente1;
//conta.conta = "25489-x";
//conta.numero_agencia = 35;
//conta.nome_agencia = "Agência Central";
//conta.verificador = true;

//Console.WriteLine(cliente1.nome);
//Console.WriteLine(cliente1.cpf);
//Console.WriteLine(cliente1.profissao);
//Console.WriteLine();

//conta.exibirInformacoes();

//Console.WriteLine();
//Console.WriteLine(conta.titular.nome);
//Console.WriteLine(conta.titular.cpf);

//ContaCorrente conta4 = new ContaCorrente(1578, "587-1");
//conta4.SetSaldo(4);

//Console.WriteLine("O saldo da conta é de: R$ " + conta4.GetSaldo());

//conta4.Saldo = 15;


//Console.WriteLine("Saldo da conta: R$ " + conta4.Saldo);
//Console.WriteLine(conta4.NumeroAgencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(0001, "5426-8");

ContaCorrente conta6 = new ContaCorrente(0001, "2587-x");

//Para exibir o total de contas criadas
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


ContaCorrente conta7 = new ContaCorrente(new Cliente("Wilson Souza", "0254857", "Programador C#"), "57896-x", 0001, "Agência Central") ;
conta7.exibirInformacoes();


Console.ReadKey();
