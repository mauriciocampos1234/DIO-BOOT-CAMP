namespace SuporteTecnicoTelecom
{
    public class PlanoMovel5G : PlanoServico
    {
        public string NumeroTelefone { get; private set; }

        public PlanoMovel5G(string nome, int velocidade, decimal custo, string numero)
            : base(nome, velocidade, custo)
        {
            NumeroTelefone = numero;
        }

        // Polimorfismo: Implementação da verificação para 5G.
        public override bool VerificarStatusConexao()
        {
            Console.WriteLine($"   -> Verificando sinal 5G para o número: {NumeroTelefone}...");
            // Simulação
            return true;
        }

        public override string ObterDetalhesPlano()
        {
            return $"{base.ObterDetalhesPlano()} | Tipo: Móvel 5G";
        }
    }
}