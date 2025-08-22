namespace BancoInovaTech
{
    // Herança: A classe Debito também HERDA de Transacao.
    public class Debito : Transacao
    {
        public Debito(DateTime data, string descricao, decimal valor) : base(data, descricao)
        {
            // Lógica de negócio importante: internamente, um débito é um valor negativo.
            // Isso simplifica MUITO o cálculo do saldo final.
            Valor = -Math.Abs(valor);
        }

        // Polimorfismo: Outra implementação do ToString()
        public override string ToString()
        {
            return $"(-) {base.ToString()}";
        }
    }
}