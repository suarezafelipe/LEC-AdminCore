/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author: Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     File for registering all the classes that are going to be injected via dependency injection. 
 *                  For more information Google: "Dependency Injection" and "Autofac"
 */
using System.Reflection;
using AdminCore.BusinessLogic.Products;
using AdminCore.Persistence.Domain.Products;
using Autofac;
using Module = Autofac.Module;


namespace AdminCore.Utilities
{
    public class AdminCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /* This is done in order to avoid registering all the Services and Interfaces.
            * AdminCore.BusinessLogic assembly registers automatically:
            *   BrandService -> IBrandService; ArticleService -> IArticleService, etc
            * AdminCore.Persistene assembly registers automatically:
            *   ProductContext -> IProductContext; UserContext -> IUserContext, etc
            */
            var businessAssembly = Assembly.Load("AdminCore.BusinessLogic");
            builder.RegisterAssemblyTypes(businessAssembly).AsImplementedInterfaces();

            var persistenceAssembly = Assembly.Load("AdminCore.Persistence");
            builder.RegisterAssemblyTypes(persistenceAssembly).AsImplementedInterfaces();

            /* The Units of Work need to be manually registered because the interfaces
             * and the implementations are located in different assemblies.
             */
            builder.RegisterType<ProductUnitOfWork>().As<IProductUnitOfWork>();
        }
    }
}
