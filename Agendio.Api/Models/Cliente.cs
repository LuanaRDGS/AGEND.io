using System.ComponentModel.DataAnnotations;
namespace AGENDIO.API.Models;

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome_Cliente { get; set; } = string.Empty;
    public string Tel_cliente { get; set; } = string.Empty;
    public string Email_cliente { get; set; } = string.Empty;

    public Guid BusinessId { get; set; }
    public Negocio Business { get; set; } = null!;

    public ICollection<Marcacao> Appointments { get; set; } = new List<Marcacao>();

}