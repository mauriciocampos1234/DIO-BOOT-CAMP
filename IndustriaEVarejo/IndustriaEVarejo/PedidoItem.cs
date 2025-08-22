namespace IndustriaEVarejo
{
    public class PedidoItem
    {
        public string SkuProduto { get; private set; }
        public int Quantidade { get; private set; }
        public StatusPedido Status { get; set; }

        public PedidoItem(string skuProduto, int quantidade)
        {
            SkuProduto = skuProduto;
            Quantidade = quantidade;
            Status = StatusPedido.Pendente; // Todo novo pedido começa como 'Pendente'
        }
    }
}