namespace UniSystem.Core.Entities
{
    public class Student
    {
        public DateTime RegistrationDate { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public double AverageScore { get; set; }

    }
}
