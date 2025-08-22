namespace IndustriaEVarejo
{
    // Herança: ProdutoDigital também é um tipo de Produto.
    public class ProdutoDigital : Produto
    {
        public bool AtivoParaVenda { get; private set; }

        public ProdutoDigital(string sku, string nome, decimal preco, bool ativo)
            : base(sku, nome, preco)
        {
            AtivoParaVenda = ativo;
        }

        public override bool VerificarDisponibilidade(int quantidade)
        {
            return AtivoParaVenda;
        }

        public override void BaixarEstoque(int quantidade)
        {
            // Para um produto digital, a baixa de estoque pode ser apenas um registro (log).
            // Aqui, vamos apenas imprimir uma mensagem para simular.
            Console.WriteLine($"   -> Log: {quantidade} licença(s) do produto '{Nome}' gerada(s).");
        }

        public override string ObterDescricaoDetalhada()
        {
            string status = AtivoParaVenda ? "Ativo" : "Inativo";
            return $"{base.ObterDescricaoDetalhada()} | Status: {status}";
        }
    }
}