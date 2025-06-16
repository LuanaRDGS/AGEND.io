using System.ComponentModel.DataAnnotations;
using Agendio.Enums;

namespace AGENDIO.API.Models;
public class Marcacao
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DateTime { get; set; }

    public MarcacaoStatusEnum Status { get; set; } = MarcacaoStatusEnum.HorarioVago;
}