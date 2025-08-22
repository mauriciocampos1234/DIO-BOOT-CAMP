namespace IndustriaEVarejo
{
    // A classe continua a mesma, apenas este método muda:
    public class GerenciadorEstoque
    {
        private List<Produto> _produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public Produto? BuscarProdutoPorSku(string sku)
        {
            // Usando LINQ (System.Linq) para uma busca mais limpa e eficiente.
            // Adicione 'using System.Linq;' no topo do arquivo se o VS Code sugerir.
            return _produtos.FirstOrDefault(p => p.Sku == sku);
        }

        public void ProcessarListaDePedidos(List<PedidoItem> pedidos)
        {
            Console.WriteLine("\n--- Processando Pedidos ---");
            foreach (var pedido in pedidos)
            {
                var produto = BuscarProdutoPorSku(pedido.SkuProduto);
                string motivoRejeicao = "";

                if (produto == null)
                {
                    pedido.Status = StatusPedido.Rejeitado;
                    motivoRejeicao = "Produto não encontrado";
                }
                else if (produto.VerificarDisponibilidade(pedido.Quantidade))
                {
                    produto.BaixarEstoque(pedido.Quantidade);
                    pedido.Status = StatusPedido.Aprovado;
                }
                else
                {
                    pedido.Status = StatusPedido.Rejeitado;
                    motivoRejeicao = "Estoque/Disponibilidade insuficiente";
                }

                if (pedido.Status == StatusPedido.Aprovado)
                {
                    // Usamos 'produto.Nome' aqui porque sabemos que o produto não é nulo.
                    Console.WriteLine($"Pedido de {pedido.Quantidade}x {produto!.Nome} [{pedido.Status}].");
                }
                else
                {
                    Console.WriteLine($"Pedido do SKU {pedido.SkuProduto} [{pedido.Status}] - Motivo: {motivoRejeicao}.");
                }
            }
            Console.WriteLine("---------------------------");
        }

        public void GerarRelatorioDeEstoque()
        {
            Console.WriteLine("\n--- Relatório de Estoque Atual ---");
            foreach (var produto in _produtos)
            {
                Console.WriteLine(produto.ObterDescricaoDetalhada());
            }
            Console.WriteLine("----------------------------------");
        }
    }
}