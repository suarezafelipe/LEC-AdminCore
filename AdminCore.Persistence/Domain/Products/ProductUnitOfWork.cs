/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author:     Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     Entry point to access the Database Context of a specific Business domain. 
 *                  This class is used to handle all the data operations of the models as if they were
 *                  operations to a List.
 *                  For more information Google: "Unit of Work Pattern", "SOLID Principles"
 */

using AdminCore.BusinessLogic.Products;
using AdminCore.BusinessLogic.Products.RepoInterfaces;
using AdminCore.Persistence.Domain.Products.Repositories;

namespace AdminCore.Persistence.Domain.Products
{
    public class ProductUnitOfWork : IProductUnitOfWork
    {
        private readonly MainContext _context;

        public IBrandRepository Brands { get; set; }

        public ProductUnitOfWork(MainContext context)
        {
            _context = context;
            Brands = new BrandRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void CompleteAsync()
        {
            _context.SaveChangesAsync();
        }

    }
}
