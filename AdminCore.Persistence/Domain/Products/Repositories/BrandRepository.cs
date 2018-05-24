using System;
using System.Collections.Generic;
using System.Linq;
using AdminCore.BusinessLogic.Products.Models;
using AdminCore.BusinessLogic.Products.RepoInterfaces;

namespace AdminCore.Persistence.Domain.Products.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly MainContext _context;

        public BrandRepository(MainContext context)
        {
            _context = context;
        }
        
        public bool CreateBrand(Marcas marca)
        {
            try
            {
                _context.Marcas.Add(marca);
                return true;
            }
            catch (Exception e)
            {
                // Write exception lo LOG
                return false;
            }
        }
       
        public List<Marcas> GetAllBrands()
        {
            return _context.Marcas.ToList();
        }


    }
}
