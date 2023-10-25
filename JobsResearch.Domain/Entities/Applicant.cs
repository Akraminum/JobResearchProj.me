
using JobResearch.Domain.Entities.Extend;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;


namespace JobResearch.Domain.Entities
{
    public class Applicant : BaseEntity
    {
        public ApplicantStatus ApplicantStatus { get; set; } = ApplicantStatus.Pending;

        // ========= Relations ========= //

        [ForeignKey(nameof(JobSeeker))]
        public string JobSeekerId { get; set; } = null!;
        public JobSeekerUser? JobSeeker { get; set; }


        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }
        public Job? Job { get; set; }

    }
}
