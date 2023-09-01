using Microsoft.AspNetCore.Identity;

namespace teorik_maraton.Data
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Videos = new HashSet<Video>();
            Comments = new HashSet<Comment>();
        }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
