using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Repositories.Abstract;
using BusinessLogic.Services.Configuration;
using DataAccess.Models;

class BooksService : IService<BookDto>
{
    private readonly IRepository<Book> repository;
    private readonly IMapper mapper;

    public BooksService(IRepository<Book> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public IEnumerable<BookDto> GetAll()
    {
        var allBooks = repository.GetAll();
        return mapper.Map<IEnumerable<BookDto>>(allBooks);
    }

}