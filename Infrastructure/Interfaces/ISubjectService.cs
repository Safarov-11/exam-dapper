using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISubjectService
{
     void AddSubject(Subject subject);
    List<Subject> GetAllSubjects();
    void UpdateSubjects(Subject subject);
    void DeleteSubject(int id);
}
