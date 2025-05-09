namespace Domain.Entities;

public class Parent
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
