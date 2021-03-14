using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Store.Data.Interface
{
    public interface IGenericRepository<TStore> where TStore : class
    {
        IList<TStore> GetAll();
        IList<TStore> GetAllMatched(Expression<Func<TStore, bool>> match);
        IQueryable<TStore> GetAllIncluding(params Expression<Func<TStore, object>>[] includeProperties);
        TStore GetById(object id);
        TStore Find(Expression<Func<TStore, bool>> match);
        IQueryable<TStore> GetIQueryable();
        IList<TStore> GetAllPaged(int pageIndex, int pageSize, out int totalCount);
        int Count();
        object Insert(TStore entity, bool saveChanges = false);
        void Delete(object id, bool saveChanges = false);
        void Delete(TStore entity, bool saveChanges = false);
        void Update(TStore entity, bool saveChanges = false);
        TStore Update(TStore entity, object key, bool saveChanges = false);
        void Commit();

        Task<IList<TStore>> GetAllAsync();
        Task<IList<TStore>> FindAllAsync(Expression<Func<TStore, bool>> match);
        Task<TStore> GetByIdAsync(object id);
        Task<TStore> FindAsync(Expression<Func<TStore, bool>> match);
        Task<int> CountAsync();
        Task<object> InsertAsync(TStore entity, bool saveChanges = false);
        Task DeleteAsync(object id, bool saveChanges = false);
        Task DeleteAsync(TStore entity, bool saveChanges = false);
        Task UpdateAsync(TStore entity, bool saveChanges = false);
        Task<TStore> UpdateAsync(TStore entity, object key, bool saveChanges = false);
        Task CommitAsync();
        void Dispose();
    }

}
