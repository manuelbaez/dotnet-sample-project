using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;
public class LibraryContext : DbContext
{

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}