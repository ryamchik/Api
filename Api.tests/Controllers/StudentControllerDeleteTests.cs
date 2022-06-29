using Api.Controllers;

namespace Api.tests.Controllers
{
    public class StudentControllerDeleteTests
    {
        [Theory]
        [InlineData(1)]
        public void DeleteStudent(int id)
        {
            var controller = new StudentController();
            controller.Delete(id);
            Assert.Throws<Exception>(() => controller.Get(id));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(-100)]
        public void DeleteStudentError(int id)
        {
            var controller = new StudentController();
            Assert.Throws<Exception>(() => controller.Delete(id));
        }
    }
}
