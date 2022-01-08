namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;
        protected abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu Saldo é : " + saldo);
        }
    }
}