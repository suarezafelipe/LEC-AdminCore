using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using AdminCore.Persistence.Mapping.SQLServerMap;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Migrations
{
    public class MigrationsContext : DbContext
    {
        private readonly IProductsMapping _productMapper;

        public MigrationsContext(DbContextOptions<MigrationsContext> options) : base(options)
        {
            _productMapper = new ProductsMapping();
        }

        //public DbSet<Brand> Brands { get; set; }
        //public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = BuilderConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder BuilderConfiguration(ModelBuilder modelBuilder)
        {
            //modelBuilder = _productMapper.BrandMapping(modelBuilder);
            //modelBuilder = _productMapper.ProductMapping(modelBuilder);
            modelBuilder = _productMapper.LecDbBuilder(modelBuilder);

            return modelBuilder;
        }

    }
}
