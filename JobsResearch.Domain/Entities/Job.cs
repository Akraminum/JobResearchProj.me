using JobResearch.Domain.Entities.Extend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities
{
    public class Job : BaseEntity
    {
        public int JobId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Location { get; set; }
        public int ApplicantsNumber { get; set; }
        //Salary Range
        public int? RangeSalaryMin { get; set; }
        public int? RangeSalaryMax { get; set; }
        public JobStatus JobStatus { get; set; } = JobStatus.Pending;

        // ========= Relations ========= //

        [ForeignKey(nameof(JobCategory))]
        public int JobCategoryId { get; set; }
        public JobCategory? JobCategory { get; set; }

        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public CompanyUser? Company { get; set; }

        public IEnumerable<Applicant>? Applicants { get; set; }

    }
}
