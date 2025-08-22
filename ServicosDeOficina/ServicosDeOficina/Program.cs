namespace ServicosDeOficina;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação da Oficina GFT Motors...");

        // 1. Veículo chega à oficina
        var veiculo1 = new Veiculo("QAB-1234", "Honda Civic", 2023, "Mariana Costa");

        // 2. Criação da Ordem de Serviço
        var os = new OrdemDeServico(2025001, veiculo1);
        Console.WriteLine($"\nCriada OS Nº {os.NumeroOS} para o veículo placa {os.VeiculoAtendido.Placa}. Status: {os.Status}");

        // 3. Adicionando os serviços solicitados pelo cliente
        os.AdicionarServico(new TrocaDeOleo(350.00m, "5W-30 Sintético"));
        os.AdicionarServico(new AlinhamentoBalanceamento(180.00m, "3D a Laser"));
        os.AdicionarServico(new DiagnosticoEletronico(120.00m, "Injeção Eletrônica e ABS"));

        // 4. Mecânico processa a OS
        os.ProcessarOrdem();

        // 5. Sistema gera o relatório final para o cliente
        os.GerarRelatorioFinal();

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
