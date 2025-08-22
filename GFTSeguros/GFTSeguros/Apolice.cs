namespace GFTSeguros
{
    // Abstração: Define o modelo de uma Apólice, com comportamento
    // que será herdado e implementado pelas classes filhas.
    public abstract class Apolice
    {
        // Encapsulamento: Protegendo os dados
        public string Numero { get; private set; }
        public string NomeSegurado { get; private set; }
        public decimal ValorPremio { get; private set; }
        public StatusApolice Status { get; private set; }

        // Encapsulamento: a lista de sinistros é privada
        private List<Sinistro> _sinistros = new List<Sinistro>();
        // Expondo uma versão "somente leitura" da lista para o mundo exterior
        public IReadOnlyList<Sinistro> Sinistros => _sinistros.AsReadOnly();

        protected Apolice(string numero, string nomeSegurado, decimal valorPremio)
        {
            Numero = numero;
            NomeSegurado = nomeSegurado;
            ValorPremio = valorPremio;
            Status = StatusApolice.Ativa;
        }

        public void AdicionarSinistro(Sinistro sinistro)
        {
            _sinistros.Add(sinistro);
        }

        // Lógica com Estrutura de Repetição (Laço foreach)
        public void ProcessarSinistrosEmAnalise()
        {
            Console.WriteLine($"\nProcessando sinistros para a apólice {Numero}...");
            foreach (var sinistro in _sinistros)
            {
                if (sinistro.Status == StatusSinistro.EmAnalise)
                {
                    // Simula a lógica de negócio de aprovação
                    sinistro.Status = StatusSinistro.Aprovado;
                    Console.WriteLine($"   -> Sinistro '{sinistro.Descricao}' foi Aprovado.");
                }
            }
        }

        // Abstração/Polimorfismo: Força as classes filhas a terem seu próprio método de resumo.
        public abstract void ExibirResumo();
    }
}