namespace UniSystem.Core.Entities
{
    public class Student
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public double AverageScore { get; set; }

    }
}
