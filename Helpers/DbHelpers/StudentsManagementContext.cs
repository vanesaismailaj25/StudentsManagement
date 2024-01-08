using Microsoft.EntityFrameworkCore;
using StudentsManagement.DAL.Enums;
using StudentsManagement.DAL.Models;

namespace StudentsManagement.Helpers.DbHelpers
{
    public class StudentsManagementContext : DbContext
    {
        public StudentsManagementContext()
        {
        }

        public StudentsManagementContext(DbContextOptions<StudentsManagementContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                Name = "Vanesa",
                LastName = "Ismailaj",
                DateOfBirth = new DateTime(2001, 07, 25),
                Gender = Gender.Female,
                Email = "vanesa@gmail.com",
                PhoneNumber = "0681245789",
                StudentYear = 3,
                RegistrationYear = new DateTime(2020, 10, 01),
                Password = "vanesa123$"
            },
            new Student
            {
                Id = 2,
                Name = "Mary",
                LastName = "John",
                DateOfBirth = new DateTime(2003, 03, 22),
                Gender = Gender.Female,
                Email = "mary@gmail.com",
                PhoneNumber = "0681298456",
                StudentYear = 2,
                RegistrationYear = new DateTime(2019, 10, 01),
                Password = "mary123$"
            },
            new Student
            {
                Id = 3,
                Name = "Elon",
                LastName = "Smith",
                DateOfBirth = new DateTime(2004, 02, 24),
                Gender = Gender.Male,
                Email = "elon@gmail.com",
                PhoneNumber = "0694590123",
                StudentYear = 1,
                RegistrationYear = new DateTime(2022, 10, 01),
                Password = "elon123$"
            }
          );

            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    Name = "Operating systems",
                    Credits = 10
                },
                new Subject
                {
                    Id = 2,
                    Name = "Database management systems",
                    Credits = 10
                },
                new Subject
                {
                    Id = 3,
                    Name = "Computer networks",
                    Credits = 10
                },
                new Subject
                {
                    Id = 4,
                    Name = "Web programming",
                    Credits = 10
                },
                new Subject
                {
                    Id = 5,
                    Name = "Theory of computation and automata theory",
                    Credits = 5
                },
                new Subject
                {
                    Id = 6,
                    Name = "Software engineering",
                    Credits = 4,
                },
                new Subject
                {
                    Id = 7,
                    Name = "GIS",
                    Credits = 4
                }
                );

            modelBuilder.Entity<SubjectStudents>().HasKey(ss => new { ss.SubjectId, ss.StudentId });
        }
    }
}
