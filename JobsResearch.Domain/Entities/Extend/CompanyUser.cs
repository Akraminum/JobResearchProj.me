using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain.Entities.Extend
{
    [Table("Companies")]
    public class CompanyUser : ApplicationUser
    {
        public CompanyUser() :base() => UserType = UserTypes.Company;


        public string CompanyName { get; set; } = null!;
        public int NumberOfJobs { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        // ========= Relations ========= //


        public IEnumerable<Job>? Jobs { get; set; }


    }
}
