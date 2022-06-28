namespace Api.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }  
        public DateOnly Date { get; set; }
        public DateTime Time { get; set; }
        public string Group { get; set; }
    }
}
