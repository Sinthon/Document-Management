using Document_Management.Controllers;
using Document_Management.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Document_Management.Extentions
{
    public static class ApplicationSeeders
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new IdentityRole { 
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                Name = "Administrator", 
                NormalizedName = "ADMINISTRATOR".ToUpper() ,
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                Name = "AppUser",
                NormalizedName = "APPUSER".ToUpper(),
            });

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "Admin",
                    NormalizedUserName = "Administrator",
                    Email = "Admin@example.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+85588000000",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd")
                }
            );


            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
        }
    }
}