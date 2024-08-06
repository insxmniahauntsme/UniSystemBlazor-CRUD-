namespace UniSystem.Core.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public string? Faculty { get; set; }
        public int AmountOfStudents { get; set; }
        public double GroupAverage { get; set; }

    }
}
