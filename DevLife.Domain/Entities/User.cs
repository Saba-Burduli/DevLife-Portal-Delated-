namespace DevLife.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirt { get; set; }
    public ZodiacSign ZodiacSign { get; set; }
    public TechStack TechStack { get; set; }
    public ExperieceLevel Experience { get; set; }
    public int Points { get; set; }
}