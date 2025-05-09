using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassService : IClassService
{
    private readonly DataContext context = new DataContext();

    public void AddClass(Class Class){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into Class(className,subjectId,teacherId,classroomId,section,createdAt,updatedAt)
            values(@className,@subjectId,@teacherId,@classroomId,@section,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,Class);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Class> GetAllClasss(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from Class";

            var res = connection.Query<Class>(cmd).ToList();
            return res;
        }
    }

    public void UpdateClasss(Class Class){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update Class set
            className = @claasName, subjectId = @subjectId,
            teacherId = @teacherId, classroomId = @classroomId,
            section = @section, createdAt = @createdAt, 
            updatedAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,Class);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteClass(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from Class where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }

}
