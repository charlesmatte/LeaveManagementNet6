using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Configuration.Entities;

public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "ddd43e6e-f9bb-4448-baaf-1abb443ccfef",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
        );
    }
}