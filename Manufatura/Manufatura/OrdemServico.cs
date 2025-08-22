namespace Manufatura
{
    public class OrdemServico
    {
        // Encapsulamento: Gerencia o estado e os componentes de uma Ordem de Serviço.
        public string NumeroOS { get; private set; }
        public Maquina MaquinaAlvo { get; private set; }
        public DateTime DataAbertura { get; private set; }

        private List<Servico> _servicos = new List<Servico>();
        public IReadOnlyList<Servico> Servicos => _servicos.AsReadOnly();

        public OrdemServico(string numeroOS, Maquina maquina)
        {
            NumeroOS = numeroOS;
            MaquinaAlvo = maquina;
            DataAbertura = DateTime.Now;
        }

        public void AdicionarServico(Servico servico)
        {
            _servicos.Add(servico);
        }

        // Lógica com Estrutura de Repetição (Laço)
        public void ProcessarOrdem()
        {
            Console.WriteLine($"\n--- Processando Ordem de Serviço {NumeroOS} ---");
            Console.WriteLine($"Máquina: {MaquinaAlvo.Nome} (Status inicial: {MaquinaAlvo.Status})");

            if (MaquinaAlvo.Status != StatusMaquina.Inativa)
            {
                MaquinaAlvo.Status = StatusMaquina.EmManutencao;
            }
            Console.WriteLine($"Status alterado para: {MaquinaAlvo.Status}");

            // Polimorfismo e Laço em ação
            foreach (var servico in _servicos)
            {
                // Não importa o tipo de serviço, o método Executar() correto será chamado.
                servico.Executar(MaquinaAlvo);
            }

            // Regra de negócio final: se a máquina não ficou Inativa após o reparo, ela está pronta.
            if (MaquinaAlvo.Status == StatusMaquina.EmManutencao)
            {
                MaquinaAlvo.Status = StatusMaquina.Operacional;
            }

            Console.WriteLine($"Processamento concluído. Status final da máquina: {MaquinaAlvo.Status}");
            Console.WriteLine("------------------------------------------");
        }
    }
}