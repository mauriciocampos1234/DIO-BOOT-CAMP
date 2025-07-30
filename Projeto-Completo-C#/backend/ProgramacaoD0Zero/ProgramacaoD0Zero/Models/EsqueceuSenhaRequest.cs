//CLASSE MODELS: Objetos que representam os dados que serão enviados e recebidos pelo Controller
// Temos 2 tipos de Models: Request e Result
//Request: São os dados que o Controller recebe do Frontend
//Result: São os dados que o Controller envia para o Frontend

namespace ProgramacaoDoZero.Models
{
    public class EsqueceuSenhaRequest
    {
        public string? email { get; set; }
    }
}