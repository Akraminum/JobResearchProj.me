

namespace JobResearch.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}
