using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ITeacherService
{
     void AddTeacher(Teacher teacher);
    List<Teacher> GetAllTeachers();
    void UpdateTeachers(Teacher teacher);
    void DeleteTeacher(int id);
}
