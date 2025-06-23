namespace DevLife.Domain.Entities;

public class CasinoGame
{
    public int CasinoGameId { get; set; }
    public string? CodeSnippet1  { get; set; }
    public string? CodeSnippet2  { get; set; }
    public int CorrectAnswer  { get; set; }
    public TechStack TechStack { get; set; }
    public DifficultyLevel DifficultyLevel { get; set; }
}