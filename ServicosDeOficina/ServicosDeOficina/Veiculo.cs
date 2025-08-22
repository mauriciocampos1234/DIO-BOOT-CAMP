namespace ServicosDeOficina
{
    public class Veiculo
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string NomeCliente { get; private set; }

        public Veiculo(string placa, string modelo, int ano, string nomeCliente)
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            NomeCliente = nomeCliente;
        }
    }
}