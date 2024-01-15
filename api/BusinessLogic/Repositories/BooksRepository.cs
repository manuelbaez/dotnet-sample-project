using BusinessLogic.Repositories.Abstract;
using DataAccess.Contexts;
using DataAccess.Models;

namespace BusinessLogic.Repositories;

class BooksRepository : IRepository<Book, int>
{
    private readonly LibraryContext libraryContext;

    public BooksRepository(LibraryContext libraryContext)
    {
        this.libraryContext = libraryContext;
    }

    public Book? GetById(int id)
    {
        var book = libraryContext.Set<Book>().Find(id);
        return book;
    }
    public IQueryable<Book> GetAll()
    {
        var books = libraryContext.Set<Book>().Where(t => t.IsActive);
        return books;
    }
}