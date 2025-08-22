namespace SuporteTecnicoTelecom
{
    public class PlanoFibraOptica : PlanoServico
    {
        public string LocalidadeInstalacao { get; private set; }

        public PlanoFibraOptica(string nome, int velocidade, decimal custo, string localidade)
            : base(nome, velocidade, custo)
        {
            LocalidadeInstalacao = localidade;
        }

        // Polimorfismo: Implementação da verificação para fibra.
        public override bool VerificarStatusConexao()
        {
            Console.WriteLine($"   -> Verificando sinal da fibra para a localidade: {LocalidadeInstalacao}...");
            // Simulação: sempre retorna 'true' se não houver um problema real.
            return true;
        }

        public override string ObterDetalhesPlano()
        {
            return $"{base.ObterDetalhesPlano()} | Tipo: Fibra Óptica";
        }
    }
}