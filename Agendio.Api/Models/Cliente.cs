public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Nome_Cliente { get; set; } = string.Empty;

    [Required]
    public string Tel_cliente { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email_cliente { get; set; } = string.Empty;

    public Guid BusinessId { get; set; }

    public Negocio Business { get; set; } = null!;

    public ICollection<Marcacao> Appointments { get; set; } = new List<Marcacao>();
}