using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface ICotizacionesMapping
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
