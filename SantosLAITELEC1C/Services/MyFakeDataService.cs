using System;
using SantosLAITELEC1C.Models;
using SantosLAITELEC1C.Services;

namespace SantosLAITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
            public List<Student> StudentList { get; }
            public List<Instructor> InstructorList { get; }
            //Constructor
            public MyFakeDataService()
            {
                StudentList = new List<Student>
            {
                new Student()
                {
                    StudentId= 1,
                    StudentFirstName = "Gabriel",
                    StudentLastName = "Montano", 
                    Course = Course.BSIS, 
                    AdmissionDate = DateTime.Parse("2022-08-26")
                },
                new Student()
                {
                    StudentId= 2,
                    StudentFirstName = "Zyx",
                    StudentLastName = "Montano", 
                    Course = Course.BSIS, 
                    AdmissionDate = DateTime.Parse("2022-08-07")
                },
                new Student()
                {
                    StudentId= 3,
                    StudentFirstName = "Aerdriel",
                    StudentLastName = "Montano", 
                    Course = Course.BSIS, 
                    AdmissionDate = DateTime.Parse("2020-01-25")
                }
            };
                InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    InstructorId= 1,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano", 
                    Rank = Rank.AssociateProfessor, 
                    HiringDate = DateTime.Parse("2022-08-26"), 
                    IsTenured = false
                },
                new Instructor()
                {
                    InstructorId= 2,
                    InstructorFirstName = "Zyx",
                    InstructorLastName = "Montano", 
                    Rank = Rank.AssistantProfessor, 
                    HiringDate = DateTime.Parse("2022-08-07"), 
                    IsTenured = false
                },
                new Instructor()
                {
                    InstructorId= 3,
                    InstructorFirstName = "Aerdriel",
                    InstructorLastName = "Montano", 
                    Rank = Rank.Instructor, 
                    HiringDate = DateTime.Parse("2020-01-25"), 
                    IsTenured = true
                }
            };
            }

        }
}
