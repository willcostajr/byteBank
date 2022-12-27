using bytebank.Titular;
namespace bytebank
{
    public class ContaCorrente
    {
        //modificadores de acesso: public, private, internal, ...
        //campo é uma variável definida dentro de uma classe, como mostrado abaixo
        //valor padrão de string é vazio
        //valor padrão de número é o 0
        //valor padrão de booleano é false

        //esses são os atributos da classe:
        //public Cliente titular;
        //public string conta;
        //public int numero_agencia;
        //public string nome_agencia;
        private double saldo;
        

        //propriedade autoimplementada
        //para criar uma propriedade autoimplementada prop + tab + tab
        public Cliente Titular { get; set; }

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Conta inválida.");
                    return; 
                }
                _conta = value;
            }
        }

        private int _numero_agencia;
        public int NumeroAgencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Número de agência inválido.");
                    return ;
                }
                _numero_agencia = value;   
            }
        }

        public string NomeAgencia { get; set; }
        

        //Métodos são comportamentos que refletem ações que um objeto de
        //determinada classe pode executar. Há métodos que retornam valor,
        //outros não retornam nada.

        //abaixo temos um método que retorna um valor (do tipo lógico)
        public bool Sacar(double valor)
        {
            if (valor < saldo && valor > 0)
            {
                saldo -= valor;
                return true;
            }
            else
                return false;
        }

        //abaixo temos um método que não retorna nenhum valor
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if (valor < saldo && valor > 0)
            {
                saldo -= valor;
                conta.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void exibirInformacoes()
        {
            Console.WriteLine();
            Console.WriteLine("Nome do titular: " + Titular.Nome);
            Console.WriteLine("CPF do titular: " + Titular.CPF);
            Console.WriteLine("Profissão do Titular: " + Titular.Profissao);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número da agência: " + NumeroAgencia);
            Console.WriteLine("Nome da Agência: " + NomeAgencia);
            Console.WriteLine("Saldo: R$ " + saldo);
            //Console.WriteLine("Verificador: " + verificador);
        }

        //Esse médoto funciona para que o saldo não receba valor negativo.
        //public void SetSaldo (double valor)
        //{
        //    //a palavra return faz o programa sair imediatamente do método.
        //    if (valor < 0)
        //        return;
        //    saldo = valor;
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        //Aqui temos uma propriedade
        public double Saldo
        {
            set
            {
                if (value < 0)
                    return;
                saldo = value;
            }
            get
            {
                return saldo;
            }
        }

        //Esse é o construtor. Construtor é um método que recebe o mesmo
        //nome da classe em que ele está. Já vem definido por padrão
        //e nos usamos ele quando vamos criar um objeto, ex: "ContaCorrente conta1 = new ContaCorrente();
        //Quando colocamos a lista de parâmetros, esses campos se tornam obrigatórios
        //no momento da criação do objeto.
        //O contrutor não inclui tipo de retorno

        //Um método construtor é chamado quando queremos criar um objeto.
        //Por meio dele é estabelecido que sejam passados parâmetros para
        //preencher os atributos da classe assim que o objeto é criado.
        public ContaCorrente(int numero_agencia, string _conta)
        {
            NumeroAgencia = numero_agencia;
            Conta = _conta;
            TotalDeContasCriadas += 1;
        }

        //não entendi ainda porque se usa o static, mas acredito que seja pra definri uma propriedade da classe
        //e não do objeto.
        //A palavra reservada static é utilizada para definir um campo ou propriedade como membro de uma classe.
        //Assim conseguimos compartilhar informações com todos os objetos de uma classe.
        public static int TotalDeContasCriadas { get; set; }

        //Construtor personalizado
        public ContaCorrente(Cliente titular, string _conta, int _numero_agencia, string _nome_agencia)
        {
            Titular = titular;
            Conta = _conta;
            NumeroAgencia = _numero_agencia;
            NomeAgencia = _nome_agencia;
        }
    }
}