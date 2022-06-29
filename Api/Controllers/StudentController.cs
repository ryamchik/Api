using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>() { 
            new Student(1, "Иванов Иван Иванович", "22.02.1998", "07:00", "J5121"),
            new Student(2, "Петренко Михаил", "24.04.1998", "12:00", "J5221"),
            new Student(3, "Курицын Василий Вячеславович", "21.12.1997", "14:00", "J5321"),
            new Student(4, "Зиновьева Раиса Ильинична", "17.05.1998", "18:00", "J5121"),
        };
        

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var indexOfStudent = students.FindIndex(student => student.Id == id);
            if (indexOfStudent > 0)
                return students[indexOfStudent];
            else
                throw new Exception("Студента c таким id = " + id + " нет в расписании");
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post(int id, string name, string date, string time, string group)
        {
            Student newStudent = new Student(id, name, date, time, group);
            students.Add(newStudent);
        }

        [HttpPost("test")]
        public Student PostForTest(int id, string name, string date, string time, string group)
        {
            Student newStudent = new Student(id, name, date, time, group);
            return newStudent;
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, string name, string date, string time, string group)
        {
            var indexOfStudent = students.FindIndex(student => student.Id == id);
            if (indexOfStudent > 0)
                students[indexOfStudent] = new Student(id, name, date, time, group);
            else
                throw new Exception("Студента c таким id = " + id + " нет в расписании");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var indexOfStudent = students.FindIndex(student => student.Id == id);
            if (indexOfStudent > 0)
                students.RemoveAt(indexOfStudent);
            else
                throw new Exception("Студента c таким id = " + id + " нет в расписании");
        }
    }
}
