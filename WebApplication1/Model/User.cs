using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Model
{
    public class User:IdentityUser
    {
        public string Firstname { get; set; } = string.Empty;

        public string Lasttname { get; set; } = string.Empty;   

    }
}
