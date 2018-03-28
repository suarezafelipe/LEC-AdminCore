using System;
using System.Collections.Generic;
using System.Linq;
using AdminCore.BusinessLogic.Products.Models;
using AdminCore.BusinessLogic.Products.RepoInterfaces;

namespace AdminCore.Persistence.Domain.Products.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IProductContext _context;

        public BrandRepository(IProductContext context)
        {
            _context = context;
        }
        
        public bool CreateBrand(Brand brand)
        {
            try
            {
                _context.Brands.Add(brand);
                return true;
            }
            catch (Exception e)
            {
                // Write exception lo LOG
                return false;
            }
        }
       
        public List<Brand> GetAllBrands()
        {
            return Enumerable.ToList<Brand>(_context.Brands);
        }


    }
}
