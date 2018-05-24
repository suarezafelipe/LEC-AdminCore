using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;

namespace AdminCore.BusinessLogic.Products.Services
{
    public interface IBrandService
    {
        List<Marcas> GetAllBrands();
        bool CreateBrand(Marcas brand);
    }
}
