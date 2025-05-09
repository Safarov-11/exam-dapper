using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IStudentService
{
    void AddStudent(Student student);
    List<Student> GetAllStudents();
    void UpdateStudents(Student student);
    void DeleteStudent(int id);
}
