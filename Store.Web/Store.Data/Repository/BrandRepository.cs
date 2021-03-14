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
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext dbContext;

        public BrandRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Brand> GetAll()
        {
            return dbContext.Brands.ToList();
            
            //throw new NotImplementedException();
        }

        public Task<IList<Brand>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public object Insert(Brand entity, bool saveChanges = false)
        {
            dbContext.Brands.Add(entity);
            dbContext.SaveChanges();

            return entity;

            //throw new NotImplementedException();
        }

        public Task<object> InsertAsync(Brand entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
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

        public void Delete(Brand entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object id, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Brand entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Brand Find(Expression<Func<Brand, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Brand>> FindAllAsync(Expression<Func<Brand, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> FindAsync(Expression<Func<Brand, bool>> match)
        {
            throw new NotImplementedException();
        }

        

        public IQueryable<Brand> GetAllIncluding(params Expression<Func<Brand, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IList<Brand> GetAllMatched(Expression<Func<Brand, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IList<Brand> GetAllPaged(int pageIndex, int pageSize, out int totalCount)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Brand> GetIQueryable()
        {
            throw new NotImplementedException();
        }

       

        public void Update(Brand entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand entity, object key, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Brand entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> UpdateAsync(Brand entity, object key, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }
    }
}
