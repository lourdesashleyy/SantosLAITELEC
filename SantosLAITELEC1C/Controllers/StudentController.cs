using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;
using SantosLAITELEC1C.Services;

namespace SantosLAITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public StudentController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }
        public IActionResult Index()
        {

            return View(_fakeData.StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student deleteStudent)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.StudentId == deleteStudent.StudentId);

            if (student != null)//was an student found?
            {
                _fakeData.StudentList.Remove(student);
                return RedirectToAction("Index");
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _fakeData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Student editStudent)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.StudentId == editStudent.StudentId);
            if (student != null)
            {
                student.StudentId = editStudent.StudentId;
                student.StudentFirstName = editStudent.StudentFirstName;
                student.StudentLastName = editStudent.StudentLastName;
                student.Course = editStudent.Course;
            }
            return RedirectToAction("Index");
        }
    }
}
