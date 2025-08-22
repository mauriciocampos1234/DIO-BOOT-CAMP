namespace Manufatura
{
    // Abstração: Define o que todo Serviço deve ter.
    public abstract class Servico
    {
        public string DescricaoServico { get; private set; }
        public decimal CustoEstimado { get; private set; }

        protected Servico(string descricao, decimal custo)
        {
            DescricaoServico = descricao;
            CustoEstimado = custo;
        }

        // Método abstrato que força as filhas a implementar a ação
        public abstract void Executar(Maquina maquina);
    }
}