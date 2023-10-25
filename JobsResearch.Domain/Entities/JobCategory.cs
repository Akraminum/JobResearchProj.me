using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities
{
    public class JobCategory : BaseEntity
    {
        public int JobCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }


        // ========= Relations ========= //
        public IEnumerable<Job>? Jobs { get; set; }

    } 
}
