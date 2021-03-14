using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Entity;
using Store.Data.Interface;
using Store.Data.Repository;

namespace Store.Data.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        private IBrandRepository brandRepository;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IBrandRepository BrandRepository
        {
            //            get { return _authorRepository = _authorRepository ?? new AuthorRepository(_databaseContext); }

            get { return brandRepository = brandRepository ?? new BrandRepository(dbContext); }
        }
        //public IBrandRepository BrandRepository => throw new NotImplementedException();

        public void Commit()
        {
            dbContext.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Rollback()
        {
            dbContext.Dispose();
            //throw new NotImplementedException();
        }

        //public Task<int> CommitAsync()
        //{
        //    return dbContext.SaveChangesAsync();
        //    //throw new NotImplementedException();
        //}

    }
}
