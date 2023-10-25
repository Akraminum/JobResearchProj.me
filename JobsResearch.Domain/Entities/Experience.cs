using JobResearch.Domain.Entities.Extend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities
{
    public class Experience : BaseEntity
    {
        public int ExperienceId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string? Description { get; set; } // months

        // ========= Relations ========= //

        [ForeignKey(nameof(JobSeeker))]
        public string JobSeekerId { get; set; } = null!;
        public JobSeekerUser? JobSeeker { get; set; }

    }
}
