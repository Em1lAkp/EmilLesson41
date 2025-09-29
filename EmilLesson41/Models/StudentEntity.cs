namespace EmilLesson41.Models
{
    public class StudentEntity
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public List<CourseEntity>? Courses { get; set; } = [];
    }
}
