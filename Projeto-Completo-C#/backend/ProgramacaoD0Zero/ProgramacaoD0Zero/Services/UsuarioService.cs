//CLASSE SERVICE: Responsável por fazer a comunicação entre o Controller e o Repository, 
//fazer as validações e regras de negócio

using ProgramacaoDoZero.Common;
using ProgramacaoDoZero.Entities;
using ProgramacaoDoZero.Models;
using ProgramacaoDoZero.Repositories;

namespace ProgramacaoDoZero.Services
{
    /// <summary>
    /// Classe responsável por gerenciar as operações relacionadas ao usuário,
    /// como login, cadastro e recuperação de senha.
    /// </summary>
    public class UsuarioService
    {
        private string _connectionString;
        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public LoginResult Login(string email, string senha)
        {
            var result = new LoginResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            //var usuario = new UsuarioRepository(_connectionString).ObterUsuarioPorEmail;

            if (usuario == null)
            {
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos!";
            }
            else if (usuario.senha == senha)
            {
                result.sucesso = true;
                result.usuarioGuid = usuario.usuarioGuid;
                result.mensagem = "Login realizado com sucesso!";

            }
            else
            {
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos!";
            }

            return result;
        }


        public CadastroResult Cadastro(string nome,
            string sobrenome,
            string telefone,
            string email,
            string genero,
            string senha)
        {
            var result = new CadastroResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario existe
                result.sucesso = false;
                result.mensagem = "Usuário já existe no sistema!";

            }
            else
            {
                //usuario não existe
                usuario = new Usuario();

                usuario.nome = nome;
                usuario.sobrenome = sobrenome;
                usuario.telefone = telefone;
                usuario.email = email;
                usuario.genero = genero;
                usuario.senha = senha;
                usuario.usuarioGuid = Guid.NewGuid();

                var insertResult = usuarioRepository.Inserir(usuario);

                if (insertResult > 0)
                {
                    //usuario inserido com sucesso
                    result.sucesso = true;
                    result.usuarioGuid = usuario.usuarioGuid;
                    result.mensagem = "Cadastro realizado com sucesso!";
                }
                else
                {
                    //erro ao inserir usuario
                    result.sucesso = false;
                    result.mensagem = "Erro ao cadastrar usuário. Tente novamente!";
                }

            }

            return result;
        }

        public EsqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new EsqueceuSenhaResult();

            var usuario = new UsuarioRepository(_connectionString).ObterUsuarioPorEmail(email);

            if (usuario == null)
            {
                // usuario não existe
                result.sucesso = false;
                result.mensagem = "Usuário não existe no sistema!";
            }
            else
            {
                // usuario existe
                var assunto = "Programação do Zero - Recuperação de senha";
                var corpo = "Sua senha é: " + usuario.senha;

                if (!string.IsNullOrEmpty(usuario.email))
                {
                    var emailSender = new EmailSender();
                    emailSender.EnviarEmail(assunto, corpo, usuario.email!);

                    result.sucesso = true;
                    result.mensagem = "E-mail de recuperação de senha enviado com sucesso!";
                }
                else
                {
                    result.sucesso = false;
                    result.mensagem = "E-mail do usuário não está cadastrado.";
                }
            }

            return result;
        }

        public Usuario? ObterUsuario(Guid usuarioGuid)
        {
            var usuario = new UsuarioRepository(_connectionString).ObterPorGuid(usuarioGuid);

            return usuario;
        }
    }
}