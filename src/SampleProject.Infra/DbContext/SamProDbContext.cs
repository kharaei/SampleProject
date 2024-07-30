using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Entities;

namespace SampleProject.Infra;

public sealed class SamProDbContext : DbContext
{
    public SamProDbContext(DbContextOptions<SamProDbContext> options)
        : base(options)
    {
        
    }

    // Definition for Entitites
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<WorkbookEntity> Workbook { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definition for configurations
        modelBuilder.ApplyConfiguration(new UserEntityConfig());
        modelBuilder.ApplyConfiguration(new WorkbookEntityConfig());

        base.OnModelCreating(modelBuilder);
    }
}