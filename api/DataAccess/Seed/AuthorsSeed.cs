using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Seed;

public static class AuthorsSeed
{
    public static void AddSeedData(this EntityTypeBuilder<Author> builder)
    {
        builder.HasData(new Author
        {
            Id = 1,
            Name = "Pedro Solo",
            IsActive = true
        });
    }
}