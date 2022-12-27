namespace bytebank.Titular
{
    public class Cliente
    {
        
        public string Nome { get; set; }
        
        public string CPF { get; set; }
        
        public string Profissao { get; set; }

        public Cliente(string nome, string cPF, string profissao)
        {
            Nome = nome;
            CPF = cPF;
            Profissao = profissao;
        }
    }
}
