using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISchoolService
{
     void AddSchool(School school);
    List<School> GetAllSchools();
    void UpdateSchools(School school);
    void DeleteSchool(int id);
}
