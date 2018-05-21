using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface ICartMapping
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
