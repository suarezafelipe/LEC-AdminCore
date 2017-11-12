using AdminCore.BusinessLogic.Products.Services;
using Autofac;


namespace AdminCore.Utilities.DI
{
    public class ProductModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandService>().As<IBrandService>();
        }
    }
}
