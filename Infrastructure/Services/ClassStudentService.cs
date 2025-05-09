using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassStudentService : IClassStudentService
{
    private readonly DataContext context = new DataContext();

    public void AddClassStudent(ClassStudent classStudent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into classStudent(classId, studentId)
            values(@classId,@studentId)";

            var res = connection.Execute(cmd,classStudent);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<ClassStudent> GetAllClassStudents(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from classStudent";

            var res = connection.Query<ClassStudent>(cmd).ToList();
            return res;
        }
    }

    public void UpdateClassStudents(ClassStudent classStudent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update classStudent set
            classId = @classId, studentId = @studentId
            where id = @id";

            var res = connection.Execute(cmd,classStudent);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteClassStudent(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from classStudent where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
