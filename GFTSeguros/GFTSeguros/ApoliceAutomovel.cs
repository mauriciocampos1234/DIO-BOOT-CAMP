namespace GFTSeguros
{
    public class ApoliceAutomovel : Apolice
    {
        public string PlacaVeiculo { get; private set; }
        public string ModeloVeiculo { get; private set; }

        public ApoliceAutomovel(string numero, string nomeSegurado, decimal valorPremio, string placa, string modelo)
            : base(numero, nomeSegurado, valorPremio)
        {
            PlacaVeiculo = placa;
            ModeloVeiculo = modelo;
        }

        // Polimorfismo: Implementação específica do método abstrato
        public override void ExibirResumo()
        {
            Console.WriteLine("\n--- Resumo da Apólice de Automóvel ---");
            Console.WriteLine($"Número: {Numero} | Segurado: {NomeSegurado}");
            Console.WriteLine($"Veículo: {ModeloVeiculo} | Placa: {PlacaVeiculo}");
            Console.WriteLine($"Prêmio: {ValorPremio:C} | Status: {Status}");
            Console.WriteLine("Sinistros Registrados:");
            foreach (var sinistro in Sinistros)
            {
                Console.WriteLine(sinistro.ToString());
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}