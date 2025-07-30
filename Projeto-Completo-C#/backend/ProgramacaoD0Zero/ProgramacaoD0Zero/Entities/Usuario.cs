//CLASSE ENTITY OU ENTIDADES: Objetos que irão mapear o banco de dados e conter os dados do sistema

using System;


namespace ProgramacaoDoZero.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public Guid usuarioGuid { get; set; }
        public string? nome { get; set; }

        public string? sobrenome { get; set; }

        public string? email { get; set; }

        public string? telefone { get; set; }

        public string? genero { get; set; }

        public string? senha { get; set; }
    }
}