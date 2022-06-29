using Api.Controllers;

namespace Api.tests.Controllers
{
    public class StudentControllerPutTests
    {
        [Theory]
        [InlineData(1, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        public void UpdateStudent(int id, string name, string date, string time, string group)
        {
            var controller = new StudentController();
            controller.Put(id, name, date, time, group);
        }

        [Theory]
        [InlineData(100, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        [InlineData(-100, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        public void UpdateStudentError(int id, string name, string date, string time, string group)
        {
            var controller = new StudentController();
            Assert.Throws<Exception>(() => controller.Put(id, name, date, time, group)); 
        }
    }
}
