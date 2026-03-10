using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Application.Containers
{
 public interface IMaterialUnitsRepository
    {
        Task<Guid> AddAsync(Domain.MaterialUnit materialUnit, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Domain.MaterialUnit materialUnit, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid containerId, CancellationToken cancellationToken);

        Task<int> GetFullValueContainers();
    }
}