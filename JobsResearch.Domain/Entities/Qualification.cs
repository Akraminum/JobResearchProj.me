using JobResearch.Domain.Entities.Extend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities
{
    public class Qualification : BaseEntity
    {
        [Key]
        public int QualificationId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string? Degree { get; set; }
        public string FieldOfStudy { get; set; } = null!;
        public int Duration { get; set; } // months
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public double? Grade { get; set; }
        public string? Description { get; set; }

        // ========= Relations ========= //

        [ForeignKey(nameof(JobSeeker))]
        public string JobSeekerId { get; set; } = null!;
        public JobSeekerUser? JobSeeker { get; set; }

    }
}
