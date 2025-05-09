using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IStudentParentService
{
     void AddStudentParent(StudentParent studentParent);
    List<StudentParent> GetAllStudentParents();
    void UpdateStudentParents(StudentParent studentParent);
    void DeleteStudentParent(int id);
}
