using BusinessLogic.Dtos;

namespace BusinessLogic.Services.Configuration;

public interface IService<TDto>
{
    IEnumerable<TDto> GetAll();

}