using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Entity;

namespace Store.Data.Interface
{
    public interface IBrandRepository: IGenericRepository<Brand>
    {

        //IEnumerable<Brand> GetAllBrands();
        //Brand GetBrandById(int brandId);
        //Brand AddBrand(Brand brand);
        //Brand UpdateBrand(Brand brandChanges);
        //Brand DeleteBrand(int brandId);
       
    }
}

