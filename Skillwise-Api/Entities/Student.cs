using System.Diagnostics;

namespace Skillwise_Api.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; } = Guid.NewGuid();
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentClass { get; set; }
        public string? StudentProfilePictureUrl { get; set; }
        public string? StudentGender { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public string StudentEmail { get; set; }
        public string? StudentPhoneNumber { get; set; }
        public string? ClassLevel { get; set; }  
        public string? Major { get; set; }
        public DateTime StudentCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime StudentModifiedDate { get; set; } = DateTime.UtcNow;
        public bool StudentIsActive { get; set; } = true;
        public DateTime? StudentLastLoginDate { get; set; }
        public List<Course>? CompletedCourses { get; set; } 
        public double? AverageGrade { get; set; }
        public double? AttendanceRate { get; set; }

    }
}
