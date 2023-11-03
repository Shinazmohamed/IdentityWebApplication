using Microsoft.AspNetCore.Identity;

namespace IdentityWebApplication.Middleware
{
    public static class DbInitializer
    {
        public static async Task SeedSuperuserAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, string superuserEmail, string superuserPassword)
        {
            var superuser = await userManager.FindByEmailAsync(superuserEmail);

            if (superuser == null)
            {
                superuser = new IdentityUser { UserName = superuserEmail, Email = superuserEmail };
                var result = await userManager.CreateAsync(superuser, superuserPassword);

                if (result.Succeeded)
                {
                    // Assign roles to the user.
                    if (!await roleManager.RoleExistsAsync("Superuser"))
                    {
                        await roleManager.CreateAsync(new IdentityRole("Superuser"));
                    }
                    await userManager.AddToRoleAsync(superuser, "Superuser");
                }
            }
        }
    }
}


