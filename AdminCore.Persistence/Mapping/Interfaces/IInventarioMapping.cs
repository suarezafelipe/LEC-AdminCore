using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface IInventarioMapping
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
