namespace BancoInovaTech
{
    // Abstração: Esta classe define o que TODA transação DEVE ter,
    // mas não pode ser instanciada diretamente. Ela é um contrato, um conceito.
    public abstract class Transacao
    {
        // Encapsulamento: Propriedades públicas controlam o acesso aos dados.
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; protected set; } // protected: só a classe e filhas podem alterar

        // Construtor da classe base
        public Transacao(DateTime data, string descricao)
        {
            Data = data;
            Descricao = descricao;
        }

        // Polimorfismo: Este método será sobrescrito pelas classes filhas
        public override string ToString()
        {
            // Retorna uma string formatada. O C# usa interpolação com '$'.
            // O ':C' formata o valor como moeda (ex: R$ 50,00)
            return $"{Data.ToShortDateString(),-12} {Descricao,-30} {Valor:C}";
        }
    }
}