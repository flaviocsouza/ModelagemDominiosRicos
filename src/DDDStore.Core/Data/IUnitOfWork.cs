namespace DDDStore.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
    }
        
}
