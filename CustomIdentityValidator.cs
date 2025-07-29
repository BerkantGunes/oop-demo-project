using Microsoft.AspNetCore.Identity;

namespace Demo_Product.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "Password Too Short",
                Description = "Password Must Be At Least 6 Characters"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code="PasswordRequiresUpper",
                Description = "Password contains at least 1 Upper Case Letter"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code="PasswordRequiresLower",
                Description="Password contains at least 1 Lower Case Letter"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Password contains at least 1 alphanumeric character"
            };
        }
    }
}
