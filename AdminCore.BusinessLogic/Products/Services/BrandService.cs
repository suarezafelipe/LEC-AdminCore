using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;

namespace AdminCore.BusinessLogic.Products.Services
{
    public class BrandService : IBrandService
    {
        private readonly IProductUnitOfWork _unitOfWork;

        public BrandService(IProductUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// Returns the list of all products in the DB.
        /// </summary>
        /// <returns></returns>
        public List<Marcas> GetAllBrands()
        {
            return _unitOfWork.Brands.GetAllBrands();
        }

        public bool CreateBrand(Marcas marca)
        {
            var result = _unitOfWork.Brands.CreateBrand(marca);
            _unitOfWork.Complete();
            return result;
        }
    }
}
