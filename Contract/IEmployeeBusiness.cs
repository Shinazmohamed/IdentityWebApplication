using IdentityWebApplication.Entity;
using IdentityWebApplication.Models;

namespace IdentityWebApplication.Contract
{
    public interface IEmployeeBusiness
    {
        Task<bool> Create(EmployeeEntity employee);
        Task<PaginationResponse<EmployeeEntity>> GetAll(PaginationFilter filter);
        Task<EmployeeEntity> GetById(string id);
        Task<bool> Update(EmployeeEntity employee);
        Task<bool> Delete(string id);
    }
}
