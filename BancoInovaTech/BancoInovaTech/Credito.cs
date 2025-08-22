namespace BancoInovaTech
{
    // Herança: A classe Credito HERDA tudo que a classe Transacao tem.
    public class Credito : Transacao
    {
        // Construtor específico para Crédito
        // Ele recebe os dados e os repassa para o construtor da classe base (Transacao)
        public Credito(DateTime data, string descricao, decimal valor) : base(data, descricao)
        {
            // Garante que o valor de um crédito seja sempre positivo
            Valor = Math.Abs(valor);
        }

        // Polimorfismo: Sobrescrevendo o método ToString() para adicionar um identificador
        public override string ToString()
        {
            return $"(+) {base.ToString()}"; // Chama o método da classe pai e adiciona um prefixo
        }
    }
}