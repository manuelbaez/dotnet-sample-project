using DataAccess.Models;
using DataAccess.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.IsActive).IsRequired().HasDefaultValue(1);
        builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
        builder.AddSeedData();
    }
}