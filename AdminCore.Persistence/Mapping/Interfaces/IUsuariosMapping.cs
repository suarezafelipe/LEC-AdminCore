using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface IUsuariosMapping
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
