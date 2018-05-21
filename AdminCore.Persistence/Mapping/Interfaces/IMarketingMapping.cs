using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.Interfaces
{
    public interface IMarketingMapping
    {
        ModelBuilder LecDbBuilder(ModelBuilder modelBuilder);
    }
}
