namespace Manufatura
{
    // Herança: Reparo Corretivo É UM tipo de Serviço.
    public class ServicoReparoCorretivo : Servico
    {
        public string PecaSubstituida { get; private set; }

        public ServicoReparoCorretivo(string descricao, decimal custo, string peca)
            : base(descricao, custo)
        {
            PecaSubstituida = peca;
        }

        // Polimorfismo: A execução de um reparo tem um impacto diferente no status da máquina.
        public override void Executar(Maquina maquina)
        {
            Console.WriteLine($"   -> Executando Reparo Corretivo: '{DescricaoServico}' na máquina {maquina.IdMaquina}.");
            Console.WriteLine($"      Peça substituída: {PecaSubstituida}.");
            // Lógica: Após um reparo, a máquina volta a ficar operacional.
            maquina.Status = StatusMaquina.Operacional;
        }
    }
}