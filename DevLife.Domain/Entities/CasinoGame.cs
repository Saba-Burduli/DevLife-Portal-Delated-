using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace DevLife.Domain.Entities;

public class CasinoGame
{
    public int CasinoGameId { get; set; }
    public string? Title { get; set; }
    public string? CodeSnippet1 { get; set; }
    public string? CodeSnippet2 { get; set; }
    public string? Explanation1 { get; set; }
    public string? Explanation2 { get; set; }
    public int CorrectAnswer { get; set; } // 1 or 2
    public TechStack TechStack { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}