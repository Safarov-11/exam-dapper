using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IParentService
{
     void AddParent(Parent parent);
    List<Parent> GetAllParents();
    void UpdateParents(Parent parent);
    void DeleteParent(int id);
}
