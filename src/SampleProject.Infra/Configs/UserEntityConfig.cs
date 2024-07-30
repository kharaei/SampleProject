using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleProject.Domain.Entities;

namespace SampleProject.Infra;

public class UserEntityConfig : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("User");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        
        builder.Property(x => x.Username).IsRequired().HasMaxLength(30);
        builder.Property(x => x.Password).IsRequired();
    }
}
