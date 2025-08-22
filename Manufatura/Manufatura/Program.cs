namespace Manufatura;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulação de Serviços da Indústria de Manufatura...");

        // 1. Criando as máquinas da fábrica
        var prensaHidraulica = new Maquina("P-001", "Prensa Hidráulica 10T");
        var esteiraRolante = new Maquina("E-002", "Esteira de Rolagem B-52");
        esteiraRolante.Status = StatusMaquina.Inativa; // Esta máquina já começa com um problema

        Console.WriteLine("\n--- Status Inicial das Máquinas ---");
        Console.WriteLine(prensaHidraulica.ToString());
        Console.WriteLine(esteiraRolante.ToString());

        // 2. Criando uma Ordem de Serviço para manutenção de rotina na prensa
        var os1 = new OrdemServico("OS-2025-001", prensaHidraulica);
        os1.AdicionarServico(new ServicoManutencaoPreventiva("Lubrificação de componentes", 300.00m, 720));
        os1.AdicionarServico(new ServicoManutencaoPreventiva("Verificação de pressão", 150.00m, 720));

        // 3. Criando uma Ordem de Serviço para consertar a esteira
        var os2 = new OrdemServico("OS-2025-002", esteiraRolante);
        os2.AdicionarServico(new ServicoReparoCorretivo("Reparo no motor principal", 1200.00m, "Correia de tração"));
        os2.AdicionarServico(new ServicoManutencaoPreventiva("Alinhamento dos roletes", 200.00m, 360));

        // 4. Processando as Ordens de Serviço
        os1.ProcessarOrdem();
        os2.ProcessarOrdem();

        Console.WriteLine("\n--- Status Final das Máquinas ---");
        Console.WriteLine(prensaHidraulica.ToString());
        Console.WriteLine(esteiraRolante.ToString());

        Console.WriteLine("\nSimulação finalizada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
