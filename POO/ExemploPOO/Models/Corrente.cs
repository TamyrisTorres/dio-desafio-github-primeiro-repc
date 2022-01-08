namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        protected override void Creditar(double valor)
        {
            base.saldo = valor;
        }

        internal void Creditar(int v)
        {
            throw new NotImplementedException();
        }
    }
}