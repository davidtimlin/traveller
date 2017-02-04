using Microsoft.AspNet.Identity.EntityFramework;
using TravellerMVC.Models;

namespace TravellerMVC.DataContexts.User
{
    public class UserDbContext : IdentityDbContext<ApplicationUser>
    {
        public UserDbContext()
            : base("TravellerConnection", throwIfV1Schema: false)
        {
        }

        public static UserDbContext Create()
        {
            return new UserDbContext();
        }
    }
}