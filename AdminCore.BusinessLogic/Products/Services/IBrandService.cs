using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;

namespace AdminCore.BusinessLogic.Products.Services
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands();
        bool CreateBrand(Brand brand);
    }
}
