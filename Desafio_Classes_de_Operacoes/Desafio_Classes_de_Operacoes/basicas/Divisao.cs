
namespace Desafio_Classes_de_Operacoes.basicas
{
    public class Divisao
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                return 0;
            return dividendo / divisor;
        }
    }
}
