using System;
using System.Linq;
using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Audit;
using AdminCore.Persistence.Mapping.Interfaces;
using AdminCore.Persistence.Mapping.SQLServerMap;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence
{
    public class MainContext: DbContext
    {
        private readonly IProductsMapping _productMapper;
        private readonly IMarketingMapping _marketingMapper;
        private readonly ICartMapping _cartMapping;
        private readonly IInventarioMapping _inventarioMapper;
        private readonly ICotizacionesMapping _cotizacionesMapper;
        private readonly IUsuariosMapping _usuariosMapper;
        private readonly IToBeDeleted _toBeDeleted;

        public DbSet<Marcas> Marcas { get; set; }


        protected MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            _productMapper = new ProductsMapping();
            _marketingMapper = new MarketingMapping();
            _cartMapping = new CartMapping();
            _inventarioMapper = new InventarioMapping();
            _cotizacionesMapper = new CotizacionesMapping();
            _usuariosMapper = new UsuariosMapping();
            _toBeDeleted = new ToBeDeleted();
        }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=LEC-DB-CORE;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder = Auditable(modelBuilder);
            modelBuilder = BuilderConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder BuilderConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder = _productMapper.LecDbBuilder(modelBuilder);
            modelBuilder = _marketingMapper.LecDbBuilder(modelBuilder);
            modelBuilder = _cartMapping.LecDbBuilder(modelBuilder);
            modelBuilder = _inventarioMapper.LecDbBuilder(modelBuilder);
            modelBuilder = _cotizacionesMapper.LecDbBuilder(modelBuilder);
            modelBuilder = _usuariosMapper.LecDbBuilder(modelBuilder);
            modelBuilder = _toBeDeleted.LecDbBuilder(modelBuilder);

            return modelBuilder;
        }

    }
}
