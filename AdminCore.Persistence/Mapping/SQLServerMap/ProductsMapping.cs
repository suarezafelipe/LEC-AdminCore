using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class ProductsMapping : IProductsMapping
    {
        public ModelBuilder BrandMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("dbo.MARCAS").HasKey(x => x.Id);
            modelBuilder.Entity<Brand>(e => {
                    e.Property(x => x.Id).HasColumnName("ID_MARCA").IsRequired();
                    e.Property(x => x.Name).HasColumnName("NOMBRE").HasMaxLength(45);
                    e.Property(x => x.Description).HasColumnName("DESCRIPCION").HasMaxLength(300);
                    e.Property(x => x.IsActive).HasColumnName("ESTADO_REGISTRO").IsRequired();
                    e.Property(x => x.DateCreated).HasColumnName("FECHA_CREACION");
                    e.Property(x => x.DateModified).HasColumnName("FECHA_ACTUALIZACION");
                    e.Property(x => x.CreatedBy).HasColumnName("USUARIO_CREADOR");
                    e.Property(x => x.ModifiedBy).HasColumnName("USUARIO_MODIFICADOR");
                }
            );

            return modelBuilder;
        }

        public ModelBuilder ProductMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("dbo.PRODUCTOS").HasKey(x => x.Id);
            modelBuilder.Entity<Product>(e => {
                    e.Property(x => x.Id).HasColumnName("ID_PRODUCTO").IsRequired();
                    e.Property(x => x.Name).HasColumnName("NOMBRE").HasMaxLength(45).IsRequired();
                }
            );

            return modelBuilder;
        }
    }
}
