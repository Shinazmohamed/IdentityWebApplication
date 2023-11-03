using IdentityWebApplication.Entity;

namespace IdentityWebApplication.Contract
{
    public interface IUnitOfWork
    {
        IRepository<EmployeeEntity> EmployeeRepo { get; }
        Task<int> SaveAsync();
        int Save();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
