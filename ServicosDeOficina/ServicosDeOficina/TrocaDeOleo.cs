namespace ServicosDeOficina
{
    public class TrocaDeOleo : ServicoAutomotivo
    {
        public string TipoOleo { get; private set; }

        public TrocaDeOleo(decimal custo, string tipoOleo)
            : base("SRV-001", "Troca de Óleo e Filtro", custo)
        {
            TipoOleo = tipoOleo;
        }

        // Polimorfismo: Implementação específica da troca de óleo.
        public override void ExecutarServico()
        {
            Console.WriteLine($"   -> Executando Troca de Óleo: drenagem do óleo antigo, substituição do filtro e abastecimento com óleo {TipoOleo}.");
        }
    }
}