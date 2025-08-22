namespace IndustriaEVarejo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação de Estoque para Indústria e Varejo...");

        var gerenciador = new GerenciadorEstoque();

        // Adicionando diferentes tipos de produtos ao estoque
        gerenciador.AdicionarProduto(new ProdutoFisico("FIS-001", "Mouse Gamer RGB", 150.00m, 50));
        gerenciador.AdicionarProduto(new ProdutoFisico("FIS-002", "Teclado Mecânico", 350.00m, 2)); // Estoque baixo!
        gerenciador.AdicionarProduto(new ProdutoDigital("DIG-001", "Licença Software de Edição", 899.90m, true));
        gerenciador.AdicionarProduto(new ProdutoDigital("DIG-002", "E-book de C# Avançado", 79.90m, false)); // Inativo!

        // Estado inicial do estoque
        gerenciador.GerarRelatorioDeEstoque();

        // Criando uma lista de pedidos de clientes
        var listaDePedidos = new List<PedidoItem>
        {
            new PedidoItem("FIS-001", 10), // Pedido OK
            new PedidoItem("FIS-002", 3),  // Pedido vai falhar (estoque insuficiente)
            new PedidoItem("DIG-001", 1),  // Pedido OK
            new PedidoItem("DIG-002", 1),  // Pedido vai falhar (produto inativo)
            new PedidoItem("XYZ-999", 5)   // Pedido vai falhar (produto não existe)
        };

        // Processando os pedidos
        gerenciador.ProcessarListaDePedidos(listaDePedidos);

        // Estado final do estoque para ver as baixas
        gerenciador.GerarRelatorioDeEstoque();

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
