using Microsoft.EntityFrameworkCore;
using SampleProject.Domain;

namespace SampleProject.Infra;

public class SamProDbContext : DbContext
{
    public SamProDbContext(DbContextOptions<SamProDbContext> options)
        : base(options)
    {
        
    }

    // Definition for Entitites
    public DbSet<UserEntity> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definition for configurations
        modelBuilder.ApplyConfiguration(new UserEntityConfig());

        base.OnModelCreating(modelBuilder);
    }
}