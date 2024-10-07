using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserMangement.PL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("Users","Security");
            builder.Entity<IdentityRole>().ToTable("Roles","Security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims","Security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTockens", "Security");
        }
    }
}
