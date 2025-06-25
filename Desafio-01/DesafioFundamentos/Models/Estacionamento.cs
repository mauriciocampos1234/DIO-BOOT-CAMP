namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe que representa um estacionamento, permitindo adicionar, remover e listar veículos.
    /// Possui um preço inicial e um preço por hora para calcular o valor total do estacionamento
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="precoInicial">Valor fixo da primeira hora</param>
        /// <param name="precoPorHora">Valor adicional por quantidade de horas permanecidas</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        /// <summary>
        /// Adiciona um veículo ao estacionamento.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? inputPlaca = Console.ReadLine();
            string placa = inputPlaca ?? string.Empty;
            veiculos.Add(placa);
        }
        /// <summary>
        /// Remove um veículo do estacionamento e calcula o valor total a ser pago.
        /// Solicita a placa do veículo e a quantidade de horas que ele permaneceu estacionado.
        /// Se o veículo não estiver estacionado, informa ao usuário.
        /// Se o veículo estiver estacionado, remove-o da lista e calcula o valor total com base no preço inicial e no preço por hora.
        /// Exibe o valor total a ser pago.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? inputPlaca = Console.ReadLine();
            string placa = inputPlaca ?? string.Empty;

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Lista todos os veículos estacionados.
        /// Se não houver veículos, informa ao usuário.
        /// </summary>
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}