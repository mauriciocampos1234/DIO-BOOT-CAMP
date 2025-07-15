using System.ComponentModel.DataAnnotations;

namespace Dominio.DTOs;

public class LoginDTO
{
    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
    public string Email { get; set; } = default!;

    [Required(ErrorMessage = "O campo Senha é obrigatório.")]
    [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
    public string Senha { get; set; } = default!;
}