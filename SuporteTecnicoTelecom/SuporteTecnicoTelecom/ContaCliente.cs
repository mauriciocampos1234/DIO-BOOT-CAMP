namespace SuporteTecnicoTelecom
{
    public class ContaCliente
    {
        // Encapsulamento dos dados e regras de negócio do cliente
        public int IdCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public PlanoServico PlanoContratado { get; private set; }

        private List<ChamadoSuporte> _chamados = new List<ChamadoSuporte>();
        public IReadOnlyList<ChamadoSuporte> Chamados => _chamados.AsReadOnly();

        public ContaCliente(int id, string nome, PlanoServico plano)
        {
            IdCliente = id;
            NomeCliente = nome;
            PlanoContratado = plano;
        }

        public long AbrirChamado(string descricaoProblema)
        {
            var novoChamado = new ChamadoSuporte(descricaoProblema);
            _chamados.Add(novoChamado);
            Console.WriteLine($"\nNovo chamado aberto para {NomeCliente}. Protocolo: {novoChamado.Protocolo}");
            return novoChamado.Protocolo;
        }

        // Lógica com Estrutura de Repetição
        public void ProcessarChamadosAbertos()
        {
            Console.WriteLine($"\nProcessando chamados abertos para o cliente {NomeCliente}...");
            foreach (var chamado in _chamados)
            {
                if (chamado.Status == StatusChamado.Aberto)
                {
                    Console.WriteLine($"  Atendendo protocolo {chamado.Protocolo}...");
                    chamado.Status = StatusChamado.EmAndamento;

                    // Simula o trabalho técnico
                    PlanoContratado.VerificarStatusConexao(); // Polimorfismo

                    chamado.Status = StatusChamado.Resolvido;
                    Console.WriteLine($"  Protocolo {chamado.Protocolo} foi resolvido.");
                }
            }
        }

        public void GerarRelatorioConta()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine($"RELATÓRIO DA CONTA DO CLIENTE");
            Console.WriteLine("=======================================================");
            Console.WriteLine($"ID: {IdCliente} | Cliente: {NomeCliente}");
            Console.WriteLine(PlanoContratado.ObterDetalhesPlano()); // Polimorfismo
            Console.WriteLine("\n--- Histórico de Chamados de Suporte ---");
            if (_chamados.Any()) // Verifica se a lista não está vazia
            {
                foreach (var chamado in _chamados)
                {
                    Console.WriteLine(chamado.ToString());
                }
            }
            else
            {
                Console.WriteLine("  Nenhum chamado registrado.");
            }
            Console.WriteLine("=======================================================");
        }
    }
}