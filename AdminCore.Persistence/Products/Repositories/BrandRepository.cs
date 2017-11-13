using System;
using System.Collections.Generic;
using System.Linq;
using AdminCore.BusinessLogic.Products.Models;
using AdminCore.BusinessLogic.Products.RepositoriesInterfaces;

namespace AdminCore.Persistence.Products.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IProductContext _context;

        public BrandRepository(IProductContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a brand to the database. 
        /// Returns true if successful, false if there is any exception
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all the brands from the DB
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetAllBrands()
        {
            return _context.Brands.ToList();
        }


    }
}
