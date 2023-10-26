using System;
using SantosLAITELEC1C.Models;

namespace SantosLAITELEC1C.Services
{
    public interface IMyFakeDataService
    {
            List<Student> StudentList { get; }
            List<Instructor> InstructorList { get; }
    }
}
