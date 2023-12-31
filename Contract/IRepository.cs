﻿using IdentityWebApplication.Models;
using System.Linq.Expressions;

namespace IdentityWebApplication.Contract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        Task<bool> Delete(object id);
        Task<bool> Delete(Expression<Func<T, bool>> where);
        Task<bool> Delete(T entity);
        Task<T> Get(object id);
        Task<T> Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        Task<PaginationResponse<T>> GetAll(PaginationFilter filter);
        Task<int> Count(Expression<Func<T, bool>> where);
        Task<int> Count();

        //Gets a table
        IQueryable<T> Table { get; }

        //Gets a table with "no tracting"
        IQueryable<T> TableNoTracking { get; }
    }
}
