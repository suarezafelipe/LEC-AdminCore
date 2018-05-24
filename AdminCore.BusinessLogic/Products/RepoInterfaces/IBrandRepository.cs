/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author:     Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     Implementation of the Repository Pattern that handles all the commands and queries to the DB.
 *                  This is only the "contract" of operations, the business layer does not care about the details
 *                  of the implementation.
 *                  For more information Google: "Repository Pattern", "Inversion of Control (IoC)"
 */
using System.Collections.Generic;
using AdminCore.BusinessLogic.Products.Models;

namespace AdminCore.BusinessLogic.Products.RepoInterfaces
{
    public interface IBrandRepository
    {
        bool CreateBrand(Marcas marca);
        List<Marcas> GetAllBrands();
    }
}
