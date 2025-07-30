namespace ProgramacaoDoZero.Models
{
    //Heranca: A classe nova criada chamada Moto herda da classe MÃE Veículo
    public class Moto : Veiculo
    {
        //Construtor
        public Moto()
        {
            QuantidadeRodas = 2;

            //Tem que subescrever caso o valor seja diferente do construtor MÃE Veículo
            TanqueCombustivel = 16;
        }

         public override void Acelerar() //override significa Subescrever e busca o metodo na classe MÃE acelerar que colocamos a chave para a chamada: virtual
        {
            //base.Acelerar(); Cria automaticamente e ai vamos atribuir para private

            InjetarCombustivel(1);
        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            base.TanqueCombustivel = base.TanqueCombustivel - quantidadeCombustivel;
        }

        //Atributos ou Propriedades
        public int QuantidadeRodas { get; set; }
    }
}