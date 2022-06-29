using Api.Controllers;

namespace Api.tests.Controllers
{
    public class StudentControllerDeleteTests
    {
        [Theory]
        [InlineData(3)]
        public void DeleteStudent(int id)
        {
            var controller = new StudentController();
            controller.Delete(id);
            var exception = Assert.Throws<Exception>(() => controller.Get(id));

            Assert.Equal("Студента c таким id = " + id + " нет в расписании", exception.Message);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(-100)]
        public void DeleteStudentError(int id)
        {
            var controller = new StudentController();
            var exception = Assert.Throws<Exception>(() => controller.Delete(id));

            Assert.Equal("Студента c таким id = " + id + " нет в расписании", exception.Message);
        }
    }
}
