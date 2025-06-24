namespace DevLife.Domain.Entities;

public class CasinoBet
{
    public int CasinoBetId { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }
    public int BetAmount { get; set; }
    public int GuessedAnswer { get; set; }
    public bool IsCorrect { get; set; }
    public int PointsWon { get; set; }
    public DateTime PlacedAt { get; set; }
        
    // Relations :
    
    // CasinoBet => User
    public virtual User? User { get; set; }
    
    // CasinoBet => CasinoGame
    public virtual CasinoGame? Game { get; set; }
}