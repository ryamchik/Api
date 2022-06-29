using Api.Controllers;

namespace Api.tests.Controllers
{
    public class StudentControllerGetTests
    {
        [Fact]
        public void GetAll()
        {
            var controller = new StudentController();
            var students = controller.Get();
            Assert.NotNull(students);
        }

        [Theory]
        [InlineData(1)]
        public void GetOne(int id)
        {
            var controller = new StudentController();
            var student = controller.Get(id);
            Assert.NotNull(student);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(-1000)]
        public void GetOneError(int id)
        {
            var controller = new StudentController();
            var student = controller.Get(id);
            Assert.Null(student);
        }
    }
}
