using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassStudentService
{
     void AddClassStudent(ClassStudent classstudent);
    List<ClassStudent> GetAllClassStudents();
    void UpdateClassStudents(ClassStudent classstudent);
    void DeleteClassStudent(int id);
}
