using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities.Extend
{
    [Table("JobSeekers")]
    public class JobSeekerUser : ApplicationUser
    {
        public JobSeekerUser() : base() => UserType = UserTypes.JobSeeker;

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime? BirthDate { get; set; } 
        public string? ResumePath { get; set; }
        public string? ImagePath { get; set; }

        // ========= Relations ========= //
        public IEnumerable<Applicant>? Applicants { get; set; }
        public IEnumerable<Skill>? Skills { get; set; }
        public IEnumerable<Qualification>? Qualifications { get; set; }
        public IEnumerable<Experience>? Experiences { get; set; }

    }
}
