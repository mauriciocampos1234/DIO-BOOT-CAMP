namespace GFTSeguros
{
    // Uma classe simples para representar um evento/ocorrência.
    public class Sinistro
    {
        public DateTime DataOcorrencia { get; private set; }
        public string Descricao { get; private set; }
        public StatusSinistro Status { get; set; } // Status pode ser alterado, por isso o 'set' público

        public Sinistro(DateTime dataOcorrencia, string descricao)
        {
            DataOcorrencia = dataOcorrencia;
            Descricao = descricao;
            Status = StatusSinistro.EmAnalise; // Todo novo sinistro começa "Em Análise"
        }

        public override string ToString()
        {
            return $"    - Data: {DataOcorrencia.ToShortDateString()}, Descrição: {Descricao}, Status: {Status}";
        }
    }
}