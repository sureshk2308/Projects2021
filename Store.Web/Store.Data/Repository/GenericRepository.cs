using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Entity;
using Store.Data.Interface;

namespace Store.Data.Repository
{
    public class GenericRepository<TStore> : IGenericRepository<TStore> where TStore : class
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext dbContext )
        {
            this.dbContext = dbContext;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(object id, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object id, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TStore Find(Expression<Func<TStore, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TStore>> FindAllAsync(Expression<Func<TStore, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<TStore> FindAsync(Expression<Func<TStore, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IList<TStore> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<TStore>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TStore> GetAllIncluding(params Expression<Func<TStore, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IList<TStore> GetAllMatched(Expression<Func<TStore, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IList<TStore> GetAllPaged(int pageIndex, int pageSize, out int totalCount)
        {
            throw new NotImplementedException();
        }

        public TStore GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TStore> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TStore> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public object Insert(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<object> InsertAsync(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void Update(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public TStore Update(TStore entity, object key, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TStore entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<TStore> UpdateAsync(TStore entity, object key, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }
    }
}
