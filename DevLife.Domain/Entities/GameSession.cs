using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevLife.Domain.Entities;

public class GameSession
{
    [Key]
    public int GameSessionId { get; set; }
    public int Score { get; set; }
    public int Distance { get; set; }
    public int BugsAvoided { get; set; }
    public int DeadlinesAvoided { get; set; }
    public int CoffeeCollected { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public bool IsActive { get; set; }
    public string? SessionId { get; set; }
        
    // Relations :
    
    //GameSession => User
    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User? User { get; set; }
}