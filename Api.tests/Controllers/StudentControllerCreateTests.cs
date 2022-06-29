using Api.Controllers;
using Api.Models;
using Newtonsoft.Json;

namespace Api.tests.Controllers
{
    public class StudentControllerCreateTests
    {
        [Theory]
        [InlineData(1, "Иванов Иван Иванович", "22.02.1998", "06:00", "J5121")]
        [InlineData(2, "Петров Федор Михайлович", "12.05.1992", "12:32", "J5121")]
        public void CreateStudent(int id, string name, string date, string time, string group)
        {
            var guis = new Guid();
            Student trueStudent = new Student(id, name, date, time, group);

            var controller = new StudentController();
            var testStudent = controller.PostForTest(id, name, date, time, group);

            var expectation = JsonConvert.SerializeObject(trueStudent);
            var reality = JsonConvert.SerializeObject(testStudent);

            Assert.NotNull(testStudent);
            Assert.Equal(expectation, reality);
        }
    }
}
