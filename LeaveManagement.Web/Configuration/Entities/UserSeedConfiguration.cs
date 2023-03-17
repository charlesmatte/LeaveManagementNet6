using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities;

public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var hasher = new PasswordHasher<Employee>();
        builder.HasData(
            new Employee
            {
                Id = "edf41a6e-f7ac-1238-baef-1add523ccbbf",
                Email = "admin@domain.com",
                NormalizedEmail = "ADMIN@DOMAIN.COM",
                UserName = "admin@domain.com",
                NormalizedUserName = "ADMIN@DOMAIN.COM",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null, "$inG4por3"),
                EmailConfirmed = true
            },
            new Employee
            {
                Id = "edf41a6e-f7ac-1238-baef-1add523ccccf",
                Email = "user@domain.com",
                NormalizedEmail = "USER@DOMAIN.COM",
                UserName = "user@domain.com",
                NormalizedUserName = "USER@DOMAIN.COM",
                FirstName = "System",
                LastName = "User",
                PasswordHash = hasher.HashPassword(null, "$inG4por3"),
                EmailConfirmed = true
            }
        );
    }
}