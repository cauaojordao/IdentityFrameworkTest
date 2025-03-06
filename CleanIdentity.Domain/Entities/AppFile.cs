using System.ComponentModel.DataAnnotations.Schema;
using CleanIdentity.Domain.Common;

namespace CleanIdentity.Domain.Entities
{
    public class AppFile : BaseEntity
    {
        public Guid UserId { get; set; }
        public string? Folder { get; set; }
        public string Name { get; set; } = "Untitled File";
        public string Summary { get; set; } = string.Empty;
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        [Column(TypeName = "decimal(2,1)")]
        public decimal Efficiency { get; set; } = 0;
    }
}