namespace strategy.Investimento
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        { 
            this.Saldo += valor * 0.75;
        }
    }
}
