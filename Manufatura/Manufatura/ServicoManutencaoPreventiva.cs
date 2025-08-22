namespace Manufatura
{
    // Herança: Manutenção Preventiva É UM tipo de Serviço.
    public class ServicoManutencaoPreventiva : Servico
    {
        public int IntervaloHorasRecomendado { get; private set; }

        public ServicoManutencaoPreventiva(string descricao, decimal custo, int intervaloHoras)
            : base(descricao, custo)
        {
            IntervaloHorasRecomendado = intervaloHoras;
        }

        // Polimorfismo: Implementação específica da execução.
        public override void Executar(Maquina maquina)
        {
            Console.WriteLine($"   -> Executando Manutenção Preventiva: '{DescricaoServico}' na máquina {maquina.IdMaquina}.");
            // Lógica: Apenas registra a passagem, não muda o status final se já estava operacional.
        }
    }
}