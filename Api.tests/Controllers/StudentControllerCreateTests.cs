using Api.Controllers;
using Api.Models;
using Newtonsoft.Json;
using System.Web.Http;

namespace Api.tests.Controllers
{
    public class StudentControllerCreateTests
    {
        [Theory]
        [InlineData("Иванов Иван Иванович", "22.02.1998", "06:33:22", "J5121")]
        [InlineData("Иванов Иван Иванович", "12", "06:33:22", "J5121")]
        public void CreateStudent(string name, string date, string time, string group)
        {
            var guis = new Guid();
            Student trueStudent = new Student
            {
                Id = guis,
                Name = name,
                Date = date,
                Time = time,
                Group = group
            };

            var controller = new StudentController();
            var testStudent = controller.Post(name, date, time, group, guis);

            var expectation = JsonConvert.SerializeObject(trueStudent);
            var reality = JsonConvert.SerializeObject(testStudent);

            Assert.NotNull(testStudent);
            Assert.Equal(expectation, reality);
        }
    }
}
