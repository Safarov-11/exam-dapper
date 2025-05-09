using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentParentService : IStudentParentService
{
    private readonly DataContext context = new DataContext();

    public void AddStudentParent(StudentParent studentParent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into studentParent(parentId,studentId,relationship)
            values(@parentId,@studentId,@relationship)";

            var res = connection.Execute(cmd,studentParent);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<StudentParent> GetAllStudentParents(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from studentParent";

            var res = connection.Query<StudentParent>(cmd).ToList();
            return res;
        }
    }

    public void UpdateStudentParents(StudentParent studentParent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update studentParent 
            set parentId = @parentId,
            studentId = @studentId,
            relationship = @relationship
            where id = @id";

            var res = connection.Execute(cmd,studentParent);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteStudentParent(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from studentParent where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
