using DevLife.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevLife.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    DbSet<User> Users { get; set; }
    DbSet<CasinoGame> CasinoGames { get; set; }
    DbSet<CasinoBet> CasinoBets { get; set; }
    DbSet<CodeChallenge> CodeChallenges { get; set; }
    DbSet<CodeSubmission> CodeSubmissions { get; set; }
    DbSet<GameSession> GameSessions { get; set; }
    DbSet<DeveloperProfile> DeveloperProfiles { get; set; }
    DbSet<Match> Matches { get; set; }
    
}