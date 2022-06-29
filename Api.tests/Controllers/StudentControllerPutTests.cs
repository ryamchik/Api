using Api.Controllers;
using Api.Models;
using Newtonsoft.Json;

namespace Api.tests.Controllers
{
    public class StudentControllerPutTests
    {
        [Theory]
        [InlineData(2, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        public void UpdateStudent(int id, string name, string date, string time, string group)
        {
            var controller = new StudentController();
            controller.Put(id, name, date, time, group);

            var expectation = JsonConvert.SerializeObject(new Student(id, name, date, time, group));
            var reality = JsonConvert.SerializeObject(controller.Get(id));

            Assert.Equal(expectation, reality);
        }

        [Theory]
        [InlineData(100, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        [InlineData(-100, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        public void UpdateStudentError(int id, string name, string date, string time, string group)
        {
            var controller = new StudentController();
            var exception = Assert.Throws<Exception>(() => controller.Put(id, name, date, time, group));

            Assert.Equal("Студента c таким id = " + id + " нет в расписании", exception.Message);
        }
    }
}
