using Domain.Entities;
using Domain.Enums;
using Infrastructure.Services;

System.Console.WriteLine($"\n----------------Student--------------------\n");
StudentService stServ = new StudentService();
Student st1 = new Student(){
    Code = "123456",
    FullName = "Saidov Umed",
    Gender = Gender.Male,
    Dob = new DateTime (2011/11/11),
    Email = "umed11@gmail",
    Phone = "900000001",
    SchoolId = 1,
    Stage = 7,
    Section = "A",
    IsActive = Status.Active,
    JoinDate = new DateTime(2017/09/01),
    CreatedAt = new DateTime(2017/09/01),
    UpdatedAt = new DateTime(2023/09/01)
};
// stServ.AddStudent(st1);
var students = stServ.GetAllStudents();
System.Console.WriteLine("All Students:");
foreach (var s in students)
{
    System.Console.WriteLine($"{s.FullName} {s.Dob} {s.Email} {s.Phone} {s.IsActive}");
}

Student st1Upd = new Student(){
    Id = 1,
    Code = "123456",
    FullName = "Umarov Umed",
    Gender = Gender.Male,
    Dob = new DateTime (2011/11/11),
    Email = "umed0110@gmail",
    Phone = "100000009",
    SchoolId = 1,
    Stage = 8,
    Section = "A",
    IsActive = Status.Active,
    JoinDate = new DateTime(2017/09/01),
    CreatedAt = new DateTime(2017/09/01),
    UpdatedAt = new DateTime(2024/09/01)
};
// stServ.UpdateStudents(st1Upd);

// var students1 = stServ.GetAllStudents();
// System.Console.WriteLine("\nStudents after update:");
// foreach (var s in students1)
// {
//     System.Console.WriteLine($"{s.FullName} {s.Dob} {s.Email} {s.Phone} {s.IsActive}");
// }

// stServ.DeleteStudent(1);
// var students2 = stServ.GetAllStudents();
// System.Console.WriteLine("\nStudents after delete:");
// foreach (var s in students2)
// {
//     System.Console.WriteLine($"{s.FullName} {s.Dob} {s.Email} {s.Phone} {s.IsActive}");
// }

System.Console.WriteLine($"\n----------------Parent--------------------\n");
ParentService prServ = new ParentService();
Parent pr1 = new Parent(){
    Code = "54321",
    FullName = "Saidov Ahtam",
    Email = "saidovv@gmail",
    Phone = "11111110",
    CreatedAt = new DateTime(2017/09/01),
    UpdatedAt = new DateTime(2024/09/01)
};
prServ.AddParent(pr1);
var parents = prServ.GetAllParents();
foreach (var p in parents)
{
    System.Console.WriteLine($"{p.FullName} {p.Phone} {p.Email} {p.CreatedAt}");
}

Parent pr1Upd = new Parent(){
    Id = 1,
    Code = "54321",
    FullName = "Saidov Ahtam",
    Email = "saidovv@gmail",
    Phone = "11111110",
    CreatedAt = new DateTime(2017/09/01),
    UpdatedAt = new DateTime(2024/09/01)
};

prServ.UpdateParents(pr1Upd);
var parents1 = prServ.GetAllParents();
foreach (var p in parents1)
{
    System.Console.WriteLine($"{p.FullName} {p.Phone} {p.Email} {p.CreatedAt}");
}












