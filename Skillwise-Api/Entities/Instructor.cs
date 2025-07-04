namespace Skillwise_Api.Entities
{
    public class Instructor
    {
        public Guid InstructorId { get; set; } = Guid.NewGuid();
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
        public string? InstructorProfilePictureUrl { get; set; }
        public string? InstructorGender { get; set; }
        public DateTime InstructorDateOfBirth { get; set; }
        public string InstructorEmail { get; set; }
        public string? InstructorPhoneNumber { get; set; }
        public string? Department { get; set; }

        public DateTime InstructorCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime InstructorModifiedDate { get; set; } = DateTime.UtcNow;
        public bool InstructorIsActive { get; set; } = true;
        public DateTime? InstructorLastLoginDate { get; set; }

        public List<Course>? GivenCourses { get; set; }
        public double? InstructorRating { get; set; } 
    }

}
