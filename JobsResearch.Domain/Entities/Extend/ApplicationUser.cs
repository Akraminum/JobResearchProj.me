using Microsoft.AspNetCore.Identity;


namespace JobResearch.Domain.Entities.Extend
{
    
    public class ApplicationUser : IdentityUser 
    {
        public ApplicationUser() : base() { }


        public UserTypes UserType { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }

    }
}
