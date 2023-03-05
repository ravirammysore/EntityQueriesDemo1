﻿// <auto-generated />
using EntityQueriesDemo1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityQueriesDemo1.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            City = "NYC",
                            Mark = 73,
                            StudentName = "John Nigel"
                        },
                        new
                        {
                            StudentID = 2,
                            City = "CA",
                            Mark = 51,
                            StudentName = "Alex Roma"
                        },
                        new
                        {
                            StudentID = 3,
                            City = "CA",
                            Mark = 88,
                            StudentName = "Noha Shamil"
                        },
                        new
                        {
                            StudentID = 4,
                            City = "NYC",
                            Mark = 60,
                            StudentName = "James Palatte"
                        },
                        new
                        {
                            StudentID = 5,
                            City = "NYC",
                            Mark = 85,
                            StudentName = "Ron Jenova"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
