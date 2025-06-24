namespace DevLife.Domain.Entities;

public class CodeChallenge
{
    public int CodeChallengeId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? TestCases { get; set; }
    public string? SampleInput { get; set; }
    public string? SampleOutput { get; set; }
    public TechStack TechStack { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}