using DataAccess.Models.Abstract;

namespace DataAccess.Models;

public class Author : IDisableAbleEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public bool IsActive { get; set; }
}

