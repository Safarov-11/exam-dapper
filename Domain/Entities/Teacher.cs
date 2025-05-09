using Domain.Enums;

namespace Domain.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string FullName { get; set; }
    public Gender Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Status IsActive { get; set; }
    public DateTime JoinDate { get; set; }
    public int WorkingDays { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
