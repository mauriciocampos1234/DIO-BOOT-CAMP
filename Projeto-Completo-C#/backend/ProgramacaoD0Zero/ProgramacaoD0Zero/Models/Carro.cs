namespace ProgramacaoDoZero.Models
{
    //Heranca: A classe nova criada chamada Carro herda da classe MÃE Veículo
    public class Carro : Veiculo

    {
        //Construtor
        public Carro()
        {
            QuantidadeRodas = 4;
        }

        //Atributos ou Propriedades
        public int QuantidadeRodas { get; set; }

        public override void Acelerar() //override significa Subescrever e busca o metodo na classe MÃE acelerar que colocamos a chave para a chamada: virtual
        {
            //base.Acelerar(); Cria automaticamente e ai vamos atribuir para private

            InjetarCombustivel(4);
        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            base.TanqueCombustivel = base.TanqueCombustivel - quantidadeCombustivel;
        }
    }
}