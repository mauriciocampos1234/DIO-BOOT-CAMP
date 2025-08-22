namespace ServicosDeOficina
{
    public class DiagnosticoEletronico : ServicoAutomotivo
    {
        public string SistemaVerificado { get; private set; }

        public DiagnosticoEletronico(decimal custo, string sistema)
            : base("SRV-003", "Diagnóstico via Scanner", custo)
        {
            SistemaVerificado = sistema;
        }

        // Polimorfismo: Implementação específica do diagnóstico.
        public override void ExecutarServico()
        {
            Console.WriteLine($"   -> Executando Diagnóstico: conexão do scanner ao sistema de {SistemaVerificado} e leitura de códigos de falha.");
        }
    }
}