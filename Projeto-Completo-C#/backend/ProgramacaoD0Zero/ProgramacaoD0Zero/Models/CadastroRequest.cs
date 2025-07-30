//CLASSE MODELS: Objetos que representam os dados que serão enviados e recebidos pelo Controller
// Temos 2 tipos de Models: Request e Result
//Request: São os dados que o Controller recebe do Frontend
//Result: São os dados que o Controller envia para o Frontend


namespace ProgramacaoDoZero.Models
{
    public class CadastroRequest
    {
        public string? nome { get; set; }

        public string? sobrenome { get; set; }

        public string? email { get; set; }

        public string? telefone { get; set; }

        public string? genero { get; set; }

        public string? senha { get; set; }
    }
}