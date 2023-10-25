using JobResearch.Domain.Entities.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; } = null!;

        // ========= Relations ========= //
        
        public IEnumerable<JobSeekerUser>? JobSeekers { get; set; }

    }
}
