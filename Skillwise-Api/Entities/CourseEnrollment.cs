namespace Skillwise_Api.Entities
{
        public class CourseEnrollment
        {
            public Guid CourseEnrollmentId { get; set; } = Guid.NewGuid();

            public Guid CourseId { get; set; }

            public Course Course { get; set; }

            public Guid StudentId { get; set; }

            public User Student { get; set; }

            public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;

            public bool CourseIsCompleted { get; set; } = false;

            public double ProgressPercentage { get; set; } = 0.0;

            public DateTime? CompletedAt { get; set; }

            public ICollection<ModuleProgress> ModuleProgresses { get; set; } = new List<ModuleProgress>();
        }
    }

