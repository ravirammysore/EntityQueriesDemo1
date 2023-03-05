using EntityQueriesDemo1;
using Microsoft.EntityFrameworkCore;

var db = new MyContext();

try
{
    Console.WriteLine("Preparing database...");
    db.Database.Migrate();

    Console.WriteLine("Starting to seed data...");
    db.Database.EnsureCreated();
    Console.WriteLine("seed data completed!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Quitting the application now.");
    Console.ReadKey();
    return;
}

Console.WriteLine("Display Name and Mark of students with Mark higher than 80:");

var toppers = from student in db.Students
              where student.Mark > 80
              select student;

foreach (var s in toppers)
    Console.WriteLine(s.StudentName + " " + s.Mark);
Console.WriteLine();

Console.WriteLine("Display Name and City of students from NYC with Mark higher than 70:");

var res = db.Students.Where(s => s.Mark > 70 && s.City == "NYC");

foreach (var s in res)
    Console.WriteLine(s.StudentName + " " + s.City);
Console.WriteLine();

Console.WriteLine("Display the name of the first student who has scored less than 60");
var res1 = db.Students.First(s => s.Mark < 60);
Console.WriteLine(res1.StudentName);

//or

var res2 = db.Students.Where(s => s.Mark < 60).First();
Console.WriteLine(res2.StudentName);

Console.ReadKey();