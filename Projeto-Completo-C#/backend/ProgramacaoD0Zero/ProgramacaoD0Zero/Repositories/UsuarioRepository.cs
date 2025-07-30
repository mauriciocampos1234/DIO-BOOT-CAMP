//CLASSE REPOSITORY: Responsável por fazer a comunicação com o banco de dados, fazer o CRUD (Ler, Criar(Inserir), Atualizar e Deletar) dados

using MySql.Data.MySqlClient;
using ProgramacaoDoZero.Entities;

namespace ProgramacaoDoZero.Repositories
{
    public class UsuarioRepository
    {
        private string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //private string _connectionString;

        //Construtor padrão
        //public UsuarioRepository(string connectionString)
        //{
        //Construtor com injeção de dependência
        //_connectionString = connectionString;
        //}
        public int Inserir(Usuario usuario)
        {
             //var result = 1; //Primeira montagem para testes
             //return result;  //Primeira montagem para testes

            var cnn = new MySqlConnection(_connectionString);

            var cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = @"INSERT INTO usuario 
                (nome, sobrenome, telefone, email, genero, senha, usuarioGuid) 
                VALUES 
                (@nome, @sobrenome, @telefone, @email, @genero, @senha, @usuarioGuid)"; //Na linguagem SQL @ significa que é um parâmetro
            
            cmd.Parameters.AddWithValue("nome", usuario.nome);
            cmd.Parameters.AddWithValue("sobrenome", usuario.sobrenome);
            cmd.Parameters.AddWithValue("telefone", usuario.telefone);
            cmd.Parameters.AddWithValue("email", usuario.email);
            cmd.Parameters.AddWithValue("genero", usuario.genero);
            cmd.Parameters.AddWithValue("senha", usuario.senha);
            cmd.Parameters.AddWithValue("usuarioGuid", usuario.usuarioGuid);

            //Abrindo a conexão
            cnn.Open();
            //Executando o comando
            var affectedRows = cmd.ExecuteNonQuery();
            //Fechando a conexão
            cnn.Close();
            //Retornando o número de linhas afetadas
            return affectedRows;
        }

        public Usuario? ObterUsuarioPorEmail(string email)
        {
            Usuario? usuario = null;
            
            //var result = new Usuario(); //Primeira montagem para testes
            //return result; //Primeira montagem para testes

            using (MySqlConnection cnn = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT * FROM usuario WHERE email = @email"; //O @ significa que o  = @email é um parâmetro na linguagem SQL
                    cmd.Parameters.AddWithValue("email", email);

                    cnn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario();

                            //Preenchendo os dados do usuário
                            usuario.Id = Convert.ToInt32(reader["id"]);
                            usuario.nome = reader["nome"].ToString();
                            usuario.sobrenome = reader["sobrenome"].ToString();
                            usuario.telefone = reader["telefone"].ToString();
                            usuario.email = reader["email"].ToString();
                            usuario.genero = reader["genero"].ToString();
                            usuario.senha = reader["senha"].ToString();

                            //Inserindo Guid
                            var usuarioGuid = reader["usuarioGuid"]?.ToString();
                            if (!string.IsNullOrEmpty(usuarioGuid))
                            {
                                usuario.usuarioGuid = new Guid(usuarioGuid);
                            }
                        }
                    }
                }
            }

            //Retornando o usuário
            return usuario;
        }

        public Usuario? ObterPorGuid(Guid usuarioGuid)
        {
            Usuario? usuario = null;

            var cnn = new MySqlConnection(_connectionString);

            var cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM usuario WHERE usuarioGuid = @usuarioGuid";

            cmd.Parameters.AddWithValue("usuarioGuid", usuarioGuid);

            cnn.Open();

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario();

                //Preenchendo os dados do usuário
                usuario.Id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0;
                usuario.nome = reader["nome"] != DBNull.Value ? reader["nome"].ToString() : string.Empty;
                usuario.sobrenome = reader["sobrenome"] != DBNull.Value ? reader["sobrenome"].ToString() : string.Empty;
                usuario.telefone = reader["telefone"] != DBNull.Value ? reader["telefone"].ToString() : string.Empty;
                usuario.email = reader["email"] != DBNull.Value ? reader["email"].ToString() : string.Empty;
                usuario.genero = reader["genero"] != DBNull.Value ? reader["genero"].ToString() : string.Empty;
                usuario.senha = reader["senha"] != DBNull.Value ? reader["senha"].ToString() : string.Empty;
                
                //Inserindo Guid
                var guidObj = reader["usuarioGuid"];
                var guidStr = guidObj != DBNull.Value ? guidObj.ToString() : null;
                if (!string.IsNullOrEmpty(guidStr))
                {
                    usuario.usuarioGuid = new Guid(guidStr);
                }
            }

            //Fechando a conexão
            cnn.Close();

            return usuario;
        }
    }
}