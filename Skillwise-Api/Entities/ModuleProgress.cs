namespace Skillwise_Api.Entities
{
    public class ModuleProgress
    {
        public Guid ModuleProgressId { get; set; } = Guid.NewGuid();

        public Guid CourseEnrollmentId { get; set; }

        public CourseEnrollment CourseEnrollment { get; set; }

        public Guid CourseModuleId { get; set; }

        public CourseModule CourseModule { get; set; }

        public bool ModuleIsCompleted { get; set; } = false;

        public DateTime? CompletedAt { get; set; }
    }
}
