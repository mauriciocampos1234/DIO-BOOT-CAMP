using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicosDeOficina
{
    public class AlinhamentoBalanceamento : ServicoAutomotivo
    {
        public string GeometriaAplicada { get; private set; }

        public AlinhamentoBalanceamento(decimal custo, string geometria)
            : base("SRV-002", "Alinhamento e Balanceamento", custo)
        {
            GeometriaAplicada = geometria;
        }

        // Polimorfismo: Implementação específica do alinhamento.
        public override void ExecutarServico()
        {
            Console.WriteLine($"   -> Executando Alinhamento: verificação de cambagem e caster com tecnologia {GeometriaAplicada} e balanceamento das 4 rodas.");
        }
    }
}