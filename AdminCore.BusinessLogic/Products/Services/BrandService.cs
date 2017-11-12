using System;
using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;

namespace AdminCore.BusinessLogic.Products.Services
{
    public class BrandService : IBrandService
    {
        /// <summary>
        /// Returns the list of all products in the DB.
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetAllBrands()
        {
            var mockData = new List<Brand>
            {
                new Brand
                {
                    Name = "Pelikan",
                    Description = "best brand",
                    CreationDate = DateTime.UtcNow.AddDays(-7),
                    UpdateDate = DateTime.UtcNow
                },
                new Brand
                {
                    Name = "Faber-Castell",
                    Description = "oldest brand",
                    CreationDate = DateTime.UtcNow.AddDays(-7),
                    UpdateDate = DateTime.UtcNow
                }
            };
            return mockData;
        }
    }
}
