using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassroomService
{
     void AddClassroom(Classroom classroom);
    List<Classroom> GetAllClassrooms();
    void UpdateClassrooms(Classroom classroom);
    void DeleteClassroom(int id);
}
