using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ParentService : IParentService
{
    private readonly DataContext context = new DataContext();

    public void AddParent(Parent parent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into parent(code,fullName,email,phone,createdAt,updatedAt)
            values(@code,@fullName,@email,@phone,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,parent);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Parent> GetAllParents(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from parent";

            var res = connection.Query<Parent>(cmd).ToList();
            return res;
        }
    }

    public void UpdateParents(Parent parent){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update parent set
            code = @code, fullName = @fullName, 
            email = @email, phone = @phone, 
            createdAt = @createdAt, updatedAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,parent);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteParent(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from parent where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
