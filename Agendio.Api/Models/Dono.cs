public class Dono
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome_Dono { get; set; } = string.Empty;
    public string Email_Dono { get; set; } = string.Empty;
    public string Tel_Dono { get; set; } = string.Empty;
    public string Senha_Dono { get; set; } = string.Empty;
}