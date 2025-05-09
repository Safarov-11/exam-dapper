using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentService : IStudentService
{
    private readonly DataContext context = new DataContext();

    public void AddStudent(Student student){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into student(code,fullname,gender,dob,email,phone,schoolId,stage,section,isActive,joinDate,createdAt,updatedAt)
            values(@code,@fullname,@gender,@dob,@email,@phone,@schoolId,@stage,@section,@isActive,@joinDate,@createdAt,@updatedAt)";

            var res = connection.Execute(cmd,student);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Student> GetAllStudents(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from student";

            var res = connection.Query<Student>(cmd).ToList();
            return res;
        }
    }

    public void UpdateStudents(Student student){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update student
            set code = @code, fullname = @fullname, 
            gender = @gender, dob = @dob,
            email = @email, phone = @phone, 
            schoolId = schoolId, stage = @stage, 
            section = @section, isActive = @isActive, 
            joinDate = @joinDate, createdAt = @createdAt, updatedAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,student);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteStudent(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from student where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
