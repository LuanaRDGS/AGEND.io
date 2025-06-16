using System.ComponentModel.DataAnnotations;
namespace AGENDIO.API.Models;

public class Negocio
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome_Negocio { get; set; } = string.Empty;
    public string Desc_Negocio { get; set; } = string.Empty;
    public string End_negocio { get; set; } = string.Empty;
    public string Tel_Negocio { get; set; } = string.Empty;

    public ICollection<Funcionario> Employees { get; set; } = new List<Funcionario>();
    public ICollection<Cliente> Clients { get; set; } = new List<Cliente>();
    public ICollection<Servicos> Services { get; set; } = new List<Servicos>();
}