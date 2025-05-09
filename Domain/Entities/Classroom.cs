namespace Domain.Entities;

public class Classroom
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public int RoomType { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
