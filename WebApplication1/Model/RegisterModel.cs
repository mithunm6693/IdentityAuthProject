using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class RegisterModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LasttName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
