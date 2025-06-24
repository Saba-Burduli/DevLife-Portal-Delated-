namespace DevLife.Domain.Entities;

public class Match
{
    public int MatchId { get; set; }
    public bool IsLiked { get; set; }
    public bool IsMatched { get; set; }
    public DateTime MatchedAt { get; set; }

    // Relations :
    
    //Match => User
    public int UserId { get; set; }
    public virtual User? User { get; set; }

    // Match => DeveloperProfile
    public int ProfileId { get; set; }
    public virtual DeveloperProfile? Profile { get; set; }
}

