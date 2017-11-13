/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author:     Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     Implementation of the UoW that treats DB objects as lists and also performs the operations 
 *                  in the DB (save, commit, etc). The business logic does not care about implementation details 
 *                  of the persistence layer, so all it knows are the operations defined here.
 *                  For more information Google:"Inversion of Control (IoC)", "Low coupling"
 */
using AdminCore.BusinessLogic.Products.RepositoriesInterfaces;

namespace AdminCore.BusinessLogic.Products
{
    public interface IProductUnitOfWork
    {
        IBrandRepository Brands { get; }
        void Complete();
        void CompleteAsync();
    }
}
