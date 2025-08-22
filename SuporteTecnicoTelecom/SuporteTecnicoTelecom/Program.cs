namespace SuporteTecnicoTelecom;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação do CRM da GFT Telecom...");

        // 1. Criando uma conta de cliente com um plano de Fibra Óptica
        var planoFibra = new PlanoFibraOptica("Ultra Fibra Gamer", 1000, 149.90m, "Rua das Acacias, 777");
        var cliente1 = new ContaCliente(101, "Fernanda Lima", planoFibra);

        // 2. Cliente abre alguns chamados
        cliente1.AbrirChamado("Internet lenta para jogos online.");
        cliente1.AbrirChamado("Sinal do Wi-Fi caindo constantemente no segundo andar.");

        // 3. Exibindo o estado inicial da conta
        cliente1.GerarRelatorioConta();

        // 4. Equipe técnica processa os chamados que estão abertos
        cliente1.ProcessarChamadosAbertos();

        // 5. Exibindo o estado final da conta com os chamados resolvidos
        cliente1.GerarRelatorioConta();

        // --- Outro Exemplo com Cliente 5G ---
        var plano5G = new PlanoMovel5G("5G Total Connect", 200, 99.90m, "(11) 98765-4321");
        var cliente2 = new ContaCliente(102, "Ricardo Borges", plano5G);
        cliente2.AbrirChamado("Não consigo usar o 5G em áreas centrais da cidade.");
        cliente2.GerarRelatorioConta();
        cliente2.ProcessarChamadosAbertos();
        cliente2.GerarRelatorioConta();

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
