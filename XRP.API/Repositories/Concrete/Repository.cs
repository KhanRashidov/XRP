using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using XRP.API.Context;
using XRP.API.Repositories.Abstract.Interfaces;

namespace XRP.API.Repositories.Concrete
{
    public class Repository<T>:ControllerBase,IRepository<T>,IUnitOfWork where T : class
    {
        protected XRPContext _xrpContext;
        private IDbContextTransaction transaction = null;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com/todos/";
        private readonly HttpClient _client;

        public Repository(XRPContext xrpContext,HttpClient httpClient)
        {
            _xrpContext = xrpContext;
            transaction = _xrpContext.Database.BeginTransaction();
            _client = httpClient;
        }
        [NonAction]
        public List<T> GetAll()=> _xrpContext.Set<T>().ToList();

        [NonAction]
        public bool Add(T entity)
        {
            _xrpContext.Set<T>().Add(entity);
            return true;
        }
        [NonAction]
        public bool Add<A>(A entity) where A : class
        {
            _xrpContext.Set<A>().Add(entity);
            return true;
        }
        [NonAction]
        public bool Remove(T entity)
        {
            _xrpContext.Set<T>().Remove(entity);
            return true;
        }

        [NonAction]
        public int Save() => _xrpContext.SaveChanges();
        

        public void Dispose()
        {
            _xrpContext.Dispose();
        }
        [NonAction]
        public bool Commit(bool state = true)
        {
            Save();
            if (state)
                transaction.Commit();
            else
                transaction.Rollback();

            Dispose();
            return true;
        }
    }
}
