namespace DevLife.Domain.Entities;

public class GameSession
{
    public int GameSessionId { get; set; }
    public int UserId { get; set; }
    public int Score { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public bool IsActive { get; set; }
}