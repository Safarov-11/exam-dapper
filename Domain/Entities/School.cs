using Domain.Enums;

namespace Domain.Entities;

public class School
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int LevelCount { get; set; }
    public Status IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UdatedAt { get; set; }
}
