using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SchoolService : ISchoolService
{
    private readonly DataContext context = new DataContext();

    public void AddSchool(School school){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into school(schoolTitle,levelCount,isActive,createdAt,updatedAt)
            values(@schoolTitle,@levelCount,@isActive,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,school);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<School> GetAllSchools(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from school";

            var res = connection.Query<School>(cmd).ToList();
            return res;
        }
    }

    public void UpdateSchools(School school){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update school set
            schoolTitle = @schoolTitle, levelCount = @levelCount,
            isActive = @isActive, createdAt = @createdAt, 
            updatedAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,school);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteSchool(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from school where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }

}
