namespace Skillwise_Api.Entities
{
    public class Course
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string ThumbnailUrl { get; set; }  // Eğitim kartı için görsel (isteğe bağlı)

        public DifficultyLevel Difficulty { get; set; } = DifficultyLevel.Beginner;

        public TimeSpan EstimatedDuration { get; set; }  

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsPublished { get; set; } = false;

        public Guid InstructorId { get; set; }

        public User Instructor { get; set; }  

        public ICollection<CourseModule> Modules { get; set; } = new List<CourseModule>();

        public ICollection<CourseEnrollment> Enrollments { get; set; } = new List<CourseEnrollment>();
    }

    public enum DifficultyLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
}
