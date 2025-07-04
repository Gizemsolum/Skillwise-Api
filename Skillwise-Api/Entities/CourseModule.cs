namespace Skillwise_Api.Entities
{
    public class CourseModule
    {
        public Guid CourseModuleId { get; set; } = Guid.NewGuid();

        public Guid CourseId { get; set; }

        public Course Course { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ContentType { get; set; }  // örn: "Video", "PDF", "Text", "Quiz"

        public string ContentUrl { get; set; } = string.Empty;  // içerik bağlantısı (örn: video URL, PDF dosyası vs.)

        public string? Description { get; set; }

        public int Order { get; set; }  // modül sıralaması

        public TimeSpan EstimatedTime { get; set; }  // modül süresi (isteğe bağlı)

        public ICollection<ModuleProgress> ModuleProgresses { get; set; } = new List<ModuleProgress>();
    }

}
