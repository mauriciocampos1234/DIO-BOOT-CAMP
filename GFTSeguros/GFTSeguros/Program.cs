namespace GFTSeguros;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação da GFT Seguros...");

        // Polimorfismo: Criando uma lista da classe base (Apolice)
        // que pode conter objetos de qualquer classe filha (Automovel, Residencial).
        var listaDeApolices = new List<Apolice>();

        // Criando e configurando uma apólice de automóvel
        var apoliceCarro = new ApoliceAutomovel("AUT-001", "Carlos Pereira", 2500.00m, "BRA2E19", "Toyota Corolla");
        apoliceCarro.AdicionarSinistro(new Sinistro(new DateTime(2025, 7, 20), "Colisão leve no para-choque"));
        apoliceCarro.AdicionarSinistro(new Sinistro(new DateTime(2025, 8, 15), "Vidro trincado"));
        listaDeApolices.Add(apoliceCarro);

        // Criando e configurando uma apólice residencial
        var apoliceCasa = new ApoliceResidencial("RES-002", "Ana Souza", 1200.00m, "Rua das Flores, 123");
        apoliceCasa.AdicionarSinistro(new Sinistro(new DateTime(2025, 6, 10), "Vazamento no banheiro"));
        listaDeApolices.Add(apoliceCasa);

        // --- INÍCIO DA DEMONSTRAÇÃO ---
        Console.WriteLine("\n--- ESTADO INICIAL DAS APÓLICES ---");
        foreach (var apolice in listaDeApolices)
        {
            // Polimorfismo em ação: Chama o ExibirResumo() correto para cada tipo de apólice
            apolice.ExibirResumo();
        }

        Console.WriteLine("\n\n--- EXECUTANDO PROCESSAMENTO DE SINISTROS ---");
        foreach (var apolice in listaDeApolices)
        {
            apolice.ProcessarSinistrosEmAnalise();
        }

        Console.WriteLine("\n\n--- ESTADO FINAL DAS APÓLICES ---");
        foreach (var apolice in listaDeApolices)
        {
            apolice.ExibirResumo();
        }

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
