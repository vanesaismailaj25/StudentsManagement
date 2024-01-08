﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsManagement.Helpers.DbHelpers;

#nullable disable

namespace StudentsManagement.Migrations
{
    [DbContext(typeof(StudentsManagementContext))]
    [Migration("20240108130506_removePropertyId")]
    partial class removePropertyId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentsManagement.DAL.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2001, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vanesa@gmail.com",
                            Gender = 1,
                            LastName = "Ismailaj",
                            Name = "Vanesa",
                            Password = "vanesa123$",
                            PhoneNumber = "0681245789",
                            RegistrationYear = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 3
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2003, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mary@gmail.com",
                            Gender = 1,
                            LastName = "John",
                            Name = "Mary",
                            Password = "mary123$",
                            PhoneNumber = "0681298456",
                            RegistrationYear = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2004, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elon@gmail.com",
                            Gender = 0,
                            LastName = "Smith",
                            Name = "Elon",
                            Password = "elon123$",
                            PhoneNumber = "0694590123",
                            RegistrationYear = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 1
                        });
                });

            modelBuilder.Entity("StudentsManagement.DAL.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Credits = 10,
                            Name = "Operating systems"
                        },
                        new
                        {
                            Id = 2,
                            Credits = 10,
                            Name = "Database management systems"
                        },
                        new
                        {
                            Id = 3,
                            Credits = 10,
                            Name = "Computer networks"
                        },
                        new
                        {
                            Id = 4,
                            Credits = 10,
                            Name = "Web programming"
                        },
                        new
                        {
                            Id = 5,
                            Credits = 5,
                            Name = "Theory of computation and automata theory"
                        },
                        new
                        {
                            Id = 6,
                            Credits = 4,
                            Name = "Software engineering"
                        },
                        new
                        {
                            Id = 7,
                            Credits = 4,
                            Name = "GIS"
                        });
                });

            modelBuilder.Entity("StudentsManagement.DAL.Models.SubjectStudents", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("SubjectStudents");
                });

            modelBuilder.Entity("StudentsManagement.DAL.Models.SubjectStudents", b =>
                {
                    b.HasOne("StudentsManagement.DAL.Models.Student", "Student")
                        .WithMany("SubjectStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsManagement.DAL.Models.Subject", "Subject")
                        .WithMany("SubjectStudents")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentsManagement.DAL.Models.Student", b =>
                {
                    b.Navigation("SubjectStudents");
                });

            modelBuilder.Entity("StudentsManagement.DAL.Models.Subject", b =>
                {
                    b.Navigation("SubjectStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
