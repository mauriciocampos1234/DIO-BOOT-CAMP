namespace BancoInovaTech
{
    public class ContaBancaria
    {
        // Encapsulamento: Atributos públicos, mas com setters privados.
        // Só podem ser definidos no construtor.
        public string NomeTitular { get; private set; }
        public string NumeroConta { get; private set; }

        // Encapsulamento: A lista de transações é privada.
        // Ninguém de fora pode adicionar ou remover itens diretamente.
        private List<Transacao> _transacoes;

        public ContaBancaria(string nomeTitular, string numeroConta)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
            _transacoes = new List<Transacao>(); // Inicializa a lista
        }

        // Método público que permite adicionar transações de forma controlada.
        public void AdicionarTransacao(Transacao transacao)
        {
            if (transacao != null)
            {
                _transacoes.Add(transacao);
            }
        }

        // Lógica com Estrutura de Repetição (Laço foreach)
        public decimal CalcularSaldoFinal()
        {
            decimal saldo = 0;
            foreach (var transacao in _transacoes)
            {
                // Graças à nossa modelagem, basta somar.
                // Débitos já são negativos, créditos são positivos.
                saldo += transacao.Valor;
            }
            return saldo;
        }

        // Onde tudo se junta para a saída final
        public void GerarRelatorio()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine($"Extrato da Conta: {NumeroConta} - Titular: {NomeTitular}");
            Console.WriteLine("==========================================================");
            Console.WriteLine($"{"Data",-12} {"Descrição",-33} {"Valor"}");
            Console.WriteLine("----------------------------------------------------------");

            // Polimorfismo em ação!
            // O laço percorre a lista de Transacao. Para cada item, ele chama
            // o método ToString() correto (de Credito ou de Debito) automaticamente.
            foreach (var transacao in _transacoes)
            {
                Console.WriteLine(transacao.ToString());
            }

            Console.WriteLine("----------------------------------------------------------");
            decimal saldoFinal = CalcularSaldoFinal();
            Console.WriteLine($"SALDO FINAL: {saldoFinal:C}");
            Console.WriteLine("==========================================================");
        }
    }
}