namespace XRP.API.Repositories.Abstract.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        bool Add(T entity);
        bool Add<A>(A entity) where A : class;
        bool Remove(T entity);
        int Save();
    }
}
