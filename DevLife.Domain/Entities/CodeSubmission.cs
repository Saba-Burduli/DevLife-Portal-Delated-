namespace DevLife.Domain.Entities;

public class CodeSubmission
{
    public int CodeSubmissionId { get; set; }
    public string Code { get; set; }
    public string Language { get; set; }
    public bool IsCorrect { get; set; }
    public int ExecutionTime { get; set; }
    public string RoastFeedback { get; set; }
    public int Score { get; set; }
    public DateTime SubmittedAt { get; set; }

    // Relations :

    //CodeSubmission => User
    public int UserId { get; set; }
    public virtual User? User { get; set; }

    //CodeSubmission => CodeChallenge
    public int ChallengeId { get; set; }
    public virtual CodeChallenge? Challenge { get; set; }
}