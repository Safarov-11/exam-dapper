using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassService
{
     void AddClass(Class Class);
    List<Class> GetAllClasss();
    void UpdateClasss(Class Class);
    void DeleteClass(int id);
}
