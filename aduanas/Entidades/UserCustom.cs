using Microsoft.AspNetCore.Identity;

namespace aduanas.Entidades
{
    public class UserCustom : IdentityUser
    {
        public string UserNames { get; set; }
    }
}
