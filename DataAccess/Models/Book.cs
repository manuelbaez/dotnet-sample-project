using DataAccess.Models.Abstract;

namespace DataAccess.Models;

public class Book : IDisableAbleEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
    public bool IsActive { get; set; }
}

