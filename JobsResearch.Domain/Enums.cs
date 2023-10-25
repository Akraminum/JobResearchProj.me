using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Domain
{
    public enum UserTypes
    {
        JobSeeker =1,
        Company
    }

    public enum JobStatus
    {
        Pending = 1,
        Accepted,
        Rejected
    }

    public enum ApplicantStatus
    {
        Pending = 1,
        Accepted,
        Rejected
    }
}
