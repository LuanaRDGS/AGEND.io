using System.ComponentModel.DataAnnotations;

namespace AGENDIO.API.Models;

public class Servicos
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome_Serv { get; set; } = string.Empty;
    public int Duracao_Serv { get; set; }
    public decimal Preco_Serv { get; set; }

    public Guid BusinessId { get; set; }
    public Negocio Business { get; set; } = null!;
}