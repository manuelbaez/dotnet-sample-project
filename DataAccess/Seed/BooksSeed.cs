using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Seed;

public static class BooksSeed
{
    public static void AddSeedData(this EntityTypeBuilder<Book> builder)
    {
        builder.HasData(new Book
        {
            Id = 1,
            Name = "The cat that could fly",
            Description = "A book about a car that could fly",
            AuthorId = 1,
            IsActive = true
        },
        new Book
        {
            Id = 2,
            Name = "The fly that couldn't fly",
            Description = "A book about a fly that couldn't fly",
            AuthorId = 1,
            IsActive = true
        });
    }
}