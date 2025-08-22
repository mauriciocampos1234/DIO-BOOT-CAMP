namespace ServicosDeOficina
{
    // Abstração: O conceito geral de um serviço em uma oficina.
    public abstract class ServicoAutomotivo
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Custo { get; private set; }

        protected ServicoAutomotivo(string codigo, string descricao, decimal custo)
        {
            Codigo = codigo;
            Descricao = descricao;
            Custo = custo;
        }

        // Método abstrato que define a ação principal de um serviço.
        public abstract void ExecutarServico();
    }
}