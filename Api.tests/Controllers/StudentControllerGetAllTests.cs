using Api.Controllers;

namespace Api.tests.Controllers
{
    public class StudentControllerGetAllTests
    {
        [Fact]
        public void GetAll()
        {
            var controller = new StudentController();
            var students = controller.Get();
            Assert.NotNull(students);
        }
    }
}
