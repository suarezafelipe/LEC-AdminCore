using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface IToBeDeleted
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
