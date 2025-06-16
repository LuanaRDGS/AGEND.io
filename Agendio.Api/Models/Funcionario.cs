using System.ComponentModel.DataAnnotations;
namespace AGENDIO.API.Models;

public class Funcionario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome_Func { get; set; } = string.Empty;
    public string Email_Func { get; set; } = string.Empty;
    public string Senha_Func { get; set; } = string.Empty;
    public string Tel_Func { get; set; } = string.Empty;
    public string Espec_Func { get; set; } = string.Empty;

    public Guid BusinessId { get; set; }
    public Negocio Business { get; set; } = null!;

    public ICollection<Marcacao> Appointments { get; set; } = new List<Marcacao>();
}