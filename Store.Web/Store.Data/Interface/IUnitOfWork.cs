using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Interface
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; }
        //Task<int> CommitAsync();
        void Commit();
        void Rollback();
    }
}
