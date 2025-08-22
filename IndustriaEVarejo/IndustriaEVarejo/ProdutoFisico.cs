namespace IndustriaEVarejo
{
    // Herança: ProdutoFisico é um tipo de Produto.
    public class ProdutoFisico : Produto
    {
        public int QuantidadeEmEstoque { get; private set; }

        public ProdutoFisico(string sku, string nome, decimal preco, int quantidadeEmEstoque)
            : base(sku, nome, preco)
        {
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public override bool VerificarDisponibilidade(int quantidade)
        {
            return QuantidadeEmEstoque >= quantidade;
        }

        public override void BaixarEstoque(int quantidade)
        {
            if (VerificarDisponibilidade(quantidade))
            {
                QuantidadeEmEstoque -= quantidade;
            }
        }

        public override string ObterDescricaoDetalhada()
        {
            return $"{base.ObterDescricaoDetalhada()} | Estoque: {QuantidadeEmEstoque} unidades";
        }
    }
}