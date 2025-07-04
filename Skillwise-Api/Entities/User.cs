using System.ComponentModel.DataAnnotations;

namespace Skillwise_Api.Entities
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EnumDataType(typeof(UserRole))]
        public string Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        [Phone]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Egitmen,
        Ogrenci
    }

}
