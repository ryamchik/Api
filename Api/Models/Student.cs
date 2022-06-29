namespace Api.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }  
        public string Date { get; set; }
        public string Time { get; set; }
        public string Group { get; set; }

        public Student(int id, string name, string date, string time, string group)
        {
            Id = id;
            Name = name;
            Date = date;
            Time = time;
            Group = group;
        }
    }
}
