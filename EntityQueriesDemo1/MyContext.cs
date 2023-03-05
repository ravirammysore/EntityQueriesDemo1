using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityQueriesDemo1;

public class MyContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var server = "(localdb)";
        var instance = "mssqllocaldb";
        var database = "UniversityDB";
        var authentication = "Integrated Security = true";

        var conString = $"Data Source={server}\\{instance}; Initial Catalog={database};{authentication}";

        options.UseSqlServer(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasData(
                new Student() { StudentID = 1, StudentName = "John Nigel", Mark = 73, City = "NYC" },
                new Student() { StudentID = 2, StudentName = "Alex Roma", Mark = 51, City = "CA" },
                new Student() { StudentID = 3, StudentName = "Noha Shamil", Mark = 88, City = "CA" },
                new Student() { StudentID = 4, StudentName = "James Palatte", Mark = 60, City = "NYC" },
                new Student() { StudentID = 5, StudentName = "Ron Jenova", Mark = 85, City = "NYC" }
            );
    }
}
