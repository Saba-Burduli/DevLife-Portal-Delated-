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
    public ExperienceLevel Experience { get; set; }
    public int Points { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? LastLogonAt { get; set; }

    //Relations :
    
    //User => GameSession
    public List<GameSession> GameSessions { get; set; } = new();
    
    //User => CasinoBet
    public List<CasinoBet> CasinoBets { get; set; } = new();
    
    //User => CodeSubmission
    public List<CodeSubmission> CodeSubmissions { get; set; } = new();
}