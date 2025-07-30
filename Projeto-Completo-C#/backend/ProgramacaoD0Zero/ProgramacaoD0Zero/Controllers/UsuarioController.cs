//CLASSE CONTROLLER: Responsável por receber e enviar dados do Frontend, garantir que estão corretos e interagir com o Serviços


using Microsoft.AspNetCore.Mvc;
using ProgramacaoD0Zero.Models;
using ProgramacaoDoZero.Models;
using ProgramacaoDoZero.Services;


namespace ProgramacaoDoZero.Controllers
{

    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IConfiguration _configuration;
        public UsuarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        public LoginResult Login(LoginRequest request)
        {
            var result = new LoginResult(); //Criando a instância da classe


            if (request == null)
            {
                result.sucesso = false;
                result.mensagem = "Requisição está vazia";
            }
            else if (request.email == "")
            {
                result.sucesso = false;
                result.mensagem = "E-mail obrigatório!";
            }
            else if (request.senha == "")
            {
                result.sucesso = false;
                result.mensagem = "A senha é obrigatória!";
            }
            else
            {
                //result.sucesso = true; //Primeira montagem para testes
                //result.mensagem = "Login realizado com sucesso!"; //Primeira montagem para testes

                var connectionString = _configuration.GetConnectionString("programacaoDoZeroDb");

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    result.sucesso = false;
                    result.mensagem = "A string de conexão com o banco de dados não está configurada.";
                    return result;
                }

                var usuarioService = new UsuarioService(connectionString);

                if (request.email != null && request.senha != null)
                {
                    result = usuarioService.Login(request.email, request.senha);
                }
                else
                {
                    result.sucesso = false;
                    result.mensagem = "E-mail e senha não podem ser nulos.";
                }
            }
            return result;

        }

        [HttpPost("cadastro")]
        public CadastroResult Cadastro(CadastroRequest request)
        {
            var result = new CadastroResult();

            if (request == null ||
                string.IsNullOrWhiteSpace(request.nome) ||
                string.IsNullOrWhiteSpace(request.sobrenome) ||
                string.IsNullOrWhiteSpace(request.telefone) ||
                string.IsNullOrWhiteSpace(request.email) ||
                string.IsNullOrWhiteSpace(request.genero) ||
                string.IsNullOrWhiteSpace(request.senha))
            {
                result.sucesso = false;
                result.mensagem = "Requisição está vazia ou campos obrigatórios não preenchidos";
                return result;
            }
            else
            {
                var connectionString = _configuration.GetConnectionString("programacaoDoZeroDb");

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    result.sucesso = false;
                    result.mensagem = "A string de conexão com o banco de dados não está configurada.";
                    return result;
                }

                var usuarioService = new UsuarioService(connectionString);

                result = usuarioService.Cadastro(request.nome, request.sobrenome,
                    request.telefone, request.email, request.genero, request.senha);
            }

            return result;
        }


        [HttpPost("esqueceuSenha")]
        public EsqueceuSenhaResult EsqueceuSenha(EsqueceuSenhaRequest request)
        {
            var result = new EsqueceuSenhaResult();

            if (request == null ||
                string.IsNullOrEmpty(request.email))
            {
                result.sucesso = false;
                result.mensagem = "Requisição está vazia ou campos obrigatórios não preenchidos"; //Primeira montagem para testes
            }
            //else //Primeira montagem para testes
            //{
            var connectionString = _configuration.GetConnectionString("programacaoDoZeroDb");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                result.sucesso = false;
                result.mensagem = "A string de conexão com o banco de dados não está configurada.";
                return result;
            }

            if (request != null && !string.IsNullOrEmpty(request.email))
            {
                result = new UsuarioService(connectionString).EsqueceuSenha(request.email);
            }
            else
            {
                result.sucesso = false;
                result.mensagem = "E-mail não informado.";
            }

            //var usuarioService = new UsuarioService(connectionString);
            //result = usuarioService.EsqueceuSenha(request.email);
            //} //Primeira montagem para testes
            return result;
        }

        [HttpGet("obterUsuario")]
        public ObterUsuarioResult ObterUsuario(string usuarioGuid)
        {
            var result = new ObterUsuarioResult();

            if (string.IsNullOrWhiteSpace(usuarioGuid))
            {
                result.mensagem = "Guid do usuário não informado!";
                return result;
            }

            if (!Guid.TryParse(usuarioGuid, out Guid guid))
            {
                result.mensagem = "Guid do usuário é inválido!";
                return result;
            }

            var connectionString = _configuration.GetConnectionString("programacaoDoZeroDb");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                result.mensagem = "A string de conexão com o banco de dados não está configurada.";
                return result;
            }

            var usuario = new UsuarioService(connectionString).ObterUsuario(guid);

            if (usuario == null)
            {
                result.mensagem = "Usuário não existe!";
            }
            else
            {
                result.sucesso = true;
                result.nome = usuario.nome;
            }

            return result;
        }

    }
}