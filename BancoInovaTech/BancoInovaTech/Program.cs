namespace BancoInovaTech;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação do Banco InovaTech...");

        // 1. Criando a conta bancária
        var minhaConta = new ContaBancaria("João da Silva", "12345-6");

        // 2. Adicionando transações de diferentes tipos
        // Polimorfismo: Estamos adicionando objetos Credito e Debito
        // em uma lista que espera objetos Transacao.
        minhaConta.AdicionarTransacao(new Credito(new DateTime(2025, 8, 1), "Salário Empresa GFT", 5000.00m));
        minhaConta.AdicionarTransacao(new Debito(new DateTime(2025, 8, 2), "Aluguel", 1500.00m));
        minhaConta.AdicionarTransacao(new Debito(new DateTime(2025, 8, 5), "Supermercado", 450.75m));
        minhaConta.AdicionarTransacao(new Credito(new DateTime(2025, 8, 10), "Venda Freelance", 800.00m));
        minhaConta.AdicionarTransacao(new Debito(new DateTime(2025, 8, 15), "Fatura Cartão", 950.00m));

        // 3. Gerando o relatório final
        minhaConta.GerarRelatorio();

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
