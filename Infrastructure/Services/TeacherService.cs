using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class TeacherService : ITeacherService
{
    private readonly DataContext context = new DataContext();

    public void AddTeacher(Teacher teacher){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            insert into teacher(code,fullname,gender,dob,email,phone,isActive,joinDate,workingDays,createdAt,updateAt)
            values(@code,@fullname,@gender,@dob,@email,@phone,@isActive,@joinDate,@workingDays,@createdAt,@updateAt)";

            var res = connection.Execute(cmd,teacher);
            System.Console.WriteLine(res>0 ? "Sucssesfully inserted to table" : "Failed!");
        }
    }

    public List<Teacher> GetAllTeachers(){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"select * from teacher";

            var res = connection.Query<Teacher>(cmd).ToList();
            return res;
        }
    }

    public void UpdateTeachers(Teacher teacher){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"
            Update teacher
            set code = @code, fullname = @fullname, 
            gender = @gender, dob = @dob,
            email = @email, phone = @phone, 
            isActive = @isActive, joinDate = @joinDate, 
            workingDays =@workingDays
            createdAt = @createdAt, updateAt = @updatedAt
            where id = @id";

            var res = connection.Execute(cmd,teacher);
            System.Console.WriteLine(res>0 ? "Sucssesfully updated table" : "Failed!");
        }
    }

    public void DeleteTeacher(int id){
        using (var connection = context.GetDbConnection())
        {
            var cmd = @"delete from teacher where id = @id";

            var res = connection.Execute( cmd, new { id = id } );
            System.Console.WriteLine(res>0 ? "Sucssesfully deleted from table" : "Failed!");
        }
    }
}
