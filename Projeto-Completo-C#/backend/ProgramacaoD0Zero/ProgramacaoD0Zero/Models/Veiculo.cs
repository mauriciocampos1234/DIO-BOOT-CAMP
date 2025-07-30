//Estamos usando POO Heranca, Encapsulamento e Polimorfismo


namespace ProgramacaoDoZero.Models
{
    public class Veiculo
    {
        //Construtor
        public Veiculo()
        {
            TanqueCombustivel = 40;
        }

        //Atributos ou Propriedades
        public string? Cor { get; set; }

        public string? Marca { get; set; }

        public string? Placa { get; set; }

        public string? Modelo { get; set; }

        public int TanqueCombustivel { get; set; }

        //Métodos
        //Poliformismo VIRTUAL em c#
        //Comportamentos
        public virtual void Acelerar()
        {
            //TanqueCombustivel = TanqueCombustivel - 1; //Primeira construção de código para testes
            //Segunda construção de código após encapsular private void InjetarCombustivel(int quantidadeCombustivel)
            InjetarCombustivel(2);
        }

        public void Frear()
        {

        }

        //Encapsulamento
        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
        }

    }
}