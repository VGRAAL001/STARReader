using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data
{
    public class AppUser : IdentityUser
    {
        public string StudentNo { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB {  get; set; } = DateTime.Now;
        

    }
}
