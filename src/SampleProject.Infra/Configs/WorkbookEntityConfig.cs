using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Domain.Entities;

namespace SampleProject.Infra;

public class WorkbookEntityConfig : IEntityTypeConfiguration<WorkbookEntity>
{
    public void Configure(EntityTypeBuilder<WorkbookEntity> builder)
    {
        builder.ToTable("Workbook");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.UserId).IsRequired();

        builder.HasOne(x => x.User).WithMany(x => x.Workbooks).HasForeignKey(f => f.UserId);
    }
}
