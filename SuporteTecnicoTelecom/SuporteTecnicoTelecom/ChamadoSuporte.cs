namespace SuporteTecnicoTelecom
{
    public class ChamadoSuporte
    {
        public long Protocolo { get; private set; }
        public string DescricaoProblema { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public StatusChamado Status { get; set; }

        public ChamadoSuporte(string descricaoProblema)
        {
            // Gera um protocolo "único" baseado no timestamp atual.
            Protocolo = DateTime.Now.Ticks;
            DescricaoProblema = descricaoProblema;
            DataAbertura = DateTime.Now;
            Status = StatusChamado.Aberto;
        }

        public override string ToString()
        {
            return $"  - Protocolo: {Protocolo} | Aberto em: {DataAbertura.ToString("g")} | Status: {Status}\n    Problema: {DescricaoProblema}";
        }
    }
}