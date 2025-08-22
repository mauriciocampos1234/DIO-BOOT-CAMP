namespace Manufatura
{
    public class Maquina
    {
        public string IdMaquina { get; private set; }
        public string Nome { get; private set; }
        public StatusMaquina Status { get; set; } // O status pode ser alterado pelos serviços

        public Maquina(string idMaquina, string nome)
        {
            IdMaquina = idMaquina;
            Nome = nome;
            Status = StatusMaquina.Operacional; // Toda máquina nova começa operacional
        }

        public override string ToString()
        {
            return $"Máquina ID: {IdMaquina} | Nome: {Nome} | Status Atual: {Status}";
        }
    }
}