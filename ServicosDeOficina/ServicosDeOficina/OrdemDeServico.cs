namespace ServicosDeOficina
{
    public class OrdemDeServico
    {
        public int NumeroOS { get; private set; }
        public Veiculo VeiculoAtendido { get; private set; }
        public StatusOS Status { get; private set; }

        // Encapsulamento da lista de serviços
        private List<ServicoAutomotivo> _servicos = new List<ServicoAutomotivo>();
        public IReadOnlyList<ServicoAutomotivo> Servicos => _servicos.AsReadOnly();

        public OrdemDeServico(int numeroOS, Veiculo veiculo)
        {
            NumeroOS = numeroOS;
            VeiculoAtendido = veiculo;
            Status = StatusOS.AguardandoAprovacao;
        }

        public void AdicionarServico(ServicoAutomotivo servico)
        {
            if (Status == StatusOS.AguardandoAprovacao)
            {
                _servicos.Add(servico);
            }
        }

        public decimal CalcularCustoTotal()
        {
            decimal total = 0;
            foreach (var servico in _servicos) // Laço
            {
                total += servico.Custo;
            }
            return total;
        }

        public void ProcessarOrdem()
        {
            Console.WriteLine($"\n--- Processando OS Nº {NumeroOS} | Status: {Status} -> EmExecucao ---");
            Status = StatusOS.EmExecucao;

            foreach (var servico in _servicos) // Laço e Polimorfismo
            {
                servico.ExecutarServico();
            }

            Status = StatusOS.Finalizada;
            Console.WriteLine($"--- Finalizada OS Nº {NumeroOS} | Status: {Status} ---");
        }

        public void GerarRelatorioFinal()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine($"RELATÓRIO FINAL DA ORDEM DE SERVIÇO Nº: {NumeroOS}");
            Console.WriteLine("=======================================================");
            Console.WriteLine($"Cliente: {VeiculoAtendido.NomeCliente}");
            Console.WriteLine($"Veículo: {VeiculoAtendido.Modelo} {VeiculoAtendido.Ano} | Placa: {VeiculoAtendido.Placa}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine("\n--- Serviços Executados ---");
            foreach (var servico in _servicos)
            {
                Console.WriteLine($"- {servico.Descricao,-30} | Custo: {servico.Custo:C}");
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"CUSTO TOTAL: {CalcularCustoTotal():C}");
            Console.WriteLine("=======================================================");
        }
    }
}