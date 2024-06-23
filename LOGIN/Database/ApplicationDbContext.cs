using LOGIN.Dtos.Communicates;
using LOGIN.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("Security");

        // Configuración de las tablas de Identity
        builder.Entity<UserEntity>().ToTable("users");
        builder.Entity<IdentityRole>().ToTable("roles");
        builder.Entity<IdentityUserRole<string>>().ToTable("users_roles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("users_claims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("users_logins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("roles_claims");
        builder.Entity<IdentityUserToken<string>>().ToTable("users_tokens");

        // Configuración adicional para userEntity
        builder.Entity<UserEntity>()
               .Property(u => u.CreatedDate)
               .IsRequired()
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Entity<UserEntity>()
               .Property(u => u.FirstName)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnName("first_name");

        builder.Entity<UserEntity>()
               .Property(u => u.LastName)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnName("last_name");

        builder.Entity<UserEntity>()
               .Property(u => u.UserName)
               .IsRequired();

        builder.Entity<UserEntity>()
               .Property(u => u.Email)
               .IsRequired();
    }

    // DbSet para userEntity si se necesita acceder directamente desde el contexto
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CommunicateEntity> Communicates { get; set; }
    public DbSet<StateEntity> States { get; set; }
    public DbSet<ReportEntity> Reports { get; set; }
}
