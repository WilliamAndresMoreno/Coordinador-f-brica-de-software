public interface IRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
    Task<TEntity> GetAsync(int id);
    Task UpdateAsync(TEntity entity);
}
