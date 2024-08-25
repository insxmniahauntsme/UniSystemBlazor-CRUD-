namespace UniSystem.Core.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public int AmountOfStudents { get; set; } = 0;
        public double GroupAverage { get; set; } = 0;

    }
}
