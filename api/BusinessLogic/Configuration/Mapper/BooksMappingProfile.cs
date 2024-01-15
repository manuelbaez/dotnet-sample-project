using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Models;

namespace BusinessLogic.Configuration.Mapper;

public class BooksMappingProfile : Profile
{
    public BooksMappingProfile()
    {
        CreateMap<Book, BookDto>().ForMember(t => t.AuthorName, opt => opt.MapFrom(x => x.Author.Name));
        CreateMap<BookDto, Book>().ForMember(t => t.Author, opt => opt.Ignore());
    }
}