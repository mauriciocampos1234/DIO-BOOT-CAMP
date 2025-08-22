namespace SuporteTecnicoTelecom
{
    // Abstração: Representa a ideia de um plano, um contrato de serviço.
    public abstract class PlanoServico
    {
        public string NomePlano { get; private set; }
        public int VelocidadeContratadaMB { get; private set; }
        public decimal CustoMensal { get; private set; }

        protected PlanoServico(string nome, int velocidade, decimal custo)
        {
            NomePlano = nome;
            VelocidadeContratadaMB = velocidade;
            CustoMensal = custo;
        }

        // Método abstrato que força as classes filhas a terem sua própria verificação
        public abstract bool VerificarStatusConexao();

        public virtual string ObterDetalhesPlano()
        {
            return $"Plano: {NomePlano} | Velocidade: {VelocidadeContratadaMB} Mbps | Custo: {CustoMensal:C}/mês";
        }
    }
}