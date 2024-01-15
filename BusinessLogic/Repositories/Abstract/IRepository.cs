namespace BusinessLogic.Repositories.Abstract;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> GetAll();
}
interface IRepository<TEntity, TKey> : IRepository<TEntity>
{
    TEntity? GetById(TKey id);
}