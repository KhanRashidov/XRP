namespace XRP.API.Repositories.Abstract.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        bool Commit(bool state = true);
    }
}
