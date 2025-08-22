namespace GFTSeguros
{
    public class ApoliceResidencial : Apolice
    {
        public string EnderecoImovel { get; private set; }

        public ApoliceResidencial(string numero, string nomeSegurado, decimal valorPremio, string endereco)
            : base(numero, nomeSegurado, valorPremio)
        {
            EnderecoImovel = endereco;
        }

        // Polimorfismo: Outra implementação específica
        public override void ExibirResumo()
        {
            Console.WriteLine("\n--- Resumo da Apólice Residencial ---");
            Console.WriteLine($"Número: {Numero} | Segurado: {NomeSegurado}");
            Console.WriteLine($"Endereço: {EnderecoImovel}");
            Console.WriteLine($"Prêmio: {ValorPremio:C} | Status: {Status}");
            Console.WriteLine("Sinistros Registrados:");
            foreach (var sinistro in Sinistros)
            {
                Console.WriteLine(sinistro.ToString());
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}