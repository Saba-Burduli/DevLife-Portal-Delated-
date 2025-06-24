namespace DevLife.Domain.Entities;

public class DeveloperProfile
{
    public int DeveloperProfileId { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public string? Bio { get; set; }
    public TechStack PrimaryTech { get; set; }
    public List<TechStack> Technologies { get; set; } = new();
    public ExperienceLevel Experience { get; set; }
    public string? ProfileImage { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}