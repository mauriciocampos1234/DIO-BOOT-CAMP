namespace IndustriaEVarejo
{
    // Abstração: Define o "contrato" de um Produto.
    // Todo produto no nosso sistema DEVE ter essas propriedades e comportamentos.
    public abstract class Produto
    {
        public string Sku { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; set; }

        protected Produto(string sku, string nome, decimal preco)
        {
            Sku = sku;
            Nome = nome;
            Preco = preco;
        }

        public abstract bool VerificarDisponibilidade(int quantidade);
        public abstract void BaixarEstoque(int quantidade);

        public virtual string ObterDescricaoDetalhada()
        {
            return $"SKU: {Sku} | Nome: {Nome} | Preço: {Preco:C}";
        }
    }
}