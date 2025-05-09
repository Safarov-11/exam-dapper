using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SubjectService : ISubjectService
{
    private readonly DataContext context = new DataContext();

    public void AddSubject(Subject subject){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into subject(title,schoolId,stage,term,carryMark,createdAt,updatedAt)
            values(@title,@schoolId,@stage,@term,@carryMark,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,subject);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Subject> GetAllSubjects(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from subject";

            var res = connection.Query<Subject>(cmd).ToList();
            return res;
        }
    }

    public void UpdateSubjects(Subject subject){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update subject 
            set title = @title, schoolId = @schoolId, 
            stage = @stage, term = @term,
            carryMark = @carryMark, createdAt = @createdAt, 
            updatedAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,subject);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteSubject(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from subject where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
