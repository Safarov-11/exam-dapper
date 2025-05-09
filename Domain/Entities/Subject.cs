namespace Domain.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int SchoolId { get; set; }
    public int Stage { get; set; }
    public int Term { get; set; }
    public int CarryMark { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
