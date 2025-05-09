using Domain.Enums;

namespace Domain.Entities;

public class StudentParent
{
    public int Id { get; set; }
   public int StudentId { get; set; }
   public int ParentId { get; set; }
   public Relationship Relationship { get; set; }
}
