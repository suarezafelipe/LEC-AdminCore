using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface IProductsMapping
    {
        ModelBuilder BrandMapping(ModelBuilder modelBuilder);
        ModelBuilder ProductMapping(ModelBuilder modelBuilder);
    }
}
