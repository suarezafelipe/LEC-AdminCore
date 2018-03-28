using System;
using System.Linq;
using AdminCore.Persistence.Audit;
using AdminCore.Persistence.Mapping.Interfaces;
using AdminCore.Persistence.Mapping.SQLServerMap;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence
{
    public class MainContext: DbContext
    {
        private readonly ISessionManager _sessionManager;
        private readonly IProductsMapping _productMapper;

        protected MainContext(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
            _productMapper = new ProductsMapping();
        }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=LEC-AdminCoreTest.NewDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = Auditable(modelBuilder);
            modelBuilder = BuilderConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder BuilderConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder = _productMapper.BrandMapping(modelBuilder);
            modelBuilder = _productMapper.ProductMapping(modelBuilder);
            return modelBuilder;
        }

        /// <summary>
        /// Audit fields
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <returns></returns>
        private ModelBuilder Auditable(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()
                .Where(e => typeof(IAuditable).IsAssignableFrom(e.ClrType)))
            {
                modelBuilder.Entity(entityType.ClrType)
                    .Property<DateTime>("DateCreated");

                modelBuilder.Entity(entityType.ClrType)
                    .Property<DateTime>("DateModified");

                modelBuilder.Entity(entityType.ClrType)
                    .Property<Guid>("CreatedBy");

                modelBuilder.Entity(entityType.ClrType)
                    .Property<Guid>("ModifiedBy");
            }
            return modelBuilder;
        }

        protected virtual int SaveChangesAudit()
        {
            ApplyAuditInformation();
            return SaveChanges();
        }

        private void ApplyAuditInformation()
        {
            var modifiedEntities = ChangeTracker.Entries<IAuditable>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entity in modifiedEntities)
            {
                entity.Property("DateModified").CurrentValue = DateTime.UtcNow;
                entity.Property("ModifiedBy").CurrentValue = _sessionManager.SessionId;
                if (entity.State == EntityState.Added)
                {
                    entity.Property("DateCreated").CurrentValue = DateTime.UtcNow;
                    entity.Property("CreatedBy").CurrentValue = _sessionManager.SessionId;
                }
            }
        }
    }
}
