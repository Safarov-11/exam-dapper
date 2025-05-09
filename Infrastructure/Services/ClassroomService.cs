using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassroomroomService : IClassroomroomService
{
    private readonly DataContext context = new DataContext();

    public void AddClassroom(Classroom classroom){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into classroom(capacity,roomType,description,createdAt,updatedAt)
            values(@capacity,@roomType,@description,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,classroom);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Classroom> GetAllClassrooms(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from classroom";

            var res = connection.Query<Classroom>(cmd).ToList();
            return res;
        }
    }

    public void UpdateClassrooms(Classroom classroom){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update classroom set
            capacity = @capacity, roomType = @roomType,
            description = @description, 
            createdAt = @createdAt, updatedAt = @updateAt
            where id = @id";

            var res = connection.Execute(cmd,classroom);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteClassroom(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from classroom where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }

}

public interface IClassroomroomService
{
}