using DataAccess.Models;
using DataAccess.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
        builder.Property(t => t.IsActive).IsRequired().HasDefaultValue(1);
        builder.HasOne(t => t.Author).WithMany(t => t.Books).HasForeignKey(t => t.AuthorId).IsRequired();
        builder.AddSeedData();
    }
}