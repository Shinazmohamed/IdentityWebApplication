﻿using IdentityWebApplication.Contract;
using IdentityWebApplication.Entity;
using IdentityWebApplication.Models;

namespace IdentityWebApplication.Business
{

    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeService _service;
        public EmployeeBusiness(IEmployeeService service)
        {
            _service = service;
        }
        public async Task<bool> Create(EmployeeEntity employee)
        {
            try
            {
                return await _service.Create(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<PaginationResponse<EmployeeEntity>> GetAll(PaginationFilter filter)
        {
            try
            {
                return await _service.GetAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<EmployeeEntity> GetById(string id)
        {
            try
            {
                return await _service.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(EmployeeEntity employee)
        {
            try
            {
                return await _service.Update(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                return await _service.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
